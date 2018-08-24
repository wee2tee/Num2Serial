using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
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
    }
}
