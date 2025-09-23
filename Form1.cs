using AdvancedToDoList;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ToDoList : Form
    {
        DataTable todolist = new DataTable();
        bool isEditing = false;

        public ToDoList()
        {
            InitializeComponent();
        }

        private void ToDoList_Load(object sender, EventArgs e)
        {

        }
        
        private BindingList<TaskItem> tasks = new BindingList<TaskItem>();

        private void Form1_Load(object sender, EventArgs e)
        {
            listBoxTasks.DataSource = tasks;
            listBoxTasks.DisplayMember = "Title";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            TaskForm taskForm = new TaskForm();
            if (taskForm.ShowDialog() == DialogResult.OK)
            {
                tasks.Add(taskForm.Task);
                listBoxTasks.DataSource = null;
                listBoxTasks.DataSource = tasks;
                listBoxTasks.DisplayMember = "Title";
            }
        }
    }
}