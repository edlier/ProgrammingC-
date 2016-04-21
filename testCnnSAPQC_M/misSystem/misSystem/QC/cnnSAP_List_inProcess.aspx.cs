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
        protected void Page_Load(object sender, EventArgs e)
        {
            //Read URL Data
            string DocNum = Request.QueryString["DocNum"];
            string ItemCode = Request.QueryString["ItemCode"];
            string BaseLine = Request.QueryString["BaseLine"];
            status = Request.QueryString["status"];
            dt_qc_SAP = GlobalAnnounce.SQL_String.search_SAP_QCwaitForValidateItem(DocNum, ItemCode, BaseLine);

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

        }

        protected void btn_StartValidation_Click(object sender, EventArgs e)
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert(' Start Validation ! Please check the Quantity First!');", true);

            //Check Duplicate Data in MySQL ( For re-confirm )



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
                DateTime.Now.ToString()
                );
            btn_StartValidation.Visible = false;

        }
    }
}