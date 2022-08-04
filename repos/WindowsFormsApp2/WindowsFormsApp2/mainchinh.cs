using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class mainchinh : Form
    {
        public mainchinh()
        {
            InitializeComponent();
        }
       

      

        private void khuVuiChơiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var khuvuichoi = new khuvuichoi();
            khuvuichoi.ShowDialog();
        }

        private void tròChơiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var trochoi = new trochoi();
            trochoi.ShowDialog();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var nhanvien = new nhanvien();
            nhanvien.ShowDialog();
        }

       private void véToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ve = new ve();
            ve.ShowDialog();
        }
        
        private void dịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dichvu = new dichvu();
            dichvu.ShowDialog();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mainchinh_Load(object sender, EventArgs e)
        {

        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var thongke = new thongke();
            thongke.ShowDialog();
        }

        private void véToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var ve = new ve();
            ve.ShowDialog();
        }
    }
}
