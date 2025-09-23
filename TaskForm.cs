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

            
            Task = new TaskItem(
                textBoxTitle.Text,
                comboBoxPriority.SelectedItem?.ToString() ?? "Medium",
                textBoxCategory.Text,
                dateTimePickerDueDate.Value
            );
            Task.IsCompleted = checkBoxIsCompleted.Checked;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
