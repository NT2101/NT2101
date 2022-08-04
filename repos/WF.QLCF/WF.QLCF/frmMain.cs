using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF.QLCF
{
    public partial class frmMain : Form
    {
        public frmMain(string AccountName)
        {
            InitializeComponent();
            lblAccountName.Text = "Xin chào" + AccountName;
        }

    
        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnMenu_Account_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool bExists = false;
            foreach (Control ctrl in plnMain.Controls)
            {
                if(ctrl.Name == "ucAccount")
                {
                    bExists = true;
                    ctrl.BringToFront();
                    break;
                }
            }
            if(bExists == false)
            {
                ucAccount obj = new ucAccount();
                plnMain.Controls.Add(obj);
                obj.BringToFront();
            }
           
        }

        private void btnMenu_User_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool bExists = false;
            foreach(Control ctrl in plnMain.Controls)
            {
                if(ctrl.Name == "ucUser")
                {
                    bExists = true;
                    ctrl.BringToFront();
                    break;
                }
            }
          if(bExists ==false)
            {
                ucUser obj = new ucUser();
                plnMain.Controls.Add(obj);
                obj.BringToFront();
            }
        }
    }
}
