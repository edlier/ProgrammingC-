using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace MSSQL_CON
{
    public class SQL_String
    {
        public static connect_MSSQL connenctTry = new connect_MSSQL();

        public DataTable search_P1Data()
        {
            DataTable dt = new DataTable();

            string sqlstr = "";
            sqlstr += " Select T1.ItemCode,A.WH01,SUM(T1.PlannedQty)-SUM(T1.IssuedQty) as 'TotalNeed',B.WH03,C.WH04,F.WH16";

            sqlstr += " From WOR1 T1 ";

            sqlstr += " Outer Apply (";
            sqlstr += " Select SUM(TW.OnHand) as WH01 From OITW TW Where TW.WhsCode in ('01') and TW.ItemCode = T1.ItemCode ";
            sqlstr += " ) A";           
            sqlstr += " Outer Apply (";
            sqlstr += " Select SUM(TW.OnHand) as WH03 From OITW TW Where TW.WhsCode in ('03') and TW.ItemCode = T1.ItemCode";
            sqlstr += " ) B ";
            sqlstr += " Outer Apply (";
            sqlstr += " Select SUM(TW.OnHand) as WH04 From OITW TW Where TW.WhsCode in ('04') and TW.ItemCode = T1.ItemCode";
            sqlstr += " ) C";
            sqlstr += " Outer Apply (";
            sqlstr += " Select SUM(TW.OnHand) as WH16 From OITW TW Where TW.WhsCode in ('16') and TW.ItemCode = T1.ItemCode";
            sqlstr += " ) F  ";

            sqlstr += " Inner Join OWOR T0 On T0.DocEntry = T1.DocEntry";
            sqlstr += " Inner Join OITW TW On TW.ItemCode = T1.ItemCode and TW.WhsCode = T1.wareHouse";
            sqlstr += " Inner Join OITM TM On T1.ItemCode = TM.ItemCode ";

            sqlstr += " Where T0.Status not in  ('C','L')";
            //sqlstr += " --and (T0.PostDate  <= '20140506' or '' = '20140506')";
            sqlstr += " Group By T1.ItemCode,A.WH01,B.WH03,C.WH04,F.WH16";
            sqlstr += " Having SUM(T1.PlannedQty)-SUM(T1.IssuedQty)-(Select SUM(TW.OnHand) From OITW TW Where TW.ItemCode = T1.ItemCode and TW.WhsCode in ('01','03','04','07','11','16')) > 0";

            sqlstr += " Order By";
            sqlstr += " T1.ItemCode";


            //sqlstr += "";
            dt = connenctTry.GetDataTable(sqlstr);
            return dt;
        }

        public DataTable search_QCvalidateQty()
        {
            DataTable dt = new DataTable();
            string sqlstr = "";
            sqlstr += " Select ";
            sqlstr += " DRF1.DocEntry,";
            sqlstr += " DRF1.ItemCode,";
            sqlstr += " DRF1.Quantity";
            sqlstr += " From ODRF";
            sqlstr += " Inner Join DRF1 On ODRF.DocEntry= DRF1.DocEntry ";
            sqlstr += " Where  ODRF.DocStatus = 'O'";
            sqlstr += " and  DRF1.LinManClsd <> 'Y'";
            sqlstr += " and  ODRF.U_GPONtfPr = '倉管'";
            sqlstr += " and  ODRF.ObjType = '20'";

            dt = connenctTry.GetDataTable(sqlstr);
            return dt;
        }

        public DataTable search_QCvalidateQty2()
        {
            DataTable dt = new DataTable();
            string sqlstr = "";
            sqlstr += " Select ";
            sqlstr += " DRF1.DocEntry,";
            sqlstr += " DRF1.ItemCode,";
            sqlstr += " DRF1.Quantity";
            sqlstr += " From ODRF";
            sqlstr += " Inner Join DRF1 On ODRF.DocEntry= DRF1.DocEntry ";
            sqlstr += " Where  ODRF.DocStatus = 'O'";
            sqlstr += " and  DRF1.LinManClsd <> 'Y'";
            sqlstr += " and  ODRF.U_GPONtfPr = '品保'";
            sqlstr += " and  ODRF.ObjType = '20'";

            dt = connenctTry.GetDataTable(sqlstr);
            return dt;
        }
        //P3
        public DataTable search_stockList()
        {
            DataTable dt = new DataTable();
            string sqlstr = "";
            sqlstr += " Select ItemCode,MinOrdrQty,LeadTime,MinLevel";
            sqlstr += " From OITM";
            sqlstr += " where MinLevel>0";
            dt = connenctTry.GetDataTable(sqlstr);
            return dt;
        }
        
    }
}
