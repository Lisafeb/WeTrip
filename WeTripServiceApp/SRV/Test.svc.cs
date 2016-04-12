using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WeTripServiceApp.DAL;
using WeTripServiceApp.MODEL;

namespace WeTripServiceApp.SRV
{   [DataContract]
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Test" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Test.svc or Test.svc.cs at the Solution Explorer and start debugging.
    public class Test : ITest
    {
        
        public int DoWork()
        {


            return 1;

        
           
        }
        public int DoWork2()
        {
            return 2;
        }
    }
}
