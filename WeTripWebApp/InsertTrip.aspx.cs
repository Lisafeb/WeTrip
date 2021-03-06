﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using WeTripServiceApp.BLL;

namespace WeTripWebApp
{
    public partial class InsertTrip : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.Page.User.Identity.IsAuthenticated)
            {
                FormsAuthentication.RedirectToLoginPage();
            }
        }

        

        protected void ButtonSaveTrip_Click(object sender, EventArgs e)
        {
            AccountCtr a = new AccountCtr();
            string userName = Page.User.Identity.Name;
            int? creatorId = a.getAccountByUsername(userName).id;
            WeTripServiceApp.BLL.TripCtr trip = new WeTripServiceApp.BLL.TripCtr();
            string title = TripName.Text;
            int length = Convert.ToInt32(TripDuration.Text);
            DateTime date = Convert.ToDateTime(datepicker.Text);
            string budget = TripBudget.Text;
            int maxNrOfParticipants = Convert.ToInt32(TripParticipants.Text);
            string extraInfo = TripDestination.Text;
            //creatorid = Page.User.Identity.Name;

            try
            {  
                int b = trip.insertTrip(title, length, date, budget, maxNrOfParticipants, extraInfo, true, creatorId);
                
            }
            catch (Exception)
            {

                StatusLabel.Text = "Your trip was not successfully inserted";
                
            }
            finally
            {
                StatusLabel.Visible = true;
            }
        }

        protected void datepicker_TextChanged(object sender, EventArgs e)
        {

        }
    }
}