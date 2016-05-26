using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using WeTripServiceApp.MODEL;
using WeTripServiceApp.BLL;

namespace WeTripServiceApp.DAL
{
    public class DBParticipant : IDBParticipant
    {
       
        private static SqlParameter param_accountId = new SqlParameter("@accountId", System.Data.SqlDbType.Int);
        private static SqlParameter param_tripId = new SqlParameter("@tripId", System.Data.SqlDbType.Int);
       

        public DBParticipant()
        {
            
        }
        public int insertParticipant(Participant participant)
        {
            int result = -1;
            string sqlQuery = "INSERT INTO Participants  OUTPUT inserted.id VALUES (" +
                "@accountId, " +
                "@tripId " +
                ")";
            
            SqlConnection sqlCon = new SqlConnection("Data Source = kraka.ucn.dk; Persist Security Info = True; User ID = dmai0914_2Sem_1; Password = Password1!");

            using (sqlCon)
            {
                SqlCommand sqlCommand = new SqlCommand(sqlQuery, sqlCon);
                

                sqlCommand.Parameters.Clear();

                param_accountId.Value = participant.accountId;
                sqlCommand.Parameters.Add(param_accountId);

                param_tripId.Value = participant.tripId;
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

               


                sqlCommand.Parameters.Clear();


            }

            return result;
        }
      
     
    }
}