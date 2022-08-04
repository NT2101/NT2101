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
    public partial class nhanvien : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-MFDIDQSO\\MAYAO;Initial Catalog=QLKVC;Integrated Security=True");

        public nhanvien()
        {
            InitializeComponent();
        }
      
            private void Load_cbk()
        {
            if(con.State != ConnectionState.Open)
                con.Open();
            SqlCommand cmd = new SqlCommand("select * from makhu", con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            cmd.Dispose();
            con.Close();
            DataTable tb = new DataTable();
            da.Fill(tb);
            DataRow r = tb.NewRow();
            r["mk"] = "";
            r["tmk"] = "-- Chọn -- ";
            tb.Rows.InsertAt(r, 0);
            cbk.DataSource = tb;
            cbk.DisplayMember = "tmk";
            cbk.ValueMember = "mk";
        }

        private void Load_nhanvien()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select *from nhanvien", con);
            SqlDataAdapter dap = new SqlDataAdapter();
            dap.SelectCommand = cmd;
            cmd.Dispose();
            con.Close();

            DataTable dt = new DataTable();
            dap.Fill(dt);

            grvnv.DataSource = dt;
            grvnv.Refresh();

            txtmnv.DataBindings.Clear();
            txtht.DataBindings.Clear();
            txtsdt.DataBindings.Clear();
            txtdc.DataBindings.Clear();
            txtl.DataBindings.Clear();
            txtmngs.DataBindings.Clear();
            cbcv.DataBindings.Clear();
            cbgt.DataBindings.Clear();
            cbk.DataBindings.Clear();
            dtNS.DataBindings.Clear();

            txtmnv.DataBindings.Add("text", grvnv.DataSource, "mnv");
            txtht.DataBindings.Add("text", grvnv.DataSource, "ht");
            txtsdt.DataBindings.Add("text", grvnv.DataSource, "sdt");
            txtdc.DataBindings.Add("text", grvnv.DataSource, "dc");
            txtl.DataBindings.Add("text", grvnv.DataSource, "l");
            txtmngs.DataBindings.Add("text", grvnv.DataSource, "mngs");
            dtNS.DataBindings.Add("text", grvnv.DataSource, "ns");
            cbcv.DataBindings.Add("text", grvnv.DataSource, "cv");
            cbgt.DataBindings.Add("text", grvnv.DataSource, "gt");
            cbk.DataBindings.Add("text", grvnv.DataSource, "mk");
            cbcv.Enabled = false;
            cbgt.Enabled = false;
            cbk.Enabled = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
          Load_cbk();

            txtmnv.Enabled = false;
            txtht.Enabled = false;
            txtsdt.Enabled = false;
            txtdc.Enabled = false;
            txtl.Enabled = false;
            txtmngs.Enabled = false;

            dtNS.Enabled = false;
            cbgt.Enabled = false;
            cbcv.Enabled = false;
            cbk.Enabled = false;

            btluu.Enabled = false;
            btthem.Enabled = true;
            btsua.Enabled = false;
            btxoa.Enabled = false;
            Load_nhanvien();

            cbtk_CheckedChanged(sender, e);
        }

        private void btthem_Click(object sender, EventArgs e)
        {

            txtmnv.Enabled = true;
            txtht.Enabled = true;
            txtsdt.Enabled = true;
            txtdc.Enabled = true;
            txtl.Enabled = true;
            txtmngs.Enabled = true;

            dtNS.Enabled = true;
            cbgt.Enabled = true;
            cbcv.Enabled = true;
            cbk.Enabled = true;

            btluu.Enabled = true;
            btthem.Enabled = true;
            btsua.Enabled = true;
            btxoa.Enabled = true;

            txtmnv.Text = "";
            txtht.Text = "";
            txtsdt.Text = "";
            txtdc.Text = "";
            txtl.Text = "";
            txtmngs.Text = "";
            dtNS.Text = "";
            cbcv.Text = "";
            cbgt.Text = "";
            cbk.Text = "";

            txtmnv.Focus();
        }

        private void btsua_Click(object sender, EventArgs e)
        {
                string p_Manv = txtmnv.Text.Trim();
               string p_HoTen = txtht.Text.Trim();
               float p_DienThoai = int.Parse(txtsdt.Text.Trim());
               string p_DiaChi = txtdc.Text.Trim();           
              string p_Luong = txtl.Text.Trim();
               string p_Makhu = cbk.SelectedValue.ToString();
               string p_MNGS = txtmngs.Text.Trim();


               string sqlsua = "Update  nhanvien Set ht = N'" + p_HoTen + "', " +
                    "ns = '" + dtNS.Text.ToString() + "', sdt = '" + p_DienThoai + "'," +
                     "dc = N'" + p_DiaChi + "',cv = N'" + cbcv.Text.Trim() + "', " +
                    "l = N'" + p_Luong + "',gt = N'" + cbgt.Text.Trim() + "', mngs = '" + p_MNGS + "'," +
                  "mk = '" + p_Makhu + "' where mnv = '" + p_Manv + "'";

                con.Open();
               SqlCommand cmd = new SqlCommand(sqlsua, con);
               cmd.ExecuteNonQuery();
               cmd.Dispose();
                con.Close();
               Load_nhanvien();
               MessageBox.Show("Sửa thành công");

         
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            string p_Manv = txtmnv.Text.Trim();
            con.Open();
            SqlCommand cmd = new SqlCommand("Nhanvien_Del", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@mnv", SqlDbType.NVarChar, 50).Value = p_Manv;

            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();

            Load_nhanvien();
          

            MessageBox.Show("Xóa thành công");
        }

        private void btluu_Click(object sender, EventArgs e)
        {
            string p_MaNV = txtmnv.Text.Trim();
            if (p_MaNV == "")
            {
                MessageBox.Show("Nhập mã Nhân viên nào", "Thông Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmnv.Focus();
                return;
            }
            string p_HoTen = txtht.Text.Trim();
            if (p_HoTen == "")
            {
                MessageBox.Show("Nhập họ tên đi", "Thông Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtht.Focus();
                return;
            }
            string p_DienThoai = txtsdt.Text.Trim();
                if( p_DienThoai == "")
            {
                MessageBox.Show(" Nhập sdt đi ", "THông Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtsdt.Focus();
                return;
            }
            string p_MaKhu = cbk.SelectedValue.ToString();
            string p_Diachi = txtdc.Text.Trim();
            string p_Luong = txtl.Text.Trim();
            string p_MaNGS = txtmngs.Text.Trim();
   

            string sqlthem = "Insert into nhanvien Values('" + p_MaNV + "',N'"
                + p_HoTen + "','" + dtNS.Text.ToString() + "','" + p_DienThoai + "','" + p_Diachi + "',N'" + cbcv.Text.Trim() + "',N'"
                + p_Luong + "','" + cbgt.Text.Trim() + "','" + cbk.Text.Trim() + "', '" + p_MaNGS + "')";
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
                Load_nhanvien();
         
                MessageBox.Show("Thêm thành công");
            }
        }
        private bool kiemtratontai()
        {
            bool tatkt = false;
            string manhanvien = txtmnv.Text;
    
            

            SqlCommand cmd = new SqlCommand("Select * from nhanvien", con);
           con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if ( manhanvien == dr.GetString(0))
                {
                    tatkt = true;
                    break;
                }
            }
            con.Close();
            return tatkt;
        }

      

        private void grvnv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btxoa.Enabled = true;
            btluu.Enabled = true;
            btsua.Enabled = true;
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
            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "G1");
            head.MergeCells = true; // lệnh gộp ô
            head.Value2 = "Danh Sách Nhân Viên";
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
            cl1.Value2 = "Mã Nhan Viên";
            cl1.ColumnWidth = 12.0;

            xls.Range cl2 = oSheet.get_Range("B3", "B3");
            cl2.Value2 = "Họ và Tên";
            cl2.ColumnWidth = 25.0;

            xls.Range cl3 = oSheet.get_Range("C3", "C3");
            cl3.Value2 = "Ngày Sinh";
            cl3.ColumnWidth = 35.0;

           xls.Range cl4 = oSheet.get_Range("D3", "D3");
            cl4.Value2 = "SĐT";
            cl4.ColumnWidth = 15.0;

            xls.Range cl5 = oSheet.get_Range("E3", "E3");
            cl5.Value2 = "Địa Chỉ";
            cl5.ColumnWidth = 20.0;

            xls.Range cl6 = oSheet.get_Range("F3", "F3");
            cl6.Value2 = "Chức vụ";
            cl6.ColumnWidth = 20.0;

            xls.Range cl7 = oSheet.get_Range("G3", "G3");
            cl7.Value2 = "Lương";
            cl7.ColumnWidth = 15.0;

            xls.Range cl8 = oSheet.get_Range("H3", "H3");
            cl8.Value2 = "Giới tính";
            cl8.ColumnWidth = 15.0;

            xls.Range cl9 = oSheet.get_Range("I3", "I3");
            cl9.Value2 = "Mã Khkhu";
            cl9.ColumnWidth = 15.0;

            xls.Range c20 = oSheet.get_Range("J3", "J3");
            c20.Value2 = "Mã NGS";
            c20.ColumnWidth = 15.0;

       


            xls.Range rowHead = oSheet.get_Range("A3", "J3");
            rowHead.Font.Bold = true;
            // Kẻ viền
            rowHead.Borders.LineStyle = xls.Constants.xlSolid;

            // Thiết lập màu nền
            rowHead.Interior.ColorIndex = 4;
            rowHead.HorizontalAlignment =xls.XlHAlign.xlHAlignCenter;

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
            DataColumn col1 = new DataColumn("mnv");
            DataColumn col2 = new DataColumn("ht");
            DataColumn col3 = new DataColumn("ns");
            DataColumn col4 = new DataColumn("sdt");
            DataColumn col5 = new DataColumn("dc");
            DataColumn col6 = new DataColumn("cv");
            DataColumn col7 = new DataColumn("l");
            DataColumn col8 = new DataColumn("gt");
            DataColumn co19 = new DataColumn("mk");
            DataColumn co20 = new DataColumn("mngs");


            dt.Columns.Add(col1);
            dt.Columns.Add(col2);
            dt.Columns.Add(col3);
            dt.Columns.Add(col4);
            dt.Columns.Add(col5);
            dt.Columns.Add(col6);
            dt.Columns.Add(col7);
            dt.Columns.Add(col8);
            dt.Columns.Add(co19);
            dt.Columns.Add(co20);


            foreach (DataGridViewRow dgvr in grvnv.Rows)
            {
                DataRow dtr = dt.NewRow();
                dtr[0] = dgvr.Cells[0].Value;
                dtr[1] = dgvr.Cells[1].Value;
                dtr[2] = dgvr.Cells[2].Value;
                dtr[3] = dgvr.Cells[3].Value;
                dtr[4] = dgvr.Cells[4].Value;
                dtr[5] = dgvr.Cells[5].Value;
                dtr[6] = dgvr.Cells[6].Value;
                dtr[7] = dgvr.Cells[7].Value;
                dtr[8] = dgvr.Cells[8].Value;
                dtr[9] = dgvr.Cells[9].Value;


                dt.Rows.Add(dtr);
            }
            ExportExcel(dt, "DanhSach", "Danh Sách Nhân Viên");
        }

        private void btxuat_Click_1(object sender, EventArgs e)
        {
            load_bang();
        }

      

        private void txtTk_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string sqltimkiem = "select mnv, ht, ns,sdt,dc,cv,l,gt,mk,mngs " +
                    "from nhanvien where mnv like " +
                "N'%" + txtTk.Text + "%' ";
                SqlDataAdapter dap = new SqlDataAdapter(sqltimkiem, con);
                DataTable dt = new DataTable();
                dap.Fill(dt);
                grvnv.DataSource = dt;
                grvnv.Refresh();
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
