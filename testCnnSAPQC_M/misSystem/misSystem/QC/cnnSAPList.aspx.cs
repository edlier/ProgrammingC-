using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace misSystem.QC
{
    public partial class cnnSAPList : System.Web.UI.Page
    {
        DataTable dt_qc_SAP = new DataTable();
        DataTable dt_qc_missys = new DataTable();

        protected void Page_Load(object sender, EventArgs e)
        {

            //-------------------------IQC---------------------------
            //搜尋SAP在06倉 待檢驗的資料
            dt_qc_SAP = GlobalAnnounce.SQL_String.search_SAP_QCwaitForValidateList();

            //搜尋 mis system 的資料 (MySQL Local data)
            dt_qc_missys = GlobalAnnounce.QCList.search_mySQL_QCwaitForValidateList();

            //compare two Data between SAP and MySQL
            for (int i = 0; i < dt_qc_missys.Rows.Count; i++)
            {
                //find duplicate data
                string expression;
                expression = " ItemCode LIKE '" + dt_qc_missys.Rows[i]["ItemCode"] 
                    + "' AND DocNum = " + GlobalAnnounce.db.qo(dt_qc_missys.Rows[i]["DocNum"].ToString());

                DataRow[] foundRows;

                // Use the Select method to find all rows matching the filter.
                for (int y = 0; y < dt_qc_SAP.Rows.Count; y++)
                {
                    foundRows = dt_qc_missys.Select(expression);
                    if (foundRows.Length == 0)
                    {
                        DataRow dr;
                        dr = dt_qc_missys.NewRow();

                        dr["DocNum"] = dt_qc_SAP.Rows[i]["DocNum"];
                        dr["ItemCode"] = dt_qc_SAP.Rows[i]["ItemCode"];
                        dr["Qty"] = dt_qc_SAP.Rows[i]["Quantity"];
                        dr["Dscription"] = dt_qc_SAP.Rows[i]["Dscription"];
                        dr["DocDate"] = dt_qc_SAP.Rows[i]["DocDate"];
                        //dr["Processer"] = "";
                        dt_qc_missys.Rows.Add(dr);
                    }
                }
            }



            GridView1.DataSource = dt_qc_missys;
            GridView1.DataBind();
        }
    }
}