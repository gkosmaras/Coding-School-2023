using Students;
namespace Session_06
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Student temp = new Student(Guid.NewGuid(), "Test_Name", 23, 2478543);
            Console.WriteLine(temp.Name);
            temp.GetName();
        }
    }
}
