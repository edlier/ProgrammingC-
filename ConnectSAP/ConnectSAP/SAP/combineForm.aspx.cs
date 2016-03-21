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
        DataTable stockList = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            List = GlobalAnn.SQL_String.search_P1Data();
            QCList = GlobalAnn.SQL_String.search_QCvalidateQty();
            stockList = GlobalAnn.SQL_String.search_stockList();

            DataColumn column;
            column = new DataColumn();
            List.Columns.Add("QCqty");
            List.Columns.Add("MinOrdrQty");
            List.Columns.Add("LeadTime");
            List.Columns.Add("MinLevel");


            for (int i = 0; i < QCList.Rows.Count; i++)
            {
                string expression;
                expression = " ItemCode LIKE '" + QCList.Rows[i]["ItemCode"]+"'";

                DataRow[] foundRows;

                // Use the Select method to find all rows matching the filter.
                foundRows = List.Select(expression);

                //搜尋若QC有的ITEMCODE 在List沒有就新增
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
                //若有就在欄位更新數量
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

            //Stock List查詢ItemCode並加入資料 (前置時間，最小訂購，最低庫存量)
            for (int i = 0; i < stockList.Rows.Count; i++)
            {
                string expression2;
                expression2 = " ItemCode LIKE '" + stockList.Rows[i]["ItemCode"] + "'";

                DataRow[] foundRows2;

                //// Use the Select method to find all rows matching the filter.
                foundRows2 = List.Select(expression2);
                //搜尋若存貨有ITEMCODE 在List沒有就  新增ITEMCODE
                if (foundRows2.Length == 0)
                {
                    DataRow dr;
                    dr = List.NewRow();
                    //int qtyFormat = Convert.ToInt32(QCList.Rows[i]["Quantity"]);
                    dr["ItemCode"] = stockList.Rows[i]["ItemCode"];
                    dr["MinOrdrQty"] = Convert.ToInt32(stockList.Rows[i]["MinOrdrQty"]);
                    dr["LeadTime"] = stockList.Rows[i]["LeadTime"];
                    dr["MinLevel"] = Convert.ToInt32(stockList.Rows[i]["MinLevel"]);
                    
                    List.Rows.Add(dr);
                    //List.Columns.Add("");
                    //List.Columns.Add("");
                }
                //若有就在欄位更新數量
                else
                {
                    for (int y = 0; y < List.Rows.Count; y++)
                    {
                        if (List.Rows[y]["ItemCode"].ToString() == stockList.Rows[i]["ItemCode"].ToString())
                        {
                            List.Rows[y]["MinOrdrQty"] = Convert.ToInt32(stockList.Rows[i]["MinOrdrQty"]);
                            List.Rows[y]["LeadTime"] = stockList.Rows[i]["LeadTime"];
                            List.Rows[y]["MinLevel"] = Convert.ToInt32(stockList.Rows[i]["MinLevel"]);
                            break;
                        }
                    }
                }


                //if (List.Rows[i]["ItemCode"].ToString() == stockList.Rows[i]["ItemCode"].ToString())
                //{
                //    List.Rows[i]["Stock"] = stockList.Rows[i]["Stock"];
                //}
            }



            //把剩下空值的部分化為0
            for (int i = 0; i < List.Rows.Count; i++)
            {
                //if (List.Rows[i]["QCqty"].ToString() == "")
                //{
                //    List.Rows[i]["QCqty"] = "0";
                //}
                //Lead Time若為空值 則為30天
                if (List.Rows[i]["LeadTime"].ToString() == "")
                {
                    List.Rows[i]["LeadTime"] = "30";
                }

            }


            //Grid_test.DataSource = QCList;
            //Grid_test.DataBind();

            //grid_stock.DataSource = stockList;
            //grid_stock.DataBind();

            List.DefaultView.Sort = "ItemCode asc";
            grid_CbineLst.DataSource = List;
            grid_CbineLst.DataBind();

            
            
        }



    }
}