namespace paaswordhash
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TBemailRegi = new TextBox();
            TBNicknameReg = new TextBox();
            TBPasswordReg = new TextBox();
            register = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            TBNicknameLogin = new TextBox();
            TBPasswordLogin = new TextBox();
            BTNlogin = new Button();
            labelLogin = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // TBemailRegi
            // 
            TBemailRegi.Location = new Point(57, 39);
            TBemailRegi.Name = "TBemailRegi";
            TBemailRegi.Size = new Size(125, 27);
            TBemailRegi.TabIndex = 0;
            // 
            // TBNicknameReg
            // 
            TBNicknameReg.Location = new Point(57, 105);
            TBNicknameReg.Name = "TBNicknameReg";
            TBNicknameReg.Size = new Size(125, 27);
            TBNicknameReg.TabIndex = 1;
            // 
            // TBPasswordReg
            // 
            TBPasswordReg.Location = new Point(57, 181);
            TBPasswordReg.Name = "TBPasswordReg";
            TBPasswordReg.PasswordChar = '*';
            TBPasswordReg.Size = new Size(125, 27);
            TBPasswordReg.TabIndex = 2;
            // 
            // register
            // 
            register.Location = new Point(68, 247);
            register.Name = "register";
            register.Size = new Size(94, 29);
            register.TabIndex = 3;
            register.Text = "Register";
            register.UseVisualStyleBackColor = true;
            register.Click += register_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(206, 42);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 4;
            label1.Text = "email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(206, 108);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 5;
            label2.Text = "nickname";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(206, 188);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 6;
            label3.Text = "password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 16);
            label4.Name = "label4";
            label4.Size = new Size(63, 20);
            label4.TabIndex = 7;
            label4.Text = "Register";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(527, 16);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 8;
            label5.Text = "Login";
            // 
            // TBNicknameLogin
            // 
            TBNicknameLogin.Location = new Point(527, 42);
            TBNicknameLogin.Name = "TBNicknameLogin";
            TBNicknameLogin.Size = new Size(125, 27);
            TBNicknameLogin.TabIndex = 9;
            // 
            // TBPasswordLogin
            // 
            TBPasswordLogin.Location = new Point(527, 87);
            TBPasswordLogin.Name = "TBPasswordLogin";
            TBPasswordLogin.Size = new Size(125, 27);
            TBPasswordLogin.TabIndex = 10;
            // 
            // BTNlogin
            // 
            BTNlogin.Location = new Point(544, 147);
            BTNlogin.Name = "BTNlogin";
            BTNlogin.Size = new Size(94, 29);
            BTNlogin.TabIndex = 11;
            BTNlogin.Text = "Login";
            BTNlogin.UseVisualStyleBackColor = true;
            BTNlogin.Click += BTNlogin_Click;
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Location = new Point(670, 49);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(72, 20);
            labelLogin.TabIndex = 12;
            labelLogin.Text = "nickname";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(670, 94);
            label6.Name = "label6";
            label6.Size = new Size(72, 20);
            label6.TabIndex = 13;
            label6.Text = "password";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(labelLogin);
            Controls.Add(BTNlogin);
            Controls.Add(TBPasswordLogin);
            Controls.Add(TBNicknameLogin);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(register);
            Controls.Add(TBPasswordReg);
            Controls.Add(TBNicknameReg);
            Controls.Add(TBemailRegi);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TBemailRegi;
        private TextBox TBNicknameReg;
        private TextBox TBPasswordReg;
        private Button register;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox TBNicknameLogin;
        private TextBox TBPasswordLogin;
        private Button BTNlogin;
        private Label labelLogin;
        private Label label6;
    }
}
