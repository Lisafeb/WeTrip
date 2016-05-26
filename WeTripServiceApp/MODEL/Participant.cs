using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeTripServiceApp.MODEL
{
    public class Participant
    {
        private int? _id;
        private int? _accountId;
        private int? _tripId;
       


        public Participant(int? id, int? accountId, int? tripId)
        {
            this.id = id;
            this.accountId = accountId;
            this.tripId = tripId;
            

        }

        public int? id
        {
            get { return _id; }
            set { _id = value; }
        }



        public int? accountId
        {
            get { return _accountId; }
            set { _accountId = value; }
        }



        public int? tripId
        {
            get { return _tripId; }
            set { _tripId = value; }
        }

    }
}