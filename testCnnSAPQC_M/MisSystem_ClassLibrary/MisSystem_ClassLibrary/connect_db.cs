using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using MySql.Data.MySqlClient;
namespace MisSystem_ClassLibrary
{
    public class db
    {
        // 如果有特殊的編碼在database後面請加上;CharSet=編碼, utf8請使用utf8_general_ci
        string cn = "server=localhost;user id=root;Password=root;persist security info=True;database=missystem;CharSet=utf8;Allow Zero Datetime=True";
        MySqlConnection conn = new MySqlConnection("server=localhost;user id=root;Password=root;persist security info=True;database=missystem;CharSet=utf8;Allow Zero Datetime=True");
        
        //insert update  delete
        public void InsertDataTable(string sqlstr)
        {

            MySqlDataAdapter da = new MySqlDataAdapter();
            MySqlCommand cmd = new MySqlCommand();
            cmd = new MySqlCommand(sqlstr, conn);
            conn.Open();
            da.InsertCommand = cmd;
            da.InsertCommand.ExecuteNonQuery();
            conn.Close();
        }
        public DataTable GetDataTable(string sqlstr)
        {
            
            MySqlDataAdapter da = new MySqlDataAdapter(sqlstr, cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return (dt);
        }
        public string qo(string instr)
        {

            return "'" + instr + "'";
        }

        public string getSingleData(int item_no, string sqlstr)
        {
            string temp = "";
            MySqlCommand cmd = new MySqlCommand();
            cmd = new MySqlCommand(sqlstr, conn);
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                temp = reader[item_no].ToString();
            }
            conn.Close();
            return temp;
        }

    }
}
