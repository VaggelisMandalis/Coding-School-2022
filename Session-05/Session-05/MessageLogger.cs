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

        public void ReadAll()
        {
            Messages = new Message[Messages.Length];
        }
        public void Clear()
        {

        }
        public void Write(Message) { 
        }

    }

    
}
