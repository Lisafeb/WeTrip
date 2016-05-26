using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WeTripServiceApp.BLL;
using WeTripServiceApp.MODEL;

namespace WeTripWebApp
{
    public partial class ViewTrip : System.Web.UI.Page
    { private int idTripInt;
        private int loggedInt;
        private AccountCtr ac = new AccountCtr();
        private ParticipantCtr pc = new ParticipantCtr();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["onTestPage"]!=null||Session["onSearchPage"]!=null)
            {
                string idTrip = Session["id"].ToString();
                 idTripInt = Convert.ToInt32(idTrip);
                TripCtr tc = new TripCtr();
                Trip trip = tc.getTripById(idTripInt);
                LID.Text = trip.id.ToString();
                LTITLE.Text = trip.title;
                LLENGTH.Text = trip.length.ToString();
                LDATE.Text = trip.date.ToString();
                LBUDGET.Text = trip.budget;
                LPARTICIPANTS.Text = trip.maxNrOfParticipants.ToString();
                LEXTRAINFO.Text = trip.extraInfo;
                if(trip.active)
                {
                    LACTIVE.Text = "Yes";
                }
                else
                {
                    LACTIVE.Text = "No";
                }
                StatusLabel.Visible = false;





            }
            else
            {
                Server.Transfer("~/Test.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            loggedInt = (int)ac.getAccountByUsername(Page.User.Identity.Name).id;
            int result = pc.insertParticipant(loggedInt, idTripInt);
            StatusLabel.Text = "The opperation was not possible";
            if(result>0)
            {
                StatusLabel.Text = "You have successfully joined this trip";
            }
            StatusLabel.Visible = true;
        }
    }
}