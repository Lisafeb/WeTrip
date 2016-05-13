using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;


namespace WeTripWebApp
{
    public partial class LogIn : System.Web.UI.Page
    {
        
       

        protected void Page_Load(object sender, EventArgs e)
        {
       
        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {

            WeTripServiceApp.BLL.AccountCtr b = new WeTripServiceApp.BLL.AccountCtr();
            int result = b.verifyAccount(Login1.UserName,Login1.Password);
           // UserName.Text = result.ToString();
            
            if(result==1)
                FormsAuthentication.RedirectFromLoginPage(Login1.UserName, Login1.RememberMeSet);
        }
    }
}