using Session_I;

Request request = new Request()
{
    Input = "12",
    Action = Picker.Yuan
};
Response response = new Response();
Resolver resolver = new Resolver();
response = resolver.Execute(request);
Console.Write(response.Output);
Console.ReadLine();
