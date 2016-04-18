using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace misSystem.regulatory
{
    public partial class regulatory_form_DCR : System.Web.UI.Page
    {
        int userID;
        //DataTable dataTable;
        protected void Page_Load(object sender, EventArgs e)
        {
            userID = Convert.ToInt32(Session["userID"]);
            string changeProposedBy = GlobalAnnounce.id.getName(userID);
            lbl_proposedPerson.Text = changeProposedBy;

            //顯示目前日期
            DateTime dateNow = DateTime.Now;
            lbl_proposedDate.Text = dateNow.ToString("yyyy/MM/dd");

            //Priority的選擇項
            drop_priority.DataSource = GlobalAnnounce.regulatory_DCR.priorityOption();
            drop_priority.DataBind();
            
            //Machine的選項
            drop_product.DataSource = GlobalAnnounce.machine.searchMachine();
            drop_product.DataBind();


        }
        protected void drop_changeReason_1_Init(object sender, EventArgs e)
        {
            DataTable reasonForChangerNumber = new DataTable();
            reasonForChangerNumber = GlobalAnnounce.regulatory_DCR.reasonForChangeNumber();

            //drop_changeReason_1.DataSource = reasonForChangerNumber;
            //drop_changeReason_1.DataBind();

            drop_changeReason_2.DataSource = reasonForChangerNumber;
            drop_changeReason_2.DataBind();
            drop_changeReason_3.DataSource = reasonForChangerNumber;
            drop_changeReason_3.DataBind();
            drop_changeReason_4.DataSource = reasonForChangerNumber;
            drop_changeReason_4.DataBind();
            drop_changeReason_5.DataSource = reasonForChangerNumber;
            drop_changeReason_5.DataBind();
        }


        protected void btn_DCR_submint_Click(object sender, EventArgs e)
        {
            //int count = 0;
            //int[] flagNum = new int[5];

            //string[] docNum = new string[5];
            //int[] newVersion = new int[5];
            //string[] docName = new string[5];
            //int[] changeReason = new int[5];
            //string[] changeReasonText = new string[5];

            //if (tb_docNum_1.Text != "") { 
            //    count++; flagNum[0] = 1; 
            //    docNum[0] = tb_docName_1.Text; 
            //    newVersion[0] = Convert.ToInt32(tb_newVersion_1.Text);
            //    docName[0] = tb_docName_1.Text;
            //    changeReason[0] = Convert.ToInt32(drop_changeReason_1.SelectedValue);
            //    changeReasonText[0] = tb_other_1.Text;
            //}
            //if (tb_docNum_2.Text != "")
            //{
            //    count++; flagNum[1] = 1;
            //    docNum[1] = tb_docName_2.Text;
            //    newVersion[1] = Convert.ToInt32(tb_newVersion_2.Text);
            //    docName[1] = tb_docName_2.Text;
            //    changeReason[1] = Convert.ToInt32(drop_changeReason_2.SelectedValue);
            //    changeReasonText[1] = tb_other_2.Text;
            //}
            //if (tb_docNum_3.Text != "") { count++; flagNum[2] = 1; }
            //if (tb_docNum_4.Text != "") { count++; flagNum[3] = 1; }
            //if (tb_docNum_5.Text != "") { count++; flagNum[4] = 1; }


            //for (int i = 0; i < 5; i++)
            //{
                
            //}
        }

        protected void drop_changeReason_1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (drop_changeReason_1.SelectedValue == 10.ToString() || drop_changeReason_1.SelectedValue == 9.ToString() || drop_changeReason_1.SelectedValue == 8.ToString())
            {
                tb_other_1.Visible = true;
            }
            else
            {
                tb_other_1.Visible = false;
            }
        }
        protected void drop_changeReason_2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (drop_changeReason_2.SelectedValue == 10.ToString() || drop_changeReason_2.SelectedValue == 9.ToString() || drop_changeReason_2.SelectedValue == 8.ToString())
            {
                tb_other_2.Visible = true;
            }
            else
            {
                tb_other_2.Visible = false;
            }
        }
        protected void drop_changeReason_3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (drop_changeReason_3.SelectedValue == 10.ToString() || drop_changeReason_3.SelectedValue == 9.ToString() || drop_changeReason_3.SelectedValue == 8.ToString())
            {
                tb_other_3.Visible = true;
            }
            else
            {
                tb_other_3.Visible = false;
            }
        }
        protected void drop_changeReason_4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (drop_changeReason_4.SelectedValue == 10.ToString() || drop_changeReason_4.SelectedValue == 9.ToString() || drop_changeReason_4.SelectedValue == 8.ToString())
            {
                tb_other_4.Visible = true;
            }
            else
            {
                tb_other_4.Visible = false;
            }
        }
        protected void drop_changeReason_5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (drop_changeReason_5.SelectedValue == 10.ToString() || drop_changeReason_5.SelectedValue == 9.ToString() || drop_changeReason_5.SelectedValue == 8.ToString())
            {
                tb_other_5.Visible = true;
            }
            else
            {
                tb_other_5.Visible = false;
            }
        }

    }
}