using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeTripServiceApp.MODEL;

namespace WeTripServiceApp.DAL
{
    interface IDBParticipant
    {
       int insertParticipant(Participant participant);
    }
}
