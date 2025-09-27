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
            this.textBoxTaskDescription = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBoxTasks
            // 
            this.listBoxTasks.BackColor = System.Drawing.Color.DimGray;
            this.listBoxTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxTasks.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.listBoxTasks.FormattingEnabled = true;
            this.listBoxTasks.ItemHeight = 32;
            this.listBoxTasks.Location = new System.Drawing.Point(727, 522);
            this.listBoxTasks.Name = "listBoxTasks";
            this.listBoxTasks.Size = new System.Drawing.Size(700, 260);
            this.listBoxTasks.TabIndex = 0;
            this.listBoxTasks.SelectedIndexChanged += new System.EventHandler(this.listBoxTasks_SelectedIndexChanged);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.DimGray;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonAdd.Location = new System.Drawing.Point(726, 21);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(350, 200);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.DimGray;
            this.buttonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEdit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonEdit.Location = new System.Drawing.Point(726, 227);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(350, 200);
            this.buttonEdit.TabIndex = 2;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.DimGray;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonDelete.Location = new System.Drawing.Point(1082, 21);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(344, 200);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonMarkComplete
            // 
            this.buttonMarkComplete.BackColor = System.Drawing.Color.DimGray;
            this.buttonMarkComplete.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMarkComplete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonMarkComplete.Location = new System.Drawing.Point(1081, 227);
            this.buttonMarkComplete.Name = "buttonMarkComplete";
            this.buttonMarkComplete.Size = new System.Drawing.Size(345, 200);
            this.buttonMarkComplete.TabIndex = 4;
            this.buttonMarkComplete.Text = "Mark complete";
            this.buttonMarkComplete.UseVisualStyleBackColor = false;
            this.buttonMarkComplete.Click += new System.EventHandler(this.buttonMarkComplete_Click);
            // 
            // buttonSortByTitle
            // 
            this.buttonSortByTitle.BackColor = System.Drawing.Color.DimGray;
            this.buttonSortByTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSortByTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSortByTitle.Location = new System.Drawing.Point(726, 436);
            this.buttonSortByTitle.Name = "buttonSortByTitle";
            this.buttonSortByTitle.Size = new System.Drawing.Size(170, 80);
            this.buttonSortByTitle.TabIndex = 5;
            this.buttonSortByTitle.Text = "By Title";
            this.buttonSortByTitle.UseVisualStyleBackColor = false;
            this.buttonSortByTitle.Click += new System.EventHandler(this.buttonSortByTitle_Click);
            // 
            // buttonSortByPriority
            // 
            this.buttonSortByPriority.BackColor = System.Drawing.Color.DimGray;
            this.buttonSortByPriority.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSortByPriority.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSortByPriority.Location = new System.Drawing.Point(904, 436);
            this.buttonSortByPriority.Name = "buttonSortByPriority";
            this.buttonSortByPriority.Size = new System.Drawing.Size(170, 80);
            this.buttonSortByPriority.TabIndex = 6;
            this.buttonSortByPriority.Text = "By Priority";
            this.buttonSortByPriority.UseVisualStyleBackColor = false;
            this.buttonSortByPriority.Click += new System.EventHandler(this.buttonSortByPriority_Click);
            // 
            // buttonSortByCategory
            // 
            this.buttonSortByCategory.BackColor = System.Drawing.Color.DimGray;
            this.buttonSortByCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSortByCategory.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSortByCategory.Location = new System.Drawing.Point(1080, 436);
            this.buttonSortByCategory.Name = "buttonSortByCategory";
            this.buttonSortByCategory.Size = new System.Drawing.Size(170, 80);
            this.buttonSortByCategory.TabIndex = 7;
            this.buttonSortByCategory.Text = "By Category";
            this.buttonSortByCategory.UseVisualStyleBackColor = false;
            this.buttonSortByCategory.Click += new System.EventHandler(this.buttonSortByCategory_Click);
            // 
            // buttonSortByDate
            // 
            this.buttonSortByDate.BackColor = System.Drawing.Color.DimGray;
            this.buttonSortByDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSortByDate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSortByDate.Location = new System.Drawing.Point(1256, 436);
            this.buttonSortByDate.Name = "buttonSortByDate";
            this.buttonSortByDate.Size = new System.Drawing.Size(170, 80);
            this.buttonSortByDate.TabIndex = 8;
            this.buttonSortByDate.Text = "By Date";
            this.buttonSortByDate.UseVisualStyleBackColor = false;
            this.buttonSortByDate.Click += new System.EventHandler(this.buttonSortByDate_Click);
            // 
            // textBoxTaskDescription
            // 
            this.textBoxTaskDescription.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBoxTaskDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTaskDescription.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.textBoxTaskDescription.Location = new System.Drawing.Point(12, 21);
            this.textBoxTaskDescription.Multiline = true;
            this.textBoxTaskDescription.Name = "textBoxTaskDescription";
            this.textBoxTaskDescription.ReadOnly = true;
            this.textBoxTaskDescription.Size = new System.Drawing.Size(708, 747);
            this.textBoxTaskDescription.TabIndex = 9;
            // 
            // ToDoList
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1451, 829);
            this.Controls.Add(this.textBoxTaskDescription);
            this.Controls.Add(this.buttonSortByDate);
            this.Controls.Add(this.buttonSortByCategory);
            this.Controls.Add(this.buttonSortByPriority);
            this.Controls.Add(this.buttonSortByTitle);
            this.Controls.Add(this.buttonMarkComplete);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listBoxTasks);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ToDoList";
            this.Text = "To Do List";
            this.Load += new System.EventHandler(this.ToDoList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.TextBox textBoxTaskDescription;
    }
}

