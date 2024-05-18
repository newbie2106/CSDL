
namespace QL_BenhVien
{
    partial class FrmQuanLyBacSi
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dbgird = new System.Windows.Forms.DataGridView();
            this.btnsayfayiyenile = new System.Windows.Forms.Button();
            this.btn_editBS = new System.Windows.Forms.Button();
            this.msktc = new System.Windows.Forms.MaskedTextBox();
            this.btn_deleteBS = new System.Windows.Forms.Button();
            this.btn_themBS = new System.Windows.Forms.Button();
            this.cmbBS = new System.Windows.Forms.ComboBox();
            this.cmbnganh = new System.Windows.Forms.ComboBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbtenAdmin = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbIdTK = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbgird)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.dbgird);
            this.groupBox3.Controls.Add(this.btnsayfayiyenile);
            this.groupBox3.Controls.Add(this.btn_editBS);
            this.groupBox3.Controls.Add(this.msktc);
            this.groupBox3.Controls.Add(this.btn_deleteBS);
            this.groupBox3.Controls.Add(this.btn_themBS);
            this.groupBox3.Controls.Add(this.cmbBS);
            this.groupBox3.Controls.Add(this.cmbnganh);
            this.groupBox3.Controls.Add(this.txtid);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 165);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1206, 447);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bảng Bác Sĩ";
            // 
            // dbgird
            // 
            this.dbgird.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbgird.Location = new System.Drawing.Point(460, 21);
            this.dbgird.Name = "dbgird";
            this.dbgird.RowHeadersWidth = 62;
            this.dbgird.Size = new System.Drawing.Size(740, 403);
            this.dbgird.TabIndex = 7;
            this.dbgird.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dbgird_CellContentClick_1);
            // 
            // btnsayfayiyenile
            // 
            this.btnsayfayiyenile.BackColor = System.Drawing.Color.White;
            this.btnsayfayiyenile.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsayfayiyenile.Location = new System.Drawing.Point(81, 575);
            this.btnsayfayiyenile.Name = "btnsayfayiyenile";
            this.btnsayfayiyenile.Size = new System.Drawing.Size(209, 24);
            this.btnsayfayiyenile.TabIndex = 6;
            this.btnsayfayiyenile.Text = "Sayfayı Yenile";
            this.btnsayfayiyenile.UseVisualStyleBackColor = false;
            // 
            // btn_editBS
            // 
            this.btn_editBS.Location = new System.Drawing.Point(173, 334);
            this.btn_editBS.Name = "btn_editBS";
            this.btn_editBS.Size = new System.Drawing.Size(92, 42);
            this.btn_editBS.TabIndex = 1;
            this.btn_editBS.Text = "Sửa";
            this.btn_editBS.UseVisualStyleBackColor = true;
            // 
            // msktc
            // 
            this.msktc.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msktc.Location = new System.Drawing.Point(229, 209);
            this.msktc.Mask = "00000000000";
            this.msktc.Name = "msktc";
            this.msktc.ReadOnly = true;
            this.msktc.Size = new System.Drawing.Size(209, 40);
            this.msktc.TabIndex = 5;
            this.msktc.ValidatingType = typeof(int);
            // 
            // btn_deleteBS
            // 
            this.btn_deleteBS.Location = new System.Drawing.Point(303, 334);
            this.btn_deleteBS.Name = "btn_deleteBS";
            this.btn_deleteBS.Size = new System.Drawing.Size(97, 42);
            this.btn_deleteBS.TabIndex = 1;
            this.btn_deleteBS.Text = "Xóa";
            this.btn_deleteBS.UseVisualStyleBackColor = true;
            // 
            // btn_themBS
            // 
            this.btn_themBS.Location = new System.Drawing.Point(24, 334);
            this.btn_themBS.Name = "btn_themBS";
            this.btn_themBS.Size = new System.Drawing.Size(106, 42);
            this.btn_themBS.TabIndex = 1;
            this.btn_themBS.Text = "Thêm";
            this.btn_themBS.UseVisualStyleBackColor = true;
            // 
            // cmbBS
            // 
            this.cmbBS.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBS.FormattingEnabled = true;
            this.cmbBS.Location = new System.Drawing.Point(229, 146);
            this.cmbBS.Name = "cmbBS";
            this.cmbBS.Size = new System.Drawing.Size(209, 41);
            this.cmbBS.TabIndex = 4;
            // 
            // cmbnganh
            // 
            this.cmbnganh.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbnganh.FormattingEnabled = true;
            this.cmbnganh.Location = new System.Drawing.Point(229, 93);
            this.cmbnganh.Name = "cmbnganh";
            this.cmbnganh.Size = new System.Drawing.Size(209, 41);
            this.cmbnganh.TabIndex = 3;
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(229, 42);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(209, 40);
            this.txtid.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(18, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 33);
            this.label8.TabIndex = 5;
            this.label8.Text = "Tài Khoản:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 33);
            this.label7.TabIndex = 4;
            this.label7.Text = "Bác Sĩ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 33);
            this.label6.TabIndex = 3;
            this.label6.Text = "Chuyên Khoa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 33);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID:";
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
            this.groupBox1.Size = new System.Drawing.Size(577, 125);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Admin";
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
            // FrmQuanLyBacSi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 624);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "FrmQuanLyBacSi";
            this.Text = "FrmQuanLyBacSi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmQuanLyBacSi_FormClosing);
            this.Load += new System.EventHandler(this.FrmQuanLyBacSi_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbgird)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnsayfayiyenile;
        private System.Windows.Forms.Button btn_editBS;
        private System.Windows.Forms.MaskedTextBox msktc;
        private System.Windows.Forms.Button btn_deleteBS;
        private System.Windows.Forms.Button btn_themBS;
        private System.Windows.Forms.ComboBox cmbBS;
        private System.Windows.Forms.ComboBox cmbnganh;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbtenAdmin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbIdTK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dbgird;
    }
}