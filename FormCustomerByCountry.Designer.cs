namespace WinFormsApp1
{
    partial class FormCustomerByCountry
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
            cboCountry = new ComboBox();
            dgvResult = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvResult).BeginInit();
            SuspendLayout();
            // 
            // cboCountry
            // 
            cboCountry.Font = new Font("TH Sarabun New", 22.1999989F, FontStyle.Bold);
            cboCountry.FormattingEnabled = true;
            cboCountry.Location = new Point(626, 31);
            cboCountry.Name = "cboCountry";
            cboCountry.Size = new Size(243, 57);
            cboCountry.TabIndex = 0;
            cboCountry.SelectedIndexChanged += cboCountry_SelectedIndexChanged;
            // 
            // dgvResult
            // 
            dgvResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResult.Location = new Point(12, 108);
            dgvResult.Name = "dgvResult";
            dgvResult.RowHeadersWidth = 51;
            dgvResult.Size = new Size(1458, 631);
            dgvResult.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("TH Sarabun New", 22.1999989F, FontStyle.Bold);
            label1.Location = new Point(299, 34);
            label1.Name = "label1";
            label1.Size = new Size(312, 49);
            label1.TabIndex = 2;
            label1.Text = "เลือกประเทศที่ตั้งของลูกค้า :";
            // 
            // FormCustomerByCountry
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1499, 751);
            Controls.Add(label1);
            Controls.Add(dgvResult);
            Controls.Add(cboCountry);
            Name = "FormCustomerByCountry";
            Text = "WorkShop 4 : แสดงข้อมูลลูกค้าแยกตามประเทศ";
            Load += FormCustomerByCountry_Load;
            ((System.ComponentModel.ISupportInitialize)dgvResult).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboCountry;
        private DataGridView dgvResult;
        private Label label1;
    }
}