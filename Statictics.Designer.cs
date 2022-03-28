
namespace IS_Projects_of_students
{
    partial class Statictics
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
            this.manGender = new System.Windows.Forms.Label();
            this.womanGender = new System.Windows.Forms.Label();
            this.allGender = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // manGender
            // 
            this.manGender.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.manGender.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.manGender.Location = new System.Drawing.Point(0, 0);
            this.manGender.Name = "manGender";
            this.manGender.Size = new System.Drawing.Size(154, 130);
            this.manGender.TabIndex = 0;
            this.manGender.Text = "Количество студентов мужского пола:";
            this.manGender.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // womanGender
            // 
            this.womanGender.BackColor = System.Drawing.Color.LightBlue;
            this.womanGender.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.womanGender.Location = new System.Drawing.Point(154, 0);
            this.womanGender.Name = "womanGender";
            this.womanGender.Size = new System.Drawing.Size(159, 130);
            this.womanGender.TabIndex = 1;
            this.womanGender.Text = "Количество студентов женского пола:";
            this.womanGender.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // allGender
            // 
            this.allGender.BackColor = System.Drawing.Color.LightSlateGray;
            this.allGender.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.allGender.Location = new System.Drawing.Point(0, 130);
            this.allGender.Name = "allGender";
            this.allGender.Size = new System.Drawing.Size(313, 130);
            this.allGender.TabIndex = 2;
            this.allGender.Text = "Общее количество студетов:";
            this.allGender.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Statictics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 260);
            this.Controls.Add(this.allGender);
            this.Controls.Add(this.womanGender);
            this.Controls.Add(this.manGender);
            this.Name = "Statictics";
            this.Text = "Statictics";
            this.Load += new System.EventHandler(this.Statictics_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label manGender;
        private System.Windows.Forms.Label womanGender;
        private System.Windows.Forms.Label allGender;
    }
}