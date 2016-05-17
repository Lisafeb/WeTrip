using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WeTripServiceApp.MODEL;

namespace WeTripServiceApp.DAL
{
    public class DBDestination : IDBDestination
    {
        private static SqlParameter param_destination = new SqlParameter("@destination", System.Data.SqlDbType.VarChar, 50);
        private static SqlParameter param_stops = new SqlParameter("@stops", System.Data.SqlDbType.VarChar, 50);
        private static SqlParameter param_tripId = new SqlParameter("@tripId", System.Data.SqlDbType.Int);
        public DBDestination()
        { }
            public int insertDestination(Destination destination)
        {
            int result = -1;
            string sqlQuery = "INSERT INTO Destinations  OUTPUT inserted.id VALUES (" +
                "@destination, " +
                "@stops, " +
                "@tripId " +
                ")";
            //string sqlQuery2 = "SELECT id from Accounts where userName=@userName";
            SqlConnection sqlCon = new SqlConnection("Data Source = kraka.ucn.dk; Persist Security Info = True; User ID = dmai0914_2Sem_1; Password = Password1!");

            using (sqlCon)
            {
                SqlCommand sqlCommand = new SqlCommand(sqlQuery, sqlCon);
              //  SqlCommand sqlCommand2 = new SqlCommand(sqlQuery2, sqlCon);

                sqlCommand.Parameters.Clear();

                param_destination.Value = destination.destination;
                sqlCommand.Parameters.Add(param_destination);

                param_stops.Value = destination.stops;
                sqlCommand.Parameters.Add(param_stops);

                param_tripId.Value = destination.tripId;
                sqlCommand.Parameters.Add(param_tripId);

               
                sqlCommand.Connection.Open();
                try
                {
                    result = (int)sqlCommand.ExecuteScalar();
                }
                catch (System.Data.SqlClient.SqlException)
                {

                    result = -100;
                }
                sqlCommand.Connection.Close();

                //sqlCommand2.Connection.Open();
                //result = (int)sqlCommand2.ExecuteScalar();
                //sqlCommand2.Connection.Close();


                sqlCommand.Parameters.Clear();


            }

            return result;
        }
    }
    }

