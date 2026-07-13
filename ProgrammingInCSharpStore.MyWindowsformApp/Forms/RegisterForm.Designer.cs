namespace ProgrammingInCSharpStore.MyWindowsformApp.Forms
{
    partial class RegisterForm
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
            firstNameTextBox = new TextBox();
            firstNameLabel = new Label();
            lastNameLabel = new Label();
            lastNameTextBox = new TextBox();
            nationalCodeLabel = new Label();
            nationalCodeTextBox = new TextBox();
            phoneNumberLabel = new Label();
            phoneNumberTextBox = new TextBox();
            userNameLabel = new Label();
            userNameTextBox = new TextBox();
            passwordLabel = new Label();
            passwordTextBox = new TextBox();
            confirmPasswordLabel = new Label();
            confirmPasswordTextBox = new TextBox();
            addressLabel = new Label();
            addressTextBox = new TextBox();
            registerButton = new Button();
            cancelButton = new Button();
            emailLabel = new Label();
            emailTextBox = new TextBox();
            personalInfoGroupBox = new GroupBox();
            accountInfoGroupBox = new GroupBox();
            personalInfoGroupBox.SuspendLayout();
            accountInfoGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(145, 69);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(208, 31);
            firstNameTextBox.TabIndex = 0;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new Point(69, 72);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(34, 25);
            firstNameLabel.TabIndex = 1;
            firstNameLabel.Text = "نام";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new Point(6, 154);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(108, 25);
            lastNameLabel.TabIndex = 3;
            lastNameLabel.Text = "نام خانوادگی";
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(145, 154);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(208, 31);
            lastNameTextBox.TabIndex = 2;
            // 
            // nationalCodeLabel
            // 
            nationalCodeLabel.AutoSize = true;
            nationalCodeLabel.Location = new Point(36, 233);
            nationalCodeLabel.Name = "nationalCodeLabel";
            nationalCodeLabel.Size = new Size(67, 25);
            nationalCodeLabel.TabIndex = 5;
            nationalCodeLabel.Text = "کد ملی";
            // 
            // nationalCodeTextBox
            // 
            nationalCodeTextBox.Location = new Point(145, 227);
            nationalCodeTextBox.Name = "nationalCodeTextBox";
            nationalCodeTextBox.Size = new Size(208, 31);
            nationalCodeTextBox.TabIndex = 4;
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Location = new Point(8, 304);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new Size(106, 25);
            phoneNumberLabel.TabIndex = 7;
            phoneNumberLabel.Text = "شماره همراه";
           
            // 
            // phoneNumberTextBox
            // 
            phoneNumberTextBox.Location = new Point(145, 304);
            phoneNumberTextBox.Name = "phoneNumberTextBox";
            phoneNumberTextBox.Size = new Size(208, 31);
            phoneNumberTextBox.TabIndex = 6;
            phoneNumberTextBox.TextChanged += textBox1_TextChanged;
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Location = new Point(16, 73);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new Size(87, 25);
            userNameLabel.TabIndex = 9;
            userNameLabel.Text = "نام کاربری";
            // 
            // userNameTextBox
            // 
            userNameTextBox.Location = new Point(162, 73);
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.Size = new Size(208, 31);
            userNameTextBox.TabIndex = 8;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(36, 166);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(57, 25);
            passwordLabel.TabIndex = 11;
            passwordLabel.Text = "پسورد";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(162, 163);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(208, 31);
            passwordTextBox.TabIndex = 10;
            // 
            // confirmPasswordLabel
            // 
            confirmPasswordLabel.AutoSize = true;
            confirmPasswordLabel.Location = new Point(8, 249);
            confirmPasswordLabel.Name = "confirmPasswordLabel";
            confirmPasswordLabel.Size = new Size(96, 25);
            confirmPasswordLabel.TabIndex = 13;
            confirmPasswordLabel.Text = "تکرار پسورد";
            confirmPasswordLabel.Click += label3_Click;
            // 
            // confirmPasswordTextBox
            // 
            confirmPasswordTextBox.Location = new Point(162, 249);
            confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            confirmPasswordTextBox.Size = new Size(208, 31);
            confirmPasswordTextBox.TabIndex = 12;
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new Point(474, 160);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new Size(53, 25);
            addressLabel.TabIndex = 15;
            addressLabel.Text = "آدرس";
            // 
            // addressTextBox
            // 
            addressTextBox.Location = new Point(569, 154);
            addressTextBox.Name = "addressTextBox";
            addressTextBox.Size = new Size(217, 31);
            addressTextBox.TabIndex = 14;
            // 
            // registerButton
            // 
            registerButton.Location = new Point(677, 524);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(184, 59);
            registerButton.TabIndex = 16;
            registerButton.Text = "ثبت نام";
            registerButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(677, 644);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(184, 59);
            cancelButton.TabIndex = 17;
            cancelButton.Text = "انصراف";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(474, 63);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(52, 25);
            emailLabel.TabIndex = 19;
            emailLabel.Text = "ایمیل";
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(578, 66);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(208, 31);
            emailTextBox.TabIndex = 18;
            // 
            // personalInfoGroupBox
            // 
            personalInfoGroupBox.Controls.Add(firstNameTextBox);
            personalInfoGroupBox.Controls.Add(emailTextBox);
            personalInfoGroupBox.Controls.Add(emailLabel);
            personalInfoGroupBox.Controls.Add(addressTextBox);
            personalInfoGroupBox.Controls.Add(addressLabel);
            personalInfoGroupBox.Controls.Add(lastNameTextBox);
            personalInfoGroupBox.Controls.Add(firstNameLabel);
            personalInfoGroupBox.Controls.Add(lastNameLabel);
            personalInfoGroupBox.Controls.Add(nationalCodeLabel);
            personalInfoGroupBox.Controls.Add(nationalCodeTextBox);
            personalInfoGroupBox.Controls.Add(phoneNumberLabel);
            personalInfoGroupBox.Controls.Add(phoneNumberTextBox);
            personalInfoGroupBox.Location = new Point(35, 27);
            personalInfoGroupBox.Name = "personalInfoGroupBox";
            personalInfoGroupBox.Size = new Size(826, 385);
            personalInfoGroupBox.TabIndex = 20;
            personalInfoGroupBox.TabStop = false;
            personalInfoGroupBox.Text = "اطلاعات شخصی";
            personalInfoGroupBox.Enter += groupBox1_Enter;
            // 
            // accountInfoGroupBox
            // 
            accountInfoGroupBox.Controls.Add(userNameLabel);
            accountInfoGroupBox.Controls.Add(passwordLabel);
            accountInfoGroupBox.Controls.Add(confirmPasswordLabel);
            accountInfoGroupBox.Controls.Add(userNameTextBox);
            accountInfoGroupBox.Controls.Add(confirmPasswordTextBox);
            accountInfoGroupBox.Controls.Add(passwordTextBox);
            accountInfoGroupBox.Location = new Point(35, 451);
            accountInfoGroupBox.Name = "accountInfoGroupBox";
            accountInfoGroupBox.Size = new Size(412, 361);
            accountInfoGroupBox.TabIndex = 21;
            accountInfoGroupBox.TabStop = false;
            accountInfoGroupBox.Text = "حساب کاربری";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(894, 835);
            Controls.Add(accountInfoGroupBox);
            Controls.Add(personalInfoGroupBox);
            Controls.Add(cancelButton);
            Controls.Add(registerButton);
            Name = "RegisterForm";
            Text = "RegisterForm";
            personalInfoGroupBox.ResumeLayout(false);
            personalInfoGroupBox.PerformLayout();
            accountInfoGroupBox.ResumeLayout(false);
            accountInfoGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox firstNameTextBox;
        private Label firstNameLabel;
        private Label lastNameLabel;
        private TextBox lastNameTextBox;
        private Label nationalCodeLabel;
        private TextBox nationalCodeTextBox;
        private Label phoneNumberLabel;
        private TextBox phoneNumberTextBox;
        private Label userNameLabel;
        private TextBox userNameTextBox;
        private Label passwordLabel;
        private TextBox passwordTextBox;
        private Label confirmPasswordLabel;
        private TextBox confirmPasswordTextBox;
        private Label addressLabel;
        private TextBox addressTextBox;
        private Button registerButton;
        private Button cancelButton;
        private Label emailLabel;
        private TextBox emailTextBox;
        private GroupBox personalInfoGroupBox;
        private GroupBox accountInfoGroupBox;
    }
}