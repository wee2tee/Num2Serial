using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;

namespace Num2Serial.Helper
{
    public static class DbfTable
    {
        public enum INVOICE_TYPE : int
        {
            IV = 3,
            HS = 1
        }

        public static List<Sccomp> Sccomp(string secure_path)
        {
            DataTable dt = new DataTable();

            OleDbConnection conn = new OleDbConnection(
                @"Provider=VFPOLEDB.1;Data Source=" + secure_path);

            conn.Open();

            if (conn.State == ConnectionState.Open)
            {
                string sql = "select * from sccomp";

                OleDbCommand cmd = new OleDbCommand(sql, conn);
                OleDbDataAdapter DA = new OleDbDataAdapter(cmd);

                DA.Fill(dt);

                conn.Close();
            }

            List<Sccomp> sccomp = new List<Sccomp>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                sccomp.Add(new Sccomp
                {
                    compcod = !dt.Rows[i].IsNull("compcod") ? dt.Rows[i]["compcod"].ToString().TrimEnd() : string.Empty,
                    compnam = !dt.Rows[i].IsNull("compnam") ? dt.Rows[i]["compnam"].ToString().TrimEnd() : string.Empty,
                    gendat = !dt.Rows[i].IsNull("gendat") ? (DateTime?)dt.Rows[i]["gendat"] : null,
                    candel = !dt.Rows[i].IsNull("candel") ? dt.Rows[i]["candel"].ToString().TrimEnd() : string.Empty,
                    path = !dt.Rows[i].IsNull("path") ? dt.Rows[i]["path"].ToString().TrimEnd() : string.Empty
                });
            }

            return sccomp;
        }

        public static List<ArtrnMin> InvoiceList(string data_path, bool only_new_invoice = true, INVOICE_TYPE invoice_type = INVOICE_TYPE.IV)
        {
            if (!File.Exists(data_path + "artrn.dbf"))
                throw new Exception("ค้นหาไฟล์ artrn.dbf ไม่พบ");
            if (!File.Exists(data_path + "stcrd.dbf"))
                throw new Exception("ค้นหาไฟล์ stcrd.dbf ไม่พบ");
            if (!File.Exists(data_path + "stmas.dbf"))
                throw new Exception("ค้นหาไฟล์ stmas.dbf ไม่พบ");
            if (!File.Exists(data_path + "isacc.dbf"))
                throw new Exception("ค้นหาไฟล์ isacc.dbf ไม่พบ");
            if (!File.Exists(data_path + "artrnrm.dbf"))
                throw new Exception("ค้นหาไฟล์ artrnrm.dbf ไม่พบ");

            DataTable dt = new DataTable();
            using (OleDbConnection conn = new OleDbConnection(@"Provider=VFPOLEDB.1;Data Source=" + data_path))
            {
                conn.Open();
                var cmd = conn.CreateCommand();
                if (only_new_invoice)
                {
                    cmd.CommandText = "Select artrn.docnum, artrn.docdat, artrn.cuscod, armas.cusnam From artrn ";
                    cmd.CommandText += "Left Join armas On artrn.cuscod = armas.cuscod ";
                    cmd.CommandText += "Where artrn.docnum In ";
                    cmd.CommandText += "(Select stcrd.docnum From stcrd Left Join stmas On stcrd.stkcod=stmas.stkcod Left Join isacc On stmas.acccod=isacc.acccod Where isacc.method='X') ";
                    cmd.CommandText += "And rectyp='" + ((int)invoice_type).ToString() + "' And num2=0 ";
                    cmd.CommandText += "Order By docdat,docnum ASC";
                }
                else
                {
                    cmd.CommandText = "Select artrn.docnum, artrn.docdat, artrn.cuscod, armas.cusnam From artrn ";
                    cmd.CommandText += "Left Join armas On artrn.cuscod = armas.cuscod ";
                    cmd.CommandText += "Where artrn.docnum In ";
                    cmd.CommandText += "(Select stcrd.docnum From stcrd Left Join stmas On stcrd.stkcod=stmas.stkcod Left Join isacc On stmas.acccod=isacc.acccod Where isacc.method='X') ";
                    cmd.CommandText += "And rectyp='" + ((int)invoice_type).ToString() + "' ";
                    cmd.CommandText += "Order By docdat,docnum ASC";
                }

                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                conn.Close();
            }

            List<ArtrnMin> artrn = new List<ArtrnMin>();
            foreach (DataRow row in dt.Rows)
            {
                try
                {
                    ArtrnMin a = new ArtrnMin
                    {
                        cuscod = !row.IsNull("cuscod") ? row["cuscod"].ToString().Trim() : string.Empty,
                        cusnam = !row.IsNull("cusnam") ? row["cusnam"].ToString().Trim() : string.Empty,
                        docnum = !row.IsNull("docnum") ? row["docnum"].ToString().Trim() : string.Empty,
                        docdat = !row.IsNull("docdat") ? (DateTime?)row["docdat"] : null
                    };

                    //Artrn a = new Artrn
                    //{
                    //    rectyp = row.Field<string>("rectyp"),
                    //    docnum = row.Field<string>("docnum").Trim(),
                    //    docdat = !row.IsNull("docdat") ? (DateTime?)row.Field<DateTime>("docdat") : null,
                    //    postgl = row.Field<string>("postgl"),
                    //    sonum = row.Field<string>("sonum"),
                    //    cntyp = row.Field<string>("cntyp"),
                    //    depcod = row.Field<string>("depcod"),
                    //    flgvat = row.Field<string>("flgvat"),
                    //    slmcod = row.Field<string>("slmcod"),
                    //    cuscod = row.Field<string>("cuscod"),
                    //    shipto = row.Field<string>("shipto"),
                    //    youref = row.Field<string>("youref"),
                    //    areacod = row.Field<string>("areacod"),
                    //    paytrm = row.Field<decimal>("paytrm"),
                    //    duedat = !row.IsNull("duedat") ? (DateTime?)row.Field<DateTime>("duedat") : null,
                    //    bilnum = row.Field<string>("bilnum"),
                    //    nxtseq = row.Field<string>("nxtseq"),
                    //    amount = row.Field<double>("amount"),
                    //    disc = row.Field<string>("disc"),
                    //    discamt = row.Field<double>("discamt"),
                    //    aftdisc = row.Field<double>("aftdisc"),
                    //    advnum = row.Field<string>("advnum"),
                    //    advamt = row.Field<double>("advamt"),
                    //    total = row.Field<double>("total"),
                    //    amtrat0 = row.Field<double>("amtrat0"),
                    //    vatrat = row.Field<decimal>("vatrat"),
                    //    vatamt = row.Field<double>("vatamt"),
                    //    netamt = row.Field<double>("netamt"),
                    //    netval = row.Field<double>("netval"),
                    //    rcvamt = row.Field<double>("rcvamt"),
                    //    remamt = row.Field<double>("remamt"),
                    //    comamt = row.Field<double>("comamt"),
                    //    cmplapp = row.Field<string>("cmplapp"),
                    //    cmpldat = !row.IsNull("cmpldat") ? (DateTime?)row.Field<DateTime>("cmpldat") : null,
                    //    docstat = row.Field<string>("docstat"),
                    //    cshrcv = row.Field<double>("cshrcv"),
                    //    chqrcv = row.Field<double>("chqrcv"),
                    //    intrcv = row.Field<double>("intrcv"),
                    //    beftax = row.Field<double>("beftax"),
                    //    taxrat = row.Field<decimal>("taxrat"),
                    //    taxcond = row.Field<string>("taxcond"),
                    //    tax = row.Field<double>("tax"),
                    //    ivcamt = row.Field<double>("ivcamt"),
                    //    chqpas = row.Field<double>("chqpas"),
                    //    vatdat = !row.IsNull("vatdat") ? (DateTime?)row.Field<DateTime>("vatdat") : null,
                    //    vatprd = !row.IsNull("vatprd") ? (DateTime?)row.Field<DateTime>("vatprd") : null,
                    //    vatlate = row.Field<string>("vatlate"),
                    //    srv_vattyp = row.Field<string>("srv_vattyp"),
                    //    dlvby = row.Field<string>("dlvby"),
                    //    reserve = !row.IsNull("reserve") ? (DateTime?)row.Field<DateTime>("reserve") : null,
                    //    userid = row.Field<string>("userid"),
                    //    chgdat = !row.IsNull("chgdat") ? (DateTime?)row.Field<DateTime>("chgdat") : null,
                    //    userprn = row.Field<string>("userprn"),
                    //    prndat = !row.IsNull("prndat") ? (DateTime?)row.Field<DateTime>("prndat") : null,
                    //    prncnt = row.Field<decimal>("prncnt"),
                    //    authid = row.Field<string>("authid"),
                    //    approve = !row.IsNull("approve") ? (DateTime?)row.Field<DateTime>("approve") : null,
                    //    billto = row.Field<string>("billto"),
                    //    orgnum = row.Field<decimal>("orgnum")
                    //};

                    ///* only in v.1 */
                    //if (dt.Columns.Contains("prntim"))
                    //    a.prntim = row.Field<string>("prntim");
                    ///* only in v.2 */
                    //if (dt.Columns.Contains("creby"))
                    //    a.creby = row.Field<string>("creby");
                    //if (dt.Columns.Contains("credat"))
                    //    a.credat = !row.IsNull("credat") ? (DateTime?)row.Field<DateTime>("credat") : null;
                    //if (dt.Columns.Contains("ponum"))
                    //    a.ponum = row.Field<string>("ponum");
                    //if (dt.Columns.Contains("c_type"))
                    //    a.c_type = row.Field<string>("c_type");
                    //if (dt.Columns.Contains("c_date"))
                    //    a.c_date = !row.IsNull("c_date") ? (DateTime?)row.Field<DateTime>("c_date") : null;
                    //if (dt.Columns.Contains("c_ref"))
                    //    a.c_ref = row.Field<string>("c_ref");
                    //if (dt.Columns.Contains("c_rate"))
                    //    a.c_rate = row.Field<double>("c_rate");
                    //if (dt.Columns.Contains("c_fixrate"))
                    //    a.c_fixrate = row.Field<string>("c_fixrate");
                    //if (dt.Columns.Contains("c_ratio"))
                    //    a.c_ratio = row.Field<double>("c_ratio");
                    //if (dt.Columns.Contains("c_amount"))
                    //    a.c_amount = row.Field<double>("c_amount");
                    //if (dt.Columns.Contains("c_disc"))
                    //    a.c_disc = row.Field<string>("c_disc");
                    //if (dt.Columns.Contains("c_discamt"))
                    //    a.c_discamt = row.Field<double>("c_discamt");
                    //if (dt.Columns.Contains("c_aftdisc"))
                    //    a.c_aftdisc = row.Field<double>("c_aftdisc");
                    //if (dt.Columns.Contains("c_advamt"))
                    //    a.c_advamt = row.Field<double>("c_advamt");
                    //if (dt.Columns.Contains("c_total"))
                    //    a.c_total = row.Field<double>("c_total");
                    //if (dt.Columns.Contains("c_netamt"))
                    //    a.c_netamt = row.Field<double>("c_netamt");
                    //if (dt.Columns.Contains("c_netval"))
                    //    a.c_netval = row.Field<double>("c_netval");
                    //if (dt.Columns.Contains("c_ivcamt"))
                    //    a.c_ivcamt = row.Field<double>("c_ivcamt");
                    //if (dt.Columns.Contains("c_difamt"))
                    //    a.c_difamt = row.Field<double>("c_difamt");
                    //if (dt.Columns.Contains("c_rcvamt"))
                    //    a.c_rcvamt = row.Field<double>("c_rcvamt");
                    //if (dt.Columns.Contains("c_remamt"))
                    //    a.c_remamt = row.Field<double>("c_remamt");
                    //if (dt.Columns.Contains("link1"))
                    //    a.link1 = row.Field<string>("link1");
                    //if (dt.Columns.Contains("dat1"))
                    //    a.dat1 = !row.IsNull("dat1") ? (DateTime?)row.Field<DateTime>("dat1") : null;
                    //if (dt.Columns.Contains("dat2"))
                    //    a.dat2 = !row.IsNull("dat2") ? (DateTime?)row.Field<DateTime>("dat2") : null;
                    //if (dt.Columns.Contains("num1"))
                    //    a.num1 = row.Field<double>("num1");
                    //if (dt.Columns.Contains("num2"))
                    //    a.num2 = row.Field<double>("num2");
                    //if (dt.Columns.Contains("str1"))
                    //    a.str1 = row.Field<string>("str1");
                    //if (dt.Columns.Contains("str2"))
                    //    a.str2 = row.Field<string>("str2");

                    artrn.Add(a);
                }
                catch (Exception)
                {
                    continue;
                }
            }

            return artrn;
        }

        public static Invoice InVoice(string data_path, string docnum)
        {
            if (!File.Exists(data_path + "artrn.dbf"))
                throw new Exception("ค้นหาไฟล์ artrn.dbf ไม่พบ");
            if (!File.Exists(data_path + "stcrd.dbf"))
                throw new Exception("ค้นหาไฟล์ stcrd.dbf ไม่พบ");
            if (!File.Exists(data_path + "stmas.dbf"))
                throw new Exception("ค้นหาไฟล์ stmas.dbf ไม่พบ");
            if (!File.Exists(data_path + "isacc.dbf"))
                throw new Exception("ค้นหาไฟล์ isacc.dbf ไม่พบ");
            if (!File.Exists(data_path + "artrnrm.dbf"))
                throw new Exception("ค้นหาไฟล์ artrnrm.dbf ไม่พบ");

            Invoice inv = new Invoice();

            using (OleDbConnection conn = new OleDbConnection(@"Provider=VFPOLEDB.1;Data Source=" + data_path))
            {
                conn.Open();
                DataTable dt = new DataTable();

                var cmd = conn.CreateCommand();
                cmd.CommandText = "Select artrn.docnum, artrn.docdat, artrn.cuscod, artrn.slmcod, artrn.sonum, armas.cusnam, armas.addr01, armas.addr02, armas.addr03, armas.zipcod, armas.telnum From artrn Left Join armas On artrn.cuscod = armas.cuscod Where TRIM(docnum)='" + docnum.Trim() + "'";
                using (OleDbDataAdapter da = new OleDbDataAdapter(cmd))
                {
                    dt.Clear();
                    da.Fill(dt);
                    if(dt.Rows.Count == 0)
                    {
                        return null;
                    }

                    inv.artrn = new ArtrnDesc
                    {
                        addr01 = !dt.Rows[0].IsNull("addr01") ? dt.Rows[0]["addr01"].ToString().Trim() : string.Empty,
                        addr02 = !dt.Rows[0].IsNull("addr02") ? dt.Rows[0]["addr02"].ToString().Trim() : string.Empty,
                        addr03 = !dt.Rows[0].IsNull("addr03") ? dt.Rows[0]["addr03"].ToString().Trim() : string.Empty,
                        cuscod = !dt.Rows[0].IsNull("cuscod") ? dt.Rows[0]["cuscod"].ToString().Trim() : string.Empty,
                        cusnam = !dt.Rows[0].IsNull("cusnam") ? dt.Rows[0]["cusnam"].ToString().Trim() : string.Empty,
                        docdat = !dt.Rows[0].IsNull("docdat") ? (DateTime?)dt.Rows[0]["docdat"] : null,
                        docnum = !dt.Rows[0].IsNull("docnum") ? dt.Rows[0]["docnum"].ToString().Trim() : string.Empty,
                        slmcod = !dt.Rows[0].IsNull("slmcod") ? dt.Rows[0]["slmcod"].ToString().Trim() : string.Empty,
                        sonum = !dt.Rows[0].IsNull("sonum") ? dt.Rows[0]["sonum"].ToString().Trim() : string.Empty,
                        telnum = !dt.Rows[0].IsNull("telnum") ? dt.Rows[0]["telnum"].ToString().Trim() : string.Empty,
                        zipcod = !dt.Rows[0].IsNull("zipcod") ? dt.Rows[0]["zipcod"].ToString().Trim() : string.Empty,
                    };

                }

                cmd = conn.CreateCommand();
                cmd.CommandText = "Select stcrd.tqucod, stcrd.disc, stcrd.docnum, stcrd.stkcod, stcrd.stkdes, stcrd.loccod, stcrd.trnqty, stcrd.trnval, stcrd.unitpr, isacc.method From stcrd Left Join stmas On stcrd.stkcod=stmas.stkcod Left Join isacc On stmas.acccod=isacc.acccod Where TRIM(docnum)='" + docnum + "' and isacc.method='X' Order By seqnum";
                using (OleDbDataAdapter da = new OleDbDataAdapter(cmd))
                {
                    dt.Clear();
                    da.Fill(dt);

                    inv.stcrds = new List<StcrdMin>();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        inv.stcrds.Add(new StcrdMin
                        {
                            disc = !dt.Rows[i].IsNull("disc") ? dt.Rows[i]["disc"].ToString() : string.Empty,
                            cost_method = !dt.Rows[i].IsNull("method") ? dt.Rows[i]["method"].ToString() : string.Empty,
                            loccod = !dt.Rows[i].IsNull("loccod") ? dt.Rows[i]["loccod"].ToString().Trim() : string.Empty,
                            stkcod = !dt.Rows[i].IsNull("stkcod") ? dt.Rows[i]["stkcod"].ToString().Trim() : string.Empty,
                            stkdes = !dt.Rows[i].IsNull("stkdes") ? dt.Rows[i]["stkdes"].ToString().Trim() : string.Empty,
                            tqucod = !dt.Rows[i].IsNull("tqucod") ? dt.Rows[i]["tqucod"].ToString().Trim() : string.Empty,
                            trnqty = !dt.Rows[i].IsNull("trnqty") ? (double)dt.Rows[i]["trnqty"] : 0,
                            trnval = !dt.Rows[i].IsNull("trnval") ? (double)dt.Rows[i]["trnval"] : 0,
                            unitpr = !dt.Rows[i].IsNull("unitpr") ? (double)dt.Rows[i]["unitpr"] : 0,
                            warranty_period = string.Empty
                        });
                    }
                }
                

                conn.Close();
            }

            return inv;
        }
    }

    #region Dbf Model

    public class Sccomp
    {
        public string compnam { get; set; }
        public string compcod { get; set; }
        public string path { get; set; }
        public DateTime? gendat { get; set; }
        public string candel { get; set; }
    }

    public class SccompVM
    {
        public Sccomp sccomp { get; set; }
        public string compnam { get; set; }
        public string compcod { get; set; }
        public string path { get; set; }
    }

    public class ArtrnMin
    {
        public DateTime? docdat { get; set; }
        public string docnum { get; set; }
        public string cuscod { get; set; }
        public string cusnam { get; set; }
    }

    public class ArtrnDesc
    {
        public DateTime? docdat { get; set; }
        public string docnum { get; set; }
        public string cuscod { get; set; }
        public string cusnam { get; set; }
        public string sonum { get; set; }
        public string slmcod { get; set; }
        public string addr01 { get; set; }
        public string addr02 { get; set; }
        public string addr03 { get; set; }
        public string zipcod { get; set; }
        public string telnum { get; set; }
    }

    public class StcrdMin
    {
        public string stkcod { get; set; }
        public string stkdes { get; set; }
        public string cost_method { get; set; }
        public string loccod { get; set; }
        public double trnqty { get; set; }
        public string tqucod { get; set; }
        public double unitpr { get; set; }
        public string disc { get; set; }
        public double trnval { get; set; }
        public string warranty_period { get; set; }
    }

    public class Invoice
    {
        public ArtrnDesc artrn { get; set; }
        public List<StcrdMin> stcrds { get; set; }
    }

    public class Artrn
    {
        public string rectyp { get; set; }
        public string docnum { get; set; }
        public DateTime? docdat { get; set; }
        public string postgl { get; set; }
        public string sonum { get; set; }
        public string cntyp { get; set; }
        public string depcod { get; set; }
        public string flgvat { get; set; }
        public string slmcod { get; set; }
        public string cuscod { get; set; }
        public string shipto { get; set; }
        public string youref { get; set; }
        public string areacod { get; set; }
        public decimal paytrm { get; set; }
        public DateTime? duedat { get; set; }
        public string bilnum { get; set; }
        public string nxtseq { get; set; }
        public double amount { get; set; }
        public string disc { get; set; }
        public double discamt { get; set; }
        public double aftdisc { get; set; }
        public string advnum { get; set; }
        public double advamt { get; set; }
        public double total { get; set; }
        public double amtrat0 { get; set; }
        public decimal vatrat { get; set; }
        public double vatamt { get; set; }
        public double netamt { get; set; }
        public double netval { get; set; }
        public double rcvamt { get; set; }
        public double remamt { get; set; }
        public double comamt { get; set; }
        public string cmplapp { get; set; }
        public DateTime? cmpldat { get; set; }
        public string docstat { get; set; }
        public double cshrcv { get; set; }
        public double chqrcv { get; set; }
        public double intrcv { get; set; }
        public double beftax { get; set; }
        public decimal taxrat { get; set; }
        public string taxcond { get; set; }
        public double tax { get; set; }
        public double ivcamt { get; set; }
        public double chqpas { get; set; }
        public DateTime? vatdat { get; set; }
        public DateTime? vatprd { get; set; }
        public string vatlate { get; set; }
        public string srv_vattyp { get; set; }
        public string dlvby { get; set; }
        public DateTime? reserve { get; set; }

        /* V.2 + creby,credat */
        public string creby { get; set; }
        public DateTime? credat { get; set; }
        /**********************/

        public string userid { get; set; }
        public DateTime? chgdat { get; set; }
        public string userprn { get; set; }
        public DateTime? prndat { get; set; }
        public decimal prncnt { get; set; }

        /* only in v.1 */
        public string prntim { get; set; }
        /***************/

        public string authid { get; set; }
        public DateTime? approve { get; set; }

        /* V.2 + ponum */
        public string ponum { get; set; }
        /***************/

        public string billto { get; set; }
        public decimal orgnum { get; set; }

        public string c_type { get; set; }
        public DateTime? c_date { get; set; }
        public string c_ref { get; set; }
        public double c_rate { get; set; }
        public string c_fixrate { get; set; }
        public double c_ratio { get; set; }
        public double c_amount { get; set; }
        public string c_disc { get; set; }
        public double c_discamt { get; set; }
        public double c_aftdisc { get; set; }
        public double c_advamt { get; set; }
        public double c_total { get; set; }
        public double c_netamt { get; set; }
        public double c_netval { get; set; }
        public double c_ivcamt { get; set; }
        public double c_difamt { get; set; }
        public double c_rcvamt { get; set; }
        public double c_remamt { get; set; }
        public string link1 { get; set; }
        public DateTime? dat1 { get; set; }
        public DateTime? dat2 { get; set; }
        public double num1 { get; set; }
        public double num2 { get; set; }
        public string str1 { get; set; }
        public string str2 { get; set; }
    }
    #endregion Dbf Model
}
