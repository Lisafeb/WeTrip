using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WeTripServiceApp.MODEL;

namespace WeTripServiceApp.DAL
{
    interface IDBProfile
    {
        int insertProfile(Profile profile);

        int getProfile(int id);
        Profile getProfileByIdOfCreator(int id);

        int updateProfile(int id, int age, decimal budget, string country, string bio);


    }
}