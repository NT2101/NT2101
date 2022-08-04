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
    public partial class ve : Form
    {

        SqlConnection con = new SqlConnection("Data Source=LAPTOP-MFDIDQSO\\MAYAO;Initial Catalog=QLKVC;Integrated Security=True");
        public ve()
        {
            InitializeComponent();
        }


        private void Load_cbk()
        {
            if (con.State != ConnectionState.Open)
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

        private void Load_ve()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select *from ve", con);
            SqlDataAdapter dap = new SqlDataAdapter();
            dap.SelectCommand = cmd;
            cmd.Dispose();
            con.Close();

            DataTable dt = new DataTable();
            dap.Fill(dt);

            grvv.DataSource = dt;
            grvv.Refresh();

            txtmv.DataBindings.Clear();
 
            cbk.DataBindings.Clear();
            dtNI.DataBindings.Clear();
            txtsvte.DataBindings.Clear();
            txtsvnl.DataBindings.Clear();
            txtthanhtien.DataBindings.Clear();
            txtgvnl.DataBindings.Clear();
            txtgvte.DataBindings.Clear();
            txtmv.DataBindings.Add("text", grvv.DataSource, "mv");
     
            dtNI.DataBindings.Add("text", grvv.DataSource, "ni");
            cbk.DataBindings.Add("text", grvv.DataSource, "mk");
            txtsvte.DataBindings.Add("text", grvv.DataSource, "slvte");
            txtsvnl.DataBindings.Add("text", grvv.DataSource, "slvnl");
            txtthanhtien.DataBindings.Add("text", grvv.DataSource, "thanhtien");
            txtgvnl.DataBindings.Add("text", grvv.DataSource, "gvnl");
            txtgvte.DataBindings.Add("text", grvv.DataSource, "gvte");
            cbk.Enabled = false;

        }


        private void ve_Load(object sender, EventArgs e)
        {
            Load_cbk();

            txtmv.Enabled = false;
            txtthanhtien.Enabled = false;
            txtgvnl.Enabled = false;
            txtgvte.Enabled = false;
            txtsvte.Enabled = false;
            txtsvnl.Enabled = false;
            dtNI.Enabled = false;
            cbk.Enabled = false;
            
            btluu.Enabled = false;
            btthem.Enabled = true;
            btsua.Enabled = false;
            btxoa.Enabled = false;
            btlTinhTien.Enabled = false;
            Load_ve();
         
            cbtk_CheckedChanged_1(sender, e);
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            txtmv.Enabled = true;
 
            dtNI.Enabled  = true;
            txtgvnl.Enabled = true;
            txtgvte.Enabled = true;
            txtsvte.Enabled = true;
            txtsvnl.Enabled = true;
            cbk.Enabled = true;
            txtthanhtien.Enabled = true;
            btluu.Enabled = true;
            btthem.Enabled = true;
            btsua.Enabled = true;
            btxoa.Enabled = true;
            btlTinhTien.Enabled = true;

            txtmv.Text = "";
            txtgvnl.Text = "";
            txtgvte.Text = "";
            txtsvte.Text = "";
            txtsvnl.Text = "";
            txtthanhtien.Text = "";
            cbk.Text = "";

            txtmv.Focus();
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            string p_MaV = txtmv.Text.Trim();
            string p_GVNL = txtgvnl.Text.Trim();
            string p_GVTE = txtgvte.Text.Trim();
            string p_Makhu = cbk.SelectedValue.ToString();
            string p_SoveTE = txtsvte.Text.Trim();
            string p_SoveNL = txtsvnl.Text.Trim();
            string p_thanhtien = txtthanhtien.Text.Trim();

            string sqlsua = "Update  ve Set     ni = '" + dtNI.Text.ToString() + "'," +
               "mk = '" + p_Makhu + "', slvte = '" + p_SoveTE + "',slvnl= '" + p_SoveNL + "', " +
                 "gvnl = N'" + p_GVNL + "',gvte = N'" + p_GVTE + "',thanhtien = '"+p_thanhtien+"' where mv = '" + p_MaV + "' ";

            con.Open();
            SqlCommand cmd = new SqlCommand(sqlsua, con);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            Load_ve();
            MessageBox.Show("Sửa thành công");

        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            string p_MaV = txtmv.Text.Trim();
            con.Open();
            SqlCommand cmd = new SqlCommand("ve_Del", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("SoTE", SqlDbType.NVarChar, 50).Value = p_MaV;

            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();

            Load_ve();


            MessageBox.Show("Xóa thành công");
        }

        private void btluu_Click(object sender, EventArgs e)
        {
            string p_MaV = txtmv.Text.Trim();
            if (p_MaV == "")
            {
                MessageBox.Show("Nhập mã Vé nào", "Thông Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmv.Focus();
                return;
            }           
            string p_MaKhu = cbk.SelectedValue.ToString();
            string p_GVNL = txtgvnl.Text.Trim();
            string p_GVTE = txtgvte.Text.Trim();
            string p_SoveTE = txtsvte.Text.Trim();
            string p_SoveNL = txtsvnl.Text.Trim();
            string p_thanhtien = txtthanhtien.Text.Trim();

            string sqlthem = "Insert into ve Values('" + p_MaV + "','" + dtNI.Text.ToString() + "','" + cbk.Text.Trim() + "', '" + p_SoveTE + "','" + p_SoveNL + "',N'"
                + p_thanhtien  + "','" + p_GVNL  + "','"+ p_GVTE + "' )";
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
                Load_ve();

                MessageBox.Show("Thêm thành công");
            }

        }
        private bool kiemtratontai()
        {
            bool tatkt = false;
            string mave = txtmv.Text;

            SqlCommand cmd = new SqlCommand("Select * from ve", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (mave == dr.GetString(0))
                {
                    tatkt = true;
                    break;
                }
            }
            con.Close();
            return tatkt;
        }

        private void grvv_CellClick(object sender, DataGridViewCellEventArgs e)
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
            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "H1");
            head.MergeCells = true; // lệnh gộp ô
            head.Value2 = "Danh Sách Vé";
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
            cl1.Value2 = "Mã Vé";
            cl1.ColumnWidth = 12.0;

            xls.Range cl2 = oSheet.get_Range("B3", "B3");
            cl2.Value2 = "Ngày In";
            cl2.ColumnWidth = 25.0;

            xls.Range cl3 = oSheet.get_Range("C3", "C3");
            cl3.Value2 = "Mã Khu";
            cl3.ColumnWidth = 35.0;

            xls.Range cl4 = oSheet.get_Range("D3", "D3");
            cl4.Value2 = "Số Vé Trẻ Em";
            cl4.ColumnWidth = 15.0;
            xls.Range cl5 = oSheet.get_Range("E3", "E3");
            cl5.Value2 = "Số Vé Người lớn";
            cl5.ColumnWidth = 15.0;
            xls.Range cl6 = oSheet.get_Range("F3", "F3");
            cl6.Value2 = "Số Vé Người lớn";
            cl6.ColumnWidth = 15.0;
            xls.Range cl7 = oSheet.get_Range("G3", "G3");
            cl7.Value2 = "Số Vé Người lớn";
            cl7.ColumnWidth = 15.0;
            xls.Range cl8 = oSheet.get_Range("H3", "H3");
           cl8.Value2 = "Số Vé Người lớn";
            cl8.ColumnWidth = 15.0;





            xls.Range rowHead = oSheet.get_Range("A3", "H3");
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
            DataColumn col1 = new DataColumn("mv");
            DataColumn col2 = new DataColumn("in");
            DataColumn col3 = new DataColumn("mk");
            DataColumn col4 = new DataColumn("slvte");
            DataColumn col5 = new DataColumn("slvnl");
            DataColumn col6 = new DataColumn("thanhtien");
            DataColumn col7 = new DataColumn("gvte");
            DataColumn col8 = new DataColumn("gvnl");




            dt.Columns.Add(col1);
            dt.Columns.Add(col2);
            dt.Columns.Add(col3);
            dt.Columns.Add(col4);
            dt.Columns.Add(col5);
            dt.Columns.Add(col6);
            dt.Columns.Add(col7);
            dt.Columns.Add(col8);

            foreach (DataGridViewRow dgr in grvv.Rows)
            {
                DataRow dtr = dt.NewRow();
                dtr[0] = dgr.Cells[0].Value;
                dtr[1] = dgr.Cells[1].Value;
                dtr[2] = dgr.Cells[2].Value;
                dtr[3] = dgr.Cells[3].Value;
                dtr[4] = dgr.Cells[4].Value;
                dtr[5] = dgr.Cells[4].Value;
                dtr[6] = dgr.Cells[4].Value;
                dtr[7] = dgr.Cells[4].Value;

                dt.Rows.Add(dtr);
            }
            ExportExcel(dt, "DanhSach", "Danh Sách Vé");
        }

        private void btxuat_Click_1(object sender, EventArgs e)
        {
            load_bang();
        }
        private void txtTk_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string sqltimkiem = "select mv, ni, mk,slvte,slvnl,thanhtien,gvte,gvnl " +
                    "from ve where mv like " +
                "N'%" + txtTk.Text + "%' ";
                SqlDataAdapter dap = new SqlDataAdapter(sqltimkiem, con);
                DataTable dt = new DataTable();
                dap.Fill(dt);
                grvv.DataSource = dt;
                grvv.Refresh();
            }
        }

        private void cbtk_CheckedChanged_1(object sender, EventArgs e)
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

        private void btxuat_Click(object sender, EventArgs e)
        {
            load_bang(); 
        }

      

        private void btlTinhTien_Click(object sender, EventArgs e)
        {
            int a = 0;
            int b = 0;
            int c = 0;
            int d = 0;
            decimal thanhtien = 0;
            int.TryParse(txtgvnl.Text, out a);
            int.TryParse(txtgvte.Text, out b);
            int.TryParse(txtsvnl.Text, out c);
            int.TryParse(txtsvte.Text, out d);
            thanhtien = a * c + b * d;
            txtthanhtien.Text = thanhtien.ToString();
        }
    }
}
