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
    public partial class FormCustomerByCountry : Form
    {
        public FormCustomerByCountry()
        {
            InitializeComponent();
        }

        public void showCountry()
        {
            SqlConnection conn = DBconnection.connectionNorthwind();

            string query = "Select Distinct Country From Customers Order By Country ASC";

            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            //แทรกรายการให้แสดงทั้งหมด
            DataRow row = dt.NewRow();
            row[0] = "----- แสดงทุกประเทศ -----";
            dt.Rows.InsertAt(row, 0);

            cboCountry.DataSource = dt;
            cboCountry.ValueMember = "Country";
            cboCountry.DisplayMember = "Country";

            conn.Close();
        }

        private void FormCustomerByCountry_Load(object sender, EventArgs e)
        {
            showCountry();
            showCustomer();
        }

        public void showCustomer(string country)
        {
            SqlConnection conn = DBconnection.connectionNorthwind();

            string query = string.Format("Select * From Customers Where country = '{0}'", country);

            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvResult.DataSource = dt;
            conn.Close();
        }

        public void showCustomer()
        {
            SqlConnection conn = DBconnection.connectionNorthwind();

            string query ="Select * From Customers";

            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvResult.DataSource = dt;
            conn.Close();
        }

        private void cboCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCountry.SelectedIndex == 0)
            {
                showCustomer();
            }
            else
            {
                showCustomer(cboCountry.SelectedValue.ToString());
            }
        }
    }
}
