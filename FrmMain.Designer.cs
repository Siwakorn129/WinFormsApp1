namespace WinFormsApp1
{
    partial class FrmMain
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
            menuStrip1 = new MenuStrip();
            workshopToolStripMenuItem = new ToolStripMenuItem();
            workshop12ToolStripMenuItem = new ToolStripMenuItem();
            workshop3ToolStripMenuItem = new ToolStripMenuItem();
            workshop4ToolStripMenuItem = new ToolStripMenuItem();
            workshop5ToolStripMenuItem = new ToolStripMenuItem();
            form5ToolStripMenuItem = new ToolStripMenuItem();
            จดการขอมลToolStripMenuItem = new ToolStripMenuItem();
            จดการขอมลสนคาToolStripMenuItem = new ToolStripMenuItem();
            form6SearchEmployeeSaleDataToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { workshopToolStripMenuItem, จดการขอมลToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(965, 57);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // workshopToolStripMenuItem
            // 
            workshopToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { workshop12ToolStripMenuItem, workshop3ToolStripMenuItem, workshop4ToolStripMenuItem, workshop5ToolStripMenuItem, form5ToolStripMenuItem, form6SearchEmployeeSaleDataToolStripMenuItem });
            workshopToolStripMenuItem.Font = new Font("TH Sarabun New", 22.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            workshopToolStripMenuItem.Name = "workshopToolStripMenuItem";
            workshopToolStripMenuItem.Size = new Size(153, 53);
            workshopToolStripMenuItem.Text = "Workshop";
            // 
            // workshop12ToolStripMenuItem
            // 
            workshop12ToolStripMenuItem.Name = "workshop12ToolStripMenuItem";
            workshop12ToolStripMenuItem.Size = new Size(534, 54);
            workshop12ToolStripMenuItem.Text = "Workshop 1 - 2";
            workshop12ToolStripMenuItem.Click += workshop12ToolStripMenuItem_Click;
            // 
            // workshop3ToolStripMenuItem
            // 
            workshop3ToolStripMenuItem.Name = "workshop3ToolStripMenuItem";
            workshop3ToolStripMenuItem.Size = new Size(534, 54);
            workshop3ToolStripMenuItem.Text = "Workshop 3";
            workshop3ToolStripMenuItem.Click += workshop3ToolStripMenuItem_Click;
            // 
            // workshop4ToolStripMenuItem
            // 
            workshop4ToolStripMenuItem.Name = "workshop4ToolStripMenuItem";
            workshop4ToolStripMenuItem.Size = new Size(534, 54);
            workshop4ToolStripMenuItem.Text = "Workshop 4 - 5";
            workshop4ToolStripMenuItem.Click += workshop4ToolStripMenuItem_Click;
            // 
            // workshop5ToolStripMenuItem
            // 
            workshop5ToolStripMenuItem.Name = "workshop5ToolStripMenuItem";
            workshop5ToolStripMenuItem.Size = new Size(534, 54);
            workshop5ToolStripMenuItem.Text = "Workshop 6";
            workshop5ToolStripMenuItem.Click += workshop5ToolStripMenuItem_Click;
            // 
            // form5ToolStripMenuItem
            // 
            form5ToolStripMenuItem.Name = "form5ToolStripMenuItem";
            form5ToolStripMenuItem.Size = new Size(534, 54);
            form5ToolStripMenuItem.Text = "Form 5 Order Detail";
            form5ToolStripMenuItem.Click += form5ToolStripMenuItem_Click;
            // 
            // จดการขอมลToolStripMenuItem
            // 
            จดการขอมลToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { จดการขอมลสนคาToolStripMenuItem });
            จดการขอมลToolStripMenuItem.Font = new Font("TH Sarabun New", 22.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            จดการขอมลToolStripMenuItem.Name = "จดการขอมลToolStripMenuItem";
            จดการขอมลToolStripMenuItem.Size = new Size(165, 53);
            จดการขอมลToolStripMenuItem.Text = "จัดการข้อมูล";
            // 
            // จดการขอมลสนคาToolStripMenuItem
            // 
            จดการขอมลสนคาToolStripMenuItem.Name = "จดการขอมลสนคาToolStripMenuItem";
            จดการขอมลสนคาToolStripMenuItem.Size = new Size(305, 54);
            จดการขอมลสนคาToolStripMenuItem.Text = "จัดการข้อมูลสินค้า";
            จดการขอมลสนคาToolStripMenuItem.Click += จดการขอมลสนคาToolStripMenuItem_Click;
            // 
            // form6SearchEmployeeSaleDataToolStripMenuItem
            // 
            form6SearchEmployeeSaleDataToolStripMenuItem.Name = "form6SearchEmployeeSaleDataToolStripMenuItem";
            form6SearchEmployeeSaleDataToolStripMenuItem.Size = new Size(534, 54);
            form6SearchEmployeeSaleDataToolStripMenuItem.Text = "Form 6 Search Employee Sale Data";
            form6SearchEmployeeSaleDataToolStripMenuItem.Click += form6SearchEmployeeSaleDataToolStripMenuItem_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(965, 582);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FrmMain";
            Text = "Workshop จัดการฐานข้อมูล";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem workshopToolStripMenuItem;
        private ToolStripMenuItem workshop12ToolStripMenuItem;
        private ToolStripMenuItem workshop3ToolStripMenuItem;
        private ToolStripMenuItem workshop4ToolStripMenuItem;
        private ToolStripMenuItem workshop5ToolStripMenuItem;
        private ToolStripMenuItem จดการขอมลToolStripMenuItem;
        private ToolStripMenuItem จดการขอมลสนคาToolStripMenuItem;
        private ToolStripMenuItem form5ToolStripMenuItem;
        private ToolStripMenuItem form6SearchEmployeeSaleDataToolStripMenuItem;
    }
}