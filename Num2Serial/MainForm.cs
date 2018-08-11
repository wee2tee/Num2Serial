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
using Num2Serial.Helper;
using Num2Serial.SubForm;

namespace Num2Serial
{
    public partial class MainForm : Form
    {
        public string secure_path = null;
        public string express_path = null;
        public string data_path = null;
        public Invoice curr_invoice = null;
        private BindingList<ArtrnMin> iv_list;
        private BindingList<ArtrnMin> hs_list;
        private bool only_new_iv = true;
        private FORM_MODE form_mode;

        public MainForm(string data_path = null)
        {
            
            if(data_path != null && data_path.Trim().Length > 0)
            {
                if (data_path.Contains(@"\"))
                {
                    this.data_path = data_path;
                }
                else
                {
                    this.data_path = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.FullName + @"\" + data_path;
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

            this.secure_path = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.FullName + @"\secure";
            this.express_path = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.FullName;

            if (!this.TestSecurePath())
            {
                MessageBox.Show("ค้นหาไดเร็คทอรี่ Secure ไม่พบ, อาจเป็นเพราะที่เก็บโปรแกรมไม่ถูกต้อง", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
                return;
            }

            this.ResetFormState(FORM_MODE.READ);
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            if(this.data_path == null)
            {
                DialogCompanySelect comp = new DialogCompanySelect(this);
                if(comp.ShowDialog() == DialogResult.OK)
                {
                    this.data_path = comp.selected_comp.RewriteDataPath();
                    this.lblDataPath.Text = this.data_path.TrimEnd('\\') + "   [" + comp.selected_comp.compnam + "]";

                    this.iv_list =  new BindingList<ArtrnMin>(DbfTable.InvoiceList(this.data_path, this.only_new_iv, DbfTable.INVOICE_TYPE.IV));
                    this.dgvIV.DataSource = this.iv_list;
                    this.tabIV.Text = "  ขายเชื่อ (" + this.iv_list.Count.ToString() + ")  ";
                }
                else
                {
                    Application.Exit();
                }
            }
        }

        private void ResetFormState(FORM_MODE form_mode)
        {
            this.form_mode = form_mode;

            this.btnItem.SetControlState(new FORM_MODE[] { FORM_MODE.READ }, form_mode);
            this.btnSave.SetControlState(new FORM_MODE[] { FORM_MODE.EDIT }, form_mode);
            this.btnStop.SetControlState(new FORM_MODE[] { FORM_MODE.EDIT }, form_mode);
            this.btnWarrantyOK.SetControlState(new FORM_MODE[] { FORM_MODE.READ }, form_mode);
            this.dgvIV.SetControlState(new FORM_MODE[] { FORM_MODE.READ }, form_mode);
            this.dgvHS.SetControlState(new FORM_MODE[] { FORM_MODE.READ }, form_mode);
            this.cbWarranty.SetControlState(new FORM_MODE[] { FORM_MODE.READ }, form_mode);
            this.cbWarranted.SetControlState(new FORM_MODE[] { FORM_MODE.READ }, form_mode);
        }

        private bool TestSecurePath()
        {
            //if (File.Exists(this.secure_path + "sccomp.dbf"))
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
                        telnum = string.Empty
                    },
                    stcrds = new List<StcrdMinVM>()
                };

                this.FillForm(empty_inv);
            }
        }

        private void cbWarranty_CheckedChanged(object sender, EventArgs e)
        {
            this.only_new_iv = ((CheckBox)sender).Checked;

            if(this.tabControl2.SelectedTab == this.tabIV)
            {
                this.iv_list = new BindingList<ArtrnMin>(DbfTable.InvoiceList(this.data_path, this.only_new_iv, DbfTable.INVOICE_TYPE.IV));
                this.dgvIV.DataSource = this.iv_list;
                this.tabIV.Text = "  ขายเชื่อ (" + this.iv_list.Count.ToString() + ")  ";
            }
            else
            {
                this.hs_list = new BindingList<ArtrnMin>(DbfTable.InvoiceList(this.data_path, this.only_new_iv, DbfTable.INVOICE_TYPE.HS));
                this.dgvHS.DataSource = this.hs_list;
                this.tabHS.Text = "  ขายสด (" + this.hs_list.Count.ToString() + ")  ";
            }
        }

        private void tabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(((TabControl)sender).SelectedTab == this.tabIV)
            {
                this.iv_list = new BindingList<ArtrnMin>(DbfTable.InvoiceList(this.data_path, this.only_new_iv, DbfTable.INVOICE_TYPE.IV));
                this.dgvIV.DataSource = this.iv_list;
                this.tabIV.Text = "  ขายเชื่อ (" + this.iv_list.Count.ToString() + ")  ";
            }
            else
            {
                this.hs_list = new BindingList<ArtrnMin>(DbfTable.InvoiceList(this.data_path, this.only_new_iv, DbfTable.INVOICE_TYPE.HS));
                this.dgvHS.DataSource = this.hs_list;
                this.tabHS.Text = "  ขายสด (" + this.hs_list.Count.ToString() + ")  ";
            }
        }

        private void dgvIV_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if(e.RowIndex == -1)
            {
                if(((DataGridView)sender).Columns[e.ColumnIndex].Name == this.col_iv_warranty_spec.Name || ((DataGridView)sender).Columns[e.ColumnIndex].Name == this.col_hs_warranty_spec.Name)
                {
                    e.CellStyle.Font = new Font("Tahoma", 7f, FontStyle.Regular);
                    e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                    e.Handled = true;
                }
            }
        }

        private void dgvSTCRD_Paint(object sender, PaintEventArgs e)
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
                var st = (StcrdMin)((DataGridView)sender).Rows[e.RowIndex].Cells[this.col_stcrdmin.Name].Value;

                DialogWarranty war = new DialogWarranty(this, st);
                if(war.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }

        private void btnWarrantyOK_Click(object sender, EventArgs e)
        {
            var reindex_result = this.Reindex();
            
            if (reindex_result.success)
            {
                MessageBox.Show("It's OK");
            }
            else
            {
                MessageBox.Show(reindex_result.err_message);
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
    }
}
