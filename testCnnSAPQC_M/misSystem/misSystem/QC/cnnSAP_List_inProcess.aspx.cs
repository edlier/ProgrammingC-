using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace misSystem.QC
{
    public partial class cnnSAP_List_inProcess : System.Web.UI.Page
    {
        DataTable dt_qc_SAP;
        string status;
        string DocNum;
        string ItemCode;
        string BaseLine;
        protected void Page_Load(object sender, EventArgs e)
        {

            //Read URL Data
            DocNum = Request.QueryString["DocNum"];
            ItemCode = Request.QueryString["ItemCode"];
            BaseLine = Request.QueryString["BaseLine"];
            status = Request.QueryString["status"];
            dt_qc_SAP = GlobalAnnounce.SQL_String.search_SAP_QCwaitForValidateItem(DocNum, ItemCode, BaseLine);
            if (dt_qc_SAP.Rows.Count==0)
            {
                Response.Write("<script>alert('Wrong URL! ');location.href='cnnSAPList.aspx';</script>");
            }
            if (!IsPostBack)
            {
                //若資料為尚未存在MySQL 資料庫的資料
                if (status == "")
                {
                    lb_docnum.Text = DocNum;
                    lb_ItemCode.Text = dt_qc_SAP.Rows[0]["ItemCode"].ToString();
                    lbl_ltemdsrp.Text = dt_qc_SAP.Rows[0]["Dscription"].ToString();
                    lbl_supplierCode.Text = dt_qc_SAP.Rows[0]["CardCode"].ToString();
                    lbl_supplierName.Text = dt_qc_SAP.Rows[0]["CardName"].ToString();
                    lbl_DocDate.Text = Convert.ToDateTime(dt_qc_SAP.Rows[0]["DocDate"]).ToString("yyyy-MM-dd");
                    lbl_Qty.Text = Convert.ToInt32(dt_qc_SAP.Rows[0]["Quantity"]).ToString("0.##");
                    btn_StartValidation.Visible = true;
                }
                else
                {
                    Panl_FilVaInfo.Visible = true;
                    btn_StartValidation.Visible = false;
                }
            }
        }

        protected void btn_StartValidation_Click(object sender, EventArgs e)
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert(' Start Validation ! Please check the Quantity First!');", true);

            //Check Duplicate Data in MySQL ( For re-Confirm )
            DataTable dt_selectdata;
            dt_selectdata = GlobalAnnounce.QCList.search_mySQL_QCValidateItem(DocNum, ItemCode, BaseLine);

            if (dt_selectdata.Rows.Count != 0)
            {
                Response.Write("<script>alert(' Duplicate Data! Please check starting status !');location.href='cnnSAPList.aspx';</script>");
            }
            else { 
            //Save Data to MySQL Localization & Set Status = 1
            GlobalAnnounce.QCList.insertQCd_FSAP_TMy(
                dt_qc_SAP.Rows[0]["DocNum"].ToString(),
                dt_qc_SAP.Rows[0]["DocEntry"].ToString(),
                dt_qc_SAP.Rows[0]["ItemCode"].ToString(),
                dt_qc_SAP.Rows[0]["CardCode"].ToString(),
                dt_qc_SAP.Rows[0]["CardName"].ToString(),

                dt_qc_SAP.Rows[0]["BaseLine"].ToString(),
                dt_qc_SAP.Rows[0]["Quantity"].ToString(),
                dt_qc_SAP.Rows[0]["Dscription"].ToString(),
                dt_qc_SAP.Rows[0]["DocDate"].ToString(),
                //Operator
                Convert.ToInt32(Session[SessionString.userID]).ToString(),

                //Start_Time
                DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss")
                );
            btn_StartValidation.Visible = false;
            Panl_FilVaInfo.Visible = true;
            status = "1";
            }
        }

        protected void tb_FailedQty_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tb_FailedQty.Text == "")
                {
                    //ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert(' Please Fill in Failed Count!');", true);
                }
                else if (Convert.ToInt32(tb_FailedQty.Text) > 0)
                {
                    DataTable dt_QFailedReason;
                    //search dropListData
                    dt_QFailedReason = GlobalAnnounce.QCList.search_QCFailedReason();
                    drop_FailedReason.DataSource = dt_QFailedReason;
                    drop_FailedReason.DataBind();

                    drop_FailedReason.Enabled = true;
                    //lbl_failedReason.Visible = true;
                }
                else if (Convert.ToInt32(tb_FailedQty.Text) < 0)
                {
                    tb_FailedQty.Text = "";
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert(' Faliure count Can't be less than zero!');", true);
                }
                else
                {
                    drop_FailedReason.Enabled = false;
                }
            }
            catch
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert(' Failed Count Can't be String!');", true);
            }
            #region 註解
            //try
            //{
            //    if (Convert.ToInt32(tb_FailedQty.Text) > 0 && Convert.ToInt32(tb_FailedQty.Text) <= Convert.ToInt32(tb_TotalQty.Text))
            //    {
            //        DataTable dt_QFailedReason;
            //        //search dropListData
            //        dt_QFailedReason = GlobalAnnounce.QCList.search_QCFailedReason();
            //        drop_FailedReason.DataSource = dt_QFailedReason;
            //        drop_FailedReason.DataBind();

            //        drop_FailedReason.Enabled = true;
            //        //lbl_failedReason.Visible = true;
            //    }
            //    else if (Convert.ToInt32(tb_FailedQty.Text) > Convert.ToInt32(tb_TotalQty.Text))
            //    {
            //        tb_FailedQty.Text = "";
            //        ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert(' Faliure count is over Total count !');", true);
            //    }
            //    else if (Convert.ToInt32(tb_FailedQty.Text) < 0)
            //    {
            //        tb_FailedQty.Text = "";
            //        ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert(' Faliure count could not be less than zero!');", true);
            //    }
            //    else
            //    {
            //        drop_FailedReason.Enabled = false;
            //        //lbl_failedReason.Visible = false;
            //    }
            //}
            //catch
            //{
            //    tb_FailedQty.Text = "";
            //    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert(' The Qty can not be String!');", true);
            //}
            #endregion
        }

        protected void btn_submit_Click(object sender, EventArgs e)
        {
            //Check All Format is OK
            if (Convert.ToInt32(tb_FailedQty.Text) > Convert.ToInt32(tb_TotalQty.Text))
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert(' Faliure count is over Total count !');", true);
            }
            else if (Convert.ToInt32(tb_TotalQty.Text)==0)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert(' Total count can't be ZERO !');", true);
            }
            else
            {
                //insert   1. total Qty  2. failed Qty 3. Failed  Reason if have 4.Process Time 5. End_Time
                int Process_Time = ((Convert.ToInt32(tb_ProHr.Text)) * 60 + (Convert.ToInt32(tb_ProMin.Text)));
                string process = Process_Time.ToString();


                // Get Selected Failed Reason Value

                if (Convert.ToInt32(tb_FailedQty.Text) < 0 || tb_FailedQty.Text == "")
                {
                    doForUpdateFinished(process, "0", "");
                }
                else if (Convert.ToInt32(tb_FailedQty.Text) > 0)
                {
                    doForUpdateFinished(process, tb_FailedQty.Text, drop_FailedReason.SelectedValue);
                }
                Response.Redirect(PageListString.cnnSAP_List);
            }
        }


        private void doForUpdateFinished(string Process_Time, string FailedQty,string failedReason)
        {
            string status = "2"; //finished
            GlobalAnnounce.QCList.update_saveForFinishedValidated(
                tb_TotalQty.Text,
                FailedQty,
                failedReason,
                Process_Time.ToString(),
                DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"),
                status);
        }


    }
}
