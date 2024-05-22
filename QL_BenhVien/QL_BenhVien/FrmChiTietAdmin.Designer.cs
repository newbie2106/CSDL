
namespace QL_BenhVien
{
    partial class FrmChiTietAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btn_deleteThuoc = new System.Windows.Forms.Button();
            this.btn_updateThuoc = new System.Windows.Forms.Button();
            this.btn_addThuoc = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.lbtenAdmin = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbIdTK = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_QuanLyBS = new System.Windows.Forms.Button();
            this.btn_QuanLyBN = new System.Windows.Forms.Button();
            this.dgvThongBao = new System.Windows.Forms.DataGridView();
            this.groupBox6.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongBao)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.Transparent;
            this.groupBox6.Controls.Add(this.dgvThongBao);
            this.groupBox6.Controls.Add(this.btn_deleteThuoc);
            this.groupBox6.Controls.Add(this.btn_updateThuoc);
            this.groupBox6.Controls.Add(this.btn_addThuoc);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(12, 155);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(1101, 414);
            this.groupBox6.TabIndex = 11;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Thông Báo";
            // 
            // btn_deleteThuoc
            // 
            this.btn_deleteThuoc.Location = new System.Drawing.Point(278, 337);
            this.btn_deleteThuoc.Name = "btn_deleteThuoc";
            this.btn_deleteThuoc.Size = new System.Drawing.Size(114, 42);
            this.btn_deleteThuoc.TabIndex = 1;
            this.btn_deleteThuoc.Text = "Xóa";
            this.btn_deleteThuoc.UseVisualStyleBackColor = true;
            // 
            // btn_updateThuoc
            // 
            this.btn_updateThuoc.Location = new System.Drawing.Point(128, 337);
            this.btn_updateThuoc.Name = "btn_updateThuoc";
            this.btn_updateThuoc.Size = new System.Drawing.Size(136, 42);
            this.btn_updateThuoc.TabIndex = 1;
            this.btn_updateThuoc.Text = "Cập Nhật";
            this.btn_updateThuoc.UseVisualStyleBackColor = true;
            // 
            // btn_addThuoc
            // 
            this.btn_addThuoc.Location = new System.Drawing.Point(6, 337);
            this.btn_addThuoc.Name = "btn_addThuoc";
            this.btn_addThuoc.Size = new System.Drawing.Size(106, 42);
            this.btn_addThuoc.TabIndex = 1;
            this.btn_addThuoc.Text = "Thêm";
            this.btn_addThuoc.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 33);
            this.label9.TabIndex = 0;
            // 
            // lbtenAdmin
            // 
            this.lbtenAdmin.AutoSize = true;
            this.lbtenAdmin.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtenAdmin.Location = new System.Drawing.Point(178, 79);
            this.lbtenAdmin.Name = "lbtenAdmin";
            this.lbtenAdmin.Size = new System.Drawing.Size(43, 33);
            this.lbtenAdmin.TabIndex = 7;
            this.lbtenAdmin.Text = "....";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 33);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tên Admin:";
            // 
            // lbIdTK
            // 
            this.lbIdTK.AutoSize = true;
            this.lbIdTK.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIdTK.Location = new System.Drawing.Point(178, 37);
            this.lbIdTK.Name = "lbIdTK";
            this.lbIdTK.Size = new System.Drawing.Size(169, 33);
            this.lbIdTK.TabIndex = 5;
            this.lbIdTK.Text = "00000000000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "Số Tài Khoản :";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lbtenAdmin);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbIdTK);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 125);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Admin";
            // 
            // btn_QuanLyBS
            // 
            this.btn_QuanLyBS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QuanLyBS.Location = new System.Drawing.Point(430, 28);
            this.btn_QuanLyBS.Name = "btn_QuanLyBS";
            this.btn_QuanLyBS.Size = new System.Drawing.Size(250, 109);
            this.btn_QuanLyBS.TabIndex = 12;
            this.btn_QuanLyBS.Text = "QUẢN LÝ BÁC SĨ";
            this.btn_QuanLyBS.UseVisualStyleBackColor = true;
            this.btn_QuanLyBS.Click += new System.EventHandler(this.btn_QuanLyBS_Click);
            // 
            // btn_QuanLyBN
            // 
            this.btn_QuanLyBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QuanLyBN.Location = new System.Drawing.Point(709, 28);
            this.btn_QuanLyBN.Name = "btn_QuanLyBN";
            this.btn_QuanLyBN.Size = new System.Drawing.Size(250, 109);
            this.btn_QuanLyBN.TabIndex = 12;
            this.btn_QuanLyBN.Text = "QUẢN LÝ BỆNH NHÂN";
            this.btn_QuanLyBN.UseVisualStyleBackColor = true;
            this.btn_QuanLyBN.Click += new System.EventHandler(this.btn_QuanLyBN_Click);
            // 
            // dgvThongBao
            // 
            this.dgvThongBao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongBao.Location = new System.Drawing.Point(16, 45);
            this.dgvThongBao.Name = "dgvThongBao";
            this.dgvThongBao.RowHeadersWidth = 62;
            this.dgvThongBao.RowTemplate.Height = 28;
            this.dgvThongBao.Size = new System.Drawing.Size(1023, 283);
            this.dgvThongBao.TabIndex = 2;
            // 
            // FrmChiTietAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 585);
            this.Controls.Add(this.btn_QuanLyBN);
            this.Controls.Add(this.btn_QuanLyBS);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmChiTietAdmin";
            this.Text = "FrmChiTietAdmin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmChiTietAdmin_FormClosing);
            this.Load += new System.EventHandler(this.FrmChiTietAdmin_Load);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongBao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label lbtenAdmin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbIdTK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_deleteThuoc;
        private System.Windows.Forms.Button btn_updateThuoc;
        private System.Windows.Forms.Button btn_addThuoc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_QuanLyBS;
        private System.Windows.Forms.Button btn_QuanLyBN;
        private System.Windows.Forms.DataGridView dgvThongBao;
    }
}