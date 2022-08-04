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
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
            
        }

      

        private void btnGiai_Click(object sender, EventArgs e)
        {
            try
            {
                int valueA = 0;
                int valueB = 0;
                int valueC = 0;
                bool a = int.TryParse(txta.Text.Trim(), out valueA);
                bool b = int.TryParse(txtb.Text.Trim(), out valueB);
               if (a == false)
                {
                    MessageBox.Show("Giá trị a nhập vào không phải là số", "Thông báo");
                    txta.Focus();
                    return;
                }
                if (b == false)
                {
                    MessageBox.Show("Giá trị b nhập vào không phải là số", "Thông báo");
                    txtb.Focus();
                    return;
                }

                //Giải phương trình bậc 1
                if ( rd0PTBac1.Checked == true)
                {
                    if (valueA == 0)
                    {
                        if (valueB == 0)
                        {
                            MessageBox.Show("Phương trình vô số nghiệm");
                        }
                        else
                        {
                            MessageBox.Show("Phương trình vô nghiệm");
                        }

                    }
                    else
                    {
                        txtKetQua.Text = (" Phương trình có nghiệm " + -valueB / valueA);
                    }
                }
                else
                {
                    // Giai phuong trinh bac 2
                    bool c = int.TryParse(txtb.Text.Trim(), out valueC);
                    if(c == false)
                    {
                        MessageBox.Show("Giá trị c nhập vào không phải là số", "Thông báo");
                        txtc.Focus();
                        return;
                    }
                    double denta = valueB * valueB - 4 * valueA * valueC;
                    if (denta < 0)
                    {
                        MessageBox.Show("Phuong trinh vo nghiem");
                    }
                


                }
               
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi rồi" + ex.Message);
            }
        }

        private void rd0PTBac1_CheckedChanged(object sender, EventArgs e)
        {
         
            if (rd0PTBac1.Checked == true)
                txtc.Enabled = false;
            else
                txtc.Enabled = true;
        }

        private void txtKetQua_TextChanged(object sender, EventArgs e)
        {

        }

        private void Bai2_Load(object sender, EventArgs e)
        {

        }
    }
}
