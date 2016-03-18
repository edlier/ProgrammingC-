using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MSSQL_CON;
namespace ConnectSAP
{
    public class GlobalAnn
    {
        public static connect_MSSQL connenctTry = new connect_MSSQL();
        public static SQL_String SQL_String = new SQL_String();
    }
}