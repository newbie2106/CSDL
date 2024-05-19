using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_BenhVien
{
    public partial class FrmQuanLyBenhNhan : Form
    {
        public FrmQuanLyBenhNhan()
        {
            InitializeComponent();
        }
        public string TC;
        DBConnect _conn = new DBConnect();
        private int BenhNhanSlectedID;
        DataTable dtBenhNhan = new DataTable();

        private void FrmQuanLyBenhNhan_Load(object sender, EventArgs e)
        {
            lbIdTK.Text = TC;
            SqlCommand cmd = new SqlCommand("SELECT id,ho,ten,taikhoan,sdt,gioitinh  FROM BenhNhan", _conn.connection());
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dtBenhNhan);
            dgvBenhNhan.DataSource = dtBenhNhan;


            dgvBenhNhan.Columns[0].HeaderText = "ID";
            dgvBenhNhan.Columns[1].HeaderText = "Họ";
            dgvBenhNhan.Columns[2].HeaderText = "Tên";
            dgvBenhNhan.Columns[3].HeaderText = "ID tài khoản";
            dgvBenhNhan.Columns[4].HeaderText = "Số điện thoại";
            dgvBenhNhan.Columns[5].HeaderText = "Giới tính";

            SqlCommand cmdGT = new SqlCommand("SELECT gioitinh FROM BenhNhan", _conn.connection());
            SqlDataReader dr = cmdGT.ExecuteReader();

            List<string> gioiTinhList = new List<string>();

            while (dr.Read())
            {
                string gioiTinh = dr[0].ToString();

                if (!gioiTinhList.Contains(gioiTinh))
                {
                    gioiTinhList.Add(gioiTinh);
                    cmbGT.Items.Add(gioiTinh);
                }
            }
            _conn.connection().Close();
        }




        private void FrmQuanLyBN_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult exit = MessageBox.Show("Bạn có muốn thoát chương trình không ? ", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (exit == DialogResult.No)
            {
                e.Cancel = true;
                return;

            }
            Environment.Exit(0);
        }

        private void btn_deleteBN_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM TABLE BenhNhan where id=@idBN", _conn.connection());
            cmd.Parameters.AddWithValue("@idBN", txtid.Text);

            if (txtid.Text == "")
            {
                MessageBox.Show("Xóa không thành công", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa bệnh nhân này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Nếu người dùng chọn Yes, thực hiện xóa
                if (dialogResult == DialogResult.Yes)
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Bệnh nhân đã được xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtid.Clear();
                    txtHo.Clear();
                    txtTen.Clear();
                    txtIdTK.Clear();
                }
                else
                {
                    // Nếu người dùng chọn No, không thực hiện xóa
                    MessageBox.Show("Đã hủy xóa bệnh nhân.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            _conn.connection().Close();
        }

        private void dgvBenhNhan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dgvBenhNhan.SelectedCells[0].RowIndex;
            txtid.Text = dgvBenhNhan.Rows[secilen].Cells[0].Value.ToString();
            txtHo.Text = dgvBenhNhan.Rows[secilen].Cells[1].Value.ToString();
            txtTen.Text = dgvBenhNhan.Rows[secilen].Cells[2].Value.ToString();
            txtIdTK.Text = dgvBenhNhan.Rows[secilen].Cells[3].Value.ToString();
            txtSDT.Text = dgvBenhNhan.Rows[secilen].Cells[4].Value.ToString();
            cmbGT.Text = dgvBenhNhan.Rows[secilen].Cells[5].Value.ToString();
            BenhNhanSlectedID = Convert.ToInt16(dgvBenhNhan.Rows[secilen].Cells[0].Value);
        }


        private void btn_updateBN_Click(object sender, EventArgs e)
        {
            using(HOSPITALDBEntities context = new HOSPITALDBEntities())
            {
                BenhNhan benhNhan = context.BenhNhans.Find(BenhNhanSlectedID);

                if(benhNhan != null )
                {
                    if (txtHo.Text == "" || txtTen.Text == "" || txtSDT.Text == "" || txtid.Text == "" || txtIdTK.Text == "" || cmbGT.Text == "")
                    {
                        
                        MessageBox.Show("Sửa thông tin không thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa bệnh nhân này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dialogResult == DialogResult.Yes)
                        {
                            benhNhan.ho = txtHo.Text;
                            benhNhan.ten = txtTen.Text;
                            benhNhan.sdt = txtSDT.Text;
                            benhNhan.gioitinh = cmbGT.Text;
                            context.SaveChanges();
                            MessageBox.Show("Sửa thông tin thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dgvBenhNhan.DataSource = context.BenhNhans.ToList();

                            dgvBenhNhan.Refresh();

                        }
                        else
                        {
                            MessageBox.Show("Đã hủy sửa thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        
                    }
                }
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {

            string ten = txtTen.Text;
            DataView dv = new DataView(dtBenhNhan);
            dv.RowFilter = $"ten LIKE '%{ten}%'";
            dgvBenhNhan.DataSource = dv;
            txtid.Text = "";
            txtHo.Text = "";
            txtSDT.Text = "";
            txtIdTK.Text = "";
            cmbGT.Text = "";
        }


        private void btn_TimGT_Click(object sender, EventArgs e)
        {
            string gioitinh = cmbGT.Text;
            DataView dv = new DataView(dtBenhNhan);
            
            if (gioitinh != "")
            {

                dv.RowFilter = $"gioitinh = '{gioitinh}'";
                dgvBenhNhan.DataSource = dv;
            }
            else
            {
                dgvBenhNhan.DataSource = dv;
            }
            txtid.Text = "";
            txtHo.Text = "";
            txtSDT.Text = "";
            txtIdTK.Text = "";
            txtTen.Text = "";
        }
    }
}
