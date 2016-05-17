using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WeTripServiceApp.BLL;

namespace WeTripWebApp
{
    public partial class Test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            AccountCtr a = new AccountCtr();
            

            int? id = a.getAccountByUsername(Page.User.Identity.Name).id;
            Label1.Text = id.ToString();
        }
    }
}