using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class FrmAddUser : Form
    {
        public FrmAddUser()
        {
            InitializeComponent();
        }
        public void clearForm()
        {
            txtEmail.Clear();
            txtFirstname.Clear();
            txtLastname.Clear();
            cboPosition.SelectedIndex = 0;
            txtPassword.Clear();
            txtCFPassword.Clear();
            lblEmailErr.Text = "*";
            lblPwdErr.Text = "*";
            lblCFPwdErr.Text = "*";
        }
        public void setPosition()
        {
            cboPosition.Items.Add("Project Manager");
            cboPosition.Items.Add("Manager");
            cboPosition.Items.Add("IT Developer");
            cboPosition.Items.Add("System Administrator");
            cboPosition.Items.Add("Database Administrator");
            cboPosition.Items.Add("Project tester");
            cboPosition.Items.Add("SA");
        }
        //ฟังชันเรียกใช้ store procedure adduser transaction เพื่อบันทึกข้อมูล
        public int addNewUser()
        {
            SqlConnection conn = DBconnection.connectionDBsiwa();
            SqlCommand cmd = new SqlCommand("Adduser_Transaction", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@userID", SqlDbType.NVarChar).Value = txtEmail.Text;
            cmd.Parameters.AddWithValue("@firstname", txtFirstname.Text);
            cmd.Parameters.AddWithValue("@lastname", txtLastname.Text);
            cmd.Parameters.AddWithValue("@position", cboPosition.Text);
            cmd.Parameters.AddWithValue("@password", txtPassword.Text);

            SqlParameter result = new SqlParameter("@Result", SqlDbType.Int)
            {
                Direction = ParameterDirection.Output
            };
            cmd.Parameters.Add(result);
            cmd.ExecuteNonQuery();//ส่งคำสั่งไปsql server
            conn.Close();
            return Convert.ToInt32(result.Value);// 0 or 1
        }
        //ตรวจสอบinput 
        public int checkInputForm()
        {
            int status = 0;
            if(txtEmail.Text =="" || txtEmail.Text==null)
            {
                lblEmailErr.Text="ป้อนอีเมอล์!";
                txtEmail.Focus();
                status = -1;
            }
            else
            {
                lblEmailErr.Text = "*";
                status = 0;
            }
            if(txtPassword.Text==""||txtPassword.Text==null)
            {
                lblPwdErr.Text = "ป้อนรหัสผ่าน";
                txtPassword.Focus();
                status = -1;
            }
            else
            {
                lblPwdErr.Text = "*";
                status = 0;
            }
            if (txtCFPassword.Text != txtPassword.Text)
            {
                lblCFPwdErr.Text = "ป้อนรหัสผ่านให้ตรงกัน";
                txtCFPassword.Focus();
                status = -1;
            }
            else if(txtCFPassword.Text==""||txtCFPassword.Text==null)
            {
                lblCFPwdErr.Text = "ป้อนรหัสผ่านให้ตรงกัน";
                txtCFPassword.Focus();
                status = -1;
            }
            else
            {
                lblCFPwdErr.Text= "*";
                status = 0;
            }
            return status;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearForm();
        }

        private void FrmAddUser_Load(object sender, EventArgs e)
        {
            setPosition();
            cboPosition.SelectedIndex = 0;
            lblMsg.Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (checkInputForm()==-1)
            {
                return;
            }
            if (addNewUser()==0)
            {
                lblEmailErr.Text = "Email ซ้ำ!!! มีผู้ใช้นี้ในระบบแล้ว";
                txtEmail.Focus();
                txtEmail.SelectAll();
                lblMsg.Visible = false;
            }
            else
            {
                lblMsg.Text = "เพิ่มข้อมูลผู้ใช้ใหม่ในระบบเรียบร้อยแล้ว";
                lblMsg.Visible= true;
                clearForm();
            }
        }
    }
}
