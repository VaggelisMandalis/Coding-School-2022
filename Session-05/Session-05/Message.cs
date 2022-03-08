using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    public class Message
    {
        public Guid ID { get; set; }
        public DateTime TimeStamp { get; set; }
        public string _Message { get; set; }
        public Message(Guid id, DateTime timeStamp, string message)
        {
            ID = id;
            TimeStamp = timeStamp;
            _Message = message;
        }


    }
}
