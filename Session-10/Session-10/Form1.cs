using Session_10.Libraries;

namespace Session_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            University university = new University()
            {
                Name = "UoC",
                YearsInService = 44
            };
            Student student = new Student()
            {
                Name = "Giorgos Kosmaras",
                Age = 26,
                RegistrationNumber = 1,
            };
            university.Students.Add(student);
            Student student1 = new Student()
            {
                Name = "Giorgos2 Kosmaras2",
                Age = 262,
                RegistrationNumber = 2,
            };
            university.Students.Add(student1);
            grvStudents.DataSource = university.Students;
        }

    }
}