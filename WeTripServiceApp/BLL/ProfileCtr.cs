using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WeTripServiceApp.DAL;
using WeTripServiceApp.MODEL;
using System.ServiceModel;
using System.ServiceModel;

namespace WeTripServiceApp.BLL
{
    [ServiceContract]
    public class ProfileCtr
    {
        IDBProfile dbProfile = new DBProfile();

        public ProfileCtr()
        {

        }
        [OperationContract]
        public int insertProfile( bool gender, int age, decimal budget, string country, string bio, int rating, int creatorId)
        {
            Profile profile = new Profile(null, gender, age, budget, country, bio, rating, creatorId);
            return dbProfile.insertProfile(profile);
        }
        public int getProfile(int id)
        {
            return dbProfile.getProfile(id);
        }

        public int updateProfile(int id, int age, decimal budget, string country, string bio)
        {
            return dbProfile.updateProfile(id, age, budget, country, bio);        }

        public Profile getProfileByIdOfCreator(int id)
        {
            return dbProfile.getProfileByIdOfCreator(id);
        }
    }
}