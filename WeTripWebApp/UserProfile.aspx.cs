using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WeTripWebApp
{
    public partial class UserProfile : System.Web.UI.Page
    {
        int id;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.Page.User.Identity.IsAuthenticated)
            {
                FormsAuthentication.RedirectToLoginPage();


            }
            else
            {




                string userName = Page.User.Identity.Name;
                LabelUserName.Text = userName;
                WeTripServiceApp.BLL.AccountCtr a = new WeTripServiceApp.BLL.AccountCtr();
                id = (int)a.getAccountByUsername(userName).id;
            }
        }

        protected void ButtonUpdateProfile_Click(object sender, EventArgs e)
        {
            WeTripServiceApp.BLL.ProfileCtr profile = new WeTripServiceApp.BLL.ProfileCtr();
            bool gender = Convert.ToBoolean(DropDownListGender.SelectedIndex);
            int age = Convert.ToInt16(DropDownListAge.SelectedValue);
            decimal budget = Convert.ToDecimal(TextBoxBudget.Text);
            string country = TextBoxCountry.Text;
            string bio = TextBoxBio.Text;
            int result = profile.insertProfile(gender, age, budget, country, bio, 0, id);
            if (result!=0)
            {
                Label2.Text = "Profile created successfully";
            }
            else
                Label2.Text = "Profile was not created successfully";
        }
    }
}