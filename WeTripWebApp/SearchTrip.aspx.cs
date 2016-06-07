using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WeTripWebApp
{
    public partial class SearchTrip : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ViewButton_Click(object sender, EventArgs e)
        {
            string part = ListBox1.SelectedValue;
            int id = Convert.ToInt32(part);
            Session["id"] = id;
            Session["onSearchPage"] = true;
            Server.Transfer("~/ViewTrip.aspx", true);

        }
    }
}