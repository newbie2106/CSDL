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

            SqlCommand komut = new SqlCommand("select ho,ten from BacSi where  taikhoan=@p1", _conn.connection());
            komut.Parameters.AddWithValue("@p1", lbIdTK.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lbHoTen.Text = dr[0] + " " + dr[1];
            }
            _conn.connection().Close();

            //Randevular
            DataTable dt = new DataTable();
            //SqlDataAdapter da = new SqlDataAdapter("select * from TBL_Randevular where RandevuDoktor='" + lbHoTen.Text + "'", bgl.baglanti());
            //da.Fill(dt);
            dt.Columns.Add("Cột 1");
            dt.Columns.Add("Cột 2");
            dt.Columns.Add("Cột 3");
            dt.Columns.Add("Cột 4");
            dt.Columns.Add("Cột 5");
            dt.Columns.Add("Cột 6");
            dt.Columns.Add("Cột 7");
            dt.Columns.Add("Cột 8");
            dataGridView1.DataSource = dt;

            dataGridView1.Columns[0].HeaderText = "Randevu No";
            dataGridView1.Columns[1].HeaderText = "Randevu Tarihi";
            dataGridView1.Columns[2].HeaderText = "Randevu Saat";
            dataGridView1.Columns[3].HeaderText = "Randevu Branşı";
            dataGridView1.Columns[4].HeaderText = "Doktor";
            dataGridView1.Columns[5].HeaderText = "Randevu Durumu";
            dataGridView1.Columns[6].HeaderText = "Hasta TC";
            dataGridView1.Columns[7].HeaderText = "Hasta Şikayet";
            dataGridView1.Columns[4].Visible = false;
        }
    }
}
