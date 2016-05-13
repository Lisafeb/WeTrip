using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeTripServiceApp.MODEL
{
    public class Profile
    {
        private int? _id;
        private bool _gender;
        private int _age;
        private decimal _budget;
        private string _country;
        private string _bio;
        private int _rating;
        private int _creatorId;

        public Profile(int? id, bool gender, int age, decimal budget, string country, string bio, int rating, int creatorId)
        {
            _id = id;
            _gender = gender;
            _age = age;
            _budget = budget;
            _country = country;
            _bio = bio;
            _rating = rating;
            _creatorId = _creatorId;
        }

        public int? id
        {
            get { return _id; }
            set { _id = value; }
        }

        public bool gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        public int age
        {
            get { return _age; }
            set { _age = value; }
        }

        public decimal budget
        {
            get { return _budget; }
            set { _budget = value; }
        }

        public string country
        {
            get { return _country; }
            set { _country = value; }
        }

        public string bio
        {
            get { return _bio; }
            set { _bio = value; }
        }

        public int rating
        {
            get { return _rating; }
            set { _rating = value; }
        }

        public int creatorId
        {
            get { return _creatorId; }
            set { _creatorId = value; }
        }
    }
}