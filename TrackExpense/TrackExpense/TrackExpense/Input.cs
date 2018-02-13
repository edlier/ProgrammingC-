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
        
        public Form_Input()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
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
            dt_CatogoryTypeB=SetFirstChooseItem("Des",dt_CatogoryTypeB);
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
    }
}
