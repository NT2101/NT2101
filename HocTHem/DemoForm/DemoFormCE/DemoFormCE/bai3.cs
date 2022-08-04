using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoFormCE
{
    public partial class bai3 : Form
    {
        public bai3()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (lsb_Trai.SelectedItem != null)
                lsb_Phai.Items.Add(lsb_Trai.SelectedItem);
            else
                MessageBox.Show("Hãy chọn 1 item");
            lsb_Trai.Items.Remove(lsb_Trai.SelectedItem);
        }

        private void btlB_Click(object sender, EventArgs e)
        {
            lsb_Phai.Items.AddRange(lsb_Trai.Items);
            lsb_Trai.Items.Clear();
        }

        private void btlC_Click(object sender, EventArgs e)
        {
            if (lsb_Phai.SelectedItem != null)
                lsb_Trai.Items.Add(lsb_Phai.SelectedItem);
            else
                MessageBox.Show("Bạn hãy chọn 1 item");
            lsb_Phai.Items.Remove(lsb_Phai.SelectedItem);
        }

        private void btlD_Click(object sender, EventArgs e)
        {
            lsb_Trai.Items.AddRange(lsb_Phai.Items);
            lsb_Phai.Items.Clear();
        }

        private void btlNhap_Click(object sender, EventArgs e)
        {
            string Trai = "";
       if(lsb_Phai != null&& lsb_Phai.Items.Count>0)
            {
                for(int i=0;i < lsb_Phai.Items.Count ;i++)
                {
                    Trai += lsb_Phai.Items[i].ToString()+ ","; 
                    
                }
                Trai = Trai.Substring(0, Trai.Length - 1);
            }
            rtxtKetQua.Text = (cbbht.Text.Trim() +  dtkA.Text.Trim()+ dtkB.Text.Trim()+ "++ Môn đã chọn:" + Trai   );
            
        }

        private void btlreset_Click(object sender, EventArgs e)
        {
           rtxtKetQua.Text = "";
            lsb_Phai.Items.Clear();
        }

        private void bai3_Load(object sender, EventArgs e)
        {

        }
    }

 
 }

