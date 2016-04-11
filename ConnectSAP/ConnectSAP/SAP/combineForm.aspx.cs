using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;
using System.Web.UI.HtmlControls;
using System.Globalization;
namespace ConnectSAP.SAP
{
    public partial class combineForm : System.Web.UI.Page
    {
        DataTable List = new DataTable();
        DataTable QCList = new DataTable();
        DataTable QCList2 = new DataTable();
        DataTable stockList = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            List = GlobalAnn.SQL_String.search_P1Data();
            QCList = GlobalAnn.SQL_String.search_QCvalidateQty();
            QCList2 = GlobalAnn.SQL_String.search_QCvalidateQty2();
            stockList = GlobalAnn.SQL_String.search_stockList();

            DataColumn column;
            column = new DataColumn();
            List.Columns.Add("QCqty"); 
            List.Columns.Add("QCqty2");
            //List.Columns.Add("MinOrdrQty");
            List.Columns.Add("LeadTime");
            List.Columns.Add("MinLevel");
            List.Columns.Add("BdAMult");
            List.Columns.Add("LackMaterial");
            List.Columns.Add("EndDate");
            #region QCList1 先行處理
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
            #endregion

            #region QC2
            //QC222222
            for (int i = 0; i < QCList2.Rows.Count; i++)
            {
                string expression;
                expression = " ItemCode LIKE '" + QCList2.Rows[i]["ItemCode"] + "'";

                DataRow[] foundRows;

                // Use the Select method to find all rows matching the filter.
                foundRows = List.Select(expression);

                //搜尋若QC有的ITEMCODE 在List沒有就新增
                if (foundRows.Length == 0)
                {
                    DataRow dr;
                    dr = List.NewRow();
                    int qtyFormat = Convert.ToInt32(QCList2.Rows[i]["Quantity"]);

                    dr["ItemCode"] = QCList2.Rows[i]["ItemCode"];

                    dr["QCqty2"] = qtyFormat;
                    List.Rows.Add(dr);
                }
                //若有就在欄位更新數量
                else
                {
                    int qtyFormat = Convert.ToInt32(QCList2.Rows[i]["Quantity"]);
                    for (int y = 0; y < List.Rows.Count; y++)
                    {
                        if (List.Rows[y]["ItemCode"].ToString() == QCList2.Rows[i]["ItemCode"].ToString())
                        {
                            List.Rows[y]["QCqty2"] = qtyFormat;
                            break;
                        }
                    }
                }
            }
            #endregion
            #region Stock List查詢ItemCode並加入資料
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
                    //dr["MinOrdrQty"] = Convert.ToInt32(stockList.Rows[i]["MinOrdrQty"]);
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
                            //List.Rows[y]["MinOrdrQty"] = Convert.ToInt32(stockList.Rows[i]["MinOrdrQty"]);
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
            #endregion

            #region 移除 Total 為0
            for (int i = List.Rows.Count - 1; i >= 0; i--)
            {
                if (List.Rows[i]["TotalNeed"].ToString() == "") {
                    List.Rows.RemoveAt(i);
                }
            }
            #endregion


            for (int i = 0; i < List.Rows.Count; i++)
            {

                //if (List.Rows[i]["TotalNeed"].ToString() == "")
                //{
                //    List.Rows[i].Delete();
                //}

                #region 把剩下空值的部分化為0
                //把剩下空值的部分化為0
                if (List.Rows[i]["WH01"].ToString() == "")
                {
                    List.Rows[i]["WH01"] = "0";
                }
                if (List.Rows[i]["WH03"].ToString() == "")
                {
                    List.Rows[i]["WH03"] = "0";
                }
                if (List.Rows[i]["WH04"].ToString() == "")
                {
                    List.Rows[i]["WH04"] = "0";
                }
                if (List.Rows[i]["WH16"].ToString() == "")
                {
                    List.Rows[i]["WH16"] = "0";
                }


                if (List.Rows[i]["QCqty"].ToString() == "")
                {
                    List.Rows[i]["QCqty"] = "0";
                }
                if (List.Rows[i]["QCqty2"].ToString() == "")
                {
                    List.Rows[i]["QCqty2"] = "0";
                }
                //if (List.Rows[i]["MinOrdrQty"].ToString() == "")
                //{
                //    List.Rows[i]["MinOrdrQty"] = "0";
                //}

                //Lead Time若為空值 則為30天
                if (List.Rows[i]["LeadTime"].ToString() == "")
                {
                    List.Rows[i]["LeadTime"] = "30";
                }

                if (List.Rows[i]["MinLevel"].ToString() == "")
                {
                    List.Rows[i]["MinLevel"] = "0";
                }
                #endregion

                //把30天填入後才能做運此運算.....
                CultureInfo elGR = CultureInfo.CreateSpecificCulture("el-GR");
                List.Rows[i]["BdAMult"] = (String.Format(CultureInfo.InvariantCulture, "{0:0.##}", (Convert.ToDouble(List.Rows[i]["MinLevel"]) / Convert.ToDouble(List.Rows[i]["LeadTime"]) * 30)));	

                ////計算缺料 (需求-WHO1-WHO3-WH04-WH16-QC1-QC2)
                double lack = Convert.ToDouble(List.Rows[i]["BdAMult"])
                    - Convert.ToDouble(List.Rows[i]["WH01"])
                    - Convert.ToDouble(List.Rows[i]["WH03"])
                    - Convert.ToDouble(List.Rows[i]["WH04"])
                    - Convert.ToDouble(List.Rows[i]["WH16"])
                    - Convert.ToDouble(List.Rows[i]["QCqty"])
                    - Convert.ToDouble(List.Rows[i]["QCqty2"]);

                List.Rows[i]["LackMaterial"] = (int)(lack);

                //日用量
                int dayUsed = Convert.ToInt32(List.Rows[i]["MinLevel"]) / (Convert.ToInt32(List.Rows[i]["LeadTime"])+14);
                //QC檢驗期用量
                int qcVF_count = dayUsed * 14;

                if (dayUsed > 0)
                {
                    int addDateToEnd = ((int)lack - qcVF_count) / dayUsed;
                    List.Rows[i]["EndDate"] = DateTime.Now.AddDays(addDateToEnd).ToString("MM-dd-yyyy");
                }
                else
                {
                    List.Rows[i]["EndDate"] = DateTime.Now.ToString("MM-dd-yyyy");
                }
                
            }
           

            
            #region 移除缺料小於零
            for (int i = List.Rows.Count - 1; i >= 0; i--)
            {
                if (Convert.ToInt32(List.Rows[i]["LackMaterial"]) <=0)
                {
                    List.Rows.RemoveAt(i);
                }
            }
            #endregion


            List.DefaultView.Sort = "ItemCode asc";
            grid_CbineLst.DataSource = List;
            grid_CbineLst.DataBind();            
            
        }

        protected void btn_saveExcel_Click(object sender, EventArgs e)
        {
            //ExportToFile(grid_CbineLst);
            Response.Clear();
            Response.AddHeader("content-disposition",
                "attachment;filename=PoolExport.xls");
            Response.ContentType = "application/vnd.xls";
            System.IO.StringWriter sw = new System.IO.StringWriter();
            System.Web.UI.HtmlTextWriter htw = new HtmlTextWriter(sw);

            //關閉換頁跟排序
            grid_CbineLst.AllowSorting = false;
            grid_CbineLst.AllowPaging = false;

            //移去不要的欄位
            //grid_CbineLst.Columns.RemoveAt(grid_CbineLst.Columns.Count - 1);
            //grid_CbineLst.DataBind();

            //建立假HtmlForm避免以下錯誤
            //Control 'GridView1' of type 'GridView' must be placed inside 
            //a form tag with runat=server. 
            //另一種做法是override VerifyRenderingInServerForm後不做任何事
            //這樣就可以直接GridView1.RenderControl(htw);

            System.Web.UI.HtmlControls.HtmlForm hf = new System.Web.UI.HtmlControls.HtmlForm();
            Controls.Add(hf);
            hf.Controls.Add(grid_CbineLst);
            hf.RenderControl(htw);

            Response.Write(sw.ToString());
            Response.End();
        }




    }
}