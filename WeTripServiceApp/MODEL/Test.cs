using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WeTripServiceApp.MODEL
{
    public class Test
    {
       
        
        public void insertSomething()
        {
            SqlConnection myConnection = new SqlConnection("user id=dmai0914_2Sem_1;" +
                                  "password=Password1!;server=kraka.ucn.dk;" +
                                  "Trusted_Connection=yes;" +
                                  "database=dbo; " +
                                  "connection timeout=30");

            try
            {
                using (myConnection)
                {
                    SqlCommand myCommand = new SqlCommand("INSERT INTO testTable VALUES (134)", myConnection);
                }
            }
            catch (Exception)
            {

                throw ;
            }

        }
    }
}