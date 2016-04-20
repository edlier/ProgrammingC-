using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace misSystem.QC
{
    public partial class cnnSAP_List_inProcess : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //讀取前一頁面選取的資料
            Label1.Text = Request.QueryString["DocNum"] + "+" +
                Request.QueryString["ItemCode"] + "+" +
                Request.QueryString["BaseLine"];
        }
    }
}