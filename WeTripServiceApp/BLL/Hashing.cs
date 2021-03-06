﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BCrypt.Net;
namespace WeTripServiceApp.BLL
{
    public class Hashing
    {
        
        public static string GetRandomSalt()
        {
            return BCrypt.Net.BCrypt.GenerateSalt(6);
        }

        public static string HashPassword(string password, string salt)
        {   
            return BCrypt.Net.BCrypt.HashPassword(password, salt);
        }

        public static bool ValidatePassword(string password, string correctHash)

        {
            try
            {
                return BCrypt.Net.BCrypt.CheckPassword(password, correctHash);
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}