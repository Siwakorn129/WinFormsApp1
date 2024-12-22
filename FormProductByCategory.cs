using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class FormProductByCategory : Form
    {
        public FormProductByCategory()
        {
            InitializeComponent();
        }

        public void showCategory()
        {
            SqlConnection conn = DBconnection.connectionNorthwind();

            string query = "Select CategoryID, CategoryName From Categories Order By CategoryName ASC";

            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            DataRow row = dt.NewRow();

            row["CategoryID"] = DBNull.Value;
            row["CategoryName"] = "---- แสดงทุกประเภท ----";
            dt.Rows.InsertAt(row, 0);

            cboCategory.DataSource = dt;
            cboCategory.ValueMember = "CategoryID";
            cboCategory.DisplayMember = "CategoryName";
        }

        private void FormProductByCategory_Load(object sender, EventArgs e)
        {
            showCategory();
        }

        public void showProduct(string CategoryID)
        {
            SqlConnection conn = DBconnection.connectionNorthwind();

            string query = string.Format("Select * From Products where CategoryID = '{0}'", CategoryID);

            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvResult.DataSource = dt;
            conn.Close();
        }

        public void showProduct()
        {
            SqlConnection conn = DBconnection.connectionNorthwind();

            string query = "Select * From Products";

            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvResult.DataSource = dt;
            conn.Close();
        }

        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCategory.SelectedIndex == 0)
            {
                showProduct();
            }
            else
            {
                showProduct(cboCategory.SelectedValue.ToString());
            }
        }
    }
}
