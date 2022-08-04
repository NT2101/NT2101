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
    public partial class dichvu : Form
    {

        SqlConnection con = new SqlConnection("Data Source=LAPTOP-MFDIDQSO\\MAYAO;Initial Catalog=QLKVC;Integrated Security=True");
        public dichvu()
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


        private void Load_dichvu()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select *from dichvu", con);
            SqlDataAdapter dap = new SqlDataAdapter();
            dap.SelectCommand = cmd;
            cmd.Dispose();
            con.Close();

            DataTable dt = new DataTable();
            dap.Fill(dt);

            grvdv.DataSource = dt;
            grvdv.Refresh();

            txttdv.DataBindings.Clear();
            txtmdv.DataBindings.Clear();
            cbk.DataBindings.Clear();
            txtgdv.DataBindings.Clear();

            txttdv.DataBindings.Add("text", grvdv.DataSource, "tdv");
            txtmdv.DataBindings.Add("text", grvdv.DataSource, "mdv");
            txtgdv.DataBindings.Add("text", grvdv.DataSource, "gdv");
            cbk.DataBindings.Add("text", grvdv.DataSource, "mk");
            cbk.Enabled = false;

        }


    

        private void btthem_Click(object sender, EventArgs e)
        {

            txttdv.Enabled = true;
            txtmdv.Enabled = true;
            txtgdv.Enabled = true;



            cbk.Enabled = true;

            btluu.Enabled = true;
            btthem.Enabled = false;
            btsua.Enabled = true;
            btxoa.Enabled = true;

            txttdv.Text = "";
            txtmdv.Text = "";
            txtgdv.Text = "";


            cbk.Text = "";

            txttdv.Focus();
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            string p_TenDV = txttdv.Text.Trim();
            string p_MaDV = txtmdv.Text.Trim();
            string p_GiaDV = txtgdv.Text.Trim();
            string p_Makhu = cbk.SelectedValue.ToString();



            string sqlsua = "Update  dichvu Set     tdv = '" + p_TenDV + "',  gdv = '" + p_GiaDV + "'," +
               "mk = '" + p_Makhu + "' where mdv = '" + p_MaDV + "'";

            con.Open();
            SqlCommand cmd = new SqlCommand(sqlsua, con);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            Load_dichvu();
            MessageBox.Show("Sửa thành công");
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            string p_MaDV = txtmdv.Text.Trim();
            con.Open();
            SqlCommand cmd = new SqlCommand("dichvu_Del", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@mdv", SqlDbType.NVarChar, 50).Value = p_MaDV;

            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();

            Load_dichvu();


            MessageBox.Show("Xóa thành công");
        }

        private void btluu_Click(object sender, EventArgs e)
        {

            string p_MaDV = txtmdv.Text.Trim();
            if (p_MaDV == "")
            {
                MessageBox.Show("Nhập DỊch Vụ nào", "Thông Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmdv.Focus();
                return;
            }
            string p_TenDV = txttdv.Text.Trim();
            if (p_TenDV == "")
            {
                MessageBox.Show("Nhập Tên Dịch Vụ đi", "Thông Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttdv.Focus();
                return;
            }
            string p_MaKhu = cbk.SelectedValue.ToString();
            string p_GiaDV = txtgdv.Text.Trim();
     

            string sqlthem = "Insert into dichvu Values('" + p_MaDV + "',N'"
                + p_TenDV + "','" + cbk.Text.Trim() + "', '" + p_GiaDV + "')";
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
                Load_dichvu();

                MessageBox.Show("Thêm thành công");
            }
        }
        private bool kiemtratontai()
        {
            bool tatkt = false;
            string madichvu = txtmdv.Text;

            SqlCommand cmd = new SqlCommand("Select * from dichvu", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (madichvu == dr.GetString(0))
                {
                    tatkt = true;
                    break;
                }
            }
            con.Close();
            return tatkt;
        }

        private void btxuat_Click(object sender, EventArgs e)
        {
            load_bang();
        }

        private void dichvu_Load(object sender, EventArgs e)
        {
            Load_cbk();

            txttdv.Enabled = false;
            txtmdv.Enabled = false;

            txtgdv.Enabled = false;
            cbk.Enabled = false;

            btluu.Enabled = false;
            btthem.Enabled = true;
            btsua.Enabled = false;
            btxoa.Enabled = true;
            Load_dichvu();

            cbtk_CheckedChanged(sender, e);
        }

        private void grvdv_CellClick(object sender, DataGridViewCellEventArgs e)
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
          xls.Range head = oSheet.get_Range("A1", "D1");
            head.MergeCells = true; // lệnh gộp ô
            head.Value2 = "Danh Sách Dịch Vụ";
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
            cl1.Value2 = "Mã Dịch Vụ";
            cl1.ColumnWidth = 12.0;

            xls.Range cl2 = oSheet.get_Range("B3", "B3");
            cl2.Value2 = "Tên Dịch VỤ";
            cl2.ColumnWidth = 25.0;

            xls.Range cl3 = oSheet.get_Range("C3", "C3");
            cl3.Value2 = "Khu";
            cl3.ColumnWidth = 35.0;

            xls.Range cl4 = oSheet.get_Range("D3", "D3");
            cl4.Value2 = "Giá Dịch Vụ";
            cl4.ColumnWidth = 15.0;





         

            xls.Range rowHead = oSheet.get_Range("A3", "D3");
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
            DataColumn col1 = new DataColumn("mdv");
            DataColumn col2 = new DataColumn("tdv");
            DataColumn col3 = new DataColumn("mk");
            DataColumn col4 = new DataColumn("gdv");



            dt.Columns.Add(col1);
            dt.Columns.Add(col2);
            dt.Columns.Add(col3);
            dt.Columns.Add(col4);



            foreach (DataGridViewRow dgr in grvdv.Rows)
            {
                DataRow dtr = dt.NewRow();
                dtr[0] = dgr.Cells[0].Value;
                dtr[1] = dgr.Cells[1].Value;
                dtr[2] = dgr.Cells[2].Value;
                dtr[3] = dgr.Cells[3].Value;



                dt.Rows.Add(dtr);
            }
            ExportExcel(dt, "DanhSach", "Danh Sách Dịch Vụ");
        }

        private void txtTk_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string sqltimkiem = "select mdv, tdv, mk, gdv " +
                    "from dichvu where mdv like " +
                "N'%" + txtTk.Text + "%' ";
                SqlDataAdapter dap = new SqlDataAdapter(sqltimkiem, con);
                DataTable dt = new DataTable();
                dap.Fill(dt);
                grvdv.DataSource = dt;
                grvdv.Refresh();
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
