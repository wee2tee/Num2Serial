using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;

namespace Warranty.Helper
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

        public static List<ArtrnMin> InvoiceList(string data_path, TransactionStatus.STATUS status = TransactionStatus.STATUS.WARRANTY, INVOICE_TYPE invoice_type = INVOICE_TYPE.IV)
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
                switch (status)
                {
                    case TransactionStatus.STATUS.ALL:
                        cmd.CommandText = "Select artrn.docnum, artrn.docdat, artrn.cuscod, artrn.num2, armas.cusnam From artrn ";
                        cmd.CommandText += "Left Join armas On artrn.cuscod = armas.cuscod ";
                        cmd.CommandText += "Where artrn.docnum In ";
                        cmd.CommandText += "(Select stcrd.docnum From stcrd Left Join stmas On stcrd.stkcod=stmas.stkcod Left Join isacc On stmas.acccod=isacc.acccod Where isacc.method='X') ";
                        cmd.CommandText += "And rectyp='" + ((int)invoice_type).ToString() + "'";
                        cmd.CommandText += "Order By docdat,docnum ASC";
                        break;
                    case TransactionStatus.STATUS.WARRANTY:
                        cmd.CommandText = "Select artrn.docnum, artrn.docdat, artrn.cuscod, artrn.num2, armas.cusnam From artrn ";
                        cmd.CommandText += "Left Join armas On artrn.cuscod = armas.cuscod ";
                        cmd.CommandText += "Where artrn.docnum In ";
                        cmd.CommandText += "(Select stcrd.docnum From stcrd Left Join stmas On stcrd.stkcod=stmas.stkcod Left Join isacc On stmas.acccod=isacc.acccod Where isacc.method='X') ";
                        cmd.CommandText += "And rectyp='" + ((int)invoice_type).ToString() + "' And num2=0 ";
                        cmd.CommandText += "Order By docdat,docnum ASC";
                        break;
                    case TransactionStatus.STATUS.WARRANTED:
                        cmd.CommandText = "Select artrn.docnum, artrn.docdat, artrn.cuscod, artrn.num2, armas.cusnam From artrn ";
                        cmd.CommandText += "Left Join armas On artrn.cuscod = armas.cuscod ";
                        cmd.CommandText += "Where artrn.docnum In ";
                        cmd.CommandText += "(Select stcrd.docnum From stcrd Left Join stmas On stcrd.stkcod=stmas.stkcod Left Join isacc On stmas.acccod=isacc.acccod Where isacc.method='X') ";
                        cmd.CommandText += "And rectyp='" + ((int)invoice_type).ToString() + "' And num2>0 ";
                        cmd.CommandText += "Order By docdat,docnum ASC";
                        break;
                    default:
                        cmd.CommandText = "Select artrn.docnum, artrn.docdat, artrn.cuscod, artrn.num2, armas.cusnam From artrn ";
                        cmd.CommandText += "Left Join armas On artrn.cuscod = armas.cuscod ";
                        cmd.CommandText += "Where artrn.docnum In ";
                        cmd.CommandText += "(Select stcrd.docnum From stcrd Left Join stmas On stcrd.stkcod=stmas.stkcod Left Join isacc On stmas.acccod=isacc.acccod Where isacc.method='X') ";
                        cmd.CommandText += "And rectyp='" + ((int)invoice_type).ToString() + "'";
                        cmd.CommandText += "Order By docdat,docnum ASC";
                        break;
                }
                //if (status == TransactionStatus.STATUS.WARRANTY)
                //{
                //    cmd.CommandText = "Select artrn.docnum, artrn.docdat, artrn.cuscod, artrn.num2, armas.cusnam From artrn ";
                //    cmd.CommandText += "Left Join armas On artrn.cuscod = armas.cuscod ";
                //    cmd.CommandText += "Where artrn.docnum In ";
                //    cmd.CommandText += "(Select stcrd.docnum From stcrd Left Join stmas On stcrd.stkcod=stmas.stkcod Left Join isacc On stmas.acccod=isacc.acccod Where isacc.method='X') ";
                //    cmd.CommandText += "And rectyp='" + ((int)invoice_type).ToString() + "' And num2=0 ";
                //    cmd.CommandText += "Order By docdat,docnum ASC";
                //}
                //else
                //{
                //    cmd.CommandText = "Select artrn.docnum, artrn.docdat, artrn.cuscod, artrn.num2, armas.cusnam From artrn ";
                //    cmd.CommandText += "Left Join armas On artrn.cuscod = armas.cuscod ";
                //    cmd.CommandText += "Where artrn.docnum In ";
                //    cmd.CommandText += "(Select stcrd.docnum From stcrd Left Join stmas On stcrd.stkcod=stmas.stkcod Left Join isacc On stmas.acccod=isacc.acccod Where isacc.method='X') ";
                //    cmd.CommandText += "And rectyp='" + ((int)invoice_type).ToString() + "' ";
                //    cmd.CommandText += "Order By docdat,docnum ASC";
                //}


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
                        docdat = !row.IsNull("docdat") ? (DateTime?)row["docdat"] : null,
                        warranty_spec = !row.IsNull("num2") ? ((double)row["num2"] > 0 ? "Y" : "") : ""
                    };

                    artrn.Add(a);
                }
                catch (Exception)
                {
                    continue;
                }
            }

            return artrn;
        }

        //public static List<ArtrnMin> InvoiceList(string data_path, bool warranty_iv = true, bool warranted_iv = false, INVOICE_TYPE invoice_type = INVOICE_TYPE.IV)
        //{
        //    if (!File.Exists(data_path + "artrn.dbf"))
        //        throw new Exception("ค้นหาไฟล์ artrn.dbf ไม่พบ");
        //    if (!File.Exists(data_path + "stcrd.dbf"))
        //        throw new Exception("ค้นหาไฟล์ stcrd.dbf ไม่พบ");
        //    if (!File.Exists(data_path + "stmas.dbf"))
        //        throw new Exception("ค้นหาไฟล์ stmas.dbf ไม่พบ");
        //    if (!File.Exists(data_path + "isacc.dbf"))
        //        throw new Exception("ค้นหาไฟล์ isacc.dbf ไม่พบ");
        //    if (!File.Exists(data_path + "artrnrm.dbf"))
        //        throw new Exception("ค้นหาไฟล์ artrnrm.dbf ไม่พบ");

        //    DataTable dt = new DataTable();
        //    using (OleDbConnection conn = new OleDbConnection(@"Provider=VFPOLEDB.1;Data Source=" + data_path))
        //    {
        //        conn.Open();
        //        var cmd = conn.CreateCommand();
        //        if (warranty_iv)
        //        {
        //            cmd.CommandText = "Select artrn.docnum, artrn.docdat, artrn.cuscod, artrn.num2, armas.cusnam From artrn ";
        //            cmd.CommandText += "Left Join armas On artrn.cuscod = armas.cuscod ";
        //            cmd.CommandText += "Where artrn.docnum In ";
        //            cmd.CommandText += "(Select stcrd.docnum From stcrd Left Join stmas On stcrd.stkcod=stmas.stkcod Left Join isacc On stmas.acccod=isacc.acccod Where isacc.method='X') ";
        //            cmd.CommandText += "And rectyp='" + ((int)invoice_type).ToString() + "' And num2=0 ";
        //            cmd.CommandText += "Order By docdat,docnum ASC";
        //        }
        //        else
        //        {
        //            cmd.CommandText = "Select artrn.docnum, artrn.docdat, artrn.cuscod, artrn.num2, armas.cusnam From artrn ";
        //            cmd.CommandText += "Left Join armas On artrn.cuscod = armas.cuscod ";
        //            cmd.CommandText += "Where artrn.docnum In ";
        //            cmd.CommandText += "(Select stcrd.docnum From stcrd Left Join stmas On stcrd.stkcod=stmas.stkcod Left Join isacc On stmas.acccod=isacc.acccod Where isacc.method='X') ";
        //            cmd.CommandText += "And rectyp='" + ((int)invoice_type).ToString() + "' ";
        //            cmd.CommandText += "Order By docdat,docnum ASC";
        //        }


        //        OleDbDataAdapter da = new OleDbDataAdapter(cmd);
        //        da.Fill(dt);
        //        conn.Close();
        //    }

        //    List<ArtrnMin> artrn = new List<ArtrnMin>();
        //    foreach (DataRow row in dt.Rows)
        //    {
        //        try
        //        {
        //            ArtrnMin a = new ArtrnMin
        //            {
        //                cuscod = !row.IsNull("cuscod") ? row["cuscod"].ToString().Trim() : string.Empty,
        //                cusnam = !row.IsNull("cusnam") ? row["cusnam"].ToString().Trim() : string.Empty,
        //                docnum = !row.IsNull("docnum") ? row["docnum"].ToString().Trim() : string.Empty,
        //                docdat = !row.IsNull("docdat") ? (DateTime?)row["docdat"] : null,
        //                warranty_spec = !row.IsNull("num2") ? ((double)row["num2"] > 0 ? "Y" : "") : ""
        //            };

        //            artrn.Add(a);
        //        }
        //        catch (Exception)
        //        {
        //            continue;
        //        }
        //    }

        //    return artrn;
        //}

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
                cmd.CommandText = "Select artrn.docnum, artrn.docdat, artrn.cuscod, artrn.slmcod, artrn.sonum, artrn.num2, armas.cusnam, armas.addr01, armas.addr02, armas.addr03, armas.zipcod, armas.telnum From artrn Left Join armas On artrn.cuscod = armas.cuscod Where TRIM(docnum)='" + docnum.Trim() + "'";
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
                        num2 = !dt.Rows[0].IsNull("num2") ? (double)dt.Rows[0]["num2"] : 0
                    };

                }

                cmd = conn.CreateCommand();
                cmd.CommandText = "Select stcrd.tqucod, stcrd.disc, stcrd.docnum, stcrd.seqnum, stcrd.stkcod, stcrd.stkdes, stcrd.loccod, stcrd.trnqty, stcrd.trnval, stcrd.unitpr, stmas.warmonth, isacc.method, x.rem_remark as rem_remark From stcrd ";
                cmd.CommandText += "Left Join stmas On stcrd.stkcod=stmas.stkcod ";
                cmd.CommandText += "Left Join isacc On stmas.acccod=isacc.acccod ";
                cmd.CommandText += "Left Join (Select artrnrm.docnum as rem_docnum, artrnrm.seqnum as rem_seqnum, artrnrm.remark as rem_remark From artrnrm Where artrnrm.docnum='" + docnum + "' AND SUBSTR(artrnrm.seqnum,1,1)!='@' AND LOWER(artrnrm.remark) LIKE 'warranty.%') AS x On x.rem_docnum=stcrd.docnum AND SUBSTR(x.rem_seqnum,1,3)=stcrd.seqnum ";
                cmd.CommandText += "Where TRIM(stcrd.docnum)='" + docnum + "' and isacc.method='X' Order By stcrd.seqnum";
                using (OleDbDataAdapter da = new OleDbDataAdapter(cmd))
                {
                    dt.Clear();
                    da.Fill(dt);

                    inv.stcrds = new List<StcrdMinVM>();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        var st = new StcrdMin
                        {
                            disc = !dt.Rows[i].IsNull("disc") ? dt.Rows[i]["disc"].ToString() : string.Empty,
                            docnum = !dt.Rows[i].IsNull("docnum") ? dt.Rows[i]["docnum"].ToString().Trim() : string.Empty,
                            cost_method = !dt.Rows[i].IsNull("method") ? dt.Rows[i]["method"].ToString() : string.Empty,
                            loccod = !dt.Rows[i].IsNull("loccod") ? dt.Rows[i]["loccod"].ToString().Trim() : string.Empty,
                            seqnum = !dt.Rows[i].IsNull("seqnum") ? dt.Rows[i]["seqnum"].ToString() : string.Empty,
                            stkcod = !dt.Rows[i].IsNull("stkcod") ? dt.Rows[i]["stkcod"].ToString().Trim() : string.Empty,
                            stkdes = !dt.Rows[i].IsNull("stkdes") ? dt.Rows[i]["stkdes"].ToString().Trim() : string.Empty,
                            tqucod = !dt.Rows[i].IsNull("tqucod") ? dt.Rows[i]["tqucod"].ToString().Trim() : string.Empty,
                            trnqty = !dt.Rows[i].IsNull("trnqty") ? (double)dt.Rows[i]["trnqty"] : 0,
                            trnval = !dt.Rows[i].IsNull("trnval") ? (double)dt.Rows[i]["trnval"] : 0,
                            unitpr = !dt.Rows[i].IsNull("unitpr") ? (double)dt.Rows[i]["unitpr"] : 0,
                            warranty_default = !dt.Rows[i].IsNull("warmonth") ? (dt.Rows[i]["warmonth"].ToString().Trim().Length > 0 ? Convert.ToInt32(dt.Rows[i]["warmonth"].ToString().Trim()) : 0) : 0,
                            warranty_remark = !dt.Rows[i].IsNull("rem_remark") && dt.Rows[i]["rem_remark"].ToString().ToLower().StartsWith("warranty.") ? dt.Rows[i]["rem_remark"].ToString().ToLower().TrimStart(("warranty.").ToCharArray()).Trim() : string.Empty,
                            warranty_period = 0
                        };

                        int period = 0;
                        Int32.TryParse(st.warranty_remark, out period);

                        st.warranty_period = period == 0 ? st.warranty_default : period;
                        st.warranty_type = period == 0 ? WarrantyType.TYPE.DEFAULT : WarrantyType.TYPE.SPECIFY;

                        inv.stcrds.Add(st.ToViewModel());
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
        public string warranty_spec { get; set; }
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
        public double num2 { get; set; }
    }

    public class StcrdMin
    {
        public string docnum { get; set; }
        public string seqnum { get; set; }
        public string stkcod { get; set; }
        public string stkdes { get; set; }
        public WarrantyType.TYPE warranty_type { get; set; }
        public string warranty_remark { get; set; }
        public int warranty_period { get; set; }
        public int warranty_default { get; set; }
        public string cost_method { get; set; }
        public string loccod { get; set; }
        public double trnqty { get; set; }
        public string tqucod { get; set; }
        public double unitpr { get; set; }
        public string disc { get; set; }
        public double trnval { get; set; }

    }

    public class StcrdMinVM
    {
        public StcrdMin stcrdmin { get; set; }
        public string seqnum { get { return this.stcrdmin.seqnum; } }
        public string stkcod { get { return this.stcrdmin.stkcod; } }
        public string stkdes { get { return this.stcrdmin.stkdes; } }
        public string warranty_type { get; set; }
        public int warranty_period { get { return this.stcrdmin.warranty_period; } }
        public double trnqty { get { return this.stcrdmin.trnqty; } }
        public string tqucod { get { return this.stcrdmin.tqucod; } }
    }

    public class Invoice
    {
        public ArtrnDesc artrn { get; set; }
        public List<StcrdMinVM> stcrds { get; set; }
    }

    public class Stlotsn
    {
        public string stkcod { get; set; }
        public string docnum { get; set; }
        public string seqnum { get; set; }
        public string serial { get; set; }
        public string cutnum { get; set; }

    }

    public class Issn
    {
        public string stkcod { get; set; }
        public string serial { get; set; }
        public string warmonth { get; set; }
        public DateTime? sal_date { get; set; }
        public DateTime? war_date { get; set; }
        public DateTime? exp_date { get; set; }
    }

    public class Artrnrm
    {
        public string docnum { get; set; }
        public string seqnum { get; set; }
        public string remark { get; set; }
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
