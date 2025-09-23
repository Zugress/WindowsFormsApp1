namespace WindowsFormsApp1
{
    partial class ToDoList
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.listBoxTasks = new System.Windows.Forms.ListBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonMarkComplete = new System.Windows.Forms.Button();
            this.buttonSortByTitle = new System.Windows.Forms.Button();
            this.buttonSortByPriority = new System.Windows.Forms.Button();
            this.buttonSortByCategory = new System.Windows.Forms.Button();
            this.buttonSortByDate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxTasks
            // 
            this.listBoxTasks.FormattingEnabled = true;
            this.listBoxTasks.ItemHeight = 25;
            this.listBoxTasks.Location = new System.Drawing.Point(44, 545);
            this.listBoxTasks.Name = "listBoxTasks";
            this.listBoxTasks.Size = new System.Drawing.Size(1028, 204);
            this.listBoxTasks.TabIndex = 0;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(342, 133);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(154, 85);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(531, 133);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(154, 85);
            this.buttonEdit.TabIndex = 2;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(723, 133);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(154, 85);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonMarkComplete
            // 
            this.buttonMarkComplete.Location = new System.Drawing.Point(907, 133);
            this.buttonMarkComplete.Name = "buttonMarkComplete";
            this.buttonMarkComplete.Size = new System.Drawing.Size(154, 85);
            this.buttonMarkComplete.TabIndex = 4;
            this.buttonMarkComplete.Text = "Mark complete";
            this.buttonMarkComplete.UseVisualStyleBackColor = true;
            // 
            // buttonSortByTitle
            // 
            this.buttonSortByTitle.Location = new System.Drawing.Point(342, 250);
            this.buttonSortByTitle.Name = "buttonSortByTitle";
            this.buttonSortByTitle.Size = new System.Drawing.Size(154, 85);
            this.buttonSortByTitle.TabIndex = 5;
            this.buttonSortByTitle.Text = "By Title";
            this.buttonSortByTitle.UseVisualStyleBackColor = true;
            // 
            // buttonSortByPriority
            // 
            this.buttonSortByPriority.Location = new System.Drawing.Point(531, 250);
            this.buttonSortByPriority.Name = "buttonSortByPriority";
            this.buttonSortByPriority.Size = new System.Drawing.Size(154, 85);
            this.buttonSortByPriority.TabIndex = 6;
            this.buttonSortByPriority.Text = "By Priority";
            this.buttonSortByPriority.UseVisualStyleBackColor = true;
            // 
            // buttonSortByCategory
            // 
            this.buttonSortByCategory.Location = new System.Drawing.Point(723, 250);
            this.buttonSortByCategory.Name = "buttonSortByCategory";
            this.buttonSortByCategory.Size = new System.Drawing.Size(154, 85);
            this.buttonSortByCategory.TabIndex = 7;
            this.buttonSortByCategory.Text = "By Category";
            this.buttonSortByCategory.UseVisualStyleBackColor = true;
            // 
            // buttonSortByDate
            // 
            this.buttonSortByDate.Location = new System.Drawing.Point(918, 250);
            this.buttonSortByDate.Name = "buttonSortByDate";
            this.buttonSortByDate.Size = new System.Drawing.Size(154, 85);
            this.buttonSortByDate.TabIndex = 8;
            this.buttonSortByDate.Text = "By Date";
            this.buttonSortByDate.UseVisualStyleBackColor = true;
            // 
            // ToDoList
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1769, 829);
            this.Controls.Add(this.buttonSortByDate);
            this.Controls.Add(this.buttonSortByCategory);
            this.Controls.Add(this.buttonSortByPriority);
            this.Controls.Add(this.buttonSortByTitle);
            this.Controls.Add(this.buttonMarkComplete);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listBoxTasks);
            this.Name = "ToDoList";
            this.Text = "To Do List";
            this.Load += new System.EventHandler(this.ToDoList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox TitleTextBox;
        private System.Windows.Forms.RichTextBox DescriptionTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.DataGridView ToDoListView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ListBox listBoxTasks;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonMarkComplete;
        private System.Windows.Forms.Button buttonSortByTitle;
        private System.Windows.Forms.Button buttonSortByPriority;
        private System.Windows.Forms.Button buttonSortByCategory;
        private System.Windows.Forms.Button buttonSortByDate;
    }
}

