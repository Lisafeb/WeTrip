using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;
using WeTripServiceApp.DAL;
using WeTripServiceApp.MODEL;

namespace WeTripServiceApp.BLL
{   [ServiceContract]
    public class TripCtr
    {
        IDBTrip dbTrip = new DBTrip();
        public TripCtr()
        {
        }
        [OperationContract]
        public int insertTrip(string title, int length, DateTime? date, string budget, int maxNrOfParticipants, string extraInfo, bool active, int? creatorId)
        {
            if (length <= 0 || length > 365)
                return -105;
            if (maxNrOfParticipants < 2)
                return -106;
            if (title.Length > 50 || title.Length<5)
                return -107;


            Trip trip = new Trip(null, title, length, date, budget, maxNrOfParticipants, extraInfo, active, creatorId);
            return dbTrip.insertTrip(trip);
        }
        public Trip getTripById(int id)
        {
            return dbTrip.getTripeById(id);
        }
    }
}