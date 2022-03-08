using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    public class MessageLogger
    {
        public Message[] Messages { get; set; }

        public Message[] ReadAll()
        {
            return Messages;
        }
        public void  Clear()
        {
            for (int i = 0; i < Messages.Length; i++)
            {

            }
        }
        public void Write(Message) { 

        }

    }

    
}
