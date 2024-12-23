namespace WinFormsApp1
{
    partial class FormProductByCategory
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
            cboCategory = new ComboBox();
            dgvResult = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvResult).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("TH Sarabun New", 22.1999989F, FontStyle.Bold);
            label1.Location = new Point(324, 29);
            label1.Name = "label1";
            label1.Size = new Size(273, 49);
            label1.TabIndex = 0;
            label1.Text = "เลือกประเภทของสินค้า :";
            // 
            // cboCategory
            // 
            cboCategory.Font = new Font("TH Sarabun New", 22.1999989F, FontStyle.Bold);
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(603, 26);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(342, 57);
            cboCategory.TabIndex = 1;
            cboCategory.SelectedIndexChanged += cboCategory_SelectedIndexChanged;
            // 
            // dgvResult
            // 
            dgvResult.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvResult.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResult.Location = new Point(3, 123);
            dgvResult.Name = "dgvResult";
            dgvResult.RowHeadersWidth = 51;
            dgvResult.Size = new Size(1465, 648);
            dgvResult.TabIndex = 2;
            // 
            // FormProductByCategory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1490, 783);
            Controls.Add(dgvResult);
            Controls.Add(cboCategory);
            Controls.Add(label1);
            Name = "FormProductByCategory";
            Text = "Workshop 6 : แสดงข้อมูลสินค้าแยกตามประเภท";
            WindowState = FormWindowState.Maximized;
            Load += FormProductByCategory_Load;
            ((System.ComponentModel.ISupportInitialize)dgvResult).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cboCategory;
        private DataGridView dgvResult;
    }
}