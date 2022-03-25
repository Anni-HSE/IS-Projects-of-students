
namespace IS_Projects_of_students
{
    partial class Registration
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
            this.inputLogin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.inputPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.inputConfirmPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.showPassword = new System.Windows.Forms.CheckBox();
            this.inputFIO = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.inputDoB = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.inputEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.inputGender = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.createNewAccount = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.inputTypePerson = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // inputLogin
            // 
            this.inputLogin.Location = new System.Drawing.Point(24, 86);
            this.inputLogin.MaxLength = 20;
            this.inputLogin.Name = "inputLogin";
            this.inputLogin.Size = new System.Drawing.Size(204, 23);
            this.inputLogin.TabIndex = 6;
            this.inputLogin.TextChanged += new System.EventHandler(this.inputLogin_TextChanged);
            this.inputLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputLogin_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Логин";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // inputPassword
            // 
            this.inputPassword.Location = new System.Drawing.Point(24, 202);
            this.inputPassword.MaxLength = 20;
            this.inputPassword.Name = "inputPassword";
            this.inputPassword.Size = new System.Drawing.Size(204, 23);
            this.inputPassword.TabIndex = 8;
            this.inputPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputPassword_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(24, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Пароль";
            // 
            // inputConfirmPassword
            // 
            this.inputConfirmPassword.Location = new System.Drawing.Point(24, 260);
            this.inputConfirmPassword.MaxLength = 20;
            this.inputConfirmPassword.Name = "inputConfirmPassword";
            this.inputConfirmPassword.Size = new System.Drawing.Size(204, 23);
            this.inputConfirmPassword.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(24, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Павторить пароль";
            // 
            // showPassword
            // 
            this.showPassword.AutoSize = true;
            this.showPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.showPassword.ForeColor = System.Drawing.Color.White;
            this.showPassword.Location = new System.Drawing.Point(24, 289);
            this.showPassword.Name = "showPassword";
            this.showPassword.Size = new System.Drawing.Size(139, 21);
            this.showPassword.TabIndex = 12;
            this.showPassword.Text = "Показать пароль";
            this.showPassword.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.showPassword.UseVisualStyleBackColor = true;
            this.showPassword.CheckStateChanged += new System.EventHandler(this.showPassword_CheckStateChanged);
            // 
            // inputFIO
            // 
            this.inputFIO.Location = new System.Drawing.Point(251, 86);
            this.inputFIO.MaxLength = 20;
            this.inputFIO.Name = "inputFIO";
            this.inputFIO.Size = new System.Drawing.Size(204, 23);
            this.inputFIO.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(251, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "ФИО";
            // 
            // inputDoB
            // 
            this.inputDoB.Location = new System.Drawing.Point(251, 142);
            this.inputDoB.Name = "inputDoB";
            this.inputDoB.Size = new System.Drawing.Size(200, 23);
            this.inputDoB.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(251, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Дата Рождения";
            // 
            // inputEmail
            // 
            this.inputEmail.Location = new System.Drawing.Point(25, 145);
            this.inputEmail.MaxLength = 20;
            this.inputEmail.Name = "inputEmail";
            this.inputEmail.Size = new System.Drawing.Size(204, 23);
            this.inputEmail.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(25, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Почта";
            // 
            // inputGender
            // 
            this.inputGender.FormattingEnabled = true;
            this.inputGender.Location = new System.Drawing.Point(251, 202);
            this.inputGender.Name = "inputGender";
            this.inputGender.Size = new System.Drawing.Size(109, 23);
            this.inputGender.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(251, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "Пол";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Khaki;
            this.label8.Location = new System.Drawing.Point(25, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(430, 33);
            this.label8.TabIndex = 21;
            this.label8.Text = "Регистрация";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // createNewAccount
            // 
            this.createNewAccount.BackColor = System.Drawing.Color.LightBlue;
            this.createNewAccount.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.createNewAccount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.createNewAccount.Location = new System.Drawing.Point(24, 318);
            this.createNewAccount.Margin = new System.Windows.Forms.Padding(5);
            this.createNewAccount.Name = "createNewAccount";
            this.createNewAccount.Size = new System.Drawing.Size(204, 54);
            this.createNewAccount.TabIndex = 22;
            this.createNewAccount.Text = "Зарегистрироваться";
            this.createNewAccount.UseVisualStyleBackColor = false;
            this.createNewAccount.Click += new System.EventHandler(this.createNewAccount_Click);
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.Color.LightBlue;
            this.cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cancel.Location = new System.Drawing.Point(251, 318);
            this.cancel.Margin = new System.Windows.Forms.Padding(5);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(204, 54);
            this.cancel.TabIndex = 23;
            this.cancel.Text = "Отмена";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(251, 240);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 17);
            this.label9.TabIndex = 25;
            this.label9.Text = "Кто";
            // 
            // inputTypePerson
            // 
            this.inputTypePerson.FormattingEnabled = true;
            this.inputTypePerson.Location = new System.Drawing.Point(251, 260);
            this.inputTypePerson.Name = "inputTypePerson";
            this.inputTypePerson.Size = new System.Drawing.Size(109, 23);
            this.inputTypePerson.TabIndex = 24;
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(483, 393);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.inputTypePerson);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.createNewAccount);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.inputGender);
            this.Controls.Add(this.inputEmail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.inputDoB);
            this.Controls.Add(this.inputFIO);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.showPassword);
            this.Controls.Add(this.inputConfirmPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inputPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputLogin);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(499, 432);
            this.MinimumSize = new System.Drawing.Size(499, 432);
            this.Name = "Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Проектная деятельность студентов";
            this.Load += new System.EventHandler(this.Registration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputConfirmPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox showPassword;
        private System.Windows.Forms.TextBox inputFIO;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker inputDoB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox inputEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox inputGender;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button createNewAccount;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox inputTypePerson;
    }
}