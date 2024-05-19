using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_BenhVien
{
    public partial class FrmChiTietBacSi : Form
    {
        public FrmChiTietBacSi()
        {
            InitializeComponent();
        }
        DBConnect _conn = new DBConnect();

        public string TC;
        private void FrmChiTietBacSi_Load(object sender, EventArgs e)
        {
            lbIdTK.Text = TC;

            SqlCommand cmd1 = new SqlCommand("select ho,ten from BacSi where  taikhoan=@p1", _conn.connection());
            cmd1.Parameters.AddWithValue("@p1", lbIdTK.Text);
            SqlDataReader dr = cmd1.ExecuteReader();
            while (dr.Read())
            {
                lbHoTen.Text = dr[0] + " " + dr[1];
            }
            _conn.connection().Close();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand("SELECT CuocHen.id, CuocHen.ngay, CuocHen.thoigian, CuocHen.mota, BenhNhan.ho, BenhNhan.ten, " +
            "Nganh.ten_nganh,CuocHen.isDuyet FROM CuocHen JOIN BenhNhan ON CuocHen.id_benhnhan = BenhNhan.id " +
            "JOIN BacSi ON CuocHen.id_bacsi = BacSi.id " +
            "JOIN Nganh ON BacSi.id_nganh = Nganh.id " +
            "WHERE BacSi.taikhoan = @taikhoan_bacsi", _conn.connection());

            cmd.Parameters.AddWithValue("@taikhoan_bacsi", lbIdTK.Text);
            da.SelectCommand = cmd;
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            dataGridView1.Columns[0].HeaderText = "STT";
            dataGridView1.Columns[1].HeaderText = "Ngày";
            dataGridView1.Columns[2].HeaderText = "Giờ";
            dataGridView1.Columns[4].HeaderText = "Họ bệnh nhân";
            dataGridView1.Columns[5].HeaderText = "Tên bệnh nhân";
            dataGridView1.Columns[3].HeaderText = "Mô tả bệnh";
            dataGridView1.Columns[6].HeaderText = "Tên Ngành";
            dataGridView1.Columns[7].HeaderText = "Trạng thái";
        }

        private void btnDuyet_Click(object sender, EventArgs e)
        {
            bool tick;
            SqlCommand cmd = new SqlCommand("UPDATE CuocHen SET isDuyet=@p1 WHERE CuocHen.id=@id", _conn.connection());

            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            dataGridView1.Rows[secilen].Cells[7].Value = true;
            tick = Convert.ToBoolean(dataGridView1.Rows[secilen].Cells[7].Value);
            cmd.Parameters.AddWithValue("@id", dataGridView1.Rows[secilen].Cells[0].Value);
            cmd.Parameters.AddWithValue("@p1", tick);
            cmd.ExecuteNonQuery();
        }

        private void btnbilgidüzenle_Click(object sender, EventArgs e)
        {

        }
    }
}
