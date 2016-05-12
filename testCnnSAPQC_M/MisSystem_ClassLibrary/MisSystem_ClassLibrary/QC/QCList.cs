using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace MisSystem_ClassLibrary
{
    public class QCList
    {
        public DataTable search_mySQL_QCwaitForValidateList()
        {
            DataTable dt = new DataTable();
            string sqlstr = "";
            sqlstr += " Select * from qc_savesapdata where status=1 OR status=2";

            dt = publicNewClass.mydb.GetDataTable(sqlstr);
            return dt;
        }
        //public DataTable search_QCFailedReason()
        //{
        //    DataTable dt = new DataTable();
        //    string sqlstr = "";
        //    sqlstr += " Select id,+ "
        //        + "CONCAT_WS(',',  id , description ) as idDes from qc_failedreason";

        //    dt = publicNewClass.mydb.GetDataTable(sqlstr);
        //    return dt;
        //}


        public DataTable search_QCFailedType()
        {
            DataTable dt = new DataTable();
            string sqlstr = "";
            sqlstr += " Select id,+ "
                + "CONCAT_WS(',',  id , description ) as idDes from qc_failedType";

            dt = publicNewClass.mydb.GetDataTable(sqlstr);
            return dt;
        }

        public DataTable search_QCFReasonList()
        {
            DataTable dt = new DataTable();
            string sqlstr = "";
            sqlstr += " Select id, TypeID, "
                + " CONCAT_WS(',',  id , description ) as idDes from qc_failedreason";

            dt = publicNewClass.mydb.GetDataTable(sqlstr);
            return dt;
        }


        public DataTable search_mySQL_QCValidateItem(string DocNum, string ItemCode, string BaseLine)
        {
            DataTable dt = new DataTable();
            string sqlstr = "";
            sqlstr += " Select id from qc_savesapdata where DocNum=" + publicNewClass.mydb.qo(DocNum) +
                " AND  ItemCode = " + publicNewClass.mydb.qo(ItemCode) +
                " AND  BaseLine = " + publicNewClass.mydb.qo(BaseLine);

            dt = publicNewClass.mydb.GetDataTable(sqlstr);
            return dt;
        }
        public DataTable search_mySQL_QCwaitForValidateItem(string DocNum, string ItemCode, string BaseLine)
        {
            DataTable dt = new DataTable();
            string sqlstr = "";
            sqlstr += " Select * from qc_savesapdata where DocNum=" + publicNewClass.mydb.qo(DocNum) +
                " AND  ItemCode = " + publicNewClass.mydb.qo(ItemCode) +
                " AND  BaseLine = " + publicNewClass.mydb.qo(BaseLine);

            dt = publicNewClass.mydb.GetDataTable(sqlstr);
            return dt;
        }
        


        //  Insert QC data from SAP to MySQL
        #region insertQCd_FSAP_TMy
        public void insertQCd_FSAP_TMy(
            string DocNum,
            string DocEntry,
            string ItemCode,
            string CardCode,
            string CardName,

            string BaseLine,
            string Qty,
            string Dscription,
            string DocDate,
            string Operator,

            string Start_Time)
        {
            string aa;
            aa = " Insert into qc_savesapdata(DocNum,DocEntry,ItemCode,CardCode,CardName,BaseLine,Qty,Dscription,DocDate,Operator,Start_Time,status,QType)"
                + " values ("
                + publicNewClass.mydb.qo(DocNum) + ","
                + publicNewClass.mydb.qo(DocEntry) + ","
                + publicNewClass.mydb.qo(ItemCode) + ","
                + publicNewClass.mydb.qo(CardCode) + ","
                + publicNewClass.mydb.qo(CardName) + ","

                + publicNewClass.mydb.qo(BaseLine) + ","
                + publicNewClass.mydb.qo(Qty) + ","
                + publicNewClass.mydb.qo(Dscription) + ","
                + publicNewClass.mydb.qo(DocDate) + ","
                + publicNewClass.mydb.qo(Operator) + ","

                + publicNewClass.mydb.qo(Start_Time) + ",    '1' ,  '1'   )";
            

            publicNewClass.mydb.InsertDataTable(aa);
        }
        #endregion
        #region insertQCd_FSAP_TMy2
        public DataTable insertQCd_FSAP_TMy2(
            string DocNum,
            string DocEntry,
            string ItemCode,
            string CardCode,
            string CardName,

            string BaseLine,
            string Qty,
            string Dscription,
            string DocDate,
            string Operator,

            string Start_Time)
        {
            string aa;
            aa = " Insert into qc_savesapdata(DocNum,DocEntry,ItemCode,CardCode,CardName,BaseLine,Qty,Dscription,DocDate,Operator,Start_Time,status,QType)"
                + " values ("
                + publicNewClass.mydb.qo(DocNum) + ","
                + publicNewClass.mydb.qo(DocEntry) + ","
                + publicNewClass.mydb.qo(ItemCode) + ","
                + publicNewClass.mydb.qo(CardCode) + ","
                + publicNewClass.mydb.qo(CardName) + ","

                + publicNewClass.mydb.qo(BaseLine) + ","
                + publicNewClass.mydb.qo(Qty) + ","
                + publicNewClass.mydb.qo(Dscription) + ","
                + publicNewClass.mydb.qo(DocDate) + ","
                + publicNewClass.mydb.qo(Operator) + ","

                + publicNewClass.mydb.qo(Start_Time) + ",    '1' ,  '1'   ); "

                + " SELECT LAST_INSERT_ID() AS outID;  ";

            DataTable dt;
            dt = publicNewClass.mydb.GetDataTable(aa);
            return dt;
        }
        #endregion

        #region update_ValidatedData
        public void update_ValidatedData(
            string endTime, 
            string FQTY, 
            string TQty, 
            string IssueID, 
            string fqc_passed,
            string status)
        {
            string aa;
            aa = " update qc_savesapdata set"+
                " End_Time =" + publicNewClass.mydb.qo(endTime) +
                " FQty =" + publicNewClass.mydb.qo(FQTY) +
                " TQty =" + publicNewClass.mydb.qo(TQty) +
                " Issue_Detail =" + publicNewClass.mydb.qo(IssueID) +
                " fqc_passed =" + publicNewClass.mydb.qo(fqc_passed) +
                " status =" + publicNewClass.mydb.qo(status);
            
            publicNewClass.mydb.InsertDataTable(aa);
        }
        #endregion

        public void update_saveForFinishedValidated(string TQty, string FQty, string Process_HR, string Process_MIN, string End_Time, string status, string ID)
        {
            string aa;
            aa = " update qc_savesapdata set "
                + " TQty = " + publicNewClass.mydb.qo(TQty) + ","
                + " FQty = " + publicNewClass.mydb.qo(FQty) + ","
                //+ " Issue_ID = " + publicNewClass.mydb.qo(Issue_ID) + ","
                + " ProcessT_HR = " + publicNewClass.mydb.qo(Process_HR) + ","
                + " ProcessT_MIN = " + publicNewClass.mydb.qo(Process_MIN) + ","
                + " End_Time = " + publicNewClass.mydb.qo(End_Time) + ","
                + " status = " + publicNewClass.mydb.qo(status)
                + "  where id=" +publicNewClass.mydb.qo(ID);
            //where
            publicNewClass.mydb.InsertDataTable(aa);
        }
        public void update_FailedReasonNDQty(string itemID, string[,] failedID)
        {
            string aa = "";
            for (int i = 0; i < 5; i++)
            {
                if (failedID[i, 1] != "0" && failedID[i, 1] != null && failedID[i, 1] != "" && failedID[i, 0] != "" && failedID[i, 0] != null)
                {
                    aa += "  Insert into qc_iqcfdetail(ValidatedID,Qty,FailedID) "
                    + " values("
                    + publicNewClass.mydb.qo(itemID) + ","
                    + publicNewClass.mydb.qo(failedID[i, 1]) + ","
                    + publicNewClass.mydb.qo(failedID[i, 0])
                    + ") ;";
                }
            }
            //where
            publicNewClass.mydb.InsertDataTable(aa);
        }
    }
}
