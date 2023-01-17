using System.Text.RegularExpressions;

namespace Session_07
{
    public enum ActionEnum
    {
        Convert,
        Uppercase,
        Reverse
    }
    public class ActionResolver
    {
        public string Resolve(ActionEnum task, string test)
        {
            string result = "";
            switch (task)
            {
                case ActionEnum.Convert:
                    result = AnswerConvert(test);
                    break;
                case ActionEnum.Uppercase:
                    result = AnswerUppercase(test);
                    break;
                case ActionEnum.Reverse:
                    result = AnswerReverse(test);
                    break;
                default: result = "Enter a valid action";
                    break;
            }

            return result;
        }

        public string AnswerConvert(string test)
        {
            string result = "";
            if (decimal.TryParse(test.ToString(), out _))
            {
                int num = Convert.ToInt32(test);
                while (num > 1)
                {
                    int remainder = num % 2;
                    result = Convert.ToString(remainder) + result;
                    num = num / 2;
                }
                result = Convert.ToString(num) + result;
                return result;
            }
            else
            {
                result = "Not a decimal";
                return result;
            }

        }

        public string AnswerUppercase(string test)
        {
            if (test.IndexOf(" ") >= 0)
            {
                    string[] words = test.Split(' ');
                    string result = "";
                    foreach (string word in words)
                    {
                        if (word.Length > result.Length)
                        {
                            result = word;
                        }
                    }
                    result = result.ToUpper();
                    return result;
            }
            else
            {
                string result = "Input does not contain whitespaces";
                return result;
            }
        }
        public string AnswerReverse(string test)
        {
            if (Regex.IsMatch(test, "^[A-Za-z ]+$", RegexOptions.IgnoreCase))
            {
                char[] result = test.ToCharArray();
                Array.Reverse(result);
                return new string(result);
            }
            else
            {
                string result = "Not a valid input";
                return result;
            }

        }
    }
}

