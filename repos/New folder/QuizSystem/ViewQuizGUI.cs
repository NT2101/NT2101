using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizSystem
{
    public partial class ViewQuizGUI : UserControl
    {
        public ViewQuizGUI()
        {
            InitializeComponent();
        }

        private void ViewQuizGUI_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = new SqlManager().LoadAllQuizs();
        }
    }
}
