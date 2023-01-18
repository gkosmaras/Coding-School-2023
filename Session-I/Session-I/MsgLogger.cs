namespace Session_I
{
    public class Snippet
    {
        public Guid ID { get; set; }
        public DateTime TimeStamp { get; set; }
        public string Text { get; set; }
        public Snippet()
        {
            ID = Guid.NewGuid();
        }
        public Snippet(string text)
        {
            ID = new Guid(text);
            TimeStamp = DateTime.Now;
            Text = text;
        }
    }
    public class MsgLogger
    {
        public Snippet[] Messages { get; set; }
        private int _cnt = 0;
        public MsgLogger()
        {
            Messages = new Snippet[1000];
        }
        public void ReadAll()
        {
            foreach (Snippet message in Messages)
            {
                if (message != null)
                {
                    Console.WriteLine(message.Text);
                }
            }
        }
        public void Clear()
        {
            Messages = new Snippet[1000];
            _cnt = 0;
        }
        public void Write(Snippet message)
        {
            Messages[_cnt] = message;
            _cnt++;
        }
    }
}

