using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace MisSystem_ClassLibrary
{
    public class id
    {
        public string getName(int userID)
        {
            DataTable dt;
            string sqlstr = "";
            sqlstr = "select name from useraccount ";
            sqlstr += " where id="+publicNewClass.mydb.qo(userID.ToString());
            dt = publicNewClass.mydb.GetDataTable(sqlstr);

            return (dt.Rows[0]["name"]).ToString();
            
        }

    }
}
