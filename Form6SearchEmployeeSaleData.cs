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
    public partial class Form6SearchEmployeeSaleData : Form
    {
        public Form6SearchEmployeeSaleData()
        {
            InitializeComponent();
        }
        public void showEmployees()
        {
            SqlConnection conn = DBconnection.connectionNorthwind();
            string sqlEmployee = "select EmployeeID, (TitleOfCourtesy+FirstName+SPACE(2)+LastName) As EmployeeName From Employees";
            SqlDataAdapter da = new SqlDataAdapter(sqlEmployee, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cboEmployee.DataSource = dt;
            cboEmployee.ValueMember = "EmployeeID";
            cboEmployee.DisplayMember = "EmployeeName";
            conn.Close();
        }
        public void showShipCountry()
        {
            SqlConnection conn = DBconnection.connectionNorthwind();
            string sqlEmployee = "select distinct ShipCountry From Orders Order By ShipCountry ASC;";
            SqlDataAdapter da = new SqlDataAdapter(sqlEmployee, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cboCountry.DataSource = dt;
            cboCountry.ValueMember = "ShipCountry";
            cboCountry.DisplayMember = "ShipCountry";
            conn.Close();
        }
        public void showOrders(int employeeID, string country)
        {
            SqlConnection conn = DBconnection.connectionNorthwind();
            string sqlOrder = String.Format("select* From Orders Where EmployeeID = {0} AND ShipCountry = '{1}'", employeeID, country);
            SqlDataAdapter da = new SqlDataAdapter(sqlOrder, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvOrder.DataSource = dt;
            conn.Close();
        }
        public void showOrders()
        {
            SqlConnection conn = DBconnection.connectionNorthwind();
            string sqlOrder = String.Format("select* From Orders");
            SqlDataAdapter da = new SqlDataAdapter(sqlOrder, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvOrder.DataSource = dt;
            conn.Close();
        }
        private void Form6SearchEmployeeSaleData_Load(object sender, EventArgs e)
        {
            showEmployees();
            showShipCountry();
            showOrders();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            int employeeID = Convert.ToInt32(cboEmployee.SelectedValue);
            string country = cboCountry.SelectedValue.ToString();
            showOrders(employeeID, country);
        }
        public void showOrderDetail(int orderID)
        {
            SqlConnection conn = DBconnection.connectionNorthwind();
            string sqlDrtail = string.Format("Select * From OrderDetails_view where orderId = {0}", orderID);
            SqlDataAdapter da = new SqlDataAdapter(sqlDrtail, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvDetail.DataSource = dt;
            conn.Close();
        }
        private void dgvDetail_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int row = e.RowIndex;
            int orderID = Convert.ToInt32(dgvOrder.Rows[row].Cells[0].Value);
            showOrderDetail(orderID);
        }

        private void dgvOrder_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int row = e.RowIndex;
            int orderID = Convert.ToInt32(dgvOrder.Rows[row].Cells[0].Value);
            showOrderDetail(orderID);
        }
    }
}
