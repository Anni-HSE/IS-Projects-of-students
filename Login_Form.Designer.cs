
namespace IS_Projects_of_students
{
    partial class Login_Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.inputLogin = new System.Windows.Forms.TextBox();
            this.inputPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.forgotPassword = new System.Windows.Forms.Label();
            this.loginAsTeacher = new System.Windows.Forms.Label();
            this.registration = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(78, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Логин";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightBlue;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(94, 168);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 54);
            this.button1.TabIndex = 2;
            this.button1.Text = "Вход";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // inputLogin
            // 
            this.inputLogin.Location = new System.Drawing.Point(78, 69);
            this.inputLogin.MaxLength = 20;
            this.inputLogin.Name = "inputLogin";
            this.inputLogin.Size = new System.Drawing.Size(204, 23);
            this.inputLogin.TabIndex = 4;
            this.inputLogin.TextChanged += new System.EventHandler(this.inputLogin_TextChanged);
            this.inputLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputLogin_KeyPress);
            // 
            // inputPassword
            // 
            this.inputPassword.Location = new System.Drawing.Point(78, 115);
            this.inputPassword.MaxLength = 20;
            this.inputPassword.Name = "inputPassword";
            this.inputPassword.Size = new System.Drawing.Size(204, 23);
            this.inputPassword.TabIndex = 6;
            this.inputPassword.UseSystemPasswordChar = true;
            this.inputPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputPassword_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(77, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Пароль";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Khaki;
            this.label3.Location = new System.Drawing.Point(78, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 33);
            this.label3.TabIndex = 7;
            this.label3.Text = "Авторизация";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // forgotPassword
            // 
            this.forgotPassword.AutoSize = true;
            this.forgotPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.forgotPassword.ForeColor = System.Drawing.Color.White;
            this.forgotPassword.Location = new System.Drawing.Point(180, 236);
            this.forgotPassword.Name = "forgotPassword";
            this.forgotPassword.Size = new System.Drawing.Size(102, 17);
            this.forgotPassword.TabIndex = 8;
            this.forgotPassword.Text = "Забыл пароль";
            this.forgotPassword.Click += new System.EventHandler(this.label4_Click);
            this.forgotPassword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.loginAsTeacher_MouseDown);
            this.forgotPassword.MouseLeave += new System.EventHandler(this.loginAsTeacher_MouseLeave);
            this.forgotPassword.MouseMove += new System.Windows.Forms.MouseEventHandler(this.loginAsTeacher_MouseMove);
            // 
            // loginAsTeacher
            // 
            this.loginAsTeacher.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loginAsTeacher.ForeColor = System.Drawing.Color.White;
            this.loginAsTeacher.Location = new System.Drawing.Point(90, 253);
            this.loginAsTeacher.Name = "loginAsTeacher";
            this.loginAsTeacher.Size = new System.Drawing.Size(188, 20);
            this.loginAsTeacher.TabIndex = 9;
            this.loginAsTeacher.Text = "Войти как преподаватель";
            this.loginAsTeacher.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.loginAsTeacher.Click += new System.EventHandler(this.loginAsTeacher_Click);
            this.loginAsTeacher.MouseDown += new System.Windows.Forms.MouseEventHandler(this.loginAsTeacher_MouseDown);
            this.loginAsTeacher.MouseLeave += new System.EventHandler(this.loginAsTeacher_MouseLeave);
            this.loginAsTeacher.MouseMove += new System.Windows.Forms.MouseEventHandler(this.loginAsTeacher_MouseMove);
            // 
            // registration
            // 
            this.registration.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.registration.ForeColor = System.Drawing.Color.White;
            this.registration.Location = new System.Drawing.Point(77, 236);
            this.registration.Name = "registration";
            this.registration.Size = new System.Drawing.Size(102, 17);
            this.registration.TabIndex = 10;
            this.registration.Text = "Регистрация";
            this.registration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.registration.Click += new System.EventHandler(this.registration_Click);
            this.registration.MouseDown += new System.Windows.Forms.MouseEventHandler(this.loginAsTeacher_MouseDown);
            this.registration.MouseLeave += new System.EventHandler(this.loginAsTeacher_MouseLeave);
            this.registration.MouseMove += new System.Windows.Forms.MouseEventHandler(this.loginAsTeacher_MouseMove);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(78, 144);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(139, 21);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Показать пароль";
            this.checkBox1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(359, 282);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.registration);
            this.Controls.Add(this.loginAsTeacher);
            this.Controls.Add(this.forgotPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inputPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputLogin);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(375, 321);
            this.MinimumSize = new System.Drawing.Size(375, 321);
            this.Name = "Login_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Проектная деятельность студентов";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox inputLogin;
        private System.Windows.Forms.TextBox inputPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label forgotPassword;
        private System.Windows.Forms.Label loginAsTeacher;
        private System.Windows.Forms.Label registration;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}