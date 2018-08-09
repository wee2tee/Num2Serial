using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Num2Serial.Helper;

namespace Num2Serial.SubForm
{
    public partial class DialogWarranty : Form
    {
        public StcrdMin stcrdmin;
        private MainForm main_form;

        public DialogWarranty(MainForm main_form, StcrdMin stcrdmin)
        {
            this.main_form = main_form;
            this.stcrdmin = stcrdmin;
            InitializeComponent();
        }

        private void DialogWarranty_Load(object sender, EventArgs e)
        {
            this.cbWarType.Items.Add(new ComboboxItem { value = WarrantyType.TYPE.DEFAULT, Text = WarrantyType.Default });
            this.cbWarType.Items.Add(new ComboboxItem { value = WarrantyType.TYPE.SPECIFY, Text = WarrantyType.Specify });

            this.cbWarType.SelectedItem = this.cbWarType.Items.Cast<ComboboxItem>().Where(i => (WarrantyType.TYPE)i.value == this.stcrdmin.warranty_type).FirstOrDefault();
            this.numWarMonth.Value = this.stcrdmin.warranty_period;
        }

        private void cbWarType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if((WarrantyType.TYPE)((ComboboxItem)((ComboBox)sender).SelectedItem).value == WarrantyType.TYPE.DEFAULT)
            {
                this.numWarMonth.Value = this.stcrdmin.warranty_default;
                this.numWarMonth.Enabled = false;
                this.stcrdmin.warranty_type = WarrantyType.TYPE.DEFAULT;
            }
            else
            {
                this.numWarMonth.Enabled = true;
                this.numWarMonth.Select();
                this.stcrdmin.warranty_type = WarrantyType.TYPE.SPECIFY;
            }
        }

        private void numWarMonth_ValueChanged(object sender, EventArgs e)
        {
            this.stcrdmin.warranty_period = Convert.ToInt32(((NumericUpDown)sender).Value);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (this.cbWarType.SelectedItem == null)
            {
                MessageBox.Show("กรุณาระบุ วิธีกำหนดอายุรับประกัน", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.cbWarType.Focus();
                return;
            }

            List<Issn> issn = new List<Issn>();
            List<Artrnrm> artrnrm = new List<Artrnrm>();

            using (OleDbConnection conn = new OleDbConnection(@"Provider=VFPOLEDB.1;Data Source=" + this.main_form.data_path))
            {
                conn.Open();
                using (OleDbCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "Select issn.stkcod, issn.serial, issn.warmonth, issn.sal_date, issn.war_date, issn.exp_date From issn Where issn.serial IN ";
                    cmd.CommandText += "(Select serial From stlotsn Where TRIM(cutnum)='" + this.stcrdmin.docnum.PadRight(12) + this.stcrdmin.seqnum + "') ";
                    cmd.CommandText += "ORDER BY issn.serial ASC";
                    DataTable dt;
                    using (OleDbDataAdapter da = new OleDbDataAdapter(cmd))
                    {
                        dt = new DataTable();
                        da.Fill(dt);

                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            issn.Add(new Issn
                            {
                                exp_date = !dt.Rows[i].IsNull("exp_date") ? (DateTime?)dt.Rows[i]["exp_date"] : null,
                                sal_date = !dt.Rows[i].IsNull("sal_date") ? (DateTime?)dt.Rows[i]["sal_date"] : null,
                                war_date = !dt.Rows[i].IsNull("war_date") ? (DateTime?)dt.Rows[i]["war_date"] : null,
                                warmonth = !dt.Rows[i].IsNull("warmonth") ? dt.Rows[i]["warmonth"].ToString() : string.Empty,
                                serial = !dt.Rows[i].IsNull("serial") ? dt.Rows[i]["serial"].ToString().Trim() : string.Empty,
                                stkcod = !dt.Rows[i].IsNull("stkcod") ? dt.Rows[i]["stkcod"].ToString().Trim() : string.Empty,
                            });
                        }
                    }

                    cmd.CommandText = "Select artrnrm.docnum, artrnrm.seqnum, artrnrm.remark From artrnrm Where SUBSTR(artrnrm.seqnum,1,3)='" + this.stcrdmin.seqnum + "' ";
                    //cmd.CommandText += "ORDER BY artrnrm.docnum,artrnrm.seqnum ASC";
                    using (OleDbDataAdapter da = new OleDbDataAdapter(cmd))
                    {
                        dt.Clear();
                        da.Fill(dt);

                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            artrnrm.Add(new Artrnrm
                            {
                                docnum = !dt.Rows[i].IsNull("docnum") ? dt.Rows[i]["docnum"].ToString() : string.Empty,
                                seqnum = !dt.Rows[i].IsNull("seqnum") ? dt.Rows[i]["seqnum"].ToString() : string.Empty,
                                remark = !dt.Rows[i].IsNull("remark") ? dt.Rows[i]["remark"].ToString() : string.Empty
                            });
                        }
                    }
                }
                conn.Close();
            }

            switch (this.stcrdmin.warranty_type)
            {
                case WarrantyType.TYPE.DEFAULT:
                    
                    break;

                case WarrantyType.TYPE.SPECIFY:

                    break;

                default:
                    MessageBox.Show("กรุณาระบุ วิธีกำหนดอายุรับประกัน", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.cbWarType.Focus();
                    break;
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if(keyData == Keys.F9)
            {
                this.btnOK.PerformClick();
                return true;
            }

            if(keyData == Keys.Escape)
            {
                this.btnCancel.PerformClick();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
    }

    
}
