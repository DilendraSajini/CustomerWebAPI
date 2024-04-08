namespace CustomerWindow
{
    partial class SigninWindow
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
            userName = new TextBox();
            emailLabel = new Label();
            password = new TextBox();
            passwordLabel = new Label();
            signin = new Button();
            signup = new Button();
            ORLabel = new Label();
            SuspendLayout();
            // 
            // userName
            // 
            userName.Location = new Point(301, 83);
            userName.Name = "userName";
            userName.Size = new Size(260, 23);
            userName.TabIndex = 1;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(173, 91);
            emailLabel.Name = "email";
            emailLabel.Size = new Size(36, 15);
            emailLabel.TabIndex = 2;
            emailLabel.Text = "Email";
            // 
            // password
            // 
            password.Location = new Point(301, 139);
            password.Name = "textBox2";
            password.Size = new Size(260, 23);
            password.TabIndex = 3;
            // 
            // label3
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(173, 147);
            passwordLabel.Name = "password";
            passwordLabel.Size = new Size(57, 15);
            passwordLabel.TabIndex = 4;
            passwordLabel.Text = "Password";
            // 
            // button1
            // 
            signin.Location = new Point(391, 219);
            signin.Name = "signin";
            signin.Size = new Size(75, 23);
            signin.TabIndex = 5;
            signin.Text = "Sign in";
            signin.UseVisualStyleBackColor = true;
            signin.Click += signinClick;
            // 
            // signup
            // 
            signup.Location = new Point(391, 337);
            signup.Name = "signup";
            signup.Size = new Size(75, 23);
            signup.TabIndex = 6;
            signup.Text = "Sign up";
            signup.UseVisualStyleBackColor = true;
            // 
            // ORLabel
            // 
            ORLabel.AutoSize = true;
            ORLabel.Location = new Point(417, 281);
            ORLabel.Name = "or";
            ORLabel.Size = new Size(23, 15);
            ORLabel.TabIndex = 7;
            ORLabel.Text = "OR";
            // 
            // Signin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ORLabel);
            Controls.Add(signup);
            Controls.Add(signin);
            Controls.Add(passwordLabel);
            Controls.Add(password);
            Controls.Add(emailLabel);
            Controls.Add(userName);
            Name = "Signin";
            Text = "Signin";
            Load += signinLoad;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox userName;
        private Label emailLabel;
        private TextBox password;
        private Label passwordLabel;
        private Button signin;
        private Button signup;
        private Label ORLabel;
    }
}