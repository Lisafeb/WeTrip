using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WeTripServiceApp.MODEL;
using WeTripServiceApp.DAL;
using WeTripServiceApp.BLL;

namespace WeTripWebApp
{
    public partial class ViewProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            AccountCtr a = new AccountCtr();
            int? id = a.getAccountByUsername(Page.User.Identity.Name).id;
            ProfileCtr p = new ProfileCtr();
            Profile pm = p.getProfileByIdOfCreator((int)id);

            if (!IsPostBack)
            {
                LabelId.Text = pm.id.ToString();
                if (pm.gender == false)
                {
                    LabelGender.Text = "Male";
                }
                else
                {
                    LabelGender.Text = "Female";
                }
                LabelAge.Text = pm.age.ToString();
                LabelBudget.Text = pm.budget.ToString();
                TextBoxBudget.Text = pm.budget.ToString();
                LabelCountry.Text = pm.country;
                TextBoxCountry.Text = pm.country;
                LabelBio.Text = pm.bio;
                TextBoxBio.Text = pm.bio;
                LabelRating.Text = pm.rating.ToString();
            }




        }

        protected void SaveButton_Click(object sender, EventArgs e)
        {
            AccountCtr a = new AccountCtr();
            int? id = a.getAccountByUsername(Page.User.Identity.Name).id;
            ProfileCtr p = new ProfileCtr();
            Profile pm = p.getProfileByIdOfCreator((int)id);
            int idt = (int)pm.id;
            
                int age = Convert.ToInt32(DropDownListAge.SelectedValue);
            string budgets = TextBoxBudget.Text;
                decimal budget = Convert.ToDecimal(budgets);
                string bio = TextBoxBio.Text;
                string country = TextBoxCountry.Text;

                int result = p.updateProfile(idt, age, budget, country, bio);
                if (result != 0)
                {
                    Label1.Text = "Profile updated";
                Response.Redirect("~/ViewProfile.aspx");
                }
                else
                {
                    Label1.Text = "Profile not updated";
                }
            



            
           
        }
    }
}