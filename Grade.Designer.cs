
namespace IS_Projects_of_students
{
    partial class Grade
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
            this.selectedIdStudent = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.selectedIdProject = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.selectedGrade = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cancel = new System.Windows.Forms.Button();
            this.createNewProject = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // selectedIdStudent
            // 
            this.selectedIdStudent.FormattingEnabled = true;
            this.selectedIdStudent.Location = new System.Drawing.Point(156, 23);
            this.selectedIdStudent.Name = "selectedIdStudent";
            this.selectedIdStudent.Size = new System.Drawing.Size(93, 23);
            this.selectedIdStudent.TabIndex = 48;
            this.selectedIdStudent.SelectedIndexChanged += new System.EventHandler(this.selectedIdStudent_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Khaki;
            this.label3.Location = new System.Drawing.Point(12, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 33);
            this.label3.TabIndex = 47;
            this.label3.Text = "Студент №";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // selectedIdProject
            // 
            this.selectedIdProject.FormattingEnabled = true;
            this.selectedIdProject.Location = new System.Drawing.Point(156, 72);
            this.selectedIdProject.Name = "selectedIdProject";
            this.selectedIdProject.Size = new System.Drawing.Size(232, 23);
            this.selectedIdProject.TabIndex = 50;
            this.selectedIdProject.SelectedIndexChanged += new System.EventHandler(this.selectedIdProject_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Khaki;
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 33);
            this.label1.TabIndex = 49;
            this.label1.Text = "Проект №";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // selectedGrade
            // 
            this.selectedGrade.FormattingEnabled = true;
            this.selectedGrade.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.selectedGrade.Location = new System.Drawing.Point(156, 117);
            this.selectedGrade.Name = "selectedGrade";
            this.selectedGrade.Size = new System.Drawing.Size(93, 23);
            this.selectedGrade.TabIndex = 52;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Khaki;
            this.label2.Location = new System.Drawing.Point(12, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 33);
            this.label2.TabIndex = 51;
            this.label2.Text = "Оценка";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.Color.LightBlue;
            this.cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cancel.Location = new System.Drawing.Point(215, 164);
            this.cancel.Margin = new System.Windows.Forms.Padding(5);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(173, 54);
            this.cancel.TabIndex = 59;
            this.cancel.Text = "Отмена";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // createNewProject
            // 
            this.createNewProject.BackColor = System.Drawing.Color.LightBlue;
            this.createNewProject.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.createNewProject.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.createNewProject.Location = new System.Drawing.Point(23, 164);
            this.createNewProject.Margin = new System.Windows.Forms.Padding(5);
            this.createNewProject.Name = "createNewProject";
            this.createNewProject.Size = new System.Drawing.Size(173, 54);
            this.createNewProject.TabIndex = 58;
            this.createNewProject.Text = "Поставить";
            this.createNewProject.UseVisualStyleBackColor = false;
            this.createNewProject.Click += new System.EventHandler(this.createNewProject_Click);
            // 
            // Grade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(411, 231);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.createNewProject);
            this.Controls.Add(this.selectedGrade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.selectedIdProject);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selectedIdStudent);
            this.Controls.Add(this.label3);
            this.Name = "Grade";
            this.Text = "Grade";
            this.Load += new System.EventHandler(this.Grade_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox selectedIdStudent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox selectedIdProject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox selectedGrade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button createNewProject;
    }
}