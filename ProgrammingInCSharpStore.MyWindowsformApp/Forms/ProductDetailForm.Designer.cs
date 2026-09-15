namespace ProgrammingInCSharpStore.MyWindowsformApp.Forms
{
    partial class ProductDetailForm
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
            productPictureBox = new PictureBox();
            addToCartButton = new Button();
            productNameLabel = new Label();
            priceLabel = new Label();
            statusLabel = new Label();
            productInfoGroupBox = new GroupBox();
            statusTextBox = new TextBox();
            productPriceTextBox = new TextBox();
            productNameTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)productPictureBox).BeginInit();
            productInfoGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // productPictureBox
            // 
            productPictureBox.Location = new Point(48, 56);
            productPictureBox.Name = "productPictureBox";
            productPictureBox.Size = new Size(502, 479);
            productPictureBox.TabIndex = 0;
            productPictureBox.TabStop = false;
            // 
            // addToCartButton
            // 
            addToCartButton.Location = new Point(1265, 439);
            addToCartButton.Name = "addToCartButton";
            addToCartButton.Size = new Size(234, 44);
            addToCartButton.TabIndex = 1;
            addToCartButton.Text = "افزودن به سبد خرید";
            addToCartButton.UseVisualStyleBackColor = true;
            // 
            // productNameLabel
            // 
            productNameLabel.AutoSize = true;
            productNameLabel.Location = new Point(680, 81);
            productNameLabel.Name = "productNameLabel";
            productNameLabel.Size = new Size(104, 25);
            productNameLabel.TabIndex = 2;
            productNameLabel.Text = "نام محصول:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new Point(659, 149);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(130, 25);
            priceLabel.TabIndex = 3;
            priceLabel.Text = "قیمت محصول :";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new Point(695, 224);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(82, 25);
            statusLabel.TabIndex = 4;
            statusLabel.Text = "وضعیت :";
            // 
            // productInfoGroupBox
            // 
            productInfoGroupBox.Controls.Add(statusTextBox);
            productInfoGroupBox.Controls.Add(productPriceTextBox);
            productInfoGroupBox.Controls.Add(productNameTextBox);
            productInfoGroupBox.Controls.Add(productNameLabel);
            productInfoGroupBox.Controls.Add(statusLabel);
            productInfoGroupBox.Controls.Add(priceLabel);
            productInfoGroupBox.Location = new Point(684, 44);
            productInfoGroupBox.Name = "productInfoGroupBox";
            productInfoGroupBox.Size = new Size(815, 327);
            productInfoGroupBox.TabIndex = 5;
            productInfoGroupBox.TabStop = false;
            productInfoGroupBox.Text = "اطلاعات محصول";
            // 
            // statusTextBox
            // 
            statusTextBox.Location = new Point(20, 233);
            statusTextBox.Name = "statusTextBox";
            statusTextBox.Size = new Size(628, 31);
            statusTextBox.TabIndex = 7;
            // 
            // productPriceTextBox
            // 
            productPriceTextBox.Location = new Point(20, 149);
            productPriceTextBox.Name = "productPriceTextBox";
            productPriceTextBox.Size = new Size(628, 31);
            productPriceTextBox.TabIndex = 6;
            // 
            // productNameTextBox
            // 
            productNameTextBox.Location = new Point(20, 75);
            productNameTextBox.Name = "productNameTextBox";
            productNameTextBox.Size = new Size(628, 31);
            productNameTextBox.TabIndex = 5;
            // 
            // ProductDetailForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1543, 596);
            Controls.Add(productInfoGroupBox);
            Controls.Add(addToCartButton);
            Controls.Add(productPictureBox);
            Name = "ProductDetailForm";
            Text = "ProductDetailForm";
            ((System.ComponentModel.ISupportInitialize)productPictureBox).EndInit();
            productInfoGroupBox.ResumeLayout(false);
            productInfoGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button addToCartButton;
        private PictureBox productpictureBox;
        private PictureBox productPictureBox;
        private Label productNameLabel;
        private Label priceLabel;
        private Label statusLabel;
        private GroupBox productInfoGroupBox;
        private TextBox statusTextBox;
        private TextBox productPriceTextBox;
        private TextBox productNameTextBox;
    }
}