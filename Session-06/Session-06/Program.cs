using Students;
using System.Net.Cache;
using Uni;

namespace Session_06
{
    public class Program
    {
        private static void Main(string[] args)
        {
            /*Student[] Students = new Student[2];
            Student temp = new Student(Guid.NewGuid(), "Test_Name", 12, 99);
            Student temp1 = new Student(Guid.NewGuid(), "Name_Test", 21, 88);
            Students[0] = temp;
            Students[1] = temp1;
            Console.WriteLine((Students[0].ID, Students[0].Name, Students[0].Age));
            Console.WriteLine((Students[1].ID, Students[1].Name, Students[1].Age));
            Console.ReadLine();*/
            
            
/*            Student test = new Student()
            {
                ID = Guid.NewGuid(),
                Name = "test+test",
                Age = 12
            };
            Console.WriteLine((test.ID, test.Name, test.Age));*/
            University uni = new University();
            
            
            for (int i =0; i < uni.Students.Length; i++)
            {
                try
                {

                    if (uni.Students[i] != null)
                    {
                        Console.WriteLine(uni.Students[0].Name);
                    }
                    else
                    {
                        Console.WriteLine("We don't have any students");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("----------");
                }
            }

    }
    }
}
