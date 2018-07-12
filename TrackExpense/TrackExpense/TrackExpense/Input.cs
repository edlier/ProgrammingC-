using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrackExpense
{
    public partial class Form_Input : Form
    {
        private DataAccess DataAccess = new DataAccess();
        private PublicFunction PulicFunction = new PublicFunction();

        public Form_Input()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region tp_InputExpense
            rb_payType_Expense.Checked = true;

            //Get CreditCard Kind
            DataTable dt_CreditCardKind = DataAccess.Get_PaymentKind();
            dt_CreditCardKind = SetFirstChooseItem("NAME", dt_CreditCardKind);
            cb_payCrditCard.DropDownStyle = ComboBoxStyle.DropDownList; //設定不能更改文字
            cb_payCrditCard.Items.Add("Choose...");
            cb_payCrditCard.DisplayMember = "NAME";
            cb_payCrditCard.ValueMember = "ID";
            cb_payCrditCard.DataSource = dt_CreditCardKind;

            DataTable dt_CatogoryTypeB = DataAccess.Get_CatogoryTypeB();
            dt_CatogoryTypeB = SetFirstChooseItem("Des", dt_CatogoryTypeB);
            cb_TypeB.DisplayMember = "Des";
            cb_TypeB.ValueMember = "BID";
            cb_TypeB.DataSource = dt_CatogoryTypeB;
            cb_TypeB.DropDownStyle = ComboBoxStyle.DropDownList; //設定不能更改文字


            DataTable dt_PlaceCatB = DataAccess.Get_PlaceCatB();
            dt_PlaceCatB = SetFirstChooseItem("Type", dt_PlaceCatB);
            cb_PlaceTypeB.DisplayMember = "Type";
            cb_PlaceTypeB.ValueMember = "ID";
            cb_PlaceTypeB.DataSource = dt_PlaceCatB;
            cb_PlaceTypeB.DropDownStyle = ComboBoxStyle.DropDownList; //設定不能更改文字

            //BIND Currency
            DataTable dt_currency = DataAccess.Get_Currency();
            cb_currency.DisplayMember = "currency";
            cb_currency.ValueMember = "currency";
            cb_currency.DataSource = dt_currency;
            cb_currency.DropDownStyle = ComboBoxStyle.DropDownList; //設定不能更改文字
            #endregion

            #region tp_Add Place
            //LOAD Place B DATA
            DataTable dt_PlaceCatB_AddPlace = DataAccess.Get_PlaceCatB();
            dgv_PlaceB.DataSource = dt_PlaceCatB_AddPlace;

            //LOAD Place S DATA
            DataTable dt_PlaceCatS = DataAccess.Get_PlaceCatS();
            dgv_PlaceS.DataSource = dt_PlaceCatS;

            //LOAD Place S Search B Type Option
            DataTable dt_PlaceCats_SearchTypeB = dt_PlaceCatB_AddPlace.Copy();
            cb_SearchPlaceS_BID.DisplayMember = "Type";
            cb_SearchPlaceS_BID.ValueMember = "ID";
            dt_PlaceCats_SearchTypeB = PulicFunction.SetFirstChooseItem("ID", "Type", dt_PlaceCats_SearchTypeB);
            cb_SearchPlaceS_BID.DataSource = dt_PlaceCats_SearchTypeB;
            cb_SearchPlaceS_BID.SelectedIndex = 0;
            cb_SearchPlaceS_BID.DropDownStyle = ComboBoxStyle.DropDownList;

            DataTable dt_PlaceCats_EditTypeB = dt_PlaceCatB_AddPlace.Copy();
            cb_EditS_PlaceBList.DisplayMember = "Type";
            cb_EditS_PlaceBList.ValueMember = "ID";
            dt_PlaceCats_EditTypeB = PulicFunction.SetFirstChooseItem("ID", "Type", dt_PlaceCats_EditTypeB);
            cb_EditS_PlaceBList.DataSource = dt_PlaceCats_EditTypeB;
            cb_EditS_PlaceBList.SelectedIndex = 0;
            cb_EditS_PlaceBList.DropDownStyle = ComboBoxStyle.DropDownList;
            #endregion

            #region tp_Add Type
            //LOAD Type B DATA
            DataTable dt_TypeCatB_List = DataAccess.Get_TypeCatB();
            dgv_TypeB.DataSource = dt_TypeCatB_List;



            #endregion
        }

        private void cb_TypeB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_TypeB.SelectedValue != null)
            {
                string selectBType = cb_TypeB.SelectedValue.ToString();
                if (selectBType != "0"&&selectBType!="")
                {
                    DataTable dt_CatogoryTypeS = DataAccess.Get_CatogoryTypeS_FromBType(selectBType);
                    dt_CatogoryTypeS = SetFirstChooseItem("Des", dt_CatogoryTypeS);
                    cb_TypeS.DisplayMember = "Des";
                    cb_TypeS.ValueMember = "SID";
                    cb_TypeS.DataSource = dt_CatogoryTypeS;
                    cb_TypeS.DropDownStyle = ComboBoxStyle.DropDownList; //設定不能更改文字
                }
                else if (selectBType == "")
                {
                    cb_TypeS.DataSource = null;
                }
            }
        }
        private void cb_PlaceTypeB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_PlaceTypeB.SelectedValue != null)
            {
                string selectBPlace = cb_PlaceTypeB.SelectedValue.ToString();
                if (selectBPlace != "0"&& selectBPlace!="")
                {
                    DataTable dt_CatPlaceTypeS = DataAccess.Get_PlaeceCatS_FromBPlace(selectBPlace);
                    dt_CatPlaceTypeS = SetFirstChooseItem("Des", dt_CatPlaceTypeS);
                    cb_PlaceTypeS.DisplayMember = "Des";
                    cb_PlaceTypeS.ValueMember = "ID";
                    cb_PlaceTypeS.DataSource = dt_CatPlaceTypeS;
                    cb_PlaceTypeS.DropDownStyle = ComboBoxStyle.DropDownList; //設定不能更改文字
                }
                else if (selectBPlace == "")
                {
                    cb_PlaceTypeS.DataSource = null;
                }
            }
        }
        private void rb_EasyCard_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_EasyCard.Checked == true)
            {
                cb_payCrditCard.Enabled = false;
            }
        }
        private void rb_CreditCard_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_CreditCard.Checked == true)
            {
                cb_payCrditCard.Enabled = true;
            }
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            string spentDate = datePicker_spentDT.Value.ToString("yyyy-MM-dd");
            string content = tb_Content.Text;
            string price = "0";
            if (tb_Price.Text != "") price = tb_Price.Text;

            string currency = cb_currency.SelectedValue.ToString();

            string expenseTypeB = cb_TypeB.SelectedValue.ToString() != "" ? cb_TypeB.SelectedValue.ToString() : "0";
            string expenseTypeS ="0";
            if (expenseTypeB != "0" && cb_TypeS.SelectedValue != null)
            {
                if (cb_TypeS.SelectedValue.ToString() != "")
                {
                    expenseTypeS = cb_TypeS.SelectedValue.ToString();
                }
            }

            string type = rb_payType_InCome.Checked == true ? "2" : "1";  //2為收入
            string receiptNum = tb_receiptNum.Text!=""?tb_receiptNum.Text:"NULL";

            string place_CatB = cb_PlaceTypeB.SelectedValue.ToString() != "" ? cb_PlaceTypeB.SelectedValue.ToString() : "0";
            string place_CatS ="0";
            if (place_CatB != "0"&& cb_PlaceTypeS.SelectedValue != null)
            {
                if (cb_PlaceTypeS.SelectedValue.ToString() != "")
                {
                    place_CatS = cb_PlaceTypeS.SelectedValue.ToString();
                }
            }

            string payByCard = rb_EasyCard.Checked == true ? "1" : "2";
            payByCard = rb_CreditCard.Checked == true ? "2" : "0";
            string PayCreditCardID="0";
            if (payByCard != "0")
            {
                PayCreditCardID = cb_payCrditCard.SelectedValue.ToString() != "" ? cb_payCrditCard.SelectedValue.ToString() : "0";
            }
            string note = tb_Note.Text;

           DataTable dt_result= DataAccess.Insert_ExpenseRecord(spentDate, content, price, currency, payByCard, PayCreditCardID, expenseTypeB, expenseTypeS, receiptNum, type, place_CatB, place_CatS, note);
            SetControl();
        }


        private DataTable SetFirstChooseItem(string setDataColumnName,DataTable dt)
        {
            DataRow row = dt.NewRow();
            row[setDataColumnName] = "Choose......";
            dt.Rows.InsertAt(row, 0);
            return dt;
        }
        private void SetControl()
        {
            tb_Content.Text = "";
            tb_Note.Text = "";
            tb_Price.Text = "";
            tb_receiptNum.Text = "";

            rb_EasyCard.Checked = false;
            rb_CreditCard.Checked = false;
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            //Reset

            //設定支付類行為支出
            rb_payType_Expense.Checked = true;
            rb_payType_InCome.Checked = false;

            //重新設定日期
            datePicker_spentDT.ResetText();

            tb_Content.Text = "";
            tb_Note.Text = "";
            tb_Price.Text = "";
            tb_receiptNum.Text = "";

            //Clear combobox option
            cb_currency.SelectedIndex = -1;
            cb_payCrditCard.SelectedItem = null;
            cb_PlaceTypeB.SelectedItem = null;
            cb_PlaceTypeS.SelectedItem = null;
            cb_TypeB.SelectedIndex = 0;
            cb_TypeS.DataSource = null;

            ////Rebind Combox
            ////Get CreditCard Kind
            //DataTable dt_CreditCardKind = DataAccess.Get_PaymentKind();
            //dt_CreditCardKind = SetFirstChooseItem("NAME", dt_CreditCardKind);
            //cb_payCrditCard.DropDownStyle = ComboBoxStyle.DropDownList; //設定不能更改文字
            //cb_payCrditCard.Items.Add("Choose...");
            //cb_payCrditCard.DisplayMember = "NAME";
            //cb_payCrditCard.ValueMember = "ID";
            //cb_payCrditCard.DataSource = dt_CreditCardKind;

            //DataTable dt_CatogoryTypeB = DataAccess.Get_CatogoryTypeB();
            //dt_CatogoryTypeB = SetFirstChooseItem("Des", dt_CatogoryTypeB);
            //cb_TypeB.DisplayMember = "Des";
            //cb_TypeB.ValueMember = "BID";
            //cb_TypeB.DataSource = dt_CatogoryTypeB;
            //cb_TypeB.DropDownStyle = ComboBoxStyle.DropDownList; //設定不能更改文字


            //DataTable dt_PlaceCatB = DataAccess.Get_PlaceCatB();
            //dt_PlaceCatB = SetFirstChooseItem("Type", dt_PlaceCatB);
            //cb_PlaceTypeB.DisplayMember = "Type";
            //cb_PlaceTypeB.ValueMember = "ID";
            //cb_PlaceTypeB.DataSource = dt_PlaceCatB;
            //cb_PlaceTypeB.DropDownStyle = ComboBoxStyle.DropDownList; //設定不能更改文字

            ////BIND Currency
            //DataTable dt_currency = DataAccess.Get_Currency();
            //cb_currency.DisplayMember = "currency";
            //cb_currency.ValueMember = "currency";
            //cb_currency.DataSource = dt_currency;
            //cb_currency.DropDownStyle = ComboBoxStyle.DropDownList; //設定不能更改文字
        }

        private void btn_InputList_Click(object sender, EventArgs e)
        {


        }

        private void btn_MonthDatList_Click(object sender, EventArgs e)
        {
            ExpenseList f = new ExpenseList();
            this.Visible = false;
            f.Visible = true;
        }

        private void btn_editPlace_Click(object sender, EventArgs e)
        {
            config_PlaceList f = new config_PlaceList();
            this.Visible = false;
            f.Visible = true;
        }










        #region tp_Add Place
        private void btn_InputPage_Click(object sender, EventArgs e)
        {
            Form_Input f = new Form_Input();
            this.Visible = false;
            f.Visible = true;
        }

        #region 大分類
        private void dgv_PlaceB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string str_PlaceTypeText = dgv_PlaceB.Rows[e.RowIndex].Cells["Type"].Value.ToString();
            string str_PlaceBID = dgv_PlaceB.Rows[e.RowIndex].Cells["ID"].Value.ToString();

            // If click edit
            if (e.ColumnIndex == dgv_PlaceB.Columns["btn_Edit"].Index)
            {
                btn_AddPlaceB.Text = "Edit";
                tb_insertPlaceB.Text = str_PlaceTypeText;
                tb_Hide_PlaceB_ID.Text = str_PlaceBID;
            }
            else if (e.ColumnIndex == dgv_PlaceB.Columns["btn_Delete"].Index)
            {
                btn_AddPlaceB.Text = "Delete";
                tb_insertPlaceB.Text = str_PlaceTypeText;
                tb_Hide_PlaceB_ID.Text = str_PlaceBID;
            }
        }
        private void btn_AddPlaceB_Click(object sender, EventArgs e)
        {
            string str_Place_BID = tb_Hide_PlaceB_ID.Text;
            string str_Place_BType = tb_insertPlaceB.Text;
            if (btn_AddPlaceB.Text == "Edit")
            {
                //Check For Dulplicate
                if (Check_PlaceTypeB_Dul(str_Place_BType) == true)
                {
                    //Update in DB
                    DataAccess.Update_PlaceTypeB(str_Place_BID, str_Place_BType);
                }
                else
                {
                    MessageBox.Show("Place Type Dulplicate");
                }
            }
            else if (btn_AddPlaceB.Text == "Delete")
            {
                DialogResult myResult = MessageBox.Show("Are you sure you want to delete?", "Delete Comfirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (myResult == DialogResult.Yes)
                {
                    //Delete BY ID
                    DataAccess.Delete_PlaceTypeB(str_Place_BID);
                }
                else if (myResult == DialogResult.No)
                {
                }
            }
            else if (btn_AddPlaceB.Text == "New Add")
            {
                //Check For Dulplicate
                if (Check_PlaceTypeB_Dul(str_Place_BType) == true)
                {
                    DataAccess.Insert_PlaceTypeB(str_Place_BType);
                }
                else
                {
                    MessageBox.Show("New Place Type Dulplicate");
                }
            }

            tb_Hide_PlaceB_ID.Text = "";
            tb_insertPlaceB.Text = "";

            //Rebind List
            DataTable dt_PlaceCatB = DataAccess.Get_PlaceCatB();
            dgv_PlaceB.DataSource = dt_PlaceCatB;

            //Rebind S Type Edit Dropdown
            DataTable dt_PlaceCats_EditTypeB = DataAccess.Get_PlaceCatB();
            cb_EditS_PlaceBList.DisplayMember = "Type";
            cb_EditS_PlaceBList.ValueMember = "ID";
            dt_PlaceCats_EditTypeB = PulicFunction.SetFirstChooseItem("ID", "Type", dt_PlaceCats_EditTypeB);
            cb_EditS_PlaceBList.DataSource = dt_PlaceCats_EditTypeB;
            cb_EditS_PlaceBList.SelectedIndex = 0;
            cb_EditS_PlaceBList.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void btn_EditPlaceB_Cancel_Click(object sender, EventArgs e)
        {
            tb_insertPlaceB.Text = "";
            btn_AddPlaceB.Text = "New Add";
        }
        #endregion

        #region TAB - 小分類
        private void dgv_PlaceS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string str_PlaceSTypeText = dgv_PlaceS.Rows[e.RowIndex].Cells["Des"].Value.ToString();
            string str_PlaceBID = dgv_PlaceS.Rows[e.RowIndex].Cells["LinkBID"].Value.ToString();
            string str_PlaceSID = dgv_PlaceS.Rows[e.RowIndex].Cells["SID"].Value.ToString();

            if (e.ColumnIndex == dgv_PlaceS.Columns["dg_btn_SEdit"].Index || e.ColumnIndex == dgv_PlaceS.Columns["dg_btn_SDel"].Index)
            {
                DataTable dt_PlaceCatB = DataAccess.Get_PlaceCatB();
                cb_EditS_PlaceBList.DataSource = null;

                tb_insertPlaceS.Text = str_PlaceSTypeText;
                tb_Hide_PlaceS_ID.Text = str_PlaceSID;

                //dt_CatPlaceTypeS = SetFirstChooseItem("Des", dt_CatPlaceTypeS);
                cb_EditS_PlaceBList.DisplayMember = "Type";
                cb_EditS_PlaceBList.ValueMember = "ID";
                dt_PlaceCatB = PulicFunction.SetFirstChooseItem("ID", "Type", dt_PlaceCatB);
                cb_EditS_PlaceBList.DataSource = dt_PlaceCatB;
                cb_EditS_PlaceBList.SelectedValue = str_PlaceBID;

                if (e.ColumnIndex == dgv_PlaceS.Columns["dg_btn_SEdit"].Index)
                {
                    btn_AddPlaceS.Text = "Edit";
                }
                else
                {
                    btn_AddPlaceS.Text = "Delete";
                }
            }
        }
        private void btn_EditPlaceS_Cancel_Click(object sender, EventArgs e)
        {
            tb_insertPlaceS.Text = "";
            btn_AddPlaceS.Text = "New Add";
            cb_EditS_PlaceBList.SelectedIndex = 0;
        }
        private void SearchPlaceS_Event(object sender, EventArgs e)
        {
            string SearchPlaceSB_ID = cb_SearchPlaceS_BID.SelectedValue.ToString();
            string SearchPlaceS_Des = tb_SearchPlaceS_Des.Text;

            DataTable dt_PlaceSList = new DataTable();
            if (SearchPlaceSB_ID != "0" && SearchPlaceS_Des == "")  // Only Choose B Type
            {
                //Search By PlaceS_ID
                dt_PlaceSList = DataAccess.Get_PlaceCatS_FullList_ByBPlace(SearchPlaceSB_ID);
            }
            else if (SearchPlaceSB_ID == "0" && SearchPlaceS_Des == "")  //Not Choose AnyThing
            {
                dt_PlaceSList = DataAccess.Get_PlaceCatS();
            }
            else if (SearchPlaceSB_ID != "0" && SearchPlaceS_Des != "")  //Search By All Search Option
            {
                dt_PlaceSList = DataAccess.Get_PlaceCatS_FullList_ByBPlaceAndDes(SearchPlaceSB_ID, tb_SearchPlaceS_Des.Text);
            }
            else if (SearchPlaceSB_ID == "0" && SearchPlaceS_Des != "")  //Search By All Search Option
            {
                dt_PlaceSList = DataAccess.Get_PlaceCatS_FullList_ByDes(tb_SearchPlaceS_Des.Text);
            }

            if (dt_PlaceSList != null)
            {
                dgv_PlaceS.DataSource = dt_PlaceSList;
            }
        }
        private void btn_AddPlaceS_Click(object sender, EventArgs e)
        {
            string str_Place_BID = cb_EditS_PlaceBList.SelectedValue.ToString();
            string str_Place_SDes = tb_insertPlaceS.Text;
            string str_PlaceSEditID = tb_Hide_PlaceS_ID.Text;

            if (btn_AddPlaceS.Text == "Edit")
            {
                //Check For Dulplicate
                if (Check_PlaceTypeS_Dul(str_Place_BID, str_Place_SDes) == true)
                {
                    //Update in DB
                    DataAccess.Update_PlaceTypeS(str_PlaceSEditID, str_Place_BID, str_Place_SDes);
                }
                else
                {
                    MessageBox.Show("Place B and S Des Dulplicate");
                }
            }
            else if (btn_AddPlaceS.Text == "Delete")
            {
                DialogResult myResult = MessageBox.Show("Are you sure you want to delete?", "Delete Comfirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (myResult == DialogResult.Yes)
                {
                    //Delete BY ID
                    DataAccess.Delete_PlaceTypeS(str_PlaceSEditID);
                }
                else if (myResult == DialogResult.No)
                {
                }
            }
            else if (btn_AddPlaceS.Text == "New Add")
            {
                //Check For Dulplicate
                if (Check_PlaceTypeS_Dul(str_Place_BID, str_Place_SDes) == true)
                {
                    DataAccess.Insert_PlaceTypeS(str_Place_BID, str_Place_SDes);
                }
                else
                {
                    MessageBox.Show("New Place BID and S Des Dulplicate");
                }
            }

            tb_Hide_PlaceS_ID.Text = "";
            tb_insertPlaceS.Text = "";

            ////Rebind List
            DataTable dt_PlaceCatS = DataAccess.Get_PlaceCatS();
            dgv_PlaceS.DataSource = dt_PlaceCatS;


        }
        #endregion

        public bool Check_PlaceTypeB_Dul(string Place_BType)
        {
            DataTable dt_PlaceB_Dul = DataAccess.Get_PlaceCatB_CheckDul(Place_BType);
            if (dt_PlaceB_Dul.Rows.Count == 0)
            {
                return true;
            }
            return false;
        }
        public bool Check_PlaceTypeS_Dul(string Place_BID, string Place_SDes)
        {
            DataTable dt_PlaceS_Dul = DataAccess.Get_PlaceCatS_CheckDul(Place_BID, Place_SDes);
            if (dt_PlaceS_Dul.Rows.Count == 0)
            {
                return true;
            }
            return false;
        }

        #endregion

        #region  tp_Add Type
        private void dgv_TypeB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string str_TypeText = dgv_TypeB.Rows[e.RowIndex].Cells["tp_AddType_B_dgv_TypeaB_Des"].Value.ToString();
            string str_TypeBID = dgv_TypeB.Rows[e.RowIndex].Cells["tp_AddType_B_dgv_TypeaB_BID"].Value.ToString();

            // If click edit
            if (e.ColumnIndex == dgv_TypeB.Columns["tp_AddType_B_dgv_TypeaB_Btn_Edit"].Index)
            {
                btn_AddTypeB.Text = "Edit";
                tb_InsertTypeB.Text = str_TypeText;
                tb_Hide_TypeB_ID.Text = str_TypeBID;
            }
            else if (e.ColumnIndex == dgv_TypeB.Columns["tp_AddType_B_dgv_TypeB_Btn_Del"].Index)
            {
                btn_AddTypeB.Text = "Delete";
                tb_InsertTypeB.Text = str_TypeText;
                tb_Hide_TypeB_ID.Text = str_TypeBID;
            }
        }

        #endregion

        private void tb_SearchTypeS_Des_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void tb_SearchPlaceS_Des_TextChanged(object sender, EventArgs e)
        {
            string SearchPlaceSB_ID = cb_SearchPlaceS_BID.SelectedValue.ToString();
            string SearchPlaceS_Des = tb_SearchPlaceS_Des.Text;

            DataTable dt_PlaceSList = new DataTable();
            if (SearchPlaceSB_ID != "0" && SearchPlaceS_Des == "")  // Only Choose B Type
            {
                //Search By PlaceS_ID
                dt_PlaceSList = DataAccess.Get_PlaceCatS_FullList_ByBPlace(SearchPlaceSB_ID);
            }
            else if (SearchPlaceSB_ID == "0" && SearchPlaceS_Des == "")  //Not Choose AnyThing
            {
                dt_PlaceSList = DataAccess.Get_PlaceCatS();
            }
            else if (SearchPlaceSB_ID != "0" && SearchPlaceS_Des != "")  //Search By All Search Option
            {
                dt_PlaceSList = DataAccess.Get_PlaceCatS_FullList_ByBPlaceAndDes(SearchPlaceSB_ID, tb_SearchPlaceS_Des.Text);
            }
            else if (SearchPlaceSB_ID == "0" && SearchPlaceS_Des != "")  //Search By All Search Option
            {
                dt_PlaceSList = DataAccess.Get_PlaceCatS_FullList_ByDes(tb_SearchPlaceS_Des.Text);
            }

            if (dt_PlaceSList != null)
            {
                dgv_PlaceS.DataSource = dt_PlaceSList;
            }
        }
    }
}
