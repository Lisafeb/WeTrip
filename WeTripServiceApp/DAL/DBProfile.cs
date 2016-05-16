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
        private static SqlParameter param_Id = new SqlParameter("@Id", System.Data.SqlDbType.Int);
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


        public int UpdateProfile(Profile profile)
        {
            int result = -1;
            string sqlQuery = "INSERT INTO Profile  OUTPUT inserted.id VALUES (" +
                "@Id, " +
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

                param_Id.Value = profile.id;
                sqlCommand.Parameters.Add(param_Id);

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
    }
}