namespace WinFormsApp1
{
    partial class Form5OrderDetail
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
            label2 = new Label();
            dgvOrder = new DataGridView();
            dgvDetail = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetail).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("TH Sarabun New", 19.7999973F, FontStyle.Bold);
            label1.Location = new Point(38, 25);
            label1.Name = "label1";
            label1.Size = new Size(95, 44);
            label1.TabIndex = 0;
            label1.Text = "ใบสั่งซื้อ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("TH Sarabun New", 19.7999973F, FontStyle.Bold);
            label2.Location = new Point(38, 540);
            label2.Name = "label2";
            label2.Size = new Size(143, 44);
            label2.TabIndex = 1;
            label2.Text = "รายการสั่งซื้อ";
            // 
            // dgvOrder
            // 
            dgvOrder.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvOrder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrder.Location = new Point(38, 72);
            dgvOrder.Name = "dgvOrder";
            dgvOrder.RowHeadersWidth = 51;
            dgvOrder.Size = new Size(1328, 450);
            dgvOrder.TabIndex = 2;
            dgvOrder.CellMouseClick += dgvOrder_CellMouseClick;
            // 
            // dgvDetail
            // 
            dgvDetail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetail.Location = new Point(38, 587);
            dgvDetail.Name = "dgvDetail";
            dgvDetail.RowHeadersWidth = 51;
            dgvDetail.Size = new Size(1328, 268);
            dgvDetail.TabIndex = 3;
            // 
            // Form5OrderDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1413, 867);
            Controls.Add(dgvDetail);
            Controls.Add(dgvOrder);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form5OrderDetail";
            Text = "ข้อมูลใบสั่งซื้อ";
            WindowState = FormWindowState.Maximized;
            Load += Form5OrderDetail_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOrder).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetail).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DataGridView dgvOrder;
        private DataGridView dgvDetail;
    }
}