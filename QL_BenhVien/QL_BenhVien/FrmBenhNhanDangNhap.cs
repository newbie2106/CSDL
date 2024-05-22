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
    public partial class FrmBenhNhanDangNhap : Form
    {
        public FrmBenhNhanDangNhap()
        {
            InitializeComponent();
        }
        DBConnect _conn = new DBConnect();
        private void FrmBenhNhanDangNhap_Load(object sender, EventArgs e)
        {
            btnDangnhap.BackColor = Color.FromArgb(180, 190, 253);
        }

        private void lnkDangki_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmDangKiBenhNhan fr = new FrmDangKiBenhNhan();
            fr.Show();
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            SqlCommand ht = new SqlCommand("select * from BenhNhan where taikhoan=@p1 and matkhau=@p2", _conn.connection());
            ht.Parameters.AddWithValue("@p1", mTBSo1.Text);
            ht.Parameters.AddWithValue("@p2", txtSo2.Text);
            SqlDataReader dr = ht.ExecuteReader();
            if (dr.Read())
            {
                FrmBenhNhanDatLich fr = new FrmBenhNhanDatLich();
                fr.tc = mTBSo1.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("ID và mật khẩu bệnh nhân không chính xác");
            }

            _conn.connection().Close();
        }

        private void FrmBenhNhanDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult Out = MessageBox.Show("Bạn có chắc chắn muốn đóng chương trình không? ", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Out == DialogResult.No)
            {
                e.Cancel = true;
                return;

            }
            Environment.Exit(0);
        }

        private void btnback_Click(object sender, EventArgs e)
        {

        }

        private void btnAn_Click(object sender, EventArgs e)
        {
            if (txtSo2.UseSystemPasswordChar)
            {
                txtSo2.UseSystemPasswordChar = false;
                btnAn.BackgroundImage = global::QL_BenhVien.Properties.Resources.eye_crossed;
            }
            else
            {
                txtSo2.UseSystemPasswordChar = true;
                btnAn.BackgroundImage = global::QL_BenhVien.Properties.Resources.tải_xuống;
            }
        }
    }
}
