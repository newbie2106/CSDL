
namespace QL_BenhVien
{
    partial class FrmBenhNhanDatLich
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
            this.lbTK = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.time = new System.Windows.Forms.DateTimePicker();
            this.btnDatLich = new System.Windows.Forms.Button();
            this.rtbMoTa = new System.Windows.Forms.RichTextBox();
            this.datetime = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.cmbBacSi = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbId = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnChiTiet = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài khoản:";
            // 
            // lbTK
            // 
            this.lbTK.AutoSize = true;
            this.lbTK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTK.Location = new System.Drawing.Point(159, 83);
            this.lbTK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTK.Name = "lbTK";
            this.lbTK.Size = new System.Drawing.Size(40, 22);
            this.lbTK.TabIndex = 1;
            this.lbTK.Text = "......";
            this.lbTK.Click += new System.EventHandler(this.lbId_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.groupBox1.Controls.Add(this.btnChiTiet);
            this.groupBox1.Controls.Add(this.time);
            this.groupBox1.Controls.Add(this.btnDatLich);
            this.groupBox1.Controls.Add(this.rtbMoTa);
            this.groupBox1.Controls.Add(this.datetime);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbKhoa);
            this.groupBox1.Controls.Add(this.cmbBacSi);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(29, 126);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(432, 462);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đặt lịch";
            // 
            // time
            // 
            this.time.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.time.Location = new System.Drawing.Point(172, 188);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(213, 30);
            this.time.TabIndex = 13;
            // 
            // btnDatLich
            // 
            this.btnDatLich.Location = new System.Drawing.Point(219, 408);
            this.btnDatLich.Name = "btnDatLich";
            this.btnDatLich.Size = new System.Drawing.Size(116, 35);
            this.btnDatLich.TabIndex = 12;
            this.btnDatLich.Text = "Đặt lịch";
            this.btnDatLich.UseVisualStyleBackColor = true;
            this.btnDatLich.Click += new System.EventHandler(this.btnDatLich_Click);
            // 
            // rtbMoTa
            // 
            this.rtbMoTa.Location = new System.Drawing.Point(172, 255);
            this.rtbMoTa.Name = "rtbMoTa";
            this.rtbMoTa.Size = new System.Drawing.Size(213, 122);
            this.rtbMoTa.TabIndex = 11;
            this.rtbMoTa.Text = "";
            // 
            // datetime
            // 
            this.datetime.CustomFormat = "dd/MM/yyyy";
            this.datetime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datetime.Location = new System.Drawing.Point(172, 137);
            this.datetime.Name = "datetime";
            this.datetime.Size = new System.Drawing.Size(213, 30);
            this.datetime.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ngày";
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Location = new System.Drawing.Point(172, 30);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(213, 30);
            this.cmbKhoa.TabIndex = 7;
            this.cmbKhoa.SelectedIndexChanged += new System.EventHandler(this.cmbKhoa_SelectedIndexChanged);
            // 
            // cmbBacSi
            // 
            this.cmbBacSi.FormattingEnabled = true;
            this.cmbBacSi.Location = new System.Drawing.Point(172, 86);
            this.cmbBacSi.Name = "cmbBacSi";
            this.cmbBacSi.Size = new System.Drawing.Size(213, 30);
            this.cmbBacSi.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 22);
            this.label7.TabIndex = 4;
            this.label7.Text = "Mô tả bệnh";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 22);
            this.label6.TabIndex = 3;
            this.label6.Text = "Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 22);
            this.label5.TabIndex = 2;
            this.label5.Text = "Khoa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "Bác sĩ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(121, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "Đăng kí lịch hẹn";
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbId.Location = new System.Drawing.Point(324, 83);
            this.lbId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(40, 22);
            this.lbId.TabIndex = 5;
            this.lbId.Text = "......";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(288, 83);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 22);
            this.label9.TabIndex = 4;
            this.label9.Text = "Id:";
            // 
            // btnChiTiet
            // 
            this.btnChiTiet.Location = new System.Drawing.Point(48, 408);
            this.btnChiTiet.Name = "btnChiTiet";
            this.btnChiTiet.Size = new System.Drawing.Size(116, 35);
            this.btnChiTiet.TabIndex = 14;
            this.btnChiTiet.Text = "Chi tiết";
            this.btnChiTiet.UseVisualStyleBackColor = true;
            this.btnChiTiet.Click += new System.EventHandler(this.btnChiTiet_Click);
            // 
            // FrmBenhNhanDatLich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 614);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbTK);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmBenhNhanDatLich";
            this.Text = "FrmBenhNhanDatLich";
            this.Load += new System.EventHandler(this.FrmBenhNhanDatLich_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTK;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbKhoa;
        private System.Windows.Forms.ComboBox cmbBacSi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDatLich;
        private System.Windows.Forms.RichTextBox rtbMoTa;
        private System.Windows.Forms.DateTimePicker datetime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker time;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnChiTiet;
    }
}