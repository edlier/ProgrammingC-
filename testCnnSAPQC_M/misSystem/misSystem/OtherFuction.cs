using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Web.UI.WebControls;
namespace misSystem
{
    public class OtherFuction
    {
        public void BindDataToDrop(DataView dv, DropDownList drop)
        {
            drop.DataSource = dv;
            drop.DataBind();
            drop.Items.Insert(0, "Choose...");
        }
        public void BindDataToDrop(DataTable dv, DropDownList drop)
        {
            drop.Items.Insert(0, "Choose...");
            drop.DataSource = dv;
            drop.DataBind();

        }
    }
}