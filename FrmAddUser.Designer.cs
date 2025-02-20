namespace WinFormsApp1
{
    partial class FrmAddUser
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
            txtEmail = new TextBox();
            txtFirstname = new TextBox();
            label2 = new Label();
            txtLastname = new TextBox();
            label3 = new Label();
            label4 = new Label();
            cboPosition = new ComboBox();
            txtPassword = new TextBox();
            label5 = new Label();
            txtCFPassword = new TextBox();
            label6 = new Label();
            btnSave = new Button();
            btnClear = new Button();
            lblEmailErr = new Label();
            lblPwdErr = new Label();
            lblCFPwdErr = new Label();
            lblMsg = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("TH Sarabun New", 19.7999973F, FontStyle.Bold);
            label1.Location = new Point(195, 145);
            label1.Name = "label1";
            label1.Size = new Size(79, 44);
            label1.TabIndex = 0;
            label1.Text = "อีเมล์ :";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("TH Sarabun New", 19.7999973F, FontStyle.Bold);
            txtEmail.Location = new Point(289, 138);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(293, 51);
            txtEmail.TabIndex = 1;
            // 
            // txtFirstname
            // 
            txtFirstname.Font = new Font("TH Sarabun New", 19.7999973F, FontStyle.Bold);
            txtFirstname.Location = new Point(289, 205);
            txtFirstname.Name = "txtFirstname";
            txtFirstname.Size = new Size(293, 51);
            txtFirstname.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("TH Sarabun New", 19.7999973F, FontStyle.Bold);
            label2.Location = new Point(215, 208);
            label2.Name = "label2";
            label2.Size = new Size(59, 44);
            label2.TabIndex = 2;
            label2.Text = "ชื่อ :";
            // 
            // txtLastname
            // 
            txtLastname.Font = new Font("TH Sarabun New", 19.7999973F, FontStyle.Bold);
            txtLastname.Location = new Point(289, 266);
            txtLastname.Name = "txtLastname";
            txtLastname.Size = new Size(293, 51);
            txtLastname.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("TH Sarabun New", 19.7999973F, FontStyle.Bold);
            label3.Location = new Point(163, 269);
            label3.Name = "label3";
            label3.Size = new Size(111, 44);
            label3.TabIndex = 4;
            label3.Text = "นามสกุล :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("TH Sarabun New", 19.7999973F, FontStyle.Bold);
            label4.Location = new Point(125, 332);
            label4.Name = "label4";
            label4.Size = new Size(149, 44);
            label4.TabIndex = 6;
            label4.Text = "ตำแหน่งงาน :";
            // 
            // cboPosition
            // 
            cboPosition.Font = new Font("TH Sarabun New", 19.7999973F, FontStyle.Bold);
            cboPosition.FormattingEnabled = true;
            cboPosition.Location = new Point(289, 329);
            cboPosition.Name = "cboPosition";
            cboPosition.Size = new Size(293, 52);
            cboPosition.TabIndex = 8;
            cboPosition.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("TH Sarabun New", 19.7999973F, FontStyle.Bold);
            txtPassword.Location = new Point(289, 385);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(293, 51);
            txtPassword.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("TH Sarabun New", 19.7999973F, FontStyle.Bold);
            label5.Location = new Point(162, 388);
            label5.Name = "label5";
            label5.Size = new Size(112, 44);
            label5.TabIndex = 9;
            label5.Text = "รหัสผ่าน :";
            // 
            // txtCFPassword
            // 
            txtCFPassword.Font = new Font("TH Sarabun New", 19.7999973F, FontStyle.Bold);
            txtCFPassword.Location = new Point(289, 445);
            txtCFPassword.Name = "txtCFPassword";
            txtCFPassword.PasswordChar = '*';
            txtCFPassword.Size = new Size(293, 51);
            txtCFPassword.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("TH Sarabun New", 19.7999973F, FontStyle.Bold);
            label6.Location = new Point(106, 452);
            label6.Name = "label6";
            label6.Size = new Size(168, 44);
            label6.TabIndex = 11;
            label6.Text = "ยืนยันรหัสผ่าน :";
            // 
            // btnSave
            // 
            btnSave.Font = new Font("TH Sarabun New", 19.7999973F, FontStyle.Bold);
            btnSave.Location = new Point(393, 556);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(110, 53);
            btnSave.TabIndex = 13;
            btnSave.Text = "บันทึก";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("TH Sarabun New", 19.7999973F, FontStyle.Bold);
            btnClear.Location = new Point(557, 545);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(107, 50);
            btnClear.TabIndex = 14;
            btnClear.Text = "เคลียร์";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // lblEmailErr
            // 
            lblEmailErr.AutoSize = true;
            lblEmailErr.Font = new Font("TH Sarabun New", 19.7999973F, FontStyle.Bold);
            lblEmailErr.ForeColor = Color.Red;
            lblEmailErr.Location = new Point(747, 141);
            lblEmailErr.Name = "lblEmailErr";
            lblEmailErr.Size = new Size(30, 44);
            lblEmailErr.TabIndex = 15;
            lblEmailErr.Text = "*";
            // 
            // lblPwdErr
            // 
            lblPwdErr.AutoSize = true;
            lblPwdErr.Font = new Font("TH Sarabun New", 19.7999973F, FontStyle.Bold);
            lblPwdErr.ForeColor = Color.Red;
            lblPwdErr.Location = new Point(757, 385);
            lblPwdErr.Name = "lblPwdErr";
            lblPwdErr.Size = new Size(30, 44);
            lblPwdErr.TabIndex = 16;
            lblPwdErr.Text = "*";
            // 
            // lblCFPwdErr
            // 
            lblCFPwdErr.AutoSize = true;
            lblCFPwdErr.Font = new Font("TH Sarabun New", 19.7999973F, FontStyle.Bold);
            lblCFPwdErr.ForeColor = Color.Red;
            lblCFPwdErr.Location = new Point(757, 448);
            lblCFPwdErr.Name = "lblCFPwdErr";
            lblCFPwdErr.Size = new Size(30, 44);
            lblCFPwdErr.TabIndex = 17;
            lblCFPwdErr.Text = "*";
            // 
            // lblMsg
            // 
            lblMsg.AutoSize = true;
            lblMsg.Font = new Font("TH Sarabun New", 19.7999973F, FontStyle.Bold);
            lblMsg.ForeColor = Color.Lime;
            lblMsg.Location = new Point(80, 614);
            lblMsg.Name = "lblMsg";
            lblMsg.Size = new Size(30, 44);
            lblMsg.TabIndex = 18;
            lblMsg.Text = "*";
            // 
            // FrmAddUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1074, 721);
            Controls.Add(lblMsg);
            Controls.Add(lblCFPwdErr);
            Controls.Add(lblPwdErr);
            Controls.Add(lblEmailErr);
            Controls.Add(btnClear);
            Controls.Add(btnSave);
            Controls.Add(txtCFPassword);
            Controls.Add(label6);
            Controls.Add(txtPassword);
            Controls.Add(label5);
            Controls.Add(cboPosition);
            Controls.Add(label4);
            Controls.Add(txtLastname);
            Controls.Add(label3);
            Controls.Add(txtFirstname);
            Controls.Add(label2);
            Controls.Add(txtEmail);
            Controls.Add(label1);
            Name = "FrmAddUser";
            Text = "FrmAddUser";
            WindowState = FormWindowState.Maximized;
            Load += FrmAddUser_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtEmail;
        private TextBox txtFirstname;
        private Label label2;
        private TextBox txtLastname;
        private Label label3;
        private Label label4;
        private ComboBox cboPosition;
        private TextBox txtPassword;
        private Label label5;
        private TextBox txtCFPassword;
        private Label label6;
        private Button btnSave;
        private Button btnClear;
        private Label lblEmailErr;
        private Label lblPwdErr;
        private Label lblCFPwdErr;
        private Label lblMsg;
    }
}