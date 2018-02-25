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
    }
}
