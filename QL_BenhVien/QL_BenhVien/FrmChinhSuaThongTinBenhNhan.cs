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
    public partial class FrmChinhSuaThongTinBenhNhan : Form
    {
        public FrmChinhSuaThongTinBenhNhan()
        {
            InitializeComponent();
        }
        public string tc;
        DBConnect _conn = new DBConnect();

        private void FrmChinhSuaThongTinBenhNhan_Load(object sender, EventArgs e)
        {
            lbId.Text = tc;
            SqlCommand ht = new SqlCommand("select * from BenhNhan where taikhoan=@taikhoan", _conn.connection());
            ht.Parameters.AddWithValue("@taikhoan", lbId.Text);
            SqlDataReader dr = ht.ExecuteReader();
            while (dr.Read())
            {
                txtHo.Text = dr[1].ToString();
                txtTen.Text = dr[2].ToString();
                txtMK.Text = dr[3].ToString();
                txtSDT.Text = dr[4].ToString();
            }
            _conn.connection().Close();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            
            SqlCommand ht = new SqlCommand("Update BenhNhan set ten=@p1, ho=@p2, matkhau=@p3, sdt=@p4 where id=@p5", _conn.connection());
            ht.Parameters.AddWithValue("@p1", txtTen.Text);
            ht.Parameters.AddWithValue("@p2", txtHo.Text);
            ht.Parameters.AddWithValue("@p3", txtMK.Text);
            ht.Parameters.AddWithValue("@p4", txtSDT.Text);
            ht.Parameters.AddWithValue("@p5", lbId.Text);

            int sua = ht.ExecuteNonQuery();
            if (sua > 0)
            {
                MessageBox.Show("Sửa thông tin thành công!");
            }
            else
            {
                MessageBox.Show("Sửa thông tin không thành công.");
            }

            _conn.connection().Close();
        }
    }
}
