
namespace IS_Projects_of_students
{
    partial class UpdateAndRemoveProjects
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.delete = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.selectedId = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.inputDeadline = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.selectedSubject = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.selectedType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.inputDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.inputNameProject = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nameProject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescitptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectTypeColemn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeadlineColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartmentColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FacilityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameProject,
            this.DescitptionColumn,
            this.ProjectTypeColemn,
            this.DeadlineColumn,
            this.subjectColumn,
            this.DepartmentColumn,
            this.FacilityColumn});
            this.dataGridView1.Location = new System.Drawing.Point(278, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(743, 447);
            this.dataGridView1.TabIndex = 2;
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.LightBlue;
            this.delete.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.delete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.delete.Location = new System.Drawing.Point(149, 405);
            this.delete.Margin = new System.Windows.Forms.Padding(5);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(108, 54);
            this.delete.TabIndex = 48;
            this.delete.Text = "Удалить";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.LightBlue;
            this.update.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.update.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.update.Location = new System.Drawing.Point(21, 405);
            this.update.Margin = new System.Windows.Forms.Padding(5);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(111, 54);
            this.update.TabIndex = 47;
            this.update.Text = "Обновить";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // selectedId
            // 
            this.selectedId.FormattingEnabled = true;
            this.selectedId.Location = new System.Drawing.Point(165, 19);
            this.selectedId.Name = "selectedId";
            this.selectedId.Size = new System.Drawing.Size(93, 23);
            this.selectedId.TabIndex = 46;
            this.selectedId.SelectedIndexChanged += new System.EventHandler(this.selectedId_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Khaki;
            this.label3.Location = new System.Drawing.Point(21, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 33);
            this.label3.TabIndex = 45;
            this.label3.Text = "Проект №";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Khaki;
            this.label8.Location = new System.Drawing.Point(21, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(236, 33);
            this.label8.TabIndex = 49;
            this.label8.Text = "Данные о проекте";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inputDeadline
            // 
            this.inputDeadline.Location = new System.Drawing.Point(21, 278);
            this.inputDeadline.Name = "inputDeadline";
            this.inputDeadline.Size = new System.Drawing.Size(236, 23);
            this.inputDeadline.TabIndex = 69;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(21, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 68;
            this.label2.Text = "Предмет";
            // 
            // selectedSubject
            // 
            this.selectedSubject.FormattingEnabled = true;
            this.selectedSubject.Location = new System.Drawing.Point(21, 374);
            this.selectedSubject.Name = "selectedSubject";
            this.selectedSubject.Size = new System.Drawing.Size(237, 23);
            this.selectedSubject.TabIndex = 67;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(21, 304);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 17);
            this.label7.TabIndex = 66;
            this.label7.Text = "Тип проекта";
            // 
            // selectedType
            // 
            this.selectedType.FormattingEnabled = true;
            this.selectedType.Location = new System.Drawing.Point(21, 324);
            this.selectedType.Name = "selectedType";
            this.selectedType.Size = new System.Drawing.Size(236, 23);
            this.selectedType.TabIndex = 65;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(21, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 17);
            this.label5.TabIndex = 64;
            this.label5.Text = "Дедлайн";
            // 
            // inputDescription
            // 
            this.inputDescription.Location = new System.Drawing.Point(21, 173);
            this.inputDescription.MaxLength = 20;
            this.inputDescription.Multiline = true;
            this.inputDescription.Name = "inputDescription";
            this.inputDescription.Size = new System.Drawing.Size(236, 83);
            this.inputDescription.TabIndex = 63;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(21, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 62;
            this.label4.Text = "Описание";
            // 
            // inputNameProject
            // 
            this.inputNameProject.Location = new System.Drawing.Point(21, 126);
            this.inputNameProject.MaxLength = 20;
            this.inputNameProject.Name = "inputNameProject";
            this.inputNameProject.Size = new System.Drawing.Size(236, 23);
            this.inputNameProject.TabIndex = 61;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 17);
            this.label1.TabIndex = 60;
            this.label1.Text = "Название проекта";
            // 
            // nameProject
            // 
            this.nameProject.HeaderText = "Name Project";
            this.nameProject.Name = "nameProject";
            this.nameProject.ReadOnly = true;
            // 
            // DescitptionColumn
            // 
            this.DescitptionColumn.HeaderText = "Description";
            this.DescitptionColumn.Name = "DescitptionColumn";
            this.DescitptionColumn.ReadOnly = true;
            // 
            // ProjectTypeColemn
            // 
            this.ProjectTypeColemn.HeaderText = "ProjectType";
            this.ProjectTypeColemn.Name = "ProjectTypeColemn";
            this.ProjectTypeColemn.ReadOnly = true;
            // 
            // DeadlineColumn
            // 
            this.DeadlineColumn.HeaderText = "Deadline";
            this.DeadlineColumn.Name = "DeadlineColumn";
            this.DeadlineColumn.ReadOnly = true;
            // 
            // subjectColumn
            // 
            this.subjectColumn.HeaderText = "Subject";
            this.subjectColumn.Name = "subjectColumn";
            this.subjectColumn.ReadOnly = true;
            // 
            // DepartmentColumn
            // 
            this.DepartmentColumn.HeaderText = "Department";
            this.DepartmentColumn.Name = "DepartmentColumn";
            this.DepartmentColumn.ReadOnly = true;
            // 
            // FacilityColumn
            // 
            this.FacilityColumn.HeaderText = "Facility";
            this.FacilityColumn.Name = "FacilityColumn";
            this.FacilityColumn.ReadOnly = true;
            // 
            // UpdateAndRemoveProjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1035, 479);
            this.Controls.Add(this.inputDeadline);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.selectedSubject);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.selectedType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.inputDescription);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.inputNameProject);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.selectedId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UpdateAndRemoveProjects";
            this.Text = "UpdateAndRemoveProjects";
            this.Load += new System.EventHandler(this.UpdateAndRemoveProjects_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.ComboBox selectedId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker inputDeadline;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox selectedSubject;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox selectedType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox inputDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inputNameProject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameProject;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescitptionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectTypeColemn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeadlineColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartmentColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FacilityColumn;
    }
}