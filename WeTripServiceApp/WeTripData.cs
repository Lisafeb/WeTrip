using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeTripServiceApp
{

        [DataContract]
        public class WeTripData
        {
            public WeTripData()
            {
                Name = "WeTrip ";
                SayHello = false;
            }

            [DataMember]
            public bool SayHello { get; set; }

            [DataMember]
            public string Name { get; set; }
        }
    }
}