using Microsoft.Data.SqlClient;
using System.Data;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = DBconnection.connectionNorthwind();

            if (conn.State == ConnectionState.Open)
            {
                MessageBox.Show("ติดต่อฐานข้อมูล Northwind สำเร็จ");
            }
            conn.Close();
        }

        
    }
}
