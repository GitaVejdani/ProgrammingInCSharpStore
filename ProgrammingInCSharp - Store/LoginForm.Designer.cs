namespace ProgrammingInCSharp___Store
{
    partial class LoginForm
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
            UserNameLabel = new Label();
            userNameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            passwordLabel = new Label();
            forgetPasswordButton = new Button();
            registerButton = new Button();
            loginButton = new Button();
            SuspendLayout();
            // 
            // UserNameLabel
            // 
            UserNameLabel.AutoSize = true;
            UserNameLabel.Location = new Point(13, 38);
            UserNameLabel.Margin = new Padding(4, 0, 4, 0);
            UserNameLabel.Name = "UserNameLabel";
            UserNameLabel.Size = new Size(87, 25);
            UserNameLabel.TabIndex = 0;
            UserNameLabel.Text = "نام کاربری";
            
            // 
            // userNameTextBox
            // 
            userNameTextBox.Location = new Point(162, 38);
            userNameTextBox.Margin = new Padding(4, 5, 4, 5);
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.Size = new Size(595, 31);
            userNameTextBox.TabIndex = 1;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(162, 121);
            passwordTextBox.Margin = new Padding(4, 5, 4, 5);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(595, 31);
            passwordTextBox.TabIndex = 3;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(31, 109);
            passwordLabel.Margin = new Padding(4, 0, 4, 0);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(57, 25);
            passwordLabel.TabIndex = 2;
            passwordLabel.Text = "پسورد";
           
            // 
            // forgetPasswordButton
            // 
            forgetPasswordButton.Location = new Point(527, 194);
            forgetPasswordButton.Margin = new Padding(4, 5, 4, 5);
            forgetPasswordButton.Name = "forgetPasswordButton";
            forgetPasswordButton.Size = new Size(230, 51);
            forgetPasswordButton.TabIndex = 4;
            forgetPasswordButton.Text = "فراموشی رمز عبور";
            forgetPasswordButton.UseVisualStyleBackColor = true;
            forgetPasswordButton.Click += button1_Click;
            // 
            // registerButton
            // 
            registerButton.Location = new Point(250, 290);
            registerButton.Margin = new Padding(4, 5, 4, 5);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(383, 58);
            registerButton.TabIndex = 5;
            registerButton.Text = "ثبت نام کاربر";
            registerButton.UseVisualStyleBackColor = true;
            // 
            // loginButton
            // 
            loginButton.Location = new Point(162, 194);
            loginButton.Margin = new Padding(4, 5, 4, 5);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(252, 51);
            loginButton.TabIndex = 6;
            loginButton.Text = "ورود";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += button2_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(791, 373);
            Controls.Add(loginButton);
            Controls.Add(registerButton);
            Controls.Add(forgetPasswordButton);
            Controls.Add(passwordTextBox);
            Controls.Add(passwordLabel);
            Controls.Add(userNameTextBox);
            Controls.Add(UserNameLabel);
            Margin = new Padding(4, 5, 4, 5);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label UserNameLabel;
        private TextBox userNameTextBox;
        private TextBox passwordTextBox;
        private Label passwordLabel;
        private Button forgetPasswordButton;
        private Button registerButton;
        private Button loginButton;
    }
}