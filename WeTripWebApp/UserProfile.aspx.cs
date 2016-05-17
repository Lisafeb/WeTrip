using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WeTripWebApp
{
    public partial class UserProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonUpdateProfile_Click(object sender, EventArgs e)
        {
            WeTripServiceApp.BLL.ProfileCtr profile = new WeTripServiceApp.BLL.ProfileCtr();
        }
    }
}