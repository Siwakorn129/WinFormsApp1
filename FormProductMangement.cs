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
using System.Data;

namespace WinFormsApp1
{
    public partial class FormProductMangement : Form
    {
        public FormProductMangement()
        {
            InitializeComponent();
        }

        public void showAllProducts()
        {
            SqlConnection conn = DBconnection.connectionDBsiwa();
            string sql = String.Format("Select P.*, categoryName From Products As P inner join Categories As C ON P.CategoryID = C.CategoryID");
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvResult.DataSource = dt;
            dgvResult.Columns[2].Visible = false;
            dgvResult.Columns[4].Visible = false;

            conn.Close();
        }

        public void showCategories()
        {
            SqlConnection conn = DBconnection.connectionDBsiwa();
            string sql = String.Format("Select * From Categories Order by categoryname ASC");
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cboCid.DataSource = dt;
            cboCid.DisplayMember = "categoryName";
            cboCid.ValueMember = "categoryID";
            conn.Close();
        }

        //--เพิ่มข้อมูลสินค้าลงในตาราง products
        public void insertProduct()
        {
            SqlConnection conn = DBconnection.connectionDBsiwa();
            string sql = "insert into Products(productName, detail, unitprice, categoryID) Values(@pname, @detail, @price, @categoryID)";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@pname", txtPname.Text);
            cmd.Parameters.AddWithValue("@detail", txtDes.Text);
            cmd.Parameters.Add("@price", SqlDbType.Money).Value = txtPrice.Text;
            cmd.Parameters.Add("@categoryID", SqlDbType.Int).Value = cboCid.SelectedValue;

            cmd.ExecuteNonQuery();
            conn.Close();

        }

        public void ClearForm()
        {
            txtPid.Clear();
            txtPname.Clear();
            txtDes.Clear();
            txtPrice.Clear();
            cboCid.SelectedIndex = 0;
        }
        private void FormProductMangement_Load(object sender, EventArgs e)
        {
            showAllProducts();
            showCategories();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtPname.Text == "" || txtPname.Text.Equals(null))
            {
                MessageBox.Show("ชื่อสินค้าห้ามเป็นค่าว่าง");
                return;
            }
            insertProduct();
            showAllProducts();
            ClearForm();
        }

        private void dgvResult_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int row = e.RowIndex;
            txtPid.Text = dgvResult.Rows[row].Cells[0].Value.ToString();
            txtPname.Text = dgvResult.Rows[row].Cells[1].Value.ToString();
            txtDes.Text = dgvResult.Rows[row].Cells[2].Value.ToString();
            txtPrice.Text = dgvResult.Rows[row].Cells[3].Value.ToString();
            cboCid.SelectedValue = dgvResult.Rows[row].Cells[4].Value;
        }

        //--แก้ไขข้อมูลสินค้าตามรหัส--
        public void updateProduct()
        {
            SqlConnection conn = DBconnection.connectionDBsiwa();
            //string sql = "insert into Products(productName, detail, unitprice, categoryID) Values(@pname, @detail, @price, @categoryID)";
            string sql = "Update Products Set productName = @pname, detail = @detail,unitprice = @price, categoryID = @categoryID Where productID = @pid";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@pname", txtPname.Text);
            cmd.Parameters.AddWithValue("@detail", txtDes.Text);
            cmd.Parameters.Add("@price", SqlDbType.Money).Value = txtPrice.Text;
            cmd.Parameters.Add("@categoryID", SqlDbType.Int).Value = cboCid.SelectedValue;
            cmd.Parameters.Add("@pid", SqlDbType.Int).Value = Convert.ToInt32(txtPid.Text);

            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtPname.Text == "" || txtPname.Text.Equals(null))
            {
                MessageBox.Show("ชื่อสินค้าห้ามเป็นค่าว่าง");
                return;
            }
            updateProduct();
            showAllProducts();
            ClearForm();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        public void deleteProduct(int pid)
        {
            SqlConnection conn = DBconnection.connectionDBsiwa();
            string sql = String.Format("Delete from Products where productID = {0}", txtPid.Text);

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@pid", pid);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("คุณต้องการลบรายการสินค้านี้ใช่หรือไม่?","ยืนยันการทำงาน",MessageBoxButtons.YesNo)==DialogResult.No)
            {
                return;
            }
            int pid = Convert.ToInt32(txtPid.Text);
            deleteProduct(pid);
            showAllProducts();
            ClearForm();
        }
    }
}
