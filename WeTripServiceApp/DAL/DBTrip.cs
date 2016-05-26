using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WeTripServiceApp.MODEL;

namespace WeTripServiceApp.DAL
{
    public class DBTrip : IDBTrip
    {
        private static SqlParameter param_title = new SqlParameter("@title", System.Data.SqlDbType.VarChar, 50);
        private static SqlParameter param_length = new SqlParameter("@length", System.Data.SqlDbType.Int);
        private static SqlParameter param_date = new SqlParameter("@date", System.Data.SqlDbType.DateTime);
        private static SqlParameter param_budget = new SqlParameter("@budget", System.Data.SqlDbType.VarChar, 20);
        private static SqlParameter param_maxNrOfParticipants = new SqlParameter("@maxNrOfParticipants", System.Data.SqlDbType.Int);
        private static SqlParameter param_extraInfo = new SqlParameter("@extraInfo", System.Data.SqlDbType.VarChar, 200);
        private static SqlParameter param_active = new SqlParameter("@active", System.Data.SqlDbType.Bit);
        private static SqlParameter param_creatorId = new SqlParameter("@creatorId", System.Data.SqlDbType.Int);

        public DBTrip()
            {
            }
        public int insertTrip(Trip trip)
        {
            int result = -1;
            string sqlQuery = "INSERT INTO Trips  OUTPUT inserted.id VALUES (" +
                "@title, " +
                "@length, " +
                "@date, " +
                "@budget, " +
                "@maxNrOfParticipants, " +
                "@extraInfo, " +
                "@active, " +
                "@creatorId " +
                ")";
            
            SqlConnection sqlCon = new SqlConnection("Data Source = kraka.ucn.dk; Persist Security Info = True; User ID = dmai0914_2Sem_1; Password = Password1!");

            using (sqlCon)
            {
                SqlCommand sqlCommand = new SqlCommand(sqlQuery, sqlCon);
                

                sqlCommand.Parameters.Clear();

                param_title.Value = trip.title;
                sqlCommand.Parameters.Add(param_title);

                param_length.Value = trip.length;
                sqlCommand.Parameters.Add(param_length);

                param_date.Value = trip.date;
                sqlCommand.Parameters.Add(param_date);

                param_budget.Value = trip.budget;
                sqlCommand.Parameters.Add(param_budget);

                param_maxNrOfParticipants.Value = trip.maxNrOfParticipants;
                sqlCommand.Parameters.Add(param_maxNrOfParticipants);

                param_extraInfo.Value = trip.extraInfo;
                sqlCommand.Parameters.Add(param_extraInfo);

                param_active.Value = trip.active;
                sqlCommand.Parameters.Add(param_active);

                param_creatorId.Value = trip.creatorId;
                sqlCommand.Parameters.Add(param_creatorId);

                sqlCommand.Connection.Open();
                
                    result = (int)sqlCommand.ExecuteScalar();

                sqlCommand.Parameters.Clear();



                sqlCommand.Connection.Close();

                


            }

            return result;
        }
        public Trip getTripeById(int id)
        {

            Trip trip = null;
            SqlConnection sqlCon = new SqlConnection("Data Source = kraka.ucn.dk; Persist Security Info = True; User ID = dmai0914_2Sem_1; Password = Password1!");
            string sqlQuery = "select * from Trips  where id='" + id + "'";
            using (sqlCon)
            {
                SqlCommand command = new SqlCommand(sqlQuery, sqlCon);
                command.Connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    trip = new Trip(reader.GetInt32(0),reader.GetString(1),reader.GetInt32(2),reader.GetDateTime(3),reader.GetString(4),reader.GetInt32(5),reader.GetString(6),reader.GetBoolean(7),reader.GetInt32(8));
                }
                return trip;
            }
        }

    }
}