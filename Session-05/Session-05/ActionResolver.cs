using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    public class ActionResolver
    {
        public MessageLogger Logger { get; set; }
        public ActionResolver(MessageLogger log)
        {
            Logger = log;
        }
        public void ActionResolver()
        {
            
        }

        public ActionResolver Execute ( ActionRequest request)
        {
            var response = new ActionResponse();
            return response;
        }

            
    }
}
