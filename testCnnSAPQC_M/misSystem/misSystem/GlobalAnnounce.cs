using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MisSystem_ClassLibrary;
using MSSQL_CON;
namespace misSystem
{
    public class GlobalAnnounce
    {
        //資料庫連線 
        //public static dbLibrary.db mydb = new dbLibrary.db();

        public static loginDB logindb = new loginDB();
        public static regulatory_DCR regulatory_DCR = new regulatory_DCR();
        public static machine machine = new machine();
        public static id id = new id();
        public static User user = new User();
        public static Manager manager = new Manager();
        public static db db = new db();
        public static QCList QCList = new QCList(); 

        public static validateSession validateSession = new validateSession();
        public static SQL_String SQL_String = new SQL_String();
    }
}