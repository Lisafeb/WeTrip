using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WeTripWebApp
{
    public partial class SignUp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void signUpButton_Click(object sender, EventArgs e)
        {
            WeTripServiceApp.BLL.AccountCtr b = new WeTripServiceApp.BLL.AccountCtr();
            string userName = userNameText.Text;
            string email = emailText.Text;
            string password = passwordText.Text;
            string repeatPassword = repeatPasswordText.Text;
            if (password.Equals(repeatPassword))
                if (password.Length > 5)
                    try
                    {
                        b.insertAccount(userName, email, password);
                        Label1.Text = "account inserted succesfully";
                        Response.Redirect("~/LogIn.aspx");
                    }
                    catch (Exception)
                    {

                        Label1.Text = "account not inserted";
                    }
                    
                else
                    Label1.Text = "password less than 5 characters";
                    
            else
                Label1.Text = "password and repeatPassword not matching";
            Label1.Visible = true;
                    




        }
    }
}