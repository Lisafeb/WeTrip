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
    public partial class Test : System.Web.UI.Page
    {
        public int id;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.Page.User.Identity.IsAuthenticated)
            {
                FormsAuthentication.RedirectToLoginPage();


            }
            else {
                AccountCtr a = new AccountCtr();

                if (!IsPostBack)
                {
                    int? id = a.getAccountByUsername(Page.User.Identity.Name).id;
                    Label1.Text = id.ToString();
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            string part = DropDownList1.SelectedValue;
            id = Convert.ToInt32(part);
            Session["id"] = id;
            Session["onTestPage"] = true;
            Server.Transfer("~/ViewTrip.aspx", true);
            
            
        }
    }
}