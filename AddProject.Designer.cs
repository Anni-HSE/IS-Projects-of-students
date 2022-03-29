
namespace IS_Projects_of_students
{
    partial class AddProject
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
            this.label2 = new System.Windows.Forms.Label();
            this.cancel = new System.Windows.Forms.Button();
            this.createNewProject = new System.Windows.Forms.Button();
            this.selectedSubject = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.selectedType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.inputDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.inputNameProject = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.inputDeadline = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(238, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 58;
            this.label2.Text = "Предмет";
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.Color.LightBlue;
            this.cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cancel.Location = new System.Drawing.Point(238, 237);
            this.cancel.Margin = new System.Windows.Forms.Padding(5);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(204, 54);
            this.cancel.TabIndex = 57;
            this.cancel.Text = "Отмена";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // createNewProject
            // 
            this.createNewProject.BackColor = System.Drawing.Color.LightBlue;
            this.createNewProject.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.createNewProject.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.createNewProject.Location = new System.Drawing.Point(11, 237);
            this.createNewProject.Margin = new System.Windows.Forms.Padding(5);
            this.createNewProject.Name = "createNewProject";
            this.createNewProject.Size = new System.Drawing.Size(204, 54);
            this.createNewProject.TabIndex = 56;
            this.createNewProject.Text = "Добавить";
            this.createNewProject.UseVisualStyleBackColor = false;
            this.createNewProject.Click += new System.EventHandler(this.createNewProject_Click);
            // 
            // selectedSubject
            // 
            this.selectedSubject.FormattingEnabled = true;
            this.selectedSubject.Location = new System.Drawing.Point(238, 196);
            this.selectedSubject.Name = "selectedSubject";
            this.selectedSubject.Size = new System.Drawing.Size(109, 23);
            this.selectedSubject.TabIndex = 55;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Khaki;
            this.label8.Location = new System.Drawing.Point(12, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(426, 33);
            this.label8.TabIndex = 54;
            this.label8.Text = "Добавить проект";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(238, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 17);
            this.label7.TabIndex = 53;
            this.label7.Text = "Тип проекта";
            // 
            // selectedType
            // 
            this.selectedType.FormattingEnabled = true;
            this.selectedType.Location = new System.Drawing.Point(238, 136);
            this.selectedType.Name = "selectedType";
            this.selectedType.Size = new System.Drawing.Size(109, 23);
            this.selectedType.TabIndex = 52;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(238, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 17);
            this.label5.TabIndex = 49;
            this.label5.Text = "Дедлайн";
            // 
            // inputDescription
            // 
            this.inputDescription.Location = new System.Drawing.Point(12, 136);
            this.inputDescription.MaxLength = 20;
            this.inputDescription.Multiline = true;
            this.inputDescription.Name = "inputDescription";
            this.inputDescription.Size = new System.Drawing.Size(204, 83);
            this.inputDescription.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 47;
            this.label4.Text = "Описание";
            // 
            // inputNameProject
            // 
            this.inputNameProject.Location = new System.Drawing.Point(12, 80);
            this.inputNameProject.MaxLength = 20;
            this.inputNameProject.Name = "inputNameProject";
            this.inputNameProject.Size = new System.Drawing.Size(204, 23);
            this.inputNameProject.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 17);
            this.label1.TabIndex = 45;
            this.label1.Text = "Название проекта";
            // 
            // inputDeadline
            // 
            this.inputDeadline.Location = new System.Drawing.Point(238, 80);
            this.inputDeadline.Name = "inputDeadline";
            this.inputDeadline.Size = new System.Drawing.Size(200, 23);
            this.inputDeadline.TabIndex = 59;
            // 
            // AddProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(456, 307);
            this.Controls.Add(this.inputDeadline);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.createNewProject);
            this.Controls.Add(this.selectedSubject);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.selectedType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.inputDescription);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.inputNameProject);
            this.Controls.Add(this.label1);
            this.Name = "AddProject";
            this.Text = "AddProject";
            this.Load += new System.EventHandler(this.AddProject_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button createNewProject;
        private System.Windows.Forms.ComboBox selectedSubject;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox selectedType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox inputDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inputNameProject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker inputDeadline;
    }
}