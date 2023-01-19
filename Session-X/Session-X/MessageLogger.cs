using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_X
{
    public class Message
    {
        public Guid ID { get; set; }
        public DateTime TimeStamp { get; set; }
        public string Text { get; set; }

        public Message()
        {
            ID = Guid.NewGuid();
        }
        public Message(string text)
        {
            ID = Guid.NewGuid();
            TimeStamp= DateTime.Now;
            Text = text;
        }
    }
    public class MessageLogger
    {
        public Message[] Messages { get; set; }
        private int _msgCnt = 0;

        public MessageLogger()
        {
            Messages = new Message[1000];
        }

        public void ReadAll()
        {
            foreach(Message message in Messages)
            {
                if (message != null)
                {
                    Console.WriteLine(message.Text);
                }
            }
        }
        public void Clear()
        {
            Messages = new Message[1000];
            _msgCnt = 0;
        }
        public void Write(Message message)
        {
            Messages[_msgCnt] = message;
            _msgCnt++;
        }
    }
}
