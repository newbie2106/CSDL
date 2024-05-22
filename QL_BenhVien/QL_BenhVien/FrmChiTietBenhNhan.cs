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

namespace QL_BenhVien
{
    public partial class FrmChiTietBenhNhan : Form
    {
        public FrmChiTietBenhNhan()
        {
            InitializeComponent();
        }
        public string tc, getIdBenhNhan;
        DBConnect _conn = new DBConnect();
        private void FrmChiTietBenhNhan_Load(object sender, EventArgs e)
        {
            lbTK.Text = tc;
            SqlCommand ht = new SqlCommand("select ho,ten,id from BenhNhan where taikhoan=@taikhoan", _conn.connection());
            ht.Parameters.AddWithValue("@taikhoan", lbTK.Text);
            SqlDataReader dr = ht.ExecuteReader();
            while (dr.Read())
            {
                getIdBenhNhan = dr[2].ToString();
            }
            lbId.Text = getIdBenhNhan;
            _conn.connection().Close();

            //Hien thi danh sach cuoc hen
            SqlCommand connect = new SqlCommand("SELECT CuocHen.id, CuocHen.ngay, CuocHen.thoigian, CuocHen.mota, (BenhNhan.ho+' '+BenhNhan.ten)as'hovaten1', (BacSi.ho+' '+BacSi.ten)as'hovaten2' , Nganh.ten_nganh " +
                "FROM CuocHen JOIN BenhNhan ON CuocHen.id_benhnhan = BenhNhan.id JOIN BacSi ON CuocHen.id_bacsi = BacSi.id " +
                "JOIN Nganh ON CuocHen.id_nganh = Nganh.id WHERE CuocHen.id_benhnhan = @id_benhnhan and CuocHen.isDuyet = 1", _conn.connection());
            connect.Parameters.AddWithValue("@id_benhnhan", lbId.Text);
            SqlDataAdapter dap = new SqlDataAdapter(connect);
            DataTable dt = new DataTable();
            dap.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Ngày";
            dataGridView1.Columns[2].HeaderText = "Thời gian";
            dataGridView1.Columns[3].HeaderText = "Mô tả";
            dataGridView1.Columns[4].HeaderText = "Bệnh nhân";
            dataGridView1.Columns[5].HeaderText = "Bác sĩ";
            dataGridView1.Columns[6].HeaderText = "Ngành";
            _conn.connection().Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            FrmChinhSuaThongTinBenhNhan fr = new FrmChinhSuaThongTinBenhNhan();
            fr.tc = lbId.Text;
            fr.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lbId_Click(object sender, EventArgs e)
        {

        }
    }
}
