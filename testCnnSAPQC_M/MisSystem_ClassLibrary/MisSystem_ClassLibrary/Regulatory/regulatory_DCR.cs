using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace MisSystem_ClassLibrary
{
    public class regulatory_DCR
    {
        public DataTable priorityOption()
        {
            DataTable dt;
            string sqlstr = "";
            sqlstr = "select code,description from priority ";
            dt = publicNewClass.mydb.GetDataTable(sqlstr);
            return dt;
        }
        public DataTable reasonForChangeNumber()
        {
            DataTable dt;
            string sqlstr = "";
            sqlstr = "select No ,CONCAT_WS('  ,  ',No,Description) as NoDescription from dcrReasonForChange ";
            dt = publicNewClass.mydb.GetDataTable(sqlstr);
            return dt;
        }
        public void insert_DCR_form_changeDocDetail(string docNum, int newVersion, string docName, int changerReason,string changeReasonText)
        {

            string sqlstr = "";
            //sqlstr = "insert into useraccount(name,email,pwd,country) values('" + name + "','" + email + "','" + password + "','" + country + "')";
            publicNewClass.mydb.InsertDataTable(sqlstr);

        }



        public int returnWaitingApprovalRecordCount(int accountID)
        {
            int x=0;

            return x;
        }
    }
}
