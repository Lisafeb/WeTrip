using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using WeTripServiceApp.MODEL;

namespace WeTripServiceApp.DAL
{
    public class DBAccount : IDBAccount
    {
      //  private static SqlParameter param_id = new SqlParameter("@id", System.Data.SqlDbType.Int);
        private static SqlParameter param_userName = new SqlParameter("@userName", System.Data.SqlDbType.VarChar,15);
        private static SqlParameter param_email = new SqlParameter("@email", System.Data.SqlDbType.VarChar,50);
        private static SqlParameter param_hashedPassword = new SqlParameter("@hashedPassword", System.Data.SqlDbType.VarChar,128);
        private static SqlParameter param_salt = new SqlParameter("@salt", System.Data.SqlDbType.VarChar,16);
        

        public DBAccount()
        {

        }
        public int insertAccount(Account account)
        {
            int result =  -1;
            string sqlQuery = "INSERT INTO Accounts  OUTPUT inserted.id VALUES (" +
                "@userName, " +
                "@email, " +
                "@hashedPassword, " +
                "@salt " +
                ")";
            string sqlQuery2 = "SELECT id from Accounts where userName=@userName";
            SqlConnection sqlCon = new SqlConnection("Data Source = kraka.ucn.dk; Persist Security Info = True; User ID = dmai0914_2Sem_1; Password = Password1!");
           
                using (sqlCon)
                {
                    SqlCommand sqlCommand = new SqlCommand(sqlQuery, sqlCon);
                SqlCommand sqlCommand2 = new SqlCommand(sqlQuery2, sqlCon);

                    sqlCommand.Parameters.Clear();

                    param_userName.Value = account.userName;
                    sqlCommand.Parameters.Add(param_userName);

                    param_email.Value = account.email;
                    sqlCommand.Parameters.Add(param_email);

                    param_hashedPassword.Value = account.hashedPassword;
                    sqlCommand.Parameters.Add(param_hashedPassword);

                    param_salt.Value = account.salt;
                    sqlCommand.Parameters.Add(param_salt);

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
        public string getHashedPasswordFromAccountOnDatabase(string userName)
        {
            string result = "not found";

            SqlConnection sqlCon = new SqlConnection("Data Source = kraka.ucn.dk; Persist Security Info = True; User ID = dmai0914_2Sem_1; Password = Password1!");
           
            string sqlQuery = "select * from Accounts where userName='"+userName+"'";
            using (sqlCon)
            {
                SqlCommand command = new SqlCommand(sqlQuery, sqlCon);
                command.Connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                     result = reader.GetString(3);
                }

            }

                return result;
        }
        
       
    }
}