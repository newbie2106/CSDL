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
    public partial class FrmTaoTKBacSi : Form
    {
        private HOSPITALDBEntities dbInit;
        
        public FrmTaoTKBacSi()
        {
            InitializeComponent();
            dbInit = new HOSPITALDBEntities();
        }
        DBConnect _conn = new DBConnect();
        private void button1_Click(object sender, EventArgs e)
        {
            
            string ho, hoTen, taikhoan, matkhau;
            int idNganh = cmbNganh.SelectedIndex + 13;
            ho = txtHo.Text;
            hoTen = txtTen.Text;
            taikhoan = txt_TK.Text;
            matkhau = txt_matkhau.Text;
            BacSi bacSi = new BacSi
            {
                ho = ho,
                ten = hoTen,
                taikhoan = taikhoan,
                matkhau = matkhau,
                id_nganh = idNganh
            };
            dbInit.BacSis.Add(bacSi);
            dbInit.SaveChanges();
            this.Close();

        }

        private void FrmTaoTKBacSi_Load(object sender, EventArgs e)
        {
            SqlCommand cmd2 = new SqlCommand("select ten_nganh from Nganh", _conn.connection());
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                cmbNganh.Items.Add(dr2[0]);
            }
            _conn.connection().Close();
        }

        

       

      



    }
}
