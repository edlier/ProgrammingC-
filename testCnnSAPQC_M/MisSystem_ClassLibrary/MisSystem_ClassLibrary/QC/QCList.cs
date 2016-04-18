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
            sqlstr += " Select * from qc_savesapdata";

            dt = publicNewClass.mydb.GetDataTable(sqlstr);
            return dt;
        }
    }
}
