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
    public partial class ViewAccount : System.Web.UI.Page
    {
        WeTripServiceApp.BLL.AccountCtr b = new AccountCtr();
        string userName = "";
        
        protected void Page_Load(object sender, EventArgs e)
        {
            string email="";
            if (!this.Page.User.Identity.IsAuthenticated)
            {
                FormsAuthentication.RedirectToLoginPage();
                
                


            }
            if (!IsPostBack)
            {
                userName = Page.User.Identity.Name;
                userNameLabel.Text = userName;
                userNamefield.Text = userName;

                emailLabel.Text = b.getAccountByUsername(userName).email;
                emailField.Text = b.getAccountByUsername(userName).email;

            }
        }

        protected void updateButton_Click(object sender, EventArgs e)
        {
            userName = Page.User.Identity.Name;
            string newUserName = userNamefield.Text;
                string newEmail = emailField.Text;
            Label1.Text = userName;
                b.updateEmailAndUserName(userName, newUserName, newEmail);
            

        }

        protected void ChangePassword1_ChangedPassword(object sender, EventArgs e)
        {

        }
    }
}