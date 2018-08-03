using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
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
        public string data_path = null;
        public Invoice curr_invoice = null;
        private BindingList<ArtrnMin> iv_list;
        private BindingList<ArtrnMin> hs_list;

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

            this.iv_list = new BindingList<ArtrnMin>();
            this.dgvIV.DataSource = this.iv_list;
            this.hs_list = new BindingList<ArtrnMin>();

            this.secure_path = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.FullName + @"\secure\";

            if (!this.TestSecurePath())
            {
                MessageBox.Show("ค้นหาไดเร็คทอรี่ Secure ไม่พบ, อาจเป็นเพราะที่เก็บโปรแกรมไม่ถูกต้อง", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
                return;
            }
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

                    this.iv_list =  new BindingList<ArtrnMin>(DbfTable.InvoiceList(this.data_path, true, DbfTable.INVOICE_TYPE.IV));
                    this.dgvIV.DataSource = this.iv_list;
                }
                else
                {
                    Application.Exit();
                }
            }
        }

        //public static DataTable Sccomp()
        //{
        //    //string secure_path = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.FullName + @"\secure\";

        //    if (!(Directory.Exists(secure_path) && File.Exists(secure_path + "sccomp.dbf")))
        //    {
        //        XMessageBox.Show("ค้นหาแฟ้ม Sccomp.dbf ไม่พบ, อาจเป็นเพราะท่านติดตั้งโปรแกรมไว้ไม่ถูกที่ โปรแกรมนี้จะต้องถูกติดตั้งภายใต้โฟลเดอร์ของโปรแกรมเอ็กซ์เพรสเท่านั้น", "Error", MessageBoxButtons.OK, XMessageBoxIcon.Stop);
        //        return new DataTable();
        //    }


        //    DataTable dt = new DataTable();

        //    OleDbConnection conn = new OleDbConnection(
        //        @"Provider=VFPOLEDB.1;Data Source=" + secure_path);

        //    conn.Open();

        //    if (conn.State == ConnectionState.Open)
        //    {
        //        string mySQL = "select * from Sccomp";

        //        OleDbCommand cmd = new OleDbCommand(mySQL, conn);
        //        OleDbDataAdapter DA = new OleDbDataAdapter(cmd);

        //        DA.Fill(dt);

        //        conn.Close();
        //    }

        //    return dt;
        //}

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
                this.curr_invoice = DbfTable.InVoice(this.data_path, (string)((DataGridView)sender).Rows[((DataGridView)sender).CurrentCell.RowIndex].Cells[this.col_iv_docnum.Name].Value);
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

            }
        }
    }
}
