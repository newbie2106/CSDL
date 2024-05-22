
namespace QL_BenhVien
{
    partial class FrmBenhNhanDangNhap
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSo2 = new System.Windows.Forms.TextBox();
            this.btnDangnhap = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.lnkDangki = new System.Windows.Forms.LinkLabel();
            this.mTBSo1 = new System.Windows.Forms.MaskedTextBox();
            this.btnAn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(183, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐĂNG NHẬP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tài khoản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(73, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật khẩu";
            // 
            // txtSo2
            // 
            this.txtSo2.Location = new System.Drawing.Point(225, 235);
            this.txtSo2.Name = "txtSo2";
            this.txtSo2.Size = new System.Drawing.Size(245, 22);
            this.txtSo2.TabIndex = 4;
            // 
            // btnDangnhap
            // 
            this.btnDangnhap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangnhap.Location = new System.Drawing.Point(267, 303);
            this.btnDangnhap.Name = "btnDangnhap";
            this.btnDangnhap.Size = new System.Drawing.Size(145, 48);
            this.btnDangnhap.TabIndex = 5;
            this.btnDangnhap.Text = "Đăng nhập";
            this.btnDangnhap.UseVisualStyleBackColor = true;
            this.btnDangnhap.Click += new System.EventHandler(this.btnDangnhap_Click);
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.Transparent;
            this.btnback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnback.Location = new System.Drawing.Point(569, 326);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(52, 50);
            this.btnback.TabIndex = 6;
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // lnkDangki
            // 
            this.lnkDangki.AutoSize = true;
            this.lnkDangki.BackColor = System.Drawing.Color.White;
            this.lnkDangki.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkDangki.Location = new System.Drawing.Point(25, 343);
            this.lnkDangki.Name = "lnkDangki";
            this.lnkDangki.Size = new System.Drawing.Size(103, 33);
            this.lnkDangki.TabIndex = 8;
            this.lnkDangki.TabStop = true;
            this.lnkDangki.Text = "Đăng kí";
            this.lnkDangki.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkDangki_LinkClicked);
            // 
            // mTBSo1
            // 
            this.mTBSo1.Location = new System.Drawing.Point(225, 150);
            this.mTBSo1.Name = "mTBSo1";
            this.mTBSo1.Size = new System.Drawing.Size(245, 22);
            this.mTBSo1.TabIndex = 9;
            // 
            // btnAn
            // 
            this.btnAn.BackColor = System.Drawing.Color.Transparent;
            this.btnAn.BackgroundImage = global::QL_BenhVien.Properties.Resources.tải_xuống;
            this.btnAn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAn.Location = new System.Drawing.Point(476, 232);
            this.btnAn.Name = "btnAn";
            this.btnAn.Size = new System.Drawing.Size(25, 25);
            this.btnAn.TabIndex = 10;
            this.btnAn.UseVisualStyleBackColor = false;
            this.btnAn.Click += new System.EventHandler(this.btnAn_Click);
            // 
            // FrmBenhNhanDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 388);
            this.Controls.Add(this.btnAn);
            this.Controls.Add(this.mTBSo1);
            this.Controls.Add(this.lnkDangki);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnDangnhap);
            this.Controls.Add(this.txtSo2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmBenhNhanDangNhap";
            this.Text = "FrmBenhNhanDangNhap";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmBenhNhanDangNhap_FormClosing);
            this.Load += new System.EventHandler(this.FrmBenhNhanDangNhap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSo2;
        private System.Windows.Forms.Button btnDangnhap;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.LinkLabel lnkDangki;
        private System.Windows.Forms.MaskedTextBox mTBSo1;
        private System.Windows.Forms.Button btnAn;
    }
}