using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using xls = Microsoft.Office.Interop.Excel;

namespace WindowsFormsApp2
{
    public partial class trochoi : Form
    {

        SqlConnection con = new SqlConnection("Data Source=LAPTOP-MFDIDQSO\\MAYAO;Initial Catalog=QLKVC;Integrated Security=True");
        public trochoi()
        {
            InitializeComponent();
        }

       


        private void Load_trochoi()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select *from trochoi", con);
            SqlDataAdapter dap = new SqlDataAdapter();
            dap.SelectCommand = cmd;
            cmd.Dispose();
            con.Close();

            DataTable dt = new DataTable();
            dap.Fill(dt);

            grvtc.DataSource = dt;
            grvtc.Refresh();
            txtmtc.DataBindings.Clear();
            txtttc.DataBindings.Clear();
            txtvitri.DataBindings.Clear();
            txtdientich.DataBindings.Clear();

          //  cbtrangthai.DataBindings.Clear();
            txtttc.DataBindings.Add("text", grvtc.DataSource, "ttc");
            txtmtc.DataBindings.Add("text", grvtc.DataSource, "mtc");
            txtvitri.DataBindings.Add("text", grvtc.DataSource, "vitri");
           
            txtdientich.DataBindings.Add("text", grvtc.DataSource, "dientich");
            
          
            //cbtrangthai.Enabled = false;

        }

        private void trochoi_Load(object sender, EventArgs e)
        {
           

            txtttc.Enabled = false;
            txtmtc.Enabled = false;
            txtvitri.Enabled = false;
            txtdientich.Enabled = false;
          //  cbtrangthai.Enabled = false;
            btluu.Enabled = false;
            btthem.Enabled = true;
            btsua.Enabled = false;
            btxoa.Enabled = false;
            Load_trochoi();

            cbtk_CheckedChanged(sender, e);
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            txtdientich.Enabled = true;
            txtttc.Enabled = true;
            txtmtc.Enabled = true;
            txtvitri.Enabled = true;
            txtdientich.Enabled = true;
          //  cbtrangthai.Enabled = true;
            

            btluu.Enabled = true;
            btthem.Enabled = true;
            btsua.Enabled = true;
            btxoa.Enabled = true;

            txtttc.Text = "";
            txtmtc.Text = "";
            txtvitri.Text = "";
            txtdientich.Text = " ";
         //   cbtrangthai.Text = "";

            txtttc.Focus();
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            string p_MaTC = txtmtc.Text.Trim();
            string p_TenTC = txtttc.Text.Trim();
            string p_vitri = txtvitri.Text.Trim();
            string p_dientich = txtdientich.Text.Trim();




            string sqlsua = "Update  trochoi Set     ttc = '" + p_TenTC + "'," +
               "vitri = '" + p_vitri + "',trangthai = '"+cbtrangthai.Text.Trim()+ "',dientich = '" + p_dientich + "' where mtc = '" + p_MaTC + "'" ;

            con.Open();
            SqlCommand cmd = new SqlCommand(sqlsua, con);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            Load_trochoi();
            MessageBox.Show("Sửa thành công");
        }

        private void btxoa_Click(object sender, EventArgs e)
        {

            string p_MaTC = txtmtc.Text.Trim();
            con.Open();
            SqlCommand cmd = new SqlCommand("trochoi_Del", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@mtc", SqlDbType.NVarChar, 50).Value = p_MaTC;

            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();

            Load_trochoi();


            MessageBox.Show("Xóa thành công");
        }

        private void btluu_Click(object sender, EventArgs e)
        {

            string p_MaTC = txtmtc.Text.Trim();
            if (p_MaTC == "")
            {
                MessageBox.Show("Nhập mã MÃ trò chơi nào", "Thông Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmtc.Focus();
                return;
            }
            string p_TenTC = txtttc.Text.Trim();
            if (p_TenTC == "")
            {
                MessageBox.Show("Nhập Tên Trò Chơi đi", "Thông Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtttc.Focus();
                return;
            }
           
            string p_Vitri = txtvitri.Text.Trim();
          
            string p_dientich = txtdientich.Text.Trim();

            string sqlthem = "Insert into trochoi Values('" + p_MaTC + "',N'"
                + p_TenTC + "', '" + p_Vitri + "','"+cbtrangthai.Text.Trim()+"','"+p_dientich+"')";
            if (kiemtratontai())
            {
                MessageBox.Show("Mã đã tồn tại");
            }
            else
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(sqlthem, con);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();
                Load_trochoi();

                MessageBox.Show("Thêm thành công");
            }

        }

        private void btxuat_Click(object sender, EventArgs e)
        {
            load_bang();
        }

        private void grvtc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btxoa.Enabled = true;
            btluu.Enabled = true;
            btsua.Enabled = true;
        }
        private bool kiemtratontai()
        {
            bool tatkt = false;
            string matrochoi = txtttc.Text;

            SqlCommand cmd = new SqlCommand("Select * from trochoi", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (matrochoi == dr.GetString(0))
                {
                    tatkt = true;
                    break;
                }
            }
            con.Close();
            return tatkt;
        }

        public void ExportExcel(DataTable tb, string sheetname, string title)
        {
            //Tạo các đối tượng Excel

            xls.Application oExcel = new xls.Application();
            xls.Workbooks oBooks;
            xls.Sheets oSheets;
            xls.Workbook oBook;
            xls.Worksheet oSheet;

            //Tạo mới một Excel WorkBook 
            oExcel.Visible = true;
            oExcel.DisplayAlerts = false;
            oExcel.Application.SheetsInNewWorkbook = 1;
            oBooks = oExcel.Workbooks;
            oBook = (xls.Workbook)(oExcel.Workbooks.Add(Type.Missing));
            oSheets = oBook.Worksheets;
            oSheet = (xls.Worksheet)oSheets.get_Item(1);
            oSheet.Name = sheetname;

            // Tạo phần đầu nếu muốn
            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1"," E1");
            head.MergeCells = true; // lệnh gộp ô
            head.Value2 = "Danh Sách Trò Chơi";
            head.Font.Bold = true;
            head.Font.Name = "Times New Roman ";
            head.Font.Size = "18";
            // Căn giữa
            head.HorizontalAlignment = xls.XlHAlign.xlHAlignCenter;

            // Tạo tiêu đề cột 
            // Bắt đầu từ A3
            // A1 Danh sách 
            // A2 cách ra 
            xls.Range cl1 = oSheet.get_Range("A3", "A3");
            cl1.Value2 = "Mã Trò Chơi";
            cl1.ColumnWidth = 12.0;

            xls.Range cl2 = oSheet.get_Range("B3", "B3");
            cl2.Value2 = "Tên Trò Chơi";
            cl2.ColumnWidth = 25.0;

            xls.Range cl3 = oSheet.get_Range("C3", "C3");
            cl3.Value2 = "Vị Trí";
            cl3.ColumnWidth = 35.0;

            xls.Range cl4 = oSheet.get_Range("D3", "D3");
            cl4.Value2 = "Trạng thái";
            cl4.ColumnWidth = 15.0;

            xls.Range cl5 = oSheet.get_Range("E3", "E3");
            cl5.Value2 = "Diện tích";
            cl5.ColumnWidth = 15.0;
        






            xls.Range rowHead = oSheet.get_Range("A3", "E3");
            rowHead.Font.Bold = true;
            // Kẻ viền
            rowHead.Borders.LineStyle = xls.Constants.xlSolid;

            // Thiết lập màu nền
            rowHead.Interior.ColorIndex = 4;
            rowHead.HorizontalAlignment = xls.XlHAlign.xlHAlignCenter;

            // Tạo mảng đối tượng để lưu dữ toàn bồ dữ liệu trong DataTable,
            // vì dữ liệu được được gán vào các Cell trong Excel phải thông qua object thuần.
            // mảng 2 chiều : số lượng cột và hàng
            object[,] arr = new object[tb.Rows.Count, tb.Columns.Count];

            //Chuyển dữ liệu từ DataTable vào mảng đối
            //vòng 1 duyệt hàng

            for (int r = 0; r < tb.Rows.Count; r++)
            {
                DataRow dr = tb.Rows[r];
                for (int c = 0; c < tb.Columns.Count; c++)

                {
                    arr[r, c] = dr[c];
                }
            }
            //Thiết lập vùng điền dữ liệu
            int rowStart = 4; // ô thứ 4
            int columnStart = 1;
            int rowEnd = rowStart + tb.Rows.Count - 1;
            int columnEnd = tb.Columns.Count;
            // Ô bắt đầu điền dữ liệu
            xls.Range c1 = (xls.Range)oSheet.Cells[rowStart, columnStart];
            // Ô kết thúc điền dữ liệu
            xls.Range c2 = (xls.Range)oSheet.Cells[rowEnd, columnEnd];
            // Lấy về vùng điền dữ liệu
            xls.Range range = oSheet.get_Range(c1, c2);
            //Điền dữ liệu vào vùng đã thiết lập
            range.Value2 = arr;
            // Kẻ viền
            range.Borders.LineStyle = xls.Constants.xlSolid;
            /* Căn giữa cột STT
            Microsoft.Office.Interop.Excel.Range c3 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnStart];
            Microsoft.Office.Interop.Excel.Range c4 = oSheet.get_Range(c1, c3);*/
            oSheet.get_Range(c1, c2).HorizontalAlignment = xls.XlHAlign.xlHAlignCenter;

        }



        private void load_bang()
        {
            DataTable dt = new DataTable();
            DataColumn col1 = new DataColumn("mtc");
            DataColumn col2 = new DataColumn("ttc");
            DataColumn col3 = new DataColumn("vitri");
          //  DataColumn col4 = new DataColumn("trangthai");
            DataColumn col5 = new DataColumn("dientich");
          

            dt.Columns.Add(col1);
            dt.Columns.Add(col2);
            dt.Columns.Add(col3);
          //  dt.Columns.Add(col4);
            dt.Columns.Add(col5);


            foreach (DataGridViewRow dgr in grvtc.Rows)
            {
                DataRow dtr = dt.NewRow();
                dtr[0] = dgr.Cells[0].Value;
                dtr[1] = dgr.Cells[1].Value;
                dtr[2] = dgr.Cells[2].Value;
                //dtr[3] = dgr.Cells[3].Value;
                dtr[4] = dgr.Cells[4].Value;
   

                dt.Rows.Add(dtr);
            }
            ExportExcel(dt, "DanhSach", "Danh Sách Trò Chơi");
        }

        private void txtTk_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string sqltimkiem = "select mtc, ttc,vitri,trangthai,dientich " +
                    "from trochoi where mtc like " +
                "N'%" + txtTk.Text + "%' ";
                SqlDataAdapter dap = new SqlDataAdapter(sqltimkiem, con);
                DataTable dt = new DataTable();
                dap.Fill(dt);
                grvtc.DataSource = dt;
                grvtc.Refresh();
            }
        }

        private void cbtk_CheckedChanged(object sender, EventArgs e)
        {

            if (cbtk.Checked == true)
            {
                txtTk.Visible = true;
            }
            else
            {
                txtTk.Visible = false;
            }
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            Close();
        }


    }

   
}




  

