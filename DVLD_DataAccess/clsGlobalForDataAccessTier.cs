using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
namespace DVLD_DataAccess
{
    public class clsGlobalForDataAccessTier
    { 
        public static void LogInEventLog(string Message,EventLogEntryType type)
        {
            string source = "DVLD";
           
            try
            {

                if(!EventLog.SourceExists(source))
                {
                    EventLog.CreateEventSource(source, "Application");
                }
                EventLog.WriteEntry(source, Message, type);


            }
            catch  
            {

            }


        }







    }
}
