namespace ProgrammingInCSharpStore.MyWindowsformApp
{
    partial class ProductForm
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
            menuStrip1 = new MenuStrip();
            productDataGridView = new DataGridView();
            menuStrip2 = new MenuStrip();
            categoryToolStripMenuItem = new ToolStripMenuItem();
            computerToolStripMenuItem = new ToolStripMenuItem();
            internalPartsToolStripMenuItem = new ToolStripMenuItem();
            cPUToolStripMenuItem = new ToolStripMenuItem();
            motherboardToolStripMenuItem = new ToolStripMenuItem();
            rAMToolStripMenuItem = new ToolStripMenuItem();
            caseToolStripMenuItem = new ToolStripMenuItem();
            powerSupplyToolStripMenuItem = new ToolStripMenuItem();
            accessoriesToolStripMenuItem = new ToolStripMenuItem();
            monitorToolStripMenuItem = new ToolStripMenuItem();
            mouseToolStripMenuItem = new ToolStripMenuItem();
            keyboardToolStripMenuItem = new ToolStripMenuItem();
            networkEquipmentToolStripMenuItem = new ToolStripMenuItem();
            modemToolStripMenuItem = new ToolStripMenuItem();
            networkCardToolStripMenuItem = new ToolStripMenuItem();
            networkAccessoriesToolStripMenuItem = new ToolStripMenuItem();
            laptopToolStripMenuItem = new ToolStripMenuItem();
            mobileToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)productDataGridView).BeginInit();
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Location = new Point(0, 33);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1618, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // productDataGridView
            // 
            productDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productDataGridView.Location = new Point(23, 336);
            productDataGridView.Name = "productDataGridView";
            productDataGridView.RowHeadersWidth = 62;
            productDataGridView.Size = new Size(1479, 630);
            productDataGridView.TabIndex = 1;
            // 
            // menuStrip2
            // 
            menuStrip2.ImageScalingSize = new Size(24, 24);
            menuStrip2.Items.AddRange(new ToolStripItem[] { categoryToolStripMenuItem });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(1618, 33);
            menuStrip2.TabIndex = 2;
            menuStrip2.Text = "menuStrip2";
            // 
            // categoryToolStripMenuItem
            // 
            categoryToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { computerToolStripMenuItem, laptopToolStripMenuItem, mobileToolStripMenuItem });
            categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
            categoryToolStripMenuItem.Size = new Size(105, 29);
            categoryToolStripMenuItem.Text = "محصولات";
            // 
            // computerToolStripMenuItem
            // 
            computerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { internalPartsToolStripMenuItem, accessoriesToolStripMenuItem, networkEquipmentToolStripMenuItem });
            computerToolStripMenuItem.Name = "computerToolStripMenuItem";
            computerToolStripMenuItem.Size = new Size(270, 34);
            computerToolStripMenuItem.Text = "کامپیوتر";
            // 
            // internalPartsToolStripMenuItem
            // 
            internalPartsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cPUToolStripMenuItem, motherboardToolStripMenuItem, rAMToolStripMenuItem, caseToolStripMenuItem, powerSupplyToolStripMenuItem });
            internalPartsToolStripMenuItem.Name = "internalPartsToolStripMenuItem";
            internalPartsToolStripMenuItem.Size = new Size(270, 34);
            internalPartsToolStripMenuItem.Text = "قطعات داخلی";
            // 
            // cPUToolStripMenuItem
            // 
            cPUToolStripMenuItem.Name = "cPUToolStripMenuItem";
            cPUToolStripMenuItem.Size = new Size(194, 34);
            cPUToolStripMenuItem.Text = "پردازنده";
            cPUToolStripMenuItem.Click += CategoryItem_Click;
            // 
            // motherboardToolStripMenuItem
            // 
            motherboardToolStripMenuItem.Name = "motherboardToolStripMenuItem";
            motherboardToolStripMenuItem.Size = new Size(194, 34);
            motherboardToolStripMenuItem.Text = "مادربورد";
            motherboardToolStripMenuItem.Click += CategoryItem_Click;
            // 
            // rAMToolStripMenuItem
            // 
            rAMToolStripMenuItem.Name = "rAMToolStripMenuItem";
            rAMToolStripMenuItem.Size = new Size(194, 34);
            rAMToolStripMenuItem.Text = "رم";
            rAMToolStripMenuItem.Click += CategoryItem_Click;
            // 
            // caseToolStripMenuItem
            // 
            caseToolStripMenuItem.Name = "caseToolStripMenuItem";
            caseToolStripMenuItem.Size = new Size(194, 34);
            caseToolStripMenuItem.Text = "کیس";
            caseToolStripMenuItem.Click += CategoryItem_Click;
            // 
            // powerSupplyToolStripMenuItem
            // 
            powerSupplyToolStripMenuItem.Name = "powerSupplyToolStripMenuItem";
            powerSupplyToolStripMenuItem.Size = new Size(194, 34);
            powerSupplyToolStripMenuItem.Text = "منبع تغذیه";
            powerSupplyToolStripMenuItem.Click += CategoryItem_Click;
            // 
            // accessoriesToolStripMenuItem
            // 
            accessoriesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { monitorToolStripMenuItem, mouseToolStripMenuItem, keyboardToolStripMenuItem });
            accessoriesToolStripMenuItem.Name = "accessoriesToolStripMenuItem";
            accessoriesToolStripMenuItem.Size = new Size(270, 34);
            accessoriesToolStripMenuItem.Text = "قطعات جانبی";
            // 
            // monitorToolStripMenuItem
            // 
            monitorToolStripMenuItem.Name = "monitorToolStripMenuItem";
            monitorToolStripMenuItem.Size = new Size(165, 34);
            monitorToolStripMenuItem.Text = "مانیتور";
            monitorToolStripMenuItem.Click += CategoryItem_Click;
            // 
            // mouseToolStripMenuItem
            // 
            mouseToolStripMenuItem.Name = "mouseToolStripMenuItem";
            mouseToolStripMenuItem.Size = new Size(165, 34);
            mouseToolStripMenuItem.Text = "ماوس";
            mouseToolStripMenuItem.Click += CategoryItem_Click;
            // 
            // keyboardToolStripMenuItem
            // 
            keyboardToolStripMenuItem.Name = "keyboardToolStripMenuItem";
            keyboardToolStripMenuItem.Size = new Size(165, 34);
            keyboardToolStripMenuItem.Text = "کیبورد";
            keyboardToolStripMenuItem.Click += CategoryItem_Click;
            // 
            // networkEquipmentToolStripMenuItem
            // 
            networkEquipmentToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { modemToolStripMenuItem, networkCardToolStripMenuItem, networkAccessoriesToolStripMenuItem });
            networkEquipmentToolStripMenuItem.Name = "networkEquipmentToolStripMenuItem";
            networkEquipmentToolStripMenuItem.Size = new Size(270, 34);
            networkEquipmentToolStripMenuItem.Text = "تجهیزات شبکه";
            // 
            // modemToolStripMenuItem
            // 
            modemToolStripMenuItem.Name = "modemToolStripMenuItem";
            modemToolStripMenuItem.Size = new Size(270, 34);
            modemToolStripMenuItem.Text = "مودم";
            modemToolStripMenuItem.Click += CategoryItem_Click;
            // 
            // networkCardToolStripMenuItem
            // 
            networkCardToolStripMenuItem.Name = "networkCardToolStripMenuItem";
            networkCardToolStripMenuItem.Size = new Size(270, 34);
            networkCardToolStripMenuItem.Text = "کارت شبکه";
            networkCardToolStripMenuItem.Click += CategoryItem_Click;
            // 
            // networkAccessoriesToolStripMenuItem
            // 
            networkAccessoriesToolStripMenuItem.Name = "networkAccessoriesToolStripMenuItem";
            networkAccessoriesToolStripMenuItem.Size = new Size(270, 34);
            networkAccessoriesToolStripMenuItem.Text = "لوازم جانبی شبکه";
            networkAccessoriesToolStripMenuItem.Click += CategoryItem_Click;
            // 
            // laptopToolStripMenuItem
            // 
            laptopToolStripMenuItem.Name = "laptopToolStripMenuItem";
            laptopToolStripMenuItem.Size = new Size(270, 34);
            laptopToolStripMenuItem.Text = "لپ تاپ";
            // 
            // mobileToolStripMenuItem
            // 
            mobileToolStripMenuItem.Name = "mobileToolStripMenuItem";
            mobileToolStripMenuItem.Size = new Size(270, 34);
            mobileToolStripMenuItem.Text = "موبایل";
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1618, 1061);
            Controls.Add(productDataGridView);
            Controls.Add(menuStrip1);
            Controls.Add(menuStrip2);
            MainMenuStrip = menuStrip1;
            Name = "ProductForm";
            Text = "ProductForm";
            ((System.ComponentModel.ISupportInitialize)productDataGridView).EndInit();
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private DataGridView productDataGridView;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem categoryToolStripMenuItem;
        private ToolStripMenuItem computerToolStripMenuItem;
        private ToolStripMenuItem internalPartsToolStripMenuItem;
        private ToolStripMenuItem accessoriesToolStripMenuItem;
        private ToolStripMenuItem laptopToolStripMenuItem;
        private ToolStripMenuItem mobileToolStripMenuItem;
        private ToolStripMenuItem cPUToolStripMenuItem;
        private ToolStripMenuItem motherboardToolStripMenuItem;
        private ToolStripMenuItem rAMToolStripMenuItem;
        private ToolStripMenuItem powerSupplyToolStripMenuItem;
        private ToolStripMenuItem caseToolStripMenuItem;
        private ToolStripMenuItem monitorToolStripMenuItem;
        private ToolStripMenuItem mouseToolStripMenuItem;
        private ToolStripMenuItem keyboardToolStripMenuItem;
        private ToolStripMenuItem networkEquipmentToolStripMenuItem;
        private ToolStripMenuItem modemToolStripMenuItem;
        private ToolStripMenuItem networkCardToolStripMenuItem;
        private ToolStripMenuItem networkAccessoriesToolStripMenuItem;
    }
}
