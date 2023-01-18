using System;
using System.Xml;
using Session_I;

namespace Session_I
{
    public enum Picker
    {
        Dollar,
        Yuan,
        Pound
    }
    public class Resolver
    {
        public MsgLogger Logger { get; set; }
        public Resolver()
        {
            Logger = new MsgLogger();
        }
        public Response Execute(Request request)
        {
            Response response = new Response();
            response.ResponseID = Guid.NewGuid();
            response.RequestID = request.RequestID;
            response.Output = Checker(request.RequestID, request.Input, request.Action);
            LogEventMessage(request.RequestID, request.Input, response.Output, request.Action, DateTime.Now);
            return response;

        }
        public string Checker(Guid requestID, string input, Picker action)
        {
            int result;
            string output;
            if (input == null)
            {
                throw new ArgumentNullException("Input cannot be null!");
            }
            if(Int32.TryParse(input, out result));
            {
                output = Calculator(result, action);
            }
            return output;
        }
        public string Calculator(int result, Picker action)
        {
            switch (action)
            {
                case Picker.Yuan:
                    result = result * 7;
                    break;
                case Picker.Pound:
                    result = (int)(result * 0.8);
                    break;
                case Picker.Dollar:
                    result = (int)(result * 1.3);
                    break;
                default:
                    break;
            }
            return result.ToString();
            
        }
        public override void LogEventMessage(string description, DateTime timeStamp)
        {
            Logger.Write(new Snippet()
            {
                Text = description,
                TimeStamp = timeStamp
            });
        }
        public override void LogEventMessage(Guid requestID, string requestIn, string requestOut, Picker action, DateTime timeStamp)
        {
            Logger.Write(new Snippet()
            {
                Text = $"{requestID} : Going {action} on: '{requestIn}'. Result: '{requestOut}' .",
                TimeStamp = timeStamp
            });
        }
    }
}
