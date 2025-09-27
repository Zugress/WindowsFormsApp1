using AdvancedToDoList;
using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class TaskForm : Form
    {
        public TaskForm()
        {
            InitializeComponent();

            comboBoxPriority.SelectedItem = "Medium";
            comboBoxCategory.SelectedItem = "Work";
            dateTimePickerDueDate.Value = DateTime.Today.AddDays(1); 
            this.Task = null;
        }

        public TaskForm(TaskItem taskToEdit) : this() 
        {
            textBoxTitle.Text = taskToEdit.Title;
            comboBoxPriority.SelectedItem = taskToEdit.Priority.ToString();
            comboBoxCategory.SelectedItem = taskToEdit.Category.ToString();
            dateTimePickerDueDate.Value = taskToEdit.DueDate;
            textBoxDescription.Text = taskToEdit.Description;

            this.Task = taskToEdit;
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public TaskItem Task { get; private set; }

        private void buttonOK_Click(object sender, EventArgs e)
        {

            string priorityText = comboBoxPriority.SelectedItem?.ToString() ?? "Medium";
            PriorityLevel priority = (PriorityLevel)Enum.Parse(typeof(PriorityLevel), priorityText);

            string categoryText = comboBoxCategory.SelectedItem?.ToString() ?? "Work";
            CategoryType category = (CategoryType)Enum.Parse(typeof(CategoryType), categoryText);

            if (Task != null)
            {
                Task.Title = textBoxTitle.Text;
                Task.Priority = priority;
                Task.Category = category;
                Task.DueDate = dateTimePickerDueDate.Value;
                Task.Description = textBoxDescription.Text;
            }
            else
            {
                Task = new TaskItem(
                    textBoxTitle.Text,
                    priority,
                    category,
                    dateTimePickerDueDate.Value,
                    textBoxDescription.Text
                );
            }


            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void testBoxDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void TaskForm_Load(object sender, EventArgs e)
        {

        }
    }
}
