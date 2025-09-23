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
            this.textBoxCategory = new System.Windows.Forms.TextBox();
            this.dateTimePickerDueDate = new System.Windows.Forms.DateTimePicker();
            this.checkBoxIsCompleted = new System.Windows.Forms.CheckBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(140, 53);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(214, 31);
            this.textBoxTitle.TabIndex = 0;
            this.textBoxTitle.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // comboBoxPriority
            // 
            this.comboBoxPriority.FormattingEnabled = true;
            this.comboBoxPriority.Items.AddRange(new object[] {
            "High",
            "Medium",
            "Low"});
            this.comboBoxPriority.Location = new System.Drawing.Point(140, 116);
            this.comboBoxPriority.Name = "comboBoxPriority";
            this.comboBoxPriority.Size = new System.Drawing.Size(251, 33);
            this.comboBoxPriority.TabIndex = 1;
            // 
            // textBoxCategory
            // 
            this.textBoxCategory.Location = new System.Drawing.Point(131, 188);
            this.textBoxCategory.Name = "textBoxCategory";
            this.textBoxCategory.Size = new System.Drawing.Size(214, 31);
            this.textBoxCategory.TabIndex = 2;
            // 
            // dateTimePickerDueDate
            // 
            this.dateTimePickerDueDate.Location = new System.Drawing.Point(140, 271);
            this.dateTimePickerDueDate.Name = "dateTimePickerDueDate";
            this.dateTimePickerDueDate.Size = new System.Drawing.Size(200, 31);
            this.dateTimePickerDueDate.TabIndex = 3;
            // 
            // checkBoxIsCompleted
            // 
            this.checkBoxIsCompleted.AutoSize = true;
            this.checkBoxIsCompleted.Location = new System.Drawing.Point(140, 358);
            this.checkBoxIsCompleted.Name = "checkBoxIsCompleted";
            this.checkBoxIsCompleted.Size = new System.Drawing.Size(150, 29);
            this.checkBoxIsCompleted.TabIndex = 4;
            this.checkBoxIsCompleted.Text = "checkBox1";
            this.checkBoxIsCompleted.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(157, 435);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(166, 68);
            this.buttonOK.TabIndex = 5;
            this.buttonOK.Text = "Ok";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(391, 435);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(166, 68);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Ne ok";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // TaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(946, 541);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.checkBoxIsCompleted);
            this.Controls.Add(this.dateTimePickerDueDate);
            this.Controls.Add(this.textBoxCategory);
            this.Controls.Add(this.comboBoxPriority);
            this.Controls.Add(this.textBoxTitle);
            this.Name = "TaskForm";
            this.Text = "TaskForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.ComboBox comboBoxPriority;
        private System.Windows.Forms.TextBox textBoxCategory;
        private System.Windows.Forms.DateTimePicker dateTimePickerDueDate;
        private System.Windows.Forms.CheckBox checkBoxIsCompleted;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
    }


}