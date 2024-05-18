﻿using System;
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
    public partial class FrmChiTietAdmin : Form
    {
        public FrmChiTietAdmin()
        {
            InitializeComponent();
            this.MaximumSize = new System.Drawing.Size(2000, 2000);
        }
        public string TC;
        DBConnect _conn = new DBConnect();

        private void FrmChiTietAdmin_Load(object sender, EventArgs e)
        {
            lbIdTK.Text = TC;

            SqlCommand cmd = new SqlCommand("select ten from Admin where taikhoan=@p1", _conn.connection());
            cmd.Parameters.AddWithValue("@p1", lbIdTK.Text);
            SqlDataReader dr1 = cmd.ExecuteReader();
            while (dr1.Read())
            {
                lbtenAdmin.Text = dr1[0].ToString();
            }
            _conn.connection().Close();
        }

        private void btn_QuanLyBS_Click(object sender, EventArgs e)
        {
            FrmQuanLyBacSi from = new FrmQuanLyBacSi();
            from.TC = lbIdTK.Text;
            from.Show();
            this.Hide();
        }

        private void btn_QuanLyBN_Click(object sender, EventArgs e)
        {
            FrmQuanLyBenhNhan from1 = new FrmQuanLyBenhNhan();
            from1.TC = lbIdTK.Text;
            from1.Show();
            this.Hide();
        }

        private void FrmChiTietAdmin_FormClosing(object sender, FormClosingEventArgs e)
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
