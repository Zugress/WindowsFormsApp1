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

            Task = new TaskItem(
                textBoxTitle.Text,
                priority,
                category,
                dateTimePickerDueDate.Value
            );

            
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
    }
}
