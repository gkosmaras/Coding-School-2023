using Beings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_06
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Student temp = new Student(Guid.NewGuid(), "Test1Name", 32, 12345);
            Console.WriteLine(temp.Name);
            temp.GetName();
        }
    }
}
