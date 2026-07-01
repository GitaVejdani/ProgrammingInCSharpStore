namespace ProgrammingInCSharp___Store.Forms
{
    partial class ForgetPasswordForm
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
            label1 = new Label();
            userNamerTextBox = new TextBox();
            emailAddressTextBox = new TextBox();
            label2 = new Label();
            verifyCodeButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 35);
            label1.Name = "label1";
            label1.Size = new Size(87, 25);
            label1.TabIndex = 0;
            label1.Text = "نام کاربری";
            // 
            // userNamerTextBox
            // 
            userNamerTextBox.Location = new Point(140, 29);
            userNamerTextBox.Name = "userNamerTextBox";
            userNamerTextBox.Size = new Size(235, 31);
            userNamerTextBox.TabIndex = 1;
            // 
            // emailAddressTextBox
            // 
            emailAddressTextBox.Location = new Point(140, 85);
            emailAddressTextBox.Name = "emailAddressTextBox";
            emailAddressTextBox.Size = new Size(235, 31);
            emailAddressTextBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 91);
            label2.Name = "label2";
            label2.Size = new Size(98, 25);
            label2.TabIndex = 2;
            label2.Text = "آدرس ایمیل";
            // 
            // verifyCodeButton
            // 
            verifyCodeButton.Location = new Point(21, 163);
            verifyCodeButton.Name = "verifyCodeButton";
            verifyCodeButton.Size = new Size(360, 34);
            verifyCodeButton.TabIndex = 4;
            verifyCodeButton.Text = "ارسال کد تایید";
            verifyCodeButton.UseVisualStyleBackColor = true;
            // 
            // ForgetPasswordForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(425, 233);
            Controls.Add(verifyCodeButton);
            Controls.Add(emailAddressTextBox);
            Controls.Add(label2);
            Controls.Add(userNamerTextBox);
            Controls.Add(label1);
            Name = "ForgetPasswordForm";
            Text = "ForgetPassword";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox userNamerTextBox;
        private TextBox emailAddressTextBox;
        private Label label2;
        private Button verifyCodeButton;
    }
}