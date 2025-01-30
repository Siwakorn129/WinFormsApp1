namespace WinFormsApp1
{
    partial class FrmOrder_Counrty_Year
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
            dgvOrder = new DataGridView();
            dgvorderDetail = new DataGridView();
            label1 = new Label();
            cboCountry = new ComboBox();
            label2 = new Label();
            cboYear = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            btnShow = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvorderDetail).BeginInit();
            SuspendLayout();
            // 
            // dgvOrder
            // 
            dgvOrder.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvOrder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrder.Location = new Point(36, 86);
            dgvOrder.Name = "dgvOrder";
            dgvOrder.RowHeadersWidth = 51;
            dgvOrder.Size = new Size(1397, 386);
            dgvOrder.TabIndex = 0;
            dgvOrder.CellContentClick += dataGridView1_CellContentClick;
            dgvOrder.CellMouseClick += dgvOrder_CellMouseClick;
            // 
            // dgvorderDetail
            // 
            dgvorderDetail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvorderDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvorderDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvorderDetail.Location = new Point(36, 547);
            dgvorderDetail.Name = "dgvorderDetail";
            dgvorderDetail.RowHeadersWidth = 51;
            dgvorderDetail.Size = new Size(1397, 251);
            dgvorderDetail.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("TH Sarabun New", 19.7999973F, FontStyle.Bold);
            label1.Location = new Point(36, 16);
            label1.Name = "label1";
            label1.Size = new Size(149, 44);
            label1.TabIndex = 2;
            label1.Text = "ข้อมูลใบสั่งซื้อ";
            // 
            // cboCountry
            // 
            cboCountry.Font = new Font("TH Sarabun New", 19.7999973F, FontStyle.Bold);
            cboCountry.FormattingEnabled = true;
            cboCountry.Location = new Point(429, 13);
            cboCountry.Name = "cboCountry";
            cboCountry.Size = new Size(390, 52);
            cboCountry.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("TH Sarabun New", 19.7999973F, FontStyle.Bold);
            label2.Location = new Point(36, 490);
            label2.Name = "label2";
            label2.Size = new Size(197, 44);
            label2.TabIndex = 4;
            label2.Text = "ข้อมูลรายการสั่งซื้อ";
            // 
            // cboYear
            // 
            cboYear.Font = new Font("TH Sarabun New", 19.7999973F, FontStyle.Bold);
            cboYear.FormattingEnabled = true;
            cboYear.Location = new Point(959, 13);
            cboYear.Name = "cboYear";
            cboYear.Size = new Size(171, 52);
            cboYear.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("TH Sarabun New", 19.7999973F, FontStyle.Bold);
            label3.Location = new Point(263, 16);
            label3.Name = "label3";
            label3.Size = new Size(160, 44);
            label3.TabIndex = 6;
            label3.Text = "ประเทศที่จัดสั่ง";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("TH Sarabun New", 19.7999973F, FontStyle.Bold);
            label4.Location = new Point(852, 20);
            label4.Name = "label4";
            label4.Size = new Size(101, 44);
            label4.TabIndex = 7;
            label4.Text = "ปีที่สั่งซื้อ";
            // 
            // btnShow
            // 
            btnShow.BackColor = Color.FromArgb(128, 255, 128);
            btnShow.Font = new Font("TH Sarabun New", 19.7999973F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnShow.Location = new Point(1211, 7);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(148, 62);
            btnShow.TabIndex = 8;
            btnShow.Text = "แสดง";
            btnShow.UseVisualStyleBackColor = false;
            btnShow.Click += btnShow_Click;
            // 
            // FrmOrder_Counrty_Year
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1445, 821);
            Controls.Add(btnShow);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cboYear);
            Controls.Add(label2);
            Controls.Add(cboCountry);
            Controls.Add(label1);
            Controls.Add(dgvorderDetail);
            Controls.Add(dgvOrder);
            Name = "FrmOrder_Counrty_Year";
            Text = "FrmOrder_Counrty_Year";
            WindowState = FormWindowState.Maximized;
            Load += FrmOrder_Counrty_Year_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOrder).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvorderDetail).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvOrder;
        private DataGridView dgvorderDetail;
        private Label label1;
        private ComboBox cboCountry;
        private Label label2;
        private ComboBox cboYear;
        private Label label3;
        private Label label4;
        private Button btnShow;
    }
}