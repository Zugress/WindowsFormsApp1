namespace WindowsFormsApp1
{
    partial class TaskForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.comboBoxPriority = new System.Windows.Forms.ComboBox();
            this.dateTimePickerDueDate = new System.Windows.Forms.DateTimePicker();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.BackColor = System.Drawing.Color.DimGray;
            this.textBoxTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTitle.ForeColor = System.Drawing.Color.White;
            this.textBoxTitle.Location = new System.Drawing.Point(7, 6);
            this.textBoxTitle.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.textBoxTitle.Multiline = true;
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(359, 38);
            this.textBoxTitle.TabIndex = 0;
            this.textBoxTitle.Text = "Заголовок";
            this.textBoxTitle.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // comboBoxPriority
            // 
            this.comboBoxPriority.BackColor = System.Drawing.SystemColors.GrayText;
            this.comboBoxPriority.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.comboBoxPriority.FormattingEnabled = true;
            this.comboBoxPriority.Items.AddRange(new object[] {
            "High",
            "Medium",
            "Low"});
            this.comboBoxPriority.Location = new System.Drawing.Point(239, 171);
            this.comboBoxPriority.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.comboBoxPriority.Name = "comboBoxPriority";
            this.comboBoxPriority.Size = new System.Drawing.Size(127, 21);
            this.comboBoxPriority.TabIndex = 1;
            // 
            // dateTimePickerDueDate
            // 
            this.dateTimePickerDueDate.CalendarMonthBackground = System.Drawing.SystemColors.GrayText;
            this.dateTimePickerDueDate.CalendarTitleBackColor = System.Drawing.Color.DimGray;
            this.dateTimePickerDueDate.CalendarTrailingForeColor = System.Drawing.Color.DimGray;
            this.dateTimePickerDueDate.Location = new System.Drawing.Point(8, 172);
            this.dateTimePickerDueDate.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.dateTimePickerDueDate.Name = "dateTimePickerDueDate";
            this.dateTimePickerDueDate.Size = new System.Drawing.Size(102, 20);
            this.dateTimePickerDueDate.TabIndex = 3;
            // 
            // buttonOK
            // 
            this.buttonOK.BackColor = System.Drawing.Color.DimGray;
            this.buttonOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOK.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonOK.Location = new System.Drawing.Point(7, 195);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(210, 78);
            this.buttonOK.TabIndex = 5;
            this.buttonOK.Text = "Ok";
            this.buttonOK.UseVisualStyleBackColor = false;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.DimGray;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonCancel.Location = new System.Drawing.Point(221, 195);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(210, 78);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Ne ok";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.BackColor = System.Drawing.Color.DimGray;
            this.comboBoxCategory.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Items.AddRange(new object[] {
            "Work",
            "Home",
            "Hobby"});
            this.comboBoxCategory.Location = new System.Drawing.Point(111, 171);
            this.comboBoxCategory.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(127, 21);
            this.comboBoxCategory.TabIndex = 7;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.BackColor = System.Drawing.Color.DimGray;
            this.textBoxDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDescription.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.textBoxDescription.Location = new System.Drawing.Point(7, 52);
            this.textBoxDescription.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(359, 107);
            this.textBoxDescription.TabIndex = 8;
            this.textBoxDescription.Text = "Содержание";
            // 
            // TaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(438, 281);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.dateTimePickerDueDate);
            this.Controls.Add(this.comboBoxPriority);
            this.Controls.Add(this.textBoxTitle);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "TaskForm";
            this.Text = "TaskForm";
            this.Load += new System.EventHandler(this.TaskForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.ComboBox comboBoxPriority;
        private System.Windows.Forms.DateTimePicker dateTimePickerDueDate;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.TextBox textBoxDescription;
    }


}