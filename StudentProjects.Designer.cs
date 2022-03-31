
namespace IS_Projects_of_students
{
    partial class StudentProjects
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
            this.label8 = new System.Windows.Forms.Label();
            this.selectedSubject = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.selectedProject = new System.Windows.Forms.ComboBox();
            this.inputSolutionTask = new System.Windows.Forms.TextBox();
            this.writeDecription = new System.Windows.Forms.TextBox();
            this.writeCommentary = new System.Windows.Forms.TextBox();
            this.updateSolution = new System.Windows.Forms.Button();
            this.addSolution = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deadlineCilumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.solutionTaskColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dowlandColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Khaki;
            this.label8.Location = new System.Drawing.Point(22, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(982, 33);
            this.label8.TabIndex = 41;
            this.label8.Text = "Мои проекты";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // selectedSubject
            // 
            this.selectedSubject.FormattingEnabled = true;
            this.selectedSubject.Location = new System.Drawing.Point(22, 52);
            this.selectedSubject.Name = "selectedSubject";
            this.selectedSubject.Size = new System.Drawing.Size(967, 23);
            this.selectedSubject.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Khaki;
            this.label1.Location = new System.Drawing.Point(18, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 33);
            this.label1.TabIndex = 44;
            this.label1.Text = "Проект";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Khaki;
            this.label2.Location = new System.Drawing.Point(22, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(322, 33);
            this.label2.TabIndex = 45;
            this.label2.Text = "Описание проекта";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Khaki;
            this.label3.Location = new System.Drawing.Point(22, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(322, 33);
            this.label3.TabIndex = 46;
            this.label3.Text = "Комментарий преподавателя";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Khaki;
            this.label5.Location = new System.Drawing.Point(22, 392);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(322, 33);
            this.label5.TabIndex = 49;
            this.label5.Text = "Решение";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoEllipsis = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(22, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 18);
            this.label6.TabIndex = 52;
            this.label6.Text = "Предметы";
            // 
            // selectedProject
            // 
            this.selectedProject.FormattingEnabled = true;
            this.selectedProject.Location = new System.Drawing.Point(163, 91);
            this.selectedProject.Name = "selectedProject";
            this.selectedProject.Size = new System.Drawing.Size(172, 23);
            this.selectedProject.TabIndex = 53;
            this.selectedProject.SelectedIndexChanged += new System.EventHandler(this.selectedProject_SelectedIndexChanged);
            // 
            // inputSolutionTask
            // 
            this.inputSolutionTask.Location = new System.Drawing.Point(22, 428);
            this.inputSolutionTask.MaxLength = 20;
            this.inputSolutionTask.Multiline = true;
            this.inputSolutionTask.Name = "inputSolutionTask";
            this.inputSolutionTask.Size = new System.Drawing.Size(322, 144);
            this.inputSolutionTask.TabIndex = 57;
            // 
            // writeDecription
            // 
            this.writeDecription.Enabled = false;
            this.writeDecription.Location = new System.Drawing.Point(22, 159);
            this.writeDecription.MaxLength = 20;
            this.writeDecription.Multiline = true;
            this.writeDecription.Name = "writeDecription";
            this.writeDecription.Size = new System.Drawing.Size(322, 95);
            this.writeDecription.TabIndex = 58;
            // 
            // writeCommentary
            // 
            this.writeCommentary.Enabled = false;
            this.writeCommentary.Location = new System.Drawing.Point(22, 294);
            this.writeCommentary.MaxLength = 20;
            this.writeCommentary.Multiline = true;
            this.writeCommentary.Name = "writeCommentary";
            this.writeCommentary.Size = new System.Drawing.Size(322, 95);
            this.writeCommentary.TabIndex = 59;
            // 
            // updateSolution
            // 
            this.updateSolution.BackColor = System.Drawing.Color.LightBlue;
            this.updateSolution.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.updateSolution.Enabled = false;
            this.updateSolution.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.updateSolution.Location = new System.Drawing.Point(184, 580);
            this.updateSolution.Margin = new System.Windows.Forms.Padding(5);
            this.updateSolution.Name = "updateSolution";
            this.updateSolution.Size = new System.Drawing.Size(160, 54);
            this.updateSolution.TabIndex = 61;
            this.updateSolution.Text = "Обновить решение";
            this.updateSolution.UseVisualStyleBackColor = false;
            this.updateSolution.Click += new System.EventHandler(this.updateSolution_Click);
            // 
            // addSolution
            // 
            this.addSolution.BackColor = System.Drawing.Color.LightBlue;
            this.addSolution.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.addSolution.Enabled = false;
            this.addSolution.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addSolution.Location = new System.Drawing.Point(22, 580);
            this.addSolution.Margin = new System.Windows.Forms.Padding(5);
            this.addSolution.Name = "addSolution";
            this.addSolution.Size = new System.Drawing.Size(152, 54);
            this.addSolution.TabIndex = 60;
            this.addSolution.Text = "Добавить решение";
            this.addSolution.UseVisualStyleBackColor = false;
            this.addSolution.Click += new System.EventHandler(this.addSolution_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameColumn,
            this.typeColumn,
            this.deadlineCilumn,
            this.solutionTaskColumn,
            this.dowlandColumn,
            this.noteColumn});
            this.dataGridView1.Location = new System.Drawing.Point(352, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(637, 549);
            this.dataGridView1.TabIndex = 62;
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
            // StudentProjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(998, 650);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.updateSolution);
            this.Controls.Add(this.addSolution);
            this.Controls.Add(this.writeCommentary);
            this.Controls.Add(this.writeDecription);
            this.Controls.Add(this.inputSolutionTask);
            this.Controls.Add(this.selectedProject);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selectedSubject);
            this.Controls.Add(this.label8);
            this.Name = "StudentProjects";
            this.Text = "StudentProjects";
            this.Load += new System.EventHandler(this.StudentProjects_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox selectedSubject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox selectedProject;
        private System.Windows.Forms.TextBox inputSolutionTask;
        private System.Windows.Forms.TextBox writeDecription;
        private System.Windows.Forms.TextBox writeCommentary;
        private System.Windows.Forms.Button updateSolution;
        private System.Windows.Forms.Button addSolution;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deadlineCilumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn solutionTaskColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dowlandColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteColumn;
    }
}