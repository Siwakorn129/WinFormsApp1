namespace WinFormsApp1
{
    partial class FormProductByPrice
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
            txtStart = new TextBox();
            txtEnd = new TextBox();
            btnShow = new Button();
            dgvResult = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvResult).BeginInit();
            SuspendLayout();
            // 
            // txtStart
            // 
            txtStart.BorderStyle = BorderStyle.FixedSingle;
            txtStart.Font = new Font("TH Sarabun New", 22.1999989F, FontStyle.Bold);
            txtStart.Location = new Point(280, 29);
            txtStart.Name = "txtStart";
            txtStart.Size = new Size(172, 57);
            txtStart.TabIndex = 0;
            // 
            // txtEnd
            // 
            txtEnd.BorderStyle = BorderStyle.FixedSingle;
            txtEnd.Font = new Font("TH Sarabun New", 22.1999989F, FontStyle.Bold);
            txtEnd.Location = new Point(595, 29);
            txtEnd.Name = "txtEnd";
            txtEnd.Size = new Size(170, 57);
            txtEnd.TabIndex = 1;
            // 
            // btnShow
            // 
            btnShow.BackColor = SystemColors.Info;
            btnShow.Font = new Font("TH Sarabun New", 22.1999989F, FontStyle.Bold);
            btnShow.Location = new Point(831, 22);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(191, 67);
            btnShow.TabIndex = 2;
            btnShow.Text = "แสดงข้อมูล";
            btnShow.UseVisualStyleBackColor = false;
            btnShow.Click += btnShow_Click;
            // 
            // dgvResult
            // 
            dgvResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResult.Location = new Point(12, 110);
            dgvResult.Name = "dgvResult";
            dgvResult.RowHeadersWidth = 51;
            dgvResult.Size = new Size(1444, 659);
            dgvResult.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("TH Sarabun New", 22.1999989F, FontStyle.Bold);
            label1.Location = new Point(61, 37);
            label1.Name = "label1";
            label1.Size = new Size(213, 49);
            label1.TabIndex = 4;
            label1.Text = "ราคาสินค้าเริ่มต้น :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("TH Sarabun New", 22.1999989F, FontStyle.Bold);
            label2.Location = new Point(476, 37);
            label2.Name = "label2";
            label2.Size = new Size(113, 49);
            label2.TabIndex = 5;
            label2.Text = "ถึงราคา :";
            // 
            // FormProductByPrice
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1468, 781);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvResult);
            Controls.Add(btnShow);
            Controls.Add(txtEnd);
            Controls.Add(txtStart);
            Name = "FormProductByPrice";
            Text = "Workshop 3 : ค้นหาสินค้าตามช่วงของราคา";
            ((System.ComponentModel.ISupportInitialize)dgvResult).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtStart;
        private TextBox txtEnd;
        private Button btnShow;
        private DataGridView dgvResult;
        private Label label1;
        private Label label2;
    }
}