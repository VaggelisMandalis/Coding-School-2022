using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    public class ActionRequest
    {
        public Guid ReqiestID { get; set; }
        public string Input { get; set; }
        public enum ActionEnum
        {
            Convert,
            Uppercase,
            Reverse

        }
    }

}
