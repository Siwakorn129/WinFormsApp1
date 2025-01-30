namespace WinFormsApp1
{
    partial class FrmAddProduct
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
            txtPname = new TextBox();
            txtPrice = new TextBox();
            btnInsert = new Button();
            dgvProduct = new DataGridView();
            btnClear = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("TH Sarabun New", 19.7999973F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(159, 118);
            label1.Name = "label1";
            label1.Size = new Size(99, 44);
            label1.TabIndex = 0;
            label1.Text = "ชื่อสินค้า";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("TH Sarabun New", 19.7999973F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(182, 215);
            label2.Name = "label2";
            label2.Size = new Size(67, 44);
            label2.TabIndex = 1;
            label2.Text = "ราคา";
            // 
            // txtPname
            // 
            txtPname.BorderStyle = BorderStyle.FixedSingle;
            txtPname.Font = new Font("TH Sarabun New", 19.7999973F, FontStyle.Bold);
            txtPname.Location = new Point(305, 111);
            txtPname.Name = "txtPname";
            txtPname.Size = new Size(405, 51);
            txtPname.TabIndex = 2;
            // 
            // txtPrice
            // 
            txtPrice.BorderStyle = BorderStyle.FixedSingle;
            txtPrice.Font = new Font("TH Sarabun New", 19.7999973F, FontStyle.Bold);
            txtPrice.Location = new Point(305, 212);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(405, 51);
            txtPrice.TabIndex = 3;
            // 
            // btnInsert
            // 
            btnInsert.BackColor = Color.FromArgb(192, 255, 192);
            btnInsert.Font = new Font("TH Sarabun New", 19.7999973F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInsert.Location = new Point(744, 111);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(186, 146);
            btnInsert.TabIndex = 4;
            btnInsert.Text = "เพิ่มข้อมูล";
            btnInsert.UseVisualStyleBackColor = false;
            btnInsert.Click += btnInsert_Click;
            // 
            // dgvProduct
            // 
            dgvProduct.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProduct.Location = new Point(40, 283);
            dgvProduct.Name = "dgvProduct";
            dgvProduct.RowHeadersWidth = 51;
            dgvProduct.Size = new Size(1155, 384);
            dgvProduct.TabIndex = 5;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(255, 192, 192);
            btnClear.Font = new Font("TH Sarabun New", 19.7999973F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(961, 111);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(186, 146);
            btnClear.TabIndex = 6;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // FrmAddProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1220, 695);
            Controls.Add(btnClear);
            Controls.Add(dgvProduct);
            Controls.Add(btnInsert);
            Controls.Add(txtPrice);
            Controls.Add(txtPname);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmAddProduct";
            Text = "FrmAddProduct";
            WindowState = FormWindowState.Maximized;
            Load += FrmAddProduct_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtPname;
        private TextBox txtPrice;
        private Button btnInsert;
        private DataGridView dgvProduct;
        private Button btnClear;
    }
}