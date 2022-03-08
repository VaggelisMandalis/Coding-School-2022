using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    public class ActionResponse
    {
        public Guid ResponseID { get; set; }
        public string Output { get; set; }
        public Guid RequestID { get; set; }

        public ActionResponse(Guid requestID, Guid responseID, string output)
        {
            RequestID = requestID;
            ResponseID = responseID;
            Output = output;
        }

        


    }
}    
