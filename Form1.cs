using AdvancedToDoList;
using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ToDoList : Form
    {

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
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            TaskForm taskForm = new TaskForm();
            if (taskForm.ShowDialog() == DialogResult.OK)
            {
                tasks.Add(taskForm.Task);
                listBoxTasks.DataSource = null;
                listBoxTasks.DataSource = tasks;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
          
            TaskItem selectedTask = (TaskItem)listBoxTasks.SelectedItem;
            tasks.Remove(selectedTask);
        }

        private void buttonMarkComplete_Click(object sender, EventArgs e)
        {
            
            
            TaskItem selectedTask = (TaskItem)listBoxTasks.SelectedItem;
            selectedTask.IsCompleted = !selectedTask.IsCompleted; 
            int index = listBoxTasks.SelectedIndex;
            tasks.ResetItem(index);
            
        }

        private void buttonSortByTitle_Click(object sender, EventArgs e)
        {
            var sortedList = new BindingList<TaskItem>(tasks.OrderBy(t => t.Title).ToList());
            tasks = sortedList;
            listBoxTasks.DataSource = tasks; 
        }

        private void buttonSortByPriority_Click(object sender, EventArgs e)
        {
            var sortedList = new BindingList<TaskItem>(tasks.OrderBy(t => t.Priority).ToList());
            tasks = sortedList;
            listBoxTasks.DataSource = tasks;
        }

        private void buttonSortByCategory_Click(object sender, EventArgs e)
        {
            var sortedList = new BindingList<TaskItem>(tasks.OrderBy(t => t.Category).ToList());
            tasks = sortedList;
            listBoxTasks.DataSource = tasks;
        }

        private void buttonSortByDate_Click(object sender, EventArgs e)
        {
            var sortedList = new BindingList<TaskItem>(tasks.OrderBy(t => t.DueDate).ToList());
            tasks = sortedList;
            listBoxTasks.DataSource = tasks;
        }

        private void listBoxTasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxTasks.SelectedItem != null)
            {
                TaskItem selectedTask = (TaskItem)listBoxTasks.SelectedItem;

                textBoxTaskDescription.Text = selectedTask.Description;
            }
            else
            {
                textBoxTaskDescription.Text = string.Empty;
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listBoxTasks.SelectedItem == null)
            {
                MessageBox.Show("Выберите задачу для редактирования!");
                return;
            }

            TaskItem selectedTask = (TaskItem)listBoxTasks.SelectedItem;

            TaskForm editForm = new TaskForm(selectedTask);

            if (editForm.ShowDialog() == DialogResult.OK)
            {

                int selectedIndex = listBoxTasks.SelectedIndex;
                tasks.ResetItem(selectedIndex);

                listBoxTasks.DataSource = null;
                listBoxTasks.DataSource = tasks;

                if (listBoxTasks.SelectedItem != null)
                {
                    TaskItem updatedTask = (TaskItem)listBoxTasks.SelectedItem;
                    textBoxTaskDescription.Text = updatedTask.Description;
                }

                MessageBox.Show("Задача обновлена!");
            }
        }
    }
}