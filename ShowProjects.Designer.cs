
namespace IS_Projects_of_students
{
    partial class ShowProjects
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
            this.dataGridView1.Location = new System.Drawing.Point(3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(744, 447);
            this.dataGridView1.TabIndex = 1;
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
            // ShowProjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ShowProjects";
            this.Text = "ShowProjects";
            this.Load += new System.EventHandler(this.ShowProjects_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameProject;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescitptionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectTypeColemn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeadlineColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartmentColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FacilityColumn;
    }
}