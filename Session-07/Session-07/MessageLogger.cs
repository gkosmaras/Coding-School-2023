using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07
{
    public class MessageLogger
    {
        public Message[] Messages { get; }
        public MessageLogger()
        {
            Messages = new Message[1000];
        }
        public string ReadAll()
        {
            string log = String.Empty;

            return log;
        }
        public void Clear()
        {
            Array.Clear(Messages, 0, Messages.Length);
        }
        public void Write()
        {

        }
    }
}
