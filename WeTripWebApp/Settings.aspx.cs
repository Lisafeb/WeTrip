using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using WeTripServiceApp.BLL;

namespace WeTripWebApp
{
    public partial class Settings : System.Web.UI.Page
    { int? id;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.Page.User.Identity.IsAuthenticated)
            {
                FormsAuthentication.RedirectToLoginPage();


            }
            else
            {
                string userName = Page.User.Identity.Name;
                AccountCtr a = new AccountCtr();
                ProfileCtr p = new ProfileCtr();
                id = a.getAccountByUsername(userName).id;
                if(p.getProfile((int)id)!=0)
                {
                    LinkButton2.Visible = false;
                    ProfileInfoLinkButton.Visible = true;
                    
                }
            }
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {

        }
    }
}