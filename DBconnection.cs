using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Data;

namespace WinFormsApp1
{
    internal class DBconnection
    {
        public static SqlConnection connectionNorthwind()
        {
            string server = "MAKHAM\\SQLEXPRESS";
            string db = "Northwind";

            //ประกาศตัวแปร conStr เพื่อเก็บค่า Connection String 
            string conStr = string.Format(@"Data Source={0}; Initial catalog={1}; 
                    Integrated Security=True; Encrypt=False;", server, db);

            //ประกาศตัวแปรเพื่อเชื่อมต่อ Database
            SqlConnection conn = new SqlConnection(conStr);
            conn.Open();
            return conn;
        }
    }
}
