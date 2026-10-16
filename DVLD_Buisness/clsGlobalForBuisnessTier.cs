using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Buisness
{
    public class clsGlobalForBuisnessTier
    {
        public static void LogInEventLog(string Message, EventLogEntryType type)
        {
            clsGlobalForDataAccessTier.LogInEventLog(Message, type);
        }
    }
}
