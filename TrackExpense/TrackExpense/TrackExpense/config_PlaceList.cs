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
        private PublicFunction PulicFunction = new PublicFunction();

        public config_PlaceList()
        {
            InitializeComponent();
        }
        private void config_PlaceList_Load(object sender, EventArgs e)
        {
            //LOAD Place B DATA
            DataTable dt_PlaceCatB = DataAccess.Get_PlaceCatB();
            dgv_PlaceB.DataSource = dt_PlaceCatB;

            //LOAD Place S DATA
            DataTable dt_PlaceCatS = DataAccess.Get_PlaceCatS();
            dgv_PlaceS.DataSource = dt_PlaceCatS;

            //LOAD Place S Search B Type Option
            DataTable dt_PlaceCats_SearchTypeB = dt_PlaceCatB.Copy();
            cb_SearchPlaceS_BID.DisplayMember = "Type";
            cb_SearchPlaceS_BID.ValueMember = "ID";
            dt_PlaceCats_SearchTypeB=PulicFunction.SetFirstChooseItem("ID","Type", dt_PlaceCats_SearchTypeB);
            cb_SearchPlaceS_BID.DataSource= dt_PlaceCats_SearchTypeB;
            cb_SearchPlaceS_BID.SelectedIndex = 0;
            cb_SearchPlaceS_BID.DropDownStyle = ComboBoxStyle.DropDownList;

            DataTable dt_PlaceCats_EditTypeB = dt_PlaceCatB.Copy();
            cb_EditS_TypeBList.DisplayMember = "Type";
            cb_EditS_TypeBList.ValueMember = "ID";
            dt_PlaceCats_EditTypeB=PulicFunction.SetFirstChooseItem("ID", "Type", dt_PlaceCats_EditTypeB);
            cb_EditS_TypeBList.DataSource = dt_PlaceCats_EditTypeB;
            cb_EditS_TypeBList.SelectedIndex = 0;
            cb_EditS_TypeBList.DropDownStyle = ComboBoxStyle.DropDownList;

        }
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
                if (Check_PlaceTypeB_Dul(str_Place_BType)==true)
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


            if (e.ColumnIndex == dgv_PlaceS.Columns["dg_btn_SEdit"].Index || e.ColumnIndex == dgv_PlaceS.Columns["dg_btn_SDel"].Index)
            {
                DataTable dt_PlaceCatB = DataAccess.Get_PlaceCatB();
                cb_EditS_TypeBList.DataSource = null;

                tb_insertPlaceS.Text = str_PlaceSTypeText;

                //dt_CatPlaceTypeS = SetFirstChooseItem("Des", dt_CatPlaceTypeS);
                cb_EditS_TypeBList.DisplayMember = "Type";
                cb_EditS_TypeBList.ValueMember = "ID";
                dt_PlaceCatB=PulicFunction.SetFirstChooseItem("ID", "Type", dt_PlaceCatB);
                cb_EditS_TypeBList.DataSource = dt_PlaceCatB;
                cb_EditS_TypeBList.SelectedValue = str_PlaceBID;

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
            cb_EditS_TypeBList.SelectedIndex = 0;
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

        
    }
}
