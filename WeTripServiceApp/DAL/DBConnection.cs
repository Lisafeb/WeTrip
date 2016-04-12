using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WeTripServiceApp.DAL
{
    public class DBConnection : IDBConnection
    {
        private static SqlConnection myConnection = new SqlConnection("user id=dmai0914_2Sem_1;" +
                                 "password=Password1!;server=kraka.ucn.dk;" +
                                 "Trusted_Connection=yes;" +
                                 "database=dbo; " +
                                 "connection timeout=30");

        private static DBConnection instance = null;
        private DBConnection()
        {

        }
        public static DBConnection getInstance()
        {
            if (instance == null)
            {
                instance = new DBConnection();
                return instance;
            }
            else
            {
                return instance;
            }
        }
        public static SqlConnection getConnection()
        {

            return myConnection;
        }
    }
}
    
        
    