using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Warranty.Helper;
using Warranty.SubForm;

namespace Warranty
{
    public partial class MainForm : Form
    {
        public string secure_path = null;
        public string express_path = null;
        public string data_path = null;
        public Invoice curr_invoice = null;
        private BindingList<ArtrnMin> iv_list;
        private BindingList<ArtrnMin> hs_list;
        private TransactionStatus.STATUS status;
        private FORM_MODE form_mode;
        public Log log = new Log();

        public MainForm(string data_path = null)
        {
            
            if(data_path != null && data_path.Trim().Length > 0)
            {
                if (data_path.Contains(@"\"))
                {
                    this.data_path = data_path.TrimEnd('\\') + @"\";
                }
                else
                {
                    //this.data_path = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory)/*.Parent*/.FullName + @"\" + data_path;
                    this.data_path = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.FullName + @"\" + data_path + @"\";
                }

                if (!Directory.Exists(this.data_path))
                {
                    MessageBox.Show("ที่เก็บข้อมูล " + this.data_path + " ไม่มีข้อมูลอยู่", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    this.data_path = null;
                }
            }

            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.BackColor = Misc.MAIN_BG;
            this.dgvIV.ColumnHeadersDefaultCellStyle.BackColor = Misc.COL_HEADER_BG;
            this.dgvHS.ColumnHeadersDefaultCellStyle.BackColor = Misc.COL_HEADER_BG;
            this.dgvSTCRD.ColumnHeadersDefaultCellStyle.BackColor = Misc.COL_HEADER_BG;

            this.iv_list = new BindingList<ArtrnMin>();
            this.dgvIV.DataSource = this.iv_list;
            this.hs_list = new BindingList<ArtrnMin>();

            //this.secure_path = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory)/*.Parent*/.FullName + @"\secure";
            //this.express_path = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory)/*.Parent*/.FullName;
            this.secure_path = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.FullName + @"\secure";
            this.express_path = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.FullName;

            if (!this.TestSecurePath())
            {
                MessageBox.Show("ค้นหาไดเร็คทอรี่ Secure ไม่พบ, อาจเป็นเพราะที่เก็บโปรแกรมไม่ถูกต้อง", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
                return;
            }

            this.form_mode = FORM_MODE.READ;
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            if(this.data_path == null)
            {
                DialogCompanySelect comp = new DialogCompanySelect(this);
                if(comp.ShowDialog() == DialogResult.OK)
                {
                    this.data_path = comp.selected_comp.RewriteDataPath();
                    this.lblDataPath.Text = DbfTable.GetIsinfo(this.data_path).thinam + " ( " + this.data_path.TrimEnd('\\') + " )";

                    this.LoadStatusComboboxItem();
                    this.cbStatus.SelectedItem = this.cbStatus.Items.Cast<ComboboxItem>().Where(i => ((TransactionStatus.STATUS)i.Value) == TransactionStatus.STATUS.WARRANTY).First();

                    this.iv_list =  new BindingList<ArtrnMin>(DbfTable.InvoiceList(this.data_path, this.status, DbfTable.INVOICE_TYPE.IV));
                    this.dgvIV.DataSource = this.iv_list;
                    this.tabIV.Text = "  ขายเชื่อ (" + this.iv_list.Count.ToString() + ") <F6>  ";
                }
                else
                {
                    Application.Exit();
                }
            }
            else
            {
                this.lblDataPath.Text = DbfTable.GetIsinfo(this.data_path).thinam + " ( " + this.data_path.TrimEnd('\\') + " )";

                this.LoadStatusComboboxItem();
                this.cbStatus.SelectedItem = this.cbStatus.Items.Cast<ComboboxItem>().Where(i => ((TransactionStatus.STATUS)i.Value) == TransactionStatus.STATUS.WARRANTY).First();

                this.iv_list = new BindingList<ArtrnMin>(DbfTable.InvoiceList(this.data_path, this.status, DbfTable.INVOICE_TYPE.IV));
                this.dgvIV.DataSource = this.iv_list;
                this.tabIV.Text = "  ขายเชื่อ (" + this.iv_list.Count.ToString() + ") <F6>  ";
            }
        }

        private void LoadStatusComboboxItem()
        {
            this.cbStatus.Items.Add(new ComboboxItem { Text = TransactionStatus.All, Value = TransactionStatus.STATUS.ALL });
            this.cbStatus.Items.Add(new ComboboxItem { Text = TransactionStatus.Warranty, Value = TransactionStatus.STATUS.WARRANTY });
            this.cbStatus.Items.Add(new ComboboxItem { Text = TransactionStatus.Warranted, Value = TransactionStatus.STATUS.WARRANTED });
        }


        private bool TestSecurePath()
        {
            if (Directory.Exists(this.secure_path))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool TestDataPath()
        {
            if (Directory.Exists(this.data_path))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void dgvIV_CurrentCellChanged(object sender, EventArgs e)
        {
            if(((DataGridView)sender).CurrentCell == null)
            {
                this.curr_invoice = null;
            }
            else
            {
                if(this.tabControl2.SelectedTab == this.tabIV)
                {
                    this.curr_invoice = DbfTable.InVoice(this.data_path, (string)((DataGridView)sender).Rows[((DataGridView)sender).CurrentCell.RowIndex].Cells[this.col_iv_docnum.Name].Value);
                }
                else
                {
                    this.curr_invoice = DbfTable.InVoice(this.data_path, (string)((DataGridView)sender).Rows[((DataGridView)sender).CurrentCell.RowIndex].Cells[this.col_hs_docnum.Name].Value);
                }
            }

            this.FillForm(this.curr_invoice);
        }

        private void FillForm(Invoice inv)
        {
            if(inv != null)
            {
                this.lblCuscod.Text = inv.artrn.cuscod;
                this.lblCusnam.Text = inv.artrn.cusnam;
                this.lblAddr01.Text = inv.artrn.addr01;
                this.lblAddr02.Text = inv.artrn.addr02 + " " + inv.artrn.addr03 + " " + inv.artrn.zipcod;
                this.lblTelnum.Text = inv.artrn.telnum;
                this.lblDocdat.Text = inv.artrn.docdat.HasValue ? inv.artrn.docdat.Value.ToString("dd/MM/yyyy", CultureInfo.GetCultureInfo("th-TH")) : string.Empty;
                this.lblDocnum.Text = inv.artrn.docnum;
                this.lblSonum.Text = inv.artrn.sonum;
                this.lblSlmcod.Text = inv.artrn.slmcod;
                this.lblStatus.Visible = inv.artrn.num2 > 0 ? true : false;

                this.dgvSTCRD.DataSource = inv.stcrds;
            }
            else
            {
                Invoice empty_inv = new Invoice
                {
                    artrn = new ArtrnDesc
                    {
                        cuscod = string.Empty,
                        cusnam = string.Empty,
                        addr01 = string.Empty,
                        addr02 = string.Empty,
                        addr03 = string.Empty,
                        zipcod = string.Empty,
                        docdat = null,
                        docnum = string.Empty,
                        slmcod = string.Empty,
                        sonum = string.Empty,
                        telnum = string.Empty,
                        num2 = 0
                    },
                    stcrds = new List<StcrdMinVM>()
                };

                this.FillForm(empty_inv);
            }
        }

        private void tabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.GetInvoiceList();

            if (((TabControl)sender).SelectedTab == this.tabIV)
            {
                this.dgvIV_CurrentCellChanged(this.dgvIV, e);
            }
            else
            {
                this.dgvIV_CurrentCellChanged(this.dgvHS, e);
            }
        }

        private void dgvIV_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                if (this.form_mode == FORM_MODE.READ)
                {
                    if (((DataGridView)sender).Columns[e.ColumnIndex].Name == this.col_iv_warranty_spec.Name || ((DataGridView)sender).Columns[e.ColumnIndex].Name == this.col_hs_warranty_spec.Name)
                    {
                        e.CellStyle.Font = new Font("Tahoma", 7f, FontStyle.Regular);
                    }
                    e.CellStyle.BackColor = Color.Pink;
                    e.CellStyle.SelectionBackColor = Color.Pink;

                    e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                    e.Handled = true;
                }
                else
                {
                    if (((DataGridView)sender).Columns[e.ColumnIndex].Name == this.col_iv_warranty_spec.Name || ((DataGridView)sender).Columns[e.ColumnIndex].Name == this.col_hs_warranty_spec.Name)
                    {
                        e.CellStyle.Font = new Font("Tahoma", 7f, FontStyle.Regular);
                    }
                    e.CellStyle.BackColor = ((DataGridView)sender).ColumnHeadersDefaultCellStyle.BackColor;
                    e.CellStyle.SelectionBackColor = ((DataGridView)sender).ColumnHeadersDefaultCellStyle.SelectionBackColor;

                    e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                    e.Handled = true;
                }

            }
            else
            {
                if(((DataGridView)sender).Columns[e.ColumnIndex].Name == this.col_iv_warranty_spec.Name || ((DataGridView)sender).Columns[e.ColumnIndex].Name == this.col_hs_warranty_spec.Name)
                {
                    var warranted = (string)((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                    if(warranted != "Y")
                    {
                        e.Paint(e.CellBounds, DataGridViewPaintParts.Background | DataGridViewPaintParts.Border | DataGridViewPaintParts.ContentBackground);
                        Rectangle rect = new Rectangle(e.CellBounds.X + 5, e.CellBounds.Y + 5, 16, 16);
                        e.Graphics.DrawImage((Image)Warranty.Properties.Resources.stamp, rect);
                        e.Handled = true;
                    }
                    else
                    {
                        e.Paint(e.CellBounds, DataGridViewPaintParts.Background | DataGridViewPaintParts.Border);
                        e.Handled = true;
                    }
                }
            }
        }

        private void dgv_PaintFocusedRow(object sender, PaintEventArgs e)
        {
            if (((DataGridView)sender).CurrentCell == null)
                return;

            int curr_row_ndx = ((DataGridView)sender).CurrentCell.RowIndex;
            Rectangle rect = ((DataGridView)sender).GetRowDisplayRectangle(curr_row_ndx, true);
            using (Pen p = new Pen(new SolidBrush(Color.Red)))
            {
                e.Graphics.DrawLine(p, new Point(rect.X, rect.Y), new Point(rect.X + rect.Width, rect.Y));
                e.Graphics.DrawLine(p, new Point(rect.X, rect.Y + rect.Height - 1), new Point(rect.X + rect.Width, rect.Y + rect.Height - 1));
            }
        }

        private void dgvSTCRD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            if(((DataGridView)sender).Columns[e.ColumnIndex].Name == this.col_warranty_type.Name)
            {
                this.ShowWarrantyForm();
            }
        }

        private void GetInvoiceList()
        {
            if (this.tabControl2.SelectedTab == this.tabIV)
            {
                this.iv_list = new BindingList<ArtrnMin>(DbfTable.InvoiceList(this.data_path, this.status, DbfTable.INVOICE_TYPE.IV));
                this.dgvIV.DataSource = this.iv_list;
                this.tabIV.Text = "  ขายเชื่อ (" + this.iv_list.Count.ToString() + ") <F6>  ";
            }
            else
            {
                this.hs_list = new BindingList<ArtrnMin>(DbfTable.InvoiceList(this.data_path, this.status, DbfTable.INVOICE_TYPE.HS));
                this.dgvHS.DataSource = this.hs_list;
                this.tabHS.Text = "  ขายสด (" + this.hs_list.Count.ToString() + ") <F7>  ";
            }
        }

        public ReIndexResult Reindex()
        {
            ReIndexResult result = new ReIndexResult { success = false, err_message = string.Empty };

            FileInfo file_dbinf = new FileInfo(this.express_path + @"\dbinf.dbf");
            FileInfo file_artrnrm = new FileInfo(this.data_path + @"\artrnrm.dbf");

            if (!File.Exists(this.express_path + @"\dbinf.dbf"))
            {
                result.err_message = "File Not Found DBINF.DBF";
                return result;
            }
            if (file_dbinf.IsInUse())
            {
                result.err_message = "Permission Error File DBINF.DBF";
                return result;
            }
            if (file_artrnrm.IsInUse())
            {
                result.err_message = "Permission Error File ARTRNRM.DBF";
                return result;
            }


            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WorkingDirectory = this.express_path;
            startInfo.UseShellExecute = false;
            startInfo.CreateNoWindow = true;
            startInfo.RedirectStandardOutput = true;
            startInfo.RedirectStandardError = true;
            startInfo.RedirectStandardInput = true;

            startInfo.FileName = this.express_path + @"\adm32.exe";
            startInfo.Arguments = this.data_path;

            Process process = new Process();
            process.StartInfo = startInfo;
            process.Start();

            process.StandardInput.WriteLine("14");

            StringBuilder message = new StringBuilder();
            while (!process.StandardOutput.EndOfStream)
            {
                char[] buffer = new char[200];
                int chars = process.StandardOutput.Read(buffer, 0, buffer.Length);
                message.Append(buffer, 0, chars);
            }

            result.success = true;

            return result;
        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.status = (TransactionStatus.STATUS)((ComboboxItem)((ComboBox)sender).SelectedItem).Value;
            this.GetInvoiceList();
        }

        private void dgvIV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            if(((DataGridView)sender).Columns[e.ColumnIndex].Name == this.col_hs_warranty_spec.Name || ((DataGridView)sender).Columns[e.ColumnIndex].Name == this.col_iv_warranty_spec.Name)
            {
                var warranted = (string)((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                if(warranted != "Y")
                {
                    if (MessageBox.Show("ทำเครื่องหมายว่า " + this.curr_invoice.artrn.docnum + " ได้บันทึกอายุรับประกันแล้ว, ทำต่อหรือไม่?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        try
                        {
                            using (OleDbConnection conn = new OleDbConnection(@"Provider=VFPOLEDB.1;Data Source=" + this.data_path))
                            {
                                conn.Open();
                                using (OleDbCommand cmd = conn.CreateCommand())
                                {

                                    cmd.CommandText = "Update artrn Set num2=1 Where TRIM(docnum)='" + this.curr_invoice.artrn.docnum.Trim() + "'";
                                    int affected = cmd.ExecuteNonQuery();
                                    if(affected > 0)
                                    {
                                        this.tabControl2_SelectedIndexChanged(this.tabControl2, e);
                                    }
                                }
                                conn.Close();
                            }

                            log.KeepLog(new LogDetail { data_path = this.data_path, docnum = this.curr_invoice.artrn.docnum.Trim(), seqnum = string.Empty, desc = "ทำเครื่องหมายว่าบันทึกอายุรับประกันแล้ว" });
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void dgvSTCRD_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if(e.RowIndex == -1)
            {
                if(this.form_mode == FORM_MODE.READ_ITEM)
                {
                    e.CellStyle.BackColor = Color.Pink;
                    e.CellStyle.SelectionBackColor = Color.Pink;
                    e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                    if (((DataGridView)sender).Columns[e.ColumnIndex].Name == this.col_tqucod.Name)
                    {
                        Rectangle rect_1 = ((DataGridView)sender).GetCellDisplayRectangle(((DataGridView)sender).Columns[this.col_trnqty.Name].Index, -1, true);
                        Rectangle rect_2 = ((DataGridView)sender).GetCellDisplayRectangle(((DataGridView)sender).Columns[this.col_tqucod.Name].Index, -1, true);
                        using (SolidBrush b = new SolidBrush(Color.Pink))
                        {
                            RectangleF rect = new RectangleF(rect_1.X + 1, rect_1.Y + 2, rect_1.Width + rect_2.Width - 2, rect_1.Height - 2);
                            e.Graphics.FillRectangle(b, rect);
                            using (SolidBrush bfnt = new SolidBrush(((DataGridView)sender).ColumnHeadersDefaultCellStyle.ForeColor))
                            {
                                e.Graphics.DrawString("จำนวน", ((DataGridView)sender).ColumnHeadersDefaultCellStyle.Font, bfnt, rect_1, new StringFormat { Alignment = StringAlignment.Far, LineAlignment = StringAlignment.Center });
                            }
                        }
                    }
                    e.Handled = true;
                }
                else
                {
                    e.CellStyle.BackColor = ((DataGridView)sender).ColumnHeadersDefaultCellStyle.BackColor;
                    e.CellStyle.SelectionBackColor = ((DataGridView)sender).ColumnHeadersDefaultCellStyle.SelectionBackColor;
                    e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                    if (((DataGridView)sender).Columns[e.ColumnIndex].Name == this.col_tqucod.Name)
                    {
                        Rectangle rect_1 = ((DataGridView)sender).GetCellDisplayRectangle(((DataGridView)sender).Columns[this.col_trnqty.Name].Index, -1, true);
                        Rectangle rect_2 = ((DataGridView)sender).GetCellDisplayRectangle(((DataGridView)sender).Columns[this.col_tqucod.Name].Index, -1, true);
                        using (SolidBrush b = new SolidBrush(((DataGridView)sender).ColumnHeadersDefaultCellStyle.BackColor))
                        {
                            RectangleF rect = new RectangleF(rect_1.X + 1, rect_1.Y + 2, rect_1.Width + rect_2.Width - 2, rect_1.Height - 2);
                            e.Graphics.FillRectangle(b, rect);
                            using (SolidBrush bfnt = new SolidBrush(((DataGridView)sender).ColumnHeadersDefaultCellStyle.ForeColor))
                            {
                                e.Graphics.DrawString("จำนวน", ((DataGridView)sender).ColumnHeadersDefaultCellStyle.Font, bfnt, rect_1, new StringFormat { Alignment = StringAlignment.Far, LineAlignment = StringAlignment.Center });
                            }
                        }
                    }
                    e.Handled = true;
                }
            }
        }

        private void dgvIV_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            if(((DataGridView)sender).Columns[e.ColumnIndex].Name == this.col_iv_warranty_spec.Name || ((DataGridView)sender).Columns[e.ColumnIndex].Name == this.col_hs_warranty_spec.Name)
            {
                bool warranted = false;
                if (this.tabControl2.SelectedTab == this.tabIV)
                {
                    warranted = (string)((DataGridView)sender).Rows[e.RowIndex].Cells[this.col_iv_warranty_spec.Name].Value == "Y" ? true : false;
                }
                else
                {
                    warranted = (string)((DataGridView)sender).Rows[e.RowIndex].Cells[this.col_hs_warranty_spec.Name].Value == "Y" ? true : false;
                }

                if (!warranted)
                {
                    ((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex].ToolTipText = "ทำเครื่องหมายว่าบันทึกอายุรับประกันแล้ว";
                }
            }
        }

        private void dgvSTCRD_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            if(((DataGridView)sender).Columns[e.ColumnIndex].Name == this.col_warranty_type.Name)
            {
                ((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex].ToolTipText = "แก้ไขอายุรับประกันของสินค้านี้ <Alt + E>";
            }
        }

        private void dgvSTCRD_Enter(object sender, EventArgs e)
        {
            this.form_mode = FORM_MODE.READ_ITEM;

            this.dgvHS.Refresh();
            this.dgvIV.Refresh();
            this.dgvSTCRD.Refresh();
        }

        private void dgvIV_Enter(object sender, EventArgs e)
        {
            this.form_mode = FORM_MODE.READ;

            this.dgvHS.Refresh();
            this.dgvIV.Refresh();
            this.dgvSTCRD.Refresh();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F6)
            {
                this.form_mode = FORM_MODE.READ;
                this.tabControl2.SelectedTab = this.tabIV;
                this.dgvIV.Refresh();
                this.dgvSTCRD.Refresh();
                this.dgvIV.Focus();
            }

            if (keyData == Keys.F7)
            {
                this.form_mode = FORM_MODE.READ;
                this.tabControl2.SelectedTab = this.tabHS;
                this.dgvHS.Refresh();
                this.dgvSTCRD.Refresh();
                this.dgvHS.Focus();
            }

            if (keyData == Keys.F8)
            {
                this.form_mode = FORM_MODE.READ_ITEM;
                this.dgvSTCRD.Refresh();
                this.dgvIV.Refresh();
                this.dgvHS.Refresh();
                this.dgvSTCRD.Focus();
            }

            if (keyData == (Keys.Alt | Keys.E))
            {
                if(this.form_mode == FORM_MODE.READ_ITEM)
                {
                    if(this.dgvSTCRD.Rows.Count > 0)
                    {
                        this.ShowWarrantyForm();
                        return true;
                    }
                }
            }

            if(keyData == Keys.Enter)
            {
                if (this.txtSearchDocnum.Focused)
                {
                    this.btnSearch.PerformClick();
                    return true;
                }
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void dgvSTCRD_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            this.ShowWarrantyForm();
        }

        private void dgvSTCRD_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                int row_index = ((DataGridView)sender).HitTest(e.X, e.Y).RowIndex;
                if (row_index > -1)
                {
                    ((DataGridView)sender).Rows[row_index].Cells[this.col_stkcod.Name].Selected = true;

                    ContextMenu cm = new ContextMenu();
                    MenuItem mnu_edit = new MenuItem("แก้ไขอายุรับประกันของสินค้านี้ <Alt + E>");
                    mnu_edit.Click += delegate
                    {
                        this.ShowWarrantyForm();
                    };
                    cm.MenuItems.Add(mnu_edit);

                    cm.Show((DataGridView)sender, new Point(e.X, e.Y));
                }
            }
        }

        private void ShowWarrantyForm()
        {
            var st = (StcrdMin)this.dgvSTCRD.Rows[this.dgvSTCRD.CurrentCell.RowIndex].Cells[this.col_stcrdmin.Name].Value;

            DialogWarranty war = new DialogWarranty(this, st);
            if (war.ShowDialog() == DialogResult.OK)
            {
                if (this.tabControl2.SelectedTab == this.tabIV)
                {
                    this.curr_invoice = DbfTable.InVoice(this.data_path, this.curr_invoice.artrn.docnum.Trim());
                }
                else
                {
                    this.curr_invoice = DbfTable.InVoice(this.data_path, this.curr_invoice.artrn.docnum.Trim());
                }

                this.FillForm(this.curr_invoice);

                if (this.dgvSTCRD.Rows.Count > 0)
                    this.dgvSTCRD.Rows.Cast<DataGridViewRow>().Where(r => ((StcrdMin)r.Cells[this.col_stcrdmin.Name].Value).seqnum == st.seqnum).First().Cells[this.col_stkcod.Name].Selected = true;
            }
        }

        private void dgvIV_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                int row_index = ((DataGridView)sender).HitTest(e.X, e.Y).RowIndex;

                if(row_index > -1)
                {
                    if (this.tabControl2.SelectedTab == this.tabIV)
                        ((DataGridView)sender).Rows[row_index].Cells[this.col_iv_docnum.Name].Selected = true;

                    if(this.tabControl2.SelectedTab == this.tabHS)
                        ((DataGridView)sender).Rows[row_index].Cells[this.col_hs_docnum.Name].Selected = true;

                    ContextMenu cm = new ContextMenu();
                    MenuItem mnu_appr = new MenuItem("ทำเครื่องหมายว่าบันทึกอายุรับประกันแล้ว");
                    mnu_appr.Click += delegate
                    {
                        this.ShowApproveWarrantyForm();
                    };
                    cm.MenuItems.Add(mnu_appr);

                    cm.Show((DataGridView)sender, new Point(e.X, e.Y));
                }
            }
        }

        private void ShowApproveWarrantyForm()
        {
            string warranted = string.Empty;

            if(this.tabControl2.SelectedTab == this.tabIV)
            {
                warranted = (string)this.dgvIV.Rows[this.dgvIV.CurrentCell.RowIndex].Cells[this.col_iv_warranty_spec.Name].Value;
            }
            else
            {
                warranted = (string)this.dgvHS.Rows[this.dgvHS.CurrentCell.RowIndex].Cells[this.col_hs_warranty_spec.Name].Value;
            }

            if (warranted != "Y")
            {
                if (MessageBox.Show("ทำเครื่องหมายว่า " + this.curr_invoice.artrn.docnum + " ได้บันทึกอายุรับประกันแล้ว, ทำต่อหรือไม่?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    try
                    {
                        using (OleDbConnection conn = new OleDbConnection(@"Provider=VFPOLEDB.1;Data Source=" + this.data_path))
                        {
                            conn.Open();
                            using (OleDbCommand cmd = conn.CreateCommand())
                            {

                                cmd.CommandText = "Update artrn Set num2=1 Where TRIM(docnum)='" + this.curr_invoice.artrn.docnum.Trim() + "'";
                                int affected = cmd.ExecuteNonQuery();
                                if (affected > 0)
                                {
                                    this.tabControl2_SelectedIndexChanged(this.tabControl2, new EventArgs());
                                }
                            }
                            conn.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (this.txtSearchDocnum.Text.Trim().Length == 0)
                return;

            List<ArtrnMin> iv_list = DbfTable.InvoiceList(this.data_path, TransactionStatus.STATUS.ALL, DbfTable.INVOICE_TYPE.IV);
            List<ArtrnMin> hs_list = DbfTable.InvoiceList(this.data_path, TransactionStatus.STATUS.ALL, DbfTable.INVOICE_TYPE.HS);

            ArtrnMin target_invoice = null;
            if(iv_list.Where(i => i.docnum.Trim() == this.txtSearchDocnum.Text.Trim()).FirstOrDefault() != null)
            {
                target_invoice = iv_list.Where(i => i.docnum.Trim() == this.txtSearchDocnum.Text.Trim()).First();
                this.tabControl2.SelectedTab = this.tabIV;
                this.cbStatus.SelectedItem = this.cbStatus.Items.Cast<ComboboxItem>().Where(c => (TransactionStatus.STATUS)c.Value == TransactionStatus.STATUS.ALL).First();
                this.dgvIV.Rows.Cast<DataGridViewRow>().Where(r => ((string)r.Cells[this.col_iv_docnum.Name].Value).Trim() == this.txtSearchDocnum.Text.Trim()).First().Cells[this.col_iv_docnum.Name].Selected = true;
            }
            else if(hs_list.Where(i => i.docnum.Trim() == this.txtSearchDocnum.Text.Trim()).FirstOrDefault() != null)
            {
                target_invoice = hs_list.Where(i => i.docnum.Trim() == this.txtSearchDocnum.Text.Trim()).First();
                this.tabControl2.SelectedTab = this.tabHS;
                this.cbStatus.SelectedItem = this.cbStatus.Items.Cast<ComboboxItem>().Where(c => (TransactionStatus.STATUS)c.Value == TransactionStatus.STATUS.ALL).First();
                this.dgvHS.Rows.Cast<DataGridViewRow>().Where(r => ((string)r.Cells[this.col_hs_docnum.Name].Value).Trim() == this.txtSearchDocnum.Text.Trim()).First().Cells[this.col_hs_docnum.Name].Selected = true;
            }
            else
            {
                MessageBox.Show("ค้นหาบิลขายเลขที่ " + this.txtSearchDocnum.Text.Trim() + " ไม่พบ");
                return;
            }
        }

        private void btnLog_ButtonClick(object sender, EventArgs e)
        {
            DialogIslog log = new DialogIslog(this);
            log.ShowDialog();
        }
    }
}
