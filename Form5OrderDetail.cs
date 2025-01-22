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
    public partial class Form5OrderDetail : Form
    {
        public Form5OrderDetail()
        {
            InitializeComponent();
        }
        public void showOrder()
        {
            SqlConnection conn = DBconnection.connectionNorthwind();
            string sqlOrder = string.Format("Select * From Orders_view;");
            SqlDataAdapter da = new SqlDataAdapter(sqlOrder, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvOrder.DataSource = dt;
            conn.Close();
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
        private void Form5OrderDetail_Load(object sender, EventArgs e)
        {
            showOrder();
        }
        private void dgvOrder_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int row = e.RowIndex;
            int orderID = Convert.ToInt32(dgvOrder.Rows[row].Cells[0].Value);
            showOrderDetail(orderID);
        }
    }
}
