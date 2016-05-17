using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WeTripServiceApp.BLL;

namespace WeTripWebApp
{
    public partial class CreateUpdateProfile : System.Web.UI.Page
    {
        private AccountCtr a;
        string userName;
        protected void Page_Load(object sender, EventArgs e)
        {
             a = new AccountCtr();
            userName = Page.User.Identity.Name;

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}