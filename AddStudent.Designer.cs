
namespace IS_Projects_of_students
{
    partial class AddStudent
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
            this.inputGroup = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.inputGender = new System.Windows.Forms.ComboBox();
            this.inputEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.inputDoB = new System.Windows.Forms.DateTimePicker();
            this.inputFIO = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.inputLogin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cancel = new System.Windows.Forms.Button();
            this.createNewAccount = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputGroup
            // 
            this.inputGroup.FormattingEnabled = true;
            this.inputGroup.Location = new System.Drawing.Point(238, 196);
            this.inputGroup.Name = "inputGroup";
            this.inputGroup.Size = new System.Drawing.Size(109, 23);
            this.inputGroup.TabIndex = 41;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Khaki;
            this.label8.Location = new System.Drawing.Point(12, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(426, 33);
            this.label8.TabIndex = 40;
            this.label8.Text = "Добавить студента";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(238, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 17);
            this.label7.TabIndex = 39;
            this.label7.Text = "Пол";
            // 
            // inputGender
            // 
            this.inputGender.FormattingEnabled = true;
            this.inputGender.Location = new System.Drawing.Point(238, 136);
            this.inputGender.Name = "inputGender";
            this.inputGender.Size = new System.Drawing.Size(109, 23);
            this.inputGender.TabIndex = 38;
            // 
            // inputEmail
            // 
            this.inputEmail.Location = new System.Drawing.Point(12, 196);
            this.inputEmail.MaxLength = 20;
            this.inputEmail.Name = "inputEmail";
            this.inputEmail.Size = new System.Drawing.Size(204, 23);
            this.inputEmail.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 36;
            this.label6.Text = "Почта";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(238, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 17);
            this.label5.TabIndex = 35;
            this.label5.Text = "Дата Рождения";
            // 
            // inputDoB
            // 
            this.inputDoB.Location = new System.Drawing.Point(238, 80);
            this.inputDoB.Name = "inputDoB";
            this.inputDoB.Size = new System.Drawing.Size(200, 23);
            this.inputDoB.TabIndex = 34;
            // 
            // inputFIO
            // 
            this.inputFIO.Location = new System.Drawing.Point(12, 136);
            this.inputFIO.MaxLength = 20;
            this.inputFIO.Name = "inputFIO";
            this.inputFIO.Size = new System.Drawing.Size(204, 23);
            this.inputFIO.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 32;
            this.label4.Text = "ФИО";
            // 
            // inputLogin
            // 
            this.inputLogin.Location = new System.Drawing.Point(12, 80);
            this.inputLogin.MaxLength = 20;
            this.inputLogin.Name = "inputLogin";
            this.inputLogin.Size = new System.Drawing.Size(204, 23);
            this.inputLogin.TabIndex = 26;
            this.inputLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputLogin_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "Логин";
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
            this.cancel.TabIndex = 43;
            this.cancel.Text = "Отмена";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // createNewAccount
            // 
            this.createNewAccount.BackColor = System.Drawing.Color.LightBlue;
            this.createNewAccount.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.createNewAccount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.createNewAccount.Location = new System.Drawing.Point(11, 237);
            this.createNewAccount.Margin = new System.Windows.Forms.Padding(5);
            this.createNewAccount.Name = "createNewAccount";
            this.createNewAccount.Size = new System.Drawing.Size(204, 54);
            this.createNewAccount.TabIndex = 42;
            this.createNewAccount.Text = "Добавить";
            this.createNewAccount.UseVisualStyleBackColor = false;
            this.createNewAccount.Click += new System.EventHandler(this.createNewAccount_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(238, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 44;
            this.label2.Text = "Группа";
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(453, 305);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.createNewAccount);
            this.Controls.Add(this.inputGroup);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.inputGender);
            this.Controls.Add(this.inputEmail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.inputDoB);
            this.Controls.Add(this.inputFIO);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.inputLogin);
            this.Controls.Add(this.label1);
            this.Name = "AddStudent";
            this.Text = "AddStudent";
            this.Load += new System.EventHandler(this.AddStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox inputGroup;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox inputGender;
        private System.Windows.Forms.TextBox inputEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker inputDoB;
        private System.Windows.Forms.TextBox inputFIO;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inputLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button createNewAccount;
        private System.Windows.Forms.Label label2;
    }
}