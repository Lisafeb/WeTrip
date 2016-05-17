using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WeTripServiceApp.DAL;
using WeTripServiceApp.MODEL;

namespace WeTripServiceApp.BLL
{
    public class DestinationCtr
    {
        public DestinationCtr()
            {
            }
        public int insertDestination(string destination, string stops, int? tripId)
        {
            Destination d = new Destination(null,destination,stops,tripId);
            IDBDestination db = new DBDestination();
            int result = -1;
            result = db.insertDestination(d);
            return result;
        }
    }
}