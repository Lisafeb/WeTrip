using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeTripServiceApp.MODEL
{
    public class Trip
    {
        private int? _id;
        private string _title;
        private int _length;
        private DateTime? _date;
        private string _budget;
        private int _maxNrOfParticipants;
        private string _extraInfo;
        private bool _active;
        private int? _creatorId;


        public Trip(int? id,string title, int length, DateTime? date, string budget, int maxNrOfParticipants, string extraInfo, bool active, int? creatorId)
        {
            this.id = id;
            this.title = title;
            this.length = length;
            this.date = date;
            this.budget = budget;
            this.maxNrOfParticipants = maxNrOfParticipants;
            this.extraInfo = extraInfo;
            this.active = active;
            this.creatorId = creatorId;
        }

        public int? id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string title
        {
            get { return _title; }
            set { _title = value; }
        }

        public int length
        {
            get { return _length; }
            set { _length = value; }
        }

        public DateTime? date
        {
            get { return _date; }
            set { _date = value; }
        }

        public string budget
        {
            get { return _budget; }
            set { _budget = value; }
        }

        public int maxNrOfParticipants
        {
            get { return _maxNrOfParticipants; }
            set { _maxNrOfParticipants = value; }
        }

        public string extraInfo
        {
            get { return _extraInfo; }
            set { _extraInfo = value; }
        }

        public bool active
        {
            get { return _active; }
            set { _active = value; }
        }

        public int? creatorId
        {
            get { return _creatorId; }
            set { _creatorId = value; }
        }
    }
}