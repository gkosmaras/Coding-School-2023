using Session_10.Libraries;
using System.Data;

namespace Session_10
{
    public partial class Form1 : Form
    {
        Filler filler = new Filler();
        University university = new University();
        Serializer serializer = new Serializer();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Populate();

        }
        private void btnLoader(object sender, EventArgs e)
        {
            university = serializer.Deserialize<University>("test.json");
            Show(university);
        }
        private void btnSaver(object sender, EventArgs e)
        {
            university = filler.Populate();
            serializer.SerializeToFile(university, "test.json");
        }

        public void Populate()
        {
            university = filler.Populate();
            Show(university);
        }
        public void Show(University university)
        {
            grvStudents.DataSource = university.Students;
            grvCourses.DataSource = university.Courses;
            grvGrades.DataSource = university.Grades;
            grvSchedules.DataSource = university.Schedules;
        }


    }
}