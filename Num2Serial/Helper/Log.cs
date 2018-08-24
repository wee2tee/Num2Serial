using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Warranty.Helper
{
    public class Log
    {
        SQLiteConnection conn = null;

        public Log()
        {
            if (!File.Exists(AppDomain.CurrentDomain.BaseDirectory + "Log.db"))
            {
                SQLiteConnection.CreateFile(AppDomain.CurrentDomain.BaseDirectory + "Log.db");
                using (SQLiteConnection conn = new SQLiteConnection(@"Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "Log.db;Version=3;"))
                {
                    conn.Open();
                    using (SQLiteCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "Create table If Not Exists islog (id INTEGER PRIMARY KEY AUTOINCREMENT, rec_time datetime default current_timestamp, data_path varchar(50), docnum varchar(12), seqnum varchar(3), desc varchar(100))";
                        cmd.ExecuteNonQuery();
                    }
                    conn.Close();
                }
            }

            this.conn = new SQLiteConnection(@"Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "Log.db;Version=3;");
        }

        public bool KeepLog(LogDetail log)
        {
            try
            {
                this.conn.Open();
                using (SQLiteCommand cmd = this.conn.CreateCommand())
                {
                    cmd.CommandText = "Insert into islog (rec_time, data_path, docnum, seqnum, desc) values((Select datetime((Select strftime('%s', 'now')), 'unixepoch', 'localtime')), '" + log.data_path + "', '" + log.docnum + "', '" + log.seqnum + "', '" + log.desc + "')";
                    cmd.ExecuteNonQuery();
                    this.conn.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }

    public class LogDetail
    {
        public int id { get; set; }
        public DateTime? rec_time { get; set; }
        public string data_path { get; set; }
        public string docnum { get; set; }
        public string seqnum { get; set; }
        public string desc { get; set; }

    }
}
