using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrackExpense
{
    public partial class ExpenseList : Form
    {
        private DataAccess DataAccess = new DataAccess();
        private PublicFunction PulicFunction = new PublicFunction();
        public ExpenseList()
        {
            InitializeComponent();
        }

        private void List_Load(object sender, EventArgs e)
        {
            // Load Paid List
            //先GET 當月
            DateTime FirstDay = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            DateTime LastDay = new DateTime(DateTime.Now.AddMonths(1).Year, DateTime.Now.AddMonths(1).Month, 1).AddDays(-1);

            string monthFirstDate = FirstDay.ToString("yyyy-MM-dd");
            string monthLastDate = LastDay.ToString("yyyy-MM-dd");
            dateTimePicker_searchStart.Text = monthFirstDate;
            dateTimePicker_searchEnd.Text = monthLastDate;


            //dataGridView1.AutoGenerateColumns = false;
            //CALL dorepeat(1000);

           
            DataTable dt = DataAccess.Get_ExpenseListByDate(monthFirstDate, monthLastDate);
            dataGridView1.DataSource = dt;

            //Set Coumn Style
            //dataGridView1.Columns["Price"].DefaultCellStyle.Format = "c";
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            style.Format = "N2";
            dataGridView1.Columns["Price"].DefaultCellStyle = style;
            dataGridView1.Columns["Price"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            //Set Search Type B Drop
            DataTable dt_SearchTypeB = DataAccess.Get_CatogoryTypeB();
            dt_SearchTypeB = PulicFunction.SetFirstChooseItem("BID", "Des", dt_SearchTypeB);
            cb_Search_TypeB.DisplayMember = "Des";
            cb_Search_TypeB.ValueMember = "BID";
            cb_Search_TypeB.DataSource = dt_SearchTypeB;
            cb_Search_TypeB.DropDownStyle = ComboBoxStyle.DropDownList; //設定不能更改文字

            //Set Search Place B Drop
            DataTable dt_SearchPlaceB = DataAccess.Get_PlaceCatB();
            dt_SearchPlaceB = PulicFunction.SetFirstChooseItem("ID", "Type", dt_SearchPlaceB);
            cb_Search_PlaceB.DisplayMember = "Type";
            cb_Search_PlaceB.ValueMember = "ID";
            cb_Search_PlaceB.DataSource = dt_SearchPlaceB;
            cb_Search_PlaceB.DropDownStyle = ComboBoxStyle.DropDownList; //設定不能更改文字

        }


        private void btn_InputPage_Click(object sender, EventArgs e)
        {
            Form_Input f = new Form_Input();
            this.Visible = false;
            f.Visible = true;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            string startDate= dateTimePicker_searchStart.Value.ToString("yyyy-MM-dd");
            string endDate= dateTimePicker_searchEnd.Value.ToString("yyyy-MM-dd");

            DataTable dt = DataAccess.Get_ExpenseListByDate(startDate, endDate);
            dataGridView1.DataSource = dt;
        }

        private void dateTimePicker_searchStart_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker_searchEnd.Text = dateTimePicker_searchStart.Text;
        }
        private void cb_Search_TypeB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_Search_TypeB.SelectedValue != null)
            {
                string selectBType = cb_Search_TypeB.SelectedValue.ToString();
                if (selectBType != "0" && selectBType != "")
                {
                    DataTable dt_CatogoryTypeS = DataAccess.Get_CatogoryTypeS_FromBType(selectBType);
                    dt_CatogoryTypeS = PulicFunction.SetFirstChooseItem("SID","Des", dt_CatogoryTypeS);
                    cb_Search_TypeS.DisplayMember = "Des";
                    cb_Search_TypeS.ValueMember = "SID";
                    cb_Search_TypeS.DataSource = dt_CatogoryTypeS;
                    cb_Search_TypeS.DropDownStyle = ComboBoxStyle.DropDownList; //設定不能更改文字
                }
                else if (selectBType == "")
                {
                    cb_Search_TypeS.DataSource = null;
                }
            }
        }
        private void cb_Search_PlaceB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_Search_PlaceB.SelectedValue != null)
            {
                string selectBPlace = cb_Search_PlaceB.SelectedValue.ToString();
                if (selectBPlace != "0" && selectBPlace != "")
                {
                    DataTable dt_Search_PlaceS = DataAccess.Get_PlaeceCatS_FromBPlace(selectBPlace);
                    dt_Search_PlaceS = PulicFunction.SetFirstChooseItem("ID", "Des", dt_Search_PlaceS);
                    cb_Search_PlaceS.DisplayMember = "Des";
                    cb_Search_PlaceS.ValueMember = "ID";
                    cb_Search_PlaceS.DataSource = dt_Search_PlaceS;
                    cb_Search_PlaceS.DropDownStyle = ComboBoxStyle.DropDownList; //設定不能更改文字
                }
                else if (selectBPlace == "")
                {
                    cb_Search_PlaceS.DataSource = null;
                }
            }
        }

        private void SearchQueryData()
        {
            string startDate = dateTimePicker_searchStart.Value.ToString("yyyy-MM-dd");
            string endDate = dateTimePicker_searchEnd.Value.ToString("yyyy-MM-dd");

            string TypeB= cb_Search_TypeB.SelectedValue != null ? cb_Search_TypeB.SelectedValue.ToString() : "";
            string TypeS = cb_Search_TypeS.SelectedValue != null ? cb_Search_TypeS.SelectedValue.ToString() : "";

            string PlaceB = cb_Search_PlaceB.SelectedValue != null ? cb_Search_PlaceB.SelectedValue.ToString() : "";
            string PlaceS = cb_Search_PlaceS.SelectedValue != null ? cb_Search_PlaceS.SelectedValue.ToString() : "";

            //Get_ExpenseListByDate
        }




        private void SearchQueryData(object sender, EventArgs e)
        {
            SearchQueryData();
        }
    }
}
