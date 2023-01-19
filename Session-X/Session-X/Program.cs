using Session_X;

ActionRequest request = new ActionRequest()
{
    Input = "Giorgos",
    Action = ActionEnum.Uppercase
};

ActionResponse response = new ActionResponse();
ActionResolver resolver= new ActionResolver();
response = resolver.Execute(request);

Console.WriteLine(response.Output);
resolver.Logger.ReadAll();
Console.ReadLine();
