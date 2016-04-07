using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WeTripServiceApp
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {

        public void insertSomething()
        {
            SqlConnection myConnection = new SqlConnection("Data Source = kraka.ucn.dk; Persist Security Info = True; User ID = dmai0914_2Sem_1; Password = Password1!");
            
            try
            {
                using (myConnection)
                {
                    myConnection.Open();
                    SqlCommand myCommand = new SqlCommand("INSERT INTO testTable VALUES (134)", myConnection);
                    myCommand.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                
                throw;
            }

        }

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
