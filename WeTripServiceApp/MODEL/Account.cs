using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeTripServiceApp.MODEL
{
    public class Account
    {
        private int? _id;
        private string _userName;
        private string _email;
        private string _hashedPassword;
        private string _salt;

        public Account(int? id, string userName, string email, string hashedPassword, string salt)
        {
            this.id = id;
            this.userName = userName;
            this.email = email;
            this.hashedPassword = hashedPassword;
            this.salt = salt;
        }

        public int? id
        {
            get { return _id; }
            set { _id = value; }
        }



        public string userName
        {
            get { return _userName; }
            set { _userName = value; }
        }



        public string email
        {
            get { return _email; }
            set { _email = value; }
        }



        public string hashedPassword
        {
            get { return _hashedPassword; }
            set { _hashedPassword = value; }
        }


        public string salt
        {
            get { return _salt; }
            set { _salt = value; }
        }


    }
}