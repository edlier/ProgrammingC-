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
            sqlstr += " Select * from qc_savesapdata where status=1";

            dt = publicNewClass.mydb.GetDataTable(sqlstr);
            return dt;
        }




        #region insert
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
            aa = " Insert into qc_savesapdata(DocNum,DocEntry,ItemCode,CardCode,CardName,BaseLine,Qty,Dscription,DocDate,Operator,Start_Time,status)"
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

                + publicNewClass.mydb.qo(Start_Time) + ",    '1'           )";
            

            publicNewClass.mydb.InsertDataTable(aa);
        }
        #endregion
    }
}
