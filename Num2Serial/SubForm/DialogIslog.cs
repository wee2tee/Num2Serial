using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Warranty.Helper;

namespace Warranty.SubForm
{
    public partial class DialogIslog : Form
    {
        private MainForm main_form;
        private BindingList<Islog> islog;

        public DialogIslog(MainForm main_form)
        {
            this.main_form = main_form;
            InitializeComponent();
        }

        private void DialogIslog_Load(object sender, EventArgs e)
        {
            this.islog = new BindingList<Islog>(this.GetIslogList());
            this.dgv.DataSource = this.islog;
        }

        private List<Islog> GetIslogList()
        {
            List<Islog> log = new List<Islog>();

            using (SQLiteConnection conn = new SQLiteConnection(@"Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "Log.db;Version=3;"))
            {
                using (SQLiteCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "Select * From islog";
                    using (SQLiteDataAdapter da = new SQLiteDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();

                        da.Fill(dt);

                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            log.Add(new Islog
                            {
                                id = Convert.ToInt32(dt.Rows[i]["id"]),
                                rec_time = !dt.Rows[i].IsNull("rec_time") ? (DateTime?)dt.Rows[i]["rec_time"] : null,
                                data_path = !dt.Rows[i].IsNull("data_path") ? dt.Rows[i]["data_path"].ToString() : string.Empty,
                                docnum = !dt.Rows[i].IsNull("docnum") ? dt.Rows[i]["docnum"].ToString() : string.Empty,
                                seqnum = !dt.Rows[i].IsNull("seqnum") ? dt.Rows[i]["seqnum"].ToString() : string.Empty,
                                desc = !dt.Rows[i].IsNull("desc") ? dt.Rows[i]["desc"].ToString() : string.Empty
                            });
                        }
                    }
                }
            }

            return log;
        }

        private void dgv_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if(e.RowIndex == -1)
            {
                if(((DataGridView)sender).Columns[e.ColumnIndex].Name == this.col_docnum.Name)
                {
                    Rectangle rect = ((DataGridView)sender).GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);
                    this.btnSearchDocnum.SetBounds(rect.X + rect.Width - this.btnSearchDocnum.Width, rect.Y + 7, this.btnSearchDocnum.Width, this.btnSearchDocnum.Height);
                }

                if(((DataGridView)sender).Columns[e.ColumnIndex].Name == this.col_rec_time.Name)
                {
                    Rectangle rect = ((DataGridView)sender).GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);
                    this.btnSearchDate.SetBounds(rect.X + rect.Width - this.btnSearchDate.Width, rect.Y + 7, this.btnSearchDate.Width, this.btnSearchDate.Height);
                }
            }
        }

        private void btnSearchDate_Click(object sender, EventArgs e)
        {
            if (this.dgv.CurrentCell == null)
                return;

            DateTime? cur_dat = this.dgv.Rows.Count == 0 ? null : (DateTime?)this.dgv.Rows[this.dgv.CurrentCell.RowIndex].Cells[this.col_rec_time.Name].Value;

            DialogSearchDate sd = new DialogSearchDate(cur_dat);
            if(sd.ShowDialog() == DialogResult.OK)
            {
                var selected_row = this.dgv.Rows.Cast<DataGridViewRow>().Where(r => ((DateTime?)r.Cells[this.col_rec_time.Name].Value).Value.Date.CompareTo(sd.selected_date.Value.Date) == 0).FirstOrDefault();
                if (selected_row != null)
                {
                    selected_row.Cells[this.col_rec_time.Name].Selected = true;
                }
                else
                {
                    MessageBox.Show("ค้นหารายการวันที่ " + sd.selected_date.Value.ToString("dd/MM/yy", CultureInfo.GetCultureInfo("Th-th")) + " ไม่พบ");
                }

                this.dgv.Focus();
            }

        }

        private void btnSearchDocnum_Click(object sender, EventArgs e)
        {
            DialogSearchDocnum sd = new DialogSearchDocnum();
            if(sd.ShowDialog() == DialogResult.OK)
            {
                var selected_row = this.dgv.Rows.Cast<DataGridViewRow>().Where(r => ((string)r.Cells[this.col_docnum.Name].Value).Trim() == sd.docnum.Trim()).FirstOrDefault();
                if (selected_row != null)
                {
                    selected_row.Cells[this.col_docnum.Name].Selected = true;
                }
                else
                {
                    MessageBox.Show("ค้นหาเอกสารเลขที่ " + sd.docnum.Trim() + " ไม่พบ");
                }

                this.dgv.Focus();
            }
        }
    }
}
