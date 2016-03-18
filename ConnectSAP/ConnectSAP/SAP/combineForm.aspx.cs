using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace ConnectSAP.SAP
{
    public partial class combineForm : System.Web.UI.Page
    {
        DataTable List = new DataTable();
        DataTable QCList = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            List = GlobalAnn.SQL_String.search_P1Data();
            QCList = GlobalAnn.SQL_String.search_QCvalidateQty();

            DataColumn column;
            column = new DataColumn();
            column.ColumnName = "QCqty";
            List.Columns.Add(column);

            for (int i = 0; i < QCList.Rows.Count; i++)
            {
                string expression;
                expression = " ItemCode LIKE '" + QCList.Rows[i]["ItemCode"]+"'";

                DataRow[] foundRows;

                // Use the Select method to find all rows matching the filter.
                foundRows = List.Select(expression);
                if (foundRows.Length == 0)
                {
                    DataRow dr;
                    dr = List.NewRow();
                    int qtyFormat = Convert.ToInt32(QCList.Rows[i]["Quantity"]);

                    dr["ItemCode"] = QCList.Rows[i]["ItemCode"];                    
                    dr["WH01"] = "0";
                    
                    dr["QCqty"] = qtyFormat;
                    List.Rows.Add(dr);
                }
                else
                {
                    int qtyFormat = Convert.ToInt32(QCList.Rows[i]["Quantity"]);
                    for (int y = 0; y < List.Rows.Count; y++)
                    {
                        if (List.Rows[y]["ItemCode"].ToString() == QCList.Rows[i]["ItemCode"].ToString())
                        {
                            List.Rows[y]["QCqty"] = qtyFormat;

                            break;
                        }
                    }
                }
            }

            Grid_test.DataSource = QCList;
            Grid_test.DataBind();

            List.DefaultView.Sort = "ItemCode asc";
            GridView1.DataSource = List;
            GridView1.DataBind();

            
            
        }


    }
}