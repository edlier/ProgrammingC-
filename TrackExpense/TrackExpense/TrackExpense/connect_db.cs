using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using MySql.Data.MySqlClient;

namespace TrackExpense
{
    public class db
    {
        //missystem
        //lightmedbpm
        //test_qc_fq_20170524

        // 如果有特殊的編碼在database後面請加上;CharSet=編碼, utf8請使用utf8_general_ci
        //string cn = "server=192.168.168.184;port=3306;user id=bonnie;Password=Bonnie01612;persist security info=True;database=lightmedbpm;CharSet=utf8";
        //MySqlConnection conn = new MySqlConnection("server=192.168.168.184;port=3306;user id=bonnie;Password=Bonnie01612;persist security info=True;database=lightmedbpm;CharSet=utf8");
        string cn = "server=localhost;user id=root;Password='';persist security info=True;database=trackexpense;CharSet=utf8";
        MySqlConnection conn = new MySqlConnection("server=localhost;user id=root;Password=;persist security info=True;database=trackexpense;CharSet=utf8");

        //insert update  delete
        public void InsertDataTable(string sqlstr)
        {

            MySqlDataAdapter da = new MySqlDataAdapter();
            MySqlCommand cmd = new MySqlCommand();
            cmd = new MySqlCommand(sqlstr, conn);
            try { 
            conn.Open();
            da.InsertCommand = cmd;
            da.InsertCommand.ExecuteNonQuery();
            conn.Close();
            }
            catch
            {
                conn.Close();
            }
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

        public int getID(string table)
        {
            //get the lastest id
            string sqlstr = "";
            sqlstr = string.Format("select LAST_INSERT_ID() from {0}", table);
            int ID = Convert.ToInt32(getSingleData(0, sqlstr));
            return ID;
        }
    }
}
