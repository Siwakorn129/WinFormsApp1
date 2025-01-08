namespace WinFormsApp1
{
    partial class FormProductMangement
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
            dgvResult = new DataGridView();
            label1 = new Label();
            txtPid = new TextBox();
            label2 = new Label();
            txtPname = new TextBox();
            label3 = new Label();
            txtDes = new TextBox();
            label4 = new Label();
            txtPrice = new TextBox();
            label5 = new Label();
            cboCid = new ComboBox();
            label6 = new Label();
            btnClear = new Button();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvResult).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvResult
            // 
            dgvResult.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dgvResult.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResult.Location = new Point(21, 25);
            dgvResult.Name = "dgvResult";
            dgvResult.RowHeadersWidth = 51;
            dgvResult.Size = new Size(661, 672);
            dgvResult.TabIndex = 0;
            dgvResult.CellMouseDoubleClick += dgvResult_CellMouseDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("TH Sarabun New", 22.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(77, 106);
            label1.Name = "label1";
            label1.Size = new Size(138, 49);
            label1.TabIndex = 1;
            label1.Text = "รหัสสินค้า :";
            // 
            // txtPid
            // 
            txtPid.BackColor = SystemColors.Window;
            txtPid.BorderStyle = BorderStyle.FixedSingle;
            txtPid.Font = new Font("TH Sarabun New", 22.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPid.Location = new Point(221, 104);
            txtPid.Name = "txtPid";
            txtPid.ReadOnly = true;
            txtPid.Size = new Size(534, 57);
            txtPid.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("TH Sarabun New", 22.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(91, 178);
            label2.Name = "label2";
            label2.Size = new Size(124, 49);
            label2.TabIndex = 3;
            label2.Text = "ชื่อสินค้า :";
            // 
            // txtPname
            // 
            txtPname.BackColor = SystemColors.Window;
            txtPname.BorderStyle = BorderStyle.FixedSingle;
            txtPname.Font = new Font("TH Sarabun New", 22.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPname.Location = new Point(221, 176);
            txtPname.Name = "txtPname";
            txtPname.Size = new Size(534, 57);
            txtPname.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("TH Sarabun New", 22.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(60, 252);
            label3.Name = "label3";
            label3.Size = new Size(155, 49);
            label3.TabIndex = 5;
            label3.Text = "รายละเอียด :";
            // 
            // txtDes
            // 
            txtDes.BackColor = SystemColors.Window;
            txtDes.BorderStyle = BorderStyle.FixedSingle;
            txtDes.Font = new Font("TH Sarabun New", 22.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDes.Location = new Point(221, 250);
            txtDes.Multiline = true;
            txtDes.Name = "txtDes";
            txtDes.Size = new Size(534, 139);
            txtDes.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("TH Sarabun New", 22.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(57, 406);
            label4.Name = "label4";
            label4.Size = new Size(158, 49);
            label4.TabIndex = 7;
            label4.Text = "ราคา/หน่วย :";
            // 
            // txtPrice
            // 
            txtPrice.BackColor = SystemColors.Window;
            txtPrice.BorderStyle = BorderStyle.FixedSingle;
            txtPrice.Font = new Font("TH Sarabun New", 22.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPrice.Location = new Point(221, 404);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(534, 57);
            txtPrice.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("TH Sarabun New", 22.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(688, 501);
            label5.Name = "label5";
            label5.Size = new Size(222, 49);
            label5.TabIndex = 9;
            label5.Text = "รหัสประเภทสินค้า :";
            // 
            // cboCid
            // 
            cboCid.Font = new Font("TH Sarabun New", 22.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cboCid.FormattingEnabled = true;
            cboCid.Location = new Point(214, 482);
            cboCid.Name = "cboCid";
            cboCid.Size = new Size(541, 57);
            cboCid.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("TH Sarabun New", 22.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(293, 25);
            label6.Name = "label6";
            label6.Size = new Size(0, 49);
            label6.TabIndex = 11;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Honeydew;
            btnClear.Font = new Font("TH Sarabun New", 22.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(140, 595);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(130, 68);
            btnClear.TabIndex = 12;
            btnClear.Text = "เคลียร์";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.LightCyan;
            btnAdd.Font = new Font("TH Sarabun New", 22.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(304, 595);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(130, 68);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "เพิ่ม";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.Info;
            btnUpdate.Font = new Font("TH Sarabun New", 22.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(465, 595);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(130, 68);
            btnUpdate.TabIndex = 14;
            btnUpdate.Text = "แก้ไข";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.MistyRose;
            btnDelete.Font = new Font("TH Sarabun New", 22.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(625, 595);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(130, 68);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "ลบ";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(btnClear);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(cboCid);
            groupBox1.Controls.Add(txtPrice);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtDes);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtPname);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtPid);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("TH Sarabun New", 22.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(695, 16);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(780, 684);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "ข้อมูลสินค้า";
            // 
            // FormProductMangement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1494, 722);
            Controls.Add(groupBox1);
            Controls.Add(label5);
            Controls.Add(dgvResult);
            Name = "FormProductMangement";
            Text = "จัดการข้อมูลสินค้า";
            WindowState = FormWindowState.Maximized;
            Load += FormProductMangement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvResult).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvResult;
        private Label label1;
        private TextBox txtPid;
        private Label label2;
        private TextBox txtPname;
        private Label label3;
        private TextBox txtDes;
        private Label label4;
        private TextBox txtPrice;
        private Label label5;
        private ComboBox cboCid;
        private Label label6;
        private Button btnClear;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private GroupBox groupBox1;
    }
}