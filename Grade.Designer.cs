
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
            this.addProjectForStudent = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.studentColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deadlineCilumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.solutionTaskColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dowlandColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.writeCommentary = new System.Windows.Forms.TextBox();
            this.writeDecription = new System.Windows.Forms.TextBox();
            this.inputSolutionTask = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.addGrade = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // selectedIdStudent
            // 
            this.selectedIdStudent.FormattingEnabled = true;
            this.selectedIdStudent.Location = new System.Drawing.Point(156, 23);
            this.selectedIdStudent.Name = "selectedIdStudent";
            this.selectedIdStudent.Size = new System.Drawing.Size(232, 23);
            this.selectedIdStudent.TabIndex = 48;
            this.selectedIdStudent.SelectedIndexChanged += new System.EventHandler(this.selectedIdStudent_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Khaki;
            this.label3.Location = new System.Drawing.Point(12, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 33);
            this.label3.TabIndex = 47;
            this.label3.Text = "Студент";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // selectedIdProject
            // 
            this.selectedIdProject.FormattingEnabled = true;
            this.selectedIdProject.Location = new System.Drawing.Point(156, 61);
            this.selectedIdProject.Name = "selectedIdProject";
            this.selectedIdProject.Size = new System.Drawing.Size(232, 23);
            this.selectedIdProject.TabIndex = 50;
            this.selectedIdProject.SelectedIndexChanged += new System.EventHandler(this.selectedIdProject_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Khaki;
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 33);
            this.label1.TabIndex = 49;
            this.label1.Text = "Проект";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addProjectForStudent
            // 
            this.addProjectForStudent.BackColor = System.Drawing.Color.LightBlue;
            this.addProjectForStudent.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.addProjectForStudent.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addProjectForStudent.Location = new System.Drawing.Point(14, 97);
            this.addProjectForStudent.Margin = new System.Windows.Forms.Padding(5);
            this.addProjectForStudent.Name = "addProjectForStudent";
            this.addProjectForStudent.Size = new System.Drawing.Size(374, 54);
            this.addProjectForStudent.TabIndex = 58;
            this.addProjectForStudent.Text = "Добавить проект студенту";
            this.addProjectForStudent.UseVisualStyleBackColor = false;
            this.addProjectForStudent.Click += new System.EventHandler(this.addProjectForStudent_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentColumn,
            this.nameColumn,
            this.typeColumn,
            this.deadlineCilumn,
            this.solutionTaskColumn,
            this.dowlandColumn,
            this.noteColumn});
            this.dataGridView1.Location = new System.Drawing.Point(396, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(744, 618);
            this.dataGridView1.TabIndex = 63;
            // 
            // studentColumn
            // 
            this.studentColumn.HeaderText = "Student";
            this.studentColumn.Name = "studentColumn";
            this.studentColumn.ReadOnly = true;
            // 
            // nameColumn
            // 
            this.nameColumn.HeaderText = "Project Name";
            this.nameColumn.Name = "nameColumn";
            this.nameColumn.ReadOnly = true;
            // 
            // typeColumn
            // 
            this.typeColumn.HeaderText = "Project Type";
            this.typeColumn.Name = "typeColumn";
            this.typeColumn.ReadOnly = true;
            // 
            // deadlineCilumn
            // 
            this.deadlineCilumn.HeaderText = "Daeadline";
            this.deadlineCilumn.Name = "deadlineCilumn";
            this.deadlineCilumn.ReadOnly = true;
            // 
            // solutionTaskColumn
            // 
            this.solutionTaskColumn.HeaderText = "SolutionTask";
            this.solutionTaskColumn.Name = "solutionTaskColumn";
            this.solutionTaskColumn.ReadOnly = true;
            // 
            // dowlandColumn
            // 
            this.dowlandColumn.HeaderText = "Dowland Date";
            this.dowlandColumn.Name = "dowlandColumn";
            this.dowlandColumn.ReadOnly = true;
            // 
            // noteColumn
            // 
            this.noteColumn.HeaderText = "Note";
            this.noteColumn.Name = "noteColumn";
            this.noteColumn.ReadOnly = true;
            // 
            // writeCommentary
            // 
            this.writeCommentary.Enabled = false;
            this.writeCommentary.Location = new System.Drawing.Point(14, 308);
            this.writeCommentary.MaxLength = 20;
            this.writeCommentary.Multiline = true;
            this.writeCommentary.Name = "writeCommentary";
            this.writeCommentary.Size = new System.Drawing.Size(376, 95);
            this.writeCommentary.TabIndex = 69;
            // 
            // writeDecription
            // 
            this.writeDecription.Enabled = false;
            this.writeDecription.Location = new System.Drawing.Point(14, 181);
            this.writeDecription.MaxLength = 20;
            this.writeDecription.Multiline = true;
            this.writeDecription.Name = "writeDecription";
            this.writeDecription.Size = new System.Drawing.Size(374, 95);
            this.writeDecription.TabIndex = 68;
            // 
            // inputSolutionTask
            // 
            this.inputSolutionTask.Location = new System.Drawing.Point(14, 436);
            this.inputSolutionTask.MaxLength = 20;
            this.inputSolutionTask.Multiline = true;
            this.inputSolutionTask.Name = "inputSolutionTask";
            this.inputSolutionTask.Size = new System.Drawing.Size(376, 144);
            this.inputSolutionTask.TabIndex = 67;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Khaki;
            this.label5.Location = new System.Drawing.Point(14, 406);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(376, 27);
            this.label5.TabIndex = 66;
            this.label5.Text = "Решение студента";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Khaki;
            this.label2.Location = new System.Drawing.Point(14, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(374, 21);
            this.label2.TabIndex = 65;
            this.label2.Text = "Написать комментарий";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Khaki;
            this.label4.Location = new System.Drawing.Point(14, 600);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 27);
            this.label4.TabIndex = 64;
            this.label4.Text = "Поставить оценку";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.UseWaitCursor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(195, 604);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(44, 23);
            this.numericUpDown1.TabIndex = 70;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Khaki;
            this.label6.Location = new System.Drawing.Point(14, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(376, 21);
            this.label6.TabIndex = 71;
            this.label6.Text = "Описание предмета";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addGrade
            // 
            this.addGrade.BackColor = System.Drawing.Color.LightBlue;
            this.addGrade.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.addGrade.Enabled = false;
            this.addGrade.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addGrade.Location = new System.Drawing.Point(245, 588);
            this.addGrade.Margin = new System.Windows.Forms.Padding(5);
            this.addGrade.Name = "addGrade";
            this.addGrade.Size = new System.Drawing.Size(143, 54);
            this.addGrade.TabIndex = 72;
            this.addGrade.Text = "Поставить оценку";
            this.addGrade.UseVisualStyleBackColor = false;
            this.addGrade.Click += new System.EventHandler(this.addGrade_Click);
            // 
            // Grade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1150, 649);
            this.Controls.Add(this.addGrade);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.writeCommentary);
            this.Controls.Add(this.writeDecription);
            this.Controls.Add(this.inputSolutionTask);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.addProjectForStudent);
            this.Controls.Add(this.selectedIdProject);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selectedIdStudent);
            this.Controls.Add(this.label3);
            this.Name = "Grade";
            this.Text = "Grade";
            this.Load += new System.EventHandler(this.Grade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox selectedIdStudent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox selectedIdProject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addProjectForStudent;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deadlineCilumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn solutionTaskColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dowlandColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteColumn;
        private System.Windows.Forms.TextBox writeCommentary;
        private System.Windows.Forms.TextBox writeDecription;
        private System.Windows.Forms.TextBox inputSolutionTask;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button addGrade;
    }
}