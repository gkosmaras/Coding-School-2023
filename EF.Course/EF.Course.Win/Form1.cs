using EF.Course.Model;
using EF.Course.Orm.Repositories;

namespace EF.Course.Win
{
    public partial class Form1 : Form
    {
        private TodoRepo _todoRepo;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _todoRepo = new TodoRepo();
            RefreshTodos();
        }

        private void button_AddTodo_Click(object sender, EventArgs e)
        {
            var newTodo = new Todo(textbox_todoTitle.Text);
            newTodo.TodoInfo = new TodoInfo();
            newTodo.TodoInfo.StartDate = DateTime.Now;
            _todoRepo.Add(newTodo);
            RefreshTodos();
        }

        private void RefreshTodos()
        {
            TodoGV.DataSource = null;
            TodoGV.DataSource = _todoRepo.GetAll();
            TodoGV.Update();
            TodoGV.Refresh();
            TodoGV.Columns[index: 0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TodoGV.Columns[index: 2].Visible = false;
            TodoGV.Columns[index: 3].Visible = false;
            //TodoGV.Columns[index: 4].Visible = false;
        }
    }
}