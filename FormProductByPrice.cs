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
    public partial class FormProductByPrice : Form
    {
        public FormProductByPrice()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            //เปิดการเชื่อมต่อฐานข้อมูล Northwind
            SqlConnection conn = DBconnection.connectionNorthwind();

            string startPrice = txtStart.Text;
            string endPrice = txtEnd.Text;

            string query = string.Format("Select * From Products Where UnitPrice Between {0} And {1}", startPrice, endPrice);

            //ส่งคำสั่ง sql ไปรันที่ sever และรับค่ากลับมา
            SqlDataAdapter da = new SqlDataAdapter(query, conn);

            //สร้าง object dt จากคสาส DataTable เพื่อรองรับการเก็บข้อมูลในรูปแบบตาราง
            DataTable dt = new DataTable();
            da.Fill(dt); //นำผลลัพธ์จากการรับกลับจากออบเจ็ก da ใส่ใน dt

            dgvResult.DataSource = dt;//กำหนดค่า DataGridVeiw จากข้อมูลใน dt

            conn.Close();
        }
    }
}
