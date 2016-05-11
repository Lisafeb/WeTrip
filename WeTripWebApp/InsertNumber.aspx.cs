using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using WeTripServiceApp;


namespace WeTripWebApp
{
    public partial class InsertNumber : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.Page.User.Identity.IsAuthenticated)
            {
                FormsAuthentication.RedirectToLoginPage();
                
                
            }
        }

        protected void testButton_Click(object sender, EventArgs e)
        {

            TestReference.Service1Client client= new TestReference.Service1Client();
            client.insertSomething();
        }
    }
}