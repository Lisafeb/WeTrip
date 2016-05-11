using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WeTripServiceApp.BLL;
using WeTripServiceApp.DAL;
using WeTripServiceApp.MODEL;

namespace WeTripServiceApp
{
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {

        public int insertSomething(string input)
        {
            AccountCtr accountCtr = new AccountCtr();
            IDBAccount _dbAccount = new DBAccount();
            return accountCtr.insertAccount("Monika", "mwmwmw25@gmail.com", "blabla");
       //     return _dbAccount.userNameIsTaken(input);




        }

        public int insertTripTest()
        {
            TripCtr tripCtr = new TripCtr();
            return tripCtr.insertTrip("title 1", 2, new DateTime(2016,5,2,14,27,00,00), "20000", 20, "bla bla", true, 1);
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
