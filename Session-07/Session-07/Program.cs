using Session_07;

DateTime res = DateTime.Now;
Message temp = new Message("asdasd");
MessageLogger temp1 = new MessageLogger();
Console.WriteLine((temp.ID, temp.TimeStamp, temp.Text));
Console.WriteLine(temp1.ReadAll());
