using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WeTripServiceApp.DAL;
using WeTripServiceApp.MODEL;

namespace WeTripServiceApp.BLL
{
    public class ParticipantCtr
    {
        IDBParticipant db = new DBParticipant();
        public ParticipantCtr()
            {
            
            }
        public int insertParticipant(int accountId, int tripId)
        {
            Participant p = new Participant(null,accountId,tripId);
            return db.insertParticipant(p);
        }

    }
}