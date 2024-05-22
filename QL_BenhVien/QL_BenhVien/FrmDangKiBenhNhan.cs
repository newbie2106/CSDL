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
    public partial class FrmDangKiBenhNhan : Form
    {
        public FrmDangKiBenhNhan()
        {
            InitializeComponent();
        }
        DBConnect _conn = new DBConnect();
        private void FrmDangKiBenhNhan_Load(object sender, EventArgs e)
        {
            btnDangki.BackColor = Color.FromArgb(180, 190, 253);
        }

        private void btnDangki_Click(object sender, EventArgs e)
        {
            SqlCommand ht = new SqlCommand("insert into BenhNhan(ten,ho,taikhoan,sdt,matkhau,gioitinh) values(@p1,@p2,@p3,@p4,@p5,@p6)", _conn.connection());
            ht.Parameters.AddWithValue("@p1", txtTen.Text);
            ht.Parameters.AddWithValue("@p2", txtHo.Text);
            ht.Parameters.AddWithValue("@p3", mtbID.Text);
            ht.Parameters.AddWithValue("@p4", mtbSDT.Text);
            ht.Parameters.AddWithValue("@p5", txtMK.Text);
            ht.Parameters.AddWithValue("@p6", cmbGioitinh.Text);

            if (txtTen.Text == "" || txtHo.Text == "" || mtbID.Text == "" || mtbSDT.Text == "" || txtMK.Text == "" || cmbGioitinh.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ các thông tin trên!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                ht.ExecuteNonQuery();
                MessageBox.Show("Đăng ký của bạn đã hoàn tất. Mật khẩu của bạn: " + txtMK.Text, "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            _conn.connection().Close(); 
        }

        private void btnAn_Click(object sender, EventArgs e)
        {
            if (txtMK.UseSystemPasswordChar)
            {
                txtMK.UseSystemPasswordChar = false;
                btnAn.BackgroundImage = global::QL_BenhVien.Properties.Resources.eye_crossed;
            }


            else
            {
                txtMK.UseSystemPasswordChar = true;
                btnAn.BackgroundImage = global::QL_BenhVien.Properties.Resources.tải_xuống;
            }
        }

        private void txtTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void txtHo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }
    }
}
