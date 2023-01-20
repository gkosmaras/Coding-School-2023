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
            PopulateStudents();
            PopulateCourses();
        }
        public void PopulateStudents()
        {
            University university = new University();
            Student student1 = new Student()
            {
                Name = "Giorgos1",
                Age = 100,
                RegistrationNumber = 1,
            };

            Student student2 = new Student()
            {
                Name = "Giorgos2",
                Age = 99,
                RegistrationNumber = 2,
            };

            Student student3 = new Student()
            {
                Name = "Giorgos3",
                Age = 98,
                RegistrationNumber = 3,
            };
            university.Students.Add(student1);
            university.Students.Add(student2);
            university.Students.Add(student3);
            grvStudents.DataSource = university.Students;
        }
        public void PopulateCourses()
        {
            University university = new University();
            Course course1 = new Course()
            {
                Code = "NS-101",
                Subject = "Natural Science"
            };
            Course course2 = new Course()
            {
                Code = "LW-101",
                Subject = "Law"
            };
            Course course3 = new Course()
            {
                Code = "MD-101",
                Subject = "Medicine"
            };
            university.Courses.Add(course1);
            university.Courses.Add(course2);
            university.Courses.Add(course3);
            grvCourses.DataSource = university.Courses;
        }

    }
}