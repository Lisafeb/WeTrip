using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeTripServiceApp.MODEL
{
    public class Destination
    {
        private int? _id;
        private string _destination;
        private string _stops;
        private int? _tripId;


        public Destination(int? id, string destination, string stops, int? tripId)
        {
            this.id = id;
            this.destination = destination;
            this.stops = stops;
            this.tripId = tripId;
           
        }

        public int? id
        {
            get { return _id; }
            set { _id = value; }
        }



        public string destination
        {
            get { return _destination; }
            set { _destination = value; }
        }



        public string stops
        {
            get { return _stops; }
            set { _stops = value; }
        }



        public int? tripId
        {
            get { return _tripId; }
            set { _tripId = value; }
        }


        


    }
}