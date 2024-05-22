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
    public partial class FrmBenhNhanDatLich : Form
    {
        public FrmBenhNhanDatLich()
        {
            InitializeComponent();
        }
        public string tc, getIdBenhNhan;
        DBConnect _conn = new DBConnect();
        private void FrmBenhNhanDatLich_Load(object sender, EventArgs e)
        {
            lbTK.Text = tc;
            SqlCommand ht = new SqlCommand("select ten,id from BenhNhan where taikhoan=@taikhoan", _conn.connection());
            ht.Parameters.AddWithValue("@taikhoan", lbTK.Text);
            SqlDataReader dr = ht.ExecuteReader();
            while (dr.Read())
            {
                getIdBenhNhan = dr[1].ToString();
            }
            lbId.Text = getIdBenhNhan;

            SqlCommand ht1 = new SqlCommand("select ten_nganh from Nganh", _conn.connection());
            SqlDataReader dr2 = ht1.ExecuteReader();
            while (dr2.Read())
            {
                cmbKhoa.Items.Add(dr2[0]);
            }

            SqlCommand ht2 = new SqlCommand("select ten from BacSi", _conn.connection());
            SqlDataReader dr3 = ht2.ExecuteReader();
            while (dr3.Read())
            {
                cmbBacSi.Items.Add(dr3[0]);
            }

            _conn.connection().Close();


        }

        private void btnDatLich_Click(object sender, EventArgs e)
        {
            SqlCommand ht = new SqlCommand("insert into CuocHen(id_bacsi,id_benhnhan,id_nganh,ngay,thoigian,mota) values(@p1,@p2,@p3,@p4,@p5,@p6)", _conn.connection());
            ht.Parameters.AddWithValue("@p1", cmbBacSi.SelectedIndex + 2);
            ht.Parameters.AddWithValue("@p2", Convert.ToInt32(lbId.Text));
            ht.Parameters.AddWithValue("@p3", cmbKhoa.SelectedIndex + 13);
            ht.Parameters.AddWithValue("@p4", datetime.Text);
            ht.Parameters.AddWithValue("@p5", time.Text);
            ht.Parameters.AddWithValue("@p6", rtbMoTa.Text);

            int dt = ht.ExecuteNonQuery();
            if (dt > 0)
            {
                MessageBox.Show("Đặt lịch thành công!");
            }
            else
            {
                MessageBox.Show("Đặt lịch không thành công.");
            }
            _conn.connection().Close();
        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbBacSi.Items.Clear();

            SqlCommand ht3 = new SqlCommand("select ho,ten from BacSi join Nganh On BacSi.id_nganh = Nganh.id where ten_nganh=@p1", _conn.connection());
            ht3.Parameters.AddWithValue("@p1", cmbKhoa.Text);
            SqlDataReader dr4 = ht3.ExecuteReader();
            while (dr4.Read())
            {
                cmbBacSi.Items.Add(dr4[0] + " " + dr4[1]);
            }
            _conn.connection().Close();
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            FrmChiTietBenhNhan fr = new FrmChiTietBenhNhan();
            fr.tc = lbTK.Text;
            fr.Show();
        }

        private void lbId_Click(object sender, EventArgs e)
        {

        }
    }
}
