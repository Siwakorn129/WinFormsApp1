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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void workshop3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProductByPrice frm = new FormProductByPrice();
            frm.MdiParent = this;
            frm.Show();
        }

        private void workshop4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCustomerByCountry frm = new FormCustomerByCountry();
            frm.MdiParent = this;
            frm.Show();
        }

        private void workshop5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProductByCategory frm = new FormProductByCategory();
            frm.MdiParent = this;
            frm.Show();
        }

        private void workshop12ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
