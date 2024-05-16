using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_BenhVien
{
    public partial class FrmAdminDangNhap : Form
    {
        public FrmAdminDangNhap()
        {
            InitializeComponent();
        }
        DBConnect _conn = new DBConnect();
 
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from Admin where taikhoan=@p1 and matkhau=@p2", _conn.connection());
            cmd.Parameters.AddWithValue("@p1", txtTK.Text);
            cmd.Parameters.AddWithValue("@p2", txtMK.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                FrmChiTietAdmin frs = new FrmChiTietAdmin();
                frs.TC = txtTK.Text;
                frs.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("ID tài khoản hoặc mật khẩu không chính xác!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            _conn.connection().Close();

        }
        private void FrmAdminDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult cikis = MessageBox.Show("Bạn có muốn thoát chương trình không ? ", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (cikis == DialogResult.No)
            {
                e.Cancel = true;
                return;

            }
            Environment.Exit(0);
        }
    }
}
