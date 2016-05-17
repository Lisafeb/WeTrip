using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WeTripServiceApp.BLL;

namespace WeTripWebApp
{
    public partial class InsertDestination : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string destination = DestinationTextBox.Text;
            string stops = StopsTextBox.Text;
            DestinationCtr d = new DestinationCtr();
            Label1.Text= d.insertDestination(destination, stops, 1).ToString();
        }
    }
}