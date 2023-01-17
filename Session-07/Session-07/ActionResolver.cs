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
                default: result = "4";
                    break;
            }

            return result;
        }

        public string AnswerConvert(string test)
        {
            int num = Convert.ToInt32(test);
            string result = "";
            while (num > 1)
            {
                int remainder = num % 2;
                result = Convert.ToString(remainder) + result;
                num = num / 2;
            }
            result = Convert.ToString(num) + result;
            return result;
        }

        public string AnswerUppercase(string test)
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

        public string AnswerReverse(string test)
        {
            char[] result = test.ToCharArray();
            Array.Reverse(result);
            return new string(result);
        }
    }
}
