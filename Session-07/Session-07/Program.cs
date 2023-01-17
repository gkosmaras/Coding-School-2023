using Session_07;

internal class Program
{
    private static void Main(string[] args)
    {
        ActionResolver resolver = new ActionResolver();
        ActionResponse response = new ActionResponse();
        ActionRequest temp1 = new ActionRequest() { Input = "Despite the pure rhetoric of the regime", Action = ActionEnum.Uppercase };

        ActionRequest temp2 = new ActionRequest() { Input = "Pallindrome", Action = ActionEnum.Reverse };

        ActionRequest temp3 = new ActionRequest() { Input = "28", Action = ActionEnum.Convert };

/*        string testVar = null;

        ActionRequest testError = new ActionRequest() { Input = testVar, Action = ActionEnum.Uppercase };*/

        response = resolver.Excecute(temp1);
        response = resolver.Excecute(temp2);
        response = resolver.Excecute(temp3);
        //response = resolver.Excecute(testError);

        Console.Write(resolver.Logger.ReadAll());
        Console.ReadLine();



    }
}