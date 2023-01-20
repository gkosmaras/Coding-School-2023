using Session_10.Libraries;
using System.Data;

namespace Session_10
{
    public partial class Form1 : Form
    {
        Filler filler = new Filler();
        University university = new University();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Populate();
        }

        public void Populate()
        {
            university = filler.Populate();
            grvStudents.DataSource = university.Students;
            grvCourses.DataSource = university.Courses;
            grvGrades.DataSource = university.Grades;
            grvSchedules.DataSource = university.Schedules;
        }


    }
}