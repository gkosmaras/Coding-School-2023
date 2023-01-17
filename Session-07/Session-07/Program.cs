using Session_07;

DateTime res = DateTime.Now;
Message temp = new Message("asdasd");
MessageLogger temp1 = new MessageLogger();
Console.WriteLine((temp.ID, temp.TimeStamp, temp.Text));
ActionResolver test = new ActionResolver();
Console.WriteLine(test.Resolve(ActionEnum.Reverse, "despite"));