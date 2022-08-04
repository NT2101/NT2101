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
    public partial class ViewListExam : UserControl
    {
        public ViewListExam()
        {
            InitializeComponent();
        }

        private void ViewListExam_Load(object sender, EventArgs e)
        {
            gridExamList.DataSource = new SqlManager().LoadAllExamLists();
        }
    }
}
