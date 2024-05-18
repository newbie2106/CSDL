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
    public partial class FrmQuanLyBacSi : Form
    {
        private HOSPITALDBEntities dbInit;
        private int BacSiSelectedID;
        public FrmQuanLyBacSi()
        {
            InitializeComponent();
            dbInit = new HOSPITALDBEntities();
        }

        public void loadData()
        {
            using (HOSPITALDBEntities context = new HOSPITALDBEntities())
            {
                List<BacSi> svList = context.BacSis.ToList();
                dbgird.DataSource = svList;
            }

        }

        public string TC;
        DBConnect _conn = new DBConnect();

        private void FrmQuanLyBacSi_Load(object sender, EventArgs e)
        {
            lbIdTK.Text = TC;
            loadData();

            SqlCommand cmd = new SqlCommand("select ten from Admin where taikhoan=@p1", _conn.connection());
            cmd.Parameters.AddWithValue("@p1", lbIdTK.Text);
            SqlDataReader dr1 = cmd.ExecuteReader();
            while (dr1.Read())
            {
                lbtenAdmin.Text = dr1[0].ToString();
            }
            _conn.connection().Close();


            SqlCommand cmd2 = new SqlCommand("select ten_nganh from Nganh", _conn.connection());
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                cmbnganh.Items.Add(dr2[0]);
            }
            _conn.connection().Close();


            SqlCommand cmd3 = new SqlCommand("select ten from BacSi", _conn.connection());
            SqlDataReader dr3 = cmd3.ExecuteReader();
            while (dr3.Read())
            {
                cmbBS.Items.Add(dr3[0]);
            }
            _conn.connection().Close();
        }

        private void dbgird_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dbgird.Rows[e.RowIndex];
                BacSiSelectedID = Convert.ToInt32(row.Cells["id"].Value);
                
                
                cmbBS.Text = row.Cells["ten"].Value.ToString();
                cmbnganh.Text = row.Cells["id_nganh"].Value.ToString();
                msktc.Text = row.Cells["taikhoan"].Value.ToString();
                
                
            }


        }
        private void FrmQuanLyBacSi_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult cikis = MessageBox.Show("Bạn có muốn thoát chương trình không ? ", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (cikis == DialogResult.No)
            {
                e.Cancel = true;
                return;

            }
            Environment.Exit(0);
        }

        private void dbgird_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
