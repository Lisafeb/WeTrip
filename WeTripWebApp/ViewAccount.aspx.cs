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
       // WeTripServiceApp.BLL.AccountCtr b = new AccountCtr();
        string userName = "";
        
        protected void Page_Load(object sender, EventArgs e)
        {  WeTripServiceApp.BLL.AccountCtr b = new AccountCtr();
            //  string email="";
            if (!this.Page.User.Identity.IsAuthenticated)
            {
                FormsAuthentication.RedirectToLoginPage();




            }
            else {
                if (!IsPostBack)
                {
                    userName = Page.User.Identity.Name;
                    userNameLabel.Text = userName;
                    userNamefield.Text = userName;

                    emailLabel.Text = b.getAccountByUsername(userName).email;
                    emailField.Text = b.getAccountByUsername(userName).email;

                }
            }
        }

        protected void updateButton_Click(object sender, EventArgs e)
        {    WeTripServiceApp.BLL.AccountCtr b = new AccountCtr();
            userName = Page.User.Identity.Name;
            string newUserName = userNamefield.Text;
                string newEmail = emailField.Text;
            //   Label1.Text = userName;
            if (b.updateEmailAndUserName(userName, newUserName, newEmail)==1)
            {
                FormsAuthentication.RedirectToLoginPage();
            }
            

        }

       

        protected void ChangeButton_Click(object sender, EventArgs e)
        {


            userName = Page.User.Identity.Name;
            WeTripServiceApp.BLL.AccountCtr b = new WeTripServiceApp.BLL.AccountCtr();
            string password = PasswordTextBox.Text;
            string newPassword = NewPasswordTextBox.Text;
            string repeatPassword = RepeatPasswordTextBox.Text;
            int result = b.changePassword(userName, password, newPassword);
            if (result == 0)
            {
                Label1.Text = "The password was not succesfully changed.";
            }
            else
            {
                Label1.Text = "The password was succesfully changed.";
            }
        }

        protected void NewPasswordTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}