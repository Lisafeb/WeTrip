﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Security;
using WeTripServiceApp.DAL;
using WeTripServiceApp.MODEL;

namespace WeTripServiceApp.BLL
{
    public class AccountCtr
    {
         IDBAccount dbAccount = new DBAccount();

        public AccountCtr()
        {
            
    }

        public int insertAccount (string userName, string email, string password)
        {
            string salt = Hashing.GetRandomSalt();
            string hashedPassword = Hashing.HashPassword(password, salt);
            
                Account account = new Account(null, userName, email, hashedPassword, salt);
                return dbAccount.insertAccount(account);
        }
        public int verifyAccount (string userName, string password)
        {
            int result = 0;
            string hashedPassword = dbAccount.getHashedPasswordFromAccountOnDatabase(userName);
         
            bool response = Hashing.ValidatePassword(password, hashedPassword);

            if (response)
                result = 1;
            return result;
        }
        public int changePassword(string username, string oldPassword, string newPassword)
        {
            int result = 0;
            if (this.verifyAccount(username, oldPassword)==1)
            {
                result = dbAccount.changePassword(username, oldPassword, newPassword);
            }
            
            return result;
        }
        public Account  getAccountByUsername(string userName)
        {
            return dbAccount.getAccountByUserName(userName);
        }
        public int updateEmailAndUserName(string userName, string newUserName, string newEmail)
        {
            return dbAccount.updateEmailAndUserName(userName, newUserName, newEmail);
        }
        
       
        
    }
}