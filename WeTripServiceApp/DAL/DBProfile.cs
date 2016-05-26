using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WeTripServiceApp.MODEL;
using System.Data.SqlClient;

namespace WeTripServiceApp.DAL
{
    public class DBProfile : IDBProfile
    {
       // private static SqlParameter param_Id = new SqlParameter("@Id", System.Data.SqlDbType.Int);
        private static SqlParameter param_gender = new SqlParameter("@gender", System.Data.SqlDbType.Bit);
        private static SqlParameter param_age = new SqlParameter("@age", System.Data.SqlDbType.Int);
        private static SqlParameter param_budget = new SqlParameter("@budget", System.Data.SqlDbType.Decimal);
        private static SqlParameter param_country = new SqlParameter("@country", System.Data.SqlDbType.VarChar);
        private static SqlParameter param_bio = new SqlParameter("@bio", System.Data.SqlDbType.VarChar);
        private static SqlParameter param_rating = new SqlParameter("@rating", System.Data.SqlDbType.Int);
        private static SqlParameter param_creatorId = new SqlParameter("@creatorId", System.Data.SqlDbType.Int);


        public DBProfile()
        {
        }

        public int updateProfile(int id, int age, decimal budget, string country, string bio)
        {
            int result = -1;

            SqlConnection sqlCon = new SqlConnection("Data Source = kraka.ucn.dk; Persist Security Info = True; User ID = dmai0914_2Sem_1; Password = Password1!");
            string sqlQuery = "update Profiles set age='" + age + "', budget='" + budget + "', country='" + country + "', bio='" + bio + "' where id='" + id + "'";

            using (sqlCon)
            {
                SqlCommand command = new SqlCommand(sqlQuery, sqlCon);
                command.Connection.Open();
                result = command.ExecuteNonQuery();

            }

            return result;
        }

        public int insertProfile(Profile profile)
        {
            int result = -1;
            string sqlQuery = "INSERT INTO Profiles  OUTPUT inserted.id VALUES (" +
                "@gender, " +
                "@age, " +
                "@budget, " +
                "@country, " +
                "@bio, " +
                "@rating, " +
                "@creatorId " +
                ")";

            SqlConnection sqlCon = new SqlConnection("Data Source = kraka.ucn.dk; Persist Security Info = True; User ID = dmai0914_2Sem_1; Password = Password1!");

            using (sqlCon)
            {
                SqlCommand sqlCommand = new SqlCommand(sqlQuery, sqlCon);


                sqlCommand.Parameters.Clear();

              

                param_gender.Value = profile.gender;
                sqlCommand.Parameters.Add(param_gender);

                param_age.Value = profile.age;
                sqlCommand.Parameters.Add(param_age);

                param_budget.Value = profile.budget;
                sqlCommand.Parameters.Add(param_budget);

                param_country.Value = profile.country;
                sqlCommand.Parameters.Add(param_country);

                param_bio.Value = profile.bio;
                sqlCommand.Parameters.Add(param_bio);

                param_rating.Value = profile.rating;
                sqlCommand.Parameters.Add(param_rating);

                param_creatorId.Value = profile.creatorId;
                sqlCommand.Parameters.Add(param_creatorId);

                sqlCommand.Connection.Open();

                result = (int)sqlCommand.ExecuteScalar();

                sqlCommand.Parameters.Clear();



                sqlCommand.Connection.Close();




            }

            return result;
        }
        
        public Profile getProfileByIdOfCreator(int id)
        {

            Profile profile = null; 
            SqlConnection sqlCon = new SqlConnection("Data Source = kraka.ucn.dk; Persist Security Info = True; User ID = dmai0914_2Sem_1; Password = Password1!");
            string sqlQuery = "select * from Profiles  where creatorId='" + id + "'";
            using (sqlCon)
            {
                SqlCommand command = new SqlCommand(sqlQuery, sqlCon);
                command.Connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    profile = new Profile(reader.GetInt32(0), reader.GetBoolean(1), reader.GetInt32(2), reader.GetDecimal(3), reader.GetString(4), reader.GetString(5),reader.GetInt32(6),reader.GetInt32(7));
                }
                return profile;
            }
        }
        public int getProfile(int id)
        {
            int result = -1;
            string sqlQuery = "SELECT * FROM Profiles  WHERE creatorId=" +
                "@creatorId ";
                

            SqlConnection sqlCon = new SqlConnection("Data Source = kraka.ucn.dk; Persist Security Info = True; User ID = dmai0914_2Sem_1; Password = Password1!");

            using (sqlCon)
            {
                SqlCommand sqlCommand = new SqlCommand(sqlQuery, sqlCon);


                sqlCommand.Parameters.Clear();

                

                param_creatorId.Value = id;
                sqlCommand.Parameters.Add(param_creatorId);

                sqlCommand.Connection.Open();

                try
                {
                    result = (int)sqlCommand.ExecuteScalar();
                }
                catch (Exception)
                {

                    result = 0;
                }

                sqlCommand.Parameters.Clear();



                sqlCommand.Connection.Close();




            }

            return result;
        }
    }
}