﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WeTripWebApp
{
    public partial class InsertTrip : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        

        protected void ButtonSaveTrip_Click(object sender, EventArgs e)
        {
            WeTripServiceApp.BLL.TripCtr trip = new WeTripServiceApp.BLL.TripCtr();
            string title = TripName.Text;
            int length = Convert.ToInt32(TripDuration.Text);
            DateTime date = Convert.ToDateTime(datepicker.Text);
            string budget = TripBudget.Text;
            int maxNrOfParticipants = Convert.ToInt32(TripParticipants.Text);
            string extraInfo = TripDestination.Text;
             creatorid = Page.User.Identity.Name;
            int b = trip.insertTrip(title, length, date, budget, maxNrOfParticipants, extraInfo, true, null);
        }

        protected void datepicker_TextChanged(object sender, EventArgs e)
        {

        }
    }
}