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
    public partial class config_PlaceList : Form
    {
        private DataAccess DataAccess = new DataAccess();
        public config_PlaceList()
        {
            InitializeComponent();
        }

        private void btn_InputPage_Click(object sender, EventArgs e)
        {
            Form_Input f = new Form_Input();
            this.Visible = false;
            f.Visible = true;
        }

        private void config_PlaceList_Load(object sender, EventArgs e)
        {
            //LOAD Place B DATA

            DataTable dt_PlaceCatB = DataAccess.Get_PlaceCatB();
            dgv_PlaceB.DataSource = dt_PlaceCatB;
        }

        private void dgv_PlaceB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // If click edit
            if (e.ColumnIndex == dgv_PlaceB.Columns["btn_Edit"].Index)
            {
                string str_ypeText = dgv_PlaceB.Rows[e.RowIndex].Cells["Type"].Value.ToString();
                btn_AddPlaceB.Text = "Edit";
                btn_EditPlaceB_Cancel.Visible = true;
                tb_insertPlaceB.Text = str_ypeText;
            }
            else if (e.ColumnIndex == dgv_PlaceB.Columns["btn_Delete"].Index)
            {
                string str_ypeText = dgv_PlaceB.Rows[e.RowIndex].Cells["Type"].Value.ToString();

            }
        }

        private void btn_AddPlaceB_Click(object sender, EventArgs e)
        {
            if (btn_AddPlaceB.Text == "Edit")
            {
                //Check For Dulplicate

                //Add in DB

                //Rebind List
                DataTable dt_PlaceCatB = DataAccess.Get_PlaceCatB();
                dgv_PlaceB.DataSource = dt_PlaceCatB;
            }

        }
    }
}
