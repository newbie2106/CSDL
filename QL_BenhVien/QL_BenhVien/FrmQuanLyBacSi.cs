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
        public int BacSiSelectedID;
        public int getIdBacSi;
        public FrmQuanLyBacSi()
        {
            InitializeComponent();
            dbInit = new HOSPITALDBEntities();
        }

        public void loadData()
        {
            

            DataTable dtbacsi = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT BacSi.id,ten_nganh,(ho+' '+ten)as'hovaten'," +
                "taikhoan,matkhau from BacSi Join Nganh ON BacSi.id_nganh=Nganh.id", _conn.connection());
            SqlDataAdapter da2 = new SqlDataAdapter();
            da2.SelectCommand = cmd;
            da2.Fill(dtbacsi);
            dbgird.DataSource = dtbacsi;

            dbgird.Columns[0].HeaderText = "ID";
            dbgird.Columns[1].HeaderText = "Ten Nganh";
            dbgird.Columns[2].HeaderText = "Ten";
            dbgird.Columns[3].HeaderText = "Tai Khoan";
            dbgird.Columns[4].HeaderText = "Mat Khau";


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


            SqlCommand cmd3 = new SqlCommand("select(ho +' '+ ten) as 'hovaten' from BacSi", _conn.connection());
            SqlDataReader dr3 = cmd3.ExecuteReader();
            
            while (dr3.Read())
            {
                cmbBS.Items.Add(dr3[0]);
            }
            _conn.connection().Close();


            
        }
        private void CmbNganh_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbBS.Items.Clear();

            SqlCommand cmd4 = new SqlCommand("select ho,ten from BacSi join Nganh On BacSi.id_nganh = Nganh.id where ten_nganh=@p1", _conn.connection());
            cmd4.Parameters.AddWithValue("@p1", cmbnganh.Text);
            SqlDataReader dr4 = cmd4.ExecuteReader();
            while (dr4.Read())
            {
                cmbBS.Items.Add(dr4[0] + " " + dr4[1]);
            }
            _conn.connection().Close();
        }

       
        public void dbgird_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dbgird.SelectedCells[0].RowIndex;
            txtid.Text = dbgird.Rows[secilen].Cells[0].Value.ToString();
            cmbnganh.Text = dbgird.Rows[secilen].Cells[1].Value.ToString();
            cmbBS.Text = dbgird.Rows[secilen].Cells[2].Value.ToString();
            msktc.Text = dbgird.Rows[secilen].Cells[3].Value.ToString();
            mktc.Text = dbgird.Rows[secilen].Cells[4].Value.ToString();
            BacSiSelectedID = Convert.ToInt32(dbgird.Rows[secilen].Cells[0].Value);

        }
        private void FrmQuanLyBacSi_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult thongbao = MessageBox.Show("Bạn có muốn thoát chương trình không ? ", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (thongbao == DialogResult.No)
            {
                e.Cancel = true;
                return;

            }
            Environment.Exit(0);
        }

        private void btn_themBS_Click(object sender, EventArgs e)
        {
            FrmTaoTKBacSi f = new FrmTaoTKBacSi();
            f.Show();
        }

        private void btnRF_Click(object sender, EventArgs e)
        {
            loadData();
            dbgird.Refresh();
            
        }

        private void btn_editBS_Click(object sender, EventArgs e)
        {
            using (HOSPITALDBEntities context = new HOSPITALDBEntities())
            {
                
                BacSi bacSi = context.BacSis.Find(BacSiSelectedID);
                if (bacSi != null)
                {
                    bacSi.id_nganh = cmbnganh.SelectedIndex + 13;
                    context.SaveChanges();
                    loadData();
                }
            }
        }

        private void btn_deleteBS_Click(object sender, EventArgs e)
        {
            using (HOSPITALDBEntities context = new HOSPITALDBEntities())
            {
                BacSi bacSi = context.BacSis.Find(BacSiSelectedID);
                context.BacSis.Remove(bacSi);
                context.SaveChanges();
                loadData();
            }
        }
    }
}
