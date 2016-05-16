using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WeTripServiceApp.MODEL;

namespace WeTripServiceApp.DAL
{
    interface IDBProfile
    {
        int UpdateProfile(Profile profile);
           
    }
}