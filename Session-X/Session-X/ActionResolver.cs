using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_X
{
    public enum ActionEnum
    {
        Convert,
        Uppercase,
        Reverse
    }

    public class ActionResolver
    {
        public MessageLogger Logger { get; set; }
        public ActionResolver()
        {
            Logger = new MessageLogger();
        }

        public ActionResponse Execute(ActionRequest request)
        {
            ActionResponse response = new ActionResponse();
            response.ResponseID = Guid.NewGuid();
            response.RequestID = request.RequestID;
            Log("Execution start");

            try
            {
                switch (request.Action)
                {
                    case ActionEnum.Convert:
                        Log("Convertion");
                        response.Output = Convert(request.Input);
                        break;
                    case ActionEnum.Uppercase:
                        Log("Capitalization");
                        response.Output = Uppercase(request.Input);
                        break;
                    case ActionEnum.Reverse:
                        Log("Reversal");
                        response.Output = Reverse(request.Input);
                        break;
                    default:
                        // TODO Error message
                        break;
                }
            }
            catch (Exception ex)
            {
                Log(ex.Message);
            }
            finally
            {
                Log("Execution end");
            }
            return response;
        }

        private void Log(string text)
        {
            Logger.Write(new Message("-------"));
            Logger.Write(new Message(text));
        }
        public string Convert(string input)
        {
            StringConvert convert= new StringConvert();
            convert.Text = input;
            return convert.Manipulate();
        }
        public string Uppercase(string input)
        {
            StringUpper uppercase = new StringUpper();
            uppercase.Text = input;
            return input.ToUpper();
        }
        public string Reverse(string input)
        {
            StringReverse reverse = new StringReverse();
            reverse.Text = input;
            return reverse.Manipulate();
        }
    }
}
