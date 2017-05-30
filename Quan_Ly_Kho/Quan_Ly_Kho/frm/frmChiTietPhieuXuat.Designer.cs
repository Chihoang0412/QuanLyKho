namespace Quan_Ly_Kho.frm
{
    partial class frmChiTietPhieuXuat
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
            this.lblTittle = new System.Windows.Forms.Label();
            this.dgvDanhSachs = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSl = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.cmbHangHoa = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachs)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTittle
            // 
            this.lblTittle.AutoSize = true;
            this.lblTittle.Font = new System.Drawing.Font("Lucida Calligraphy", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTittle.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTittle.Location = new System.Drawing.Point(77, 18);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(371, 31);
            this.lblTittle.TabIndex = 0;
            this.lblTittle.Text = "Chi tiết phiếu xuất mã số ";
            // 
            // dgvDanhSachs
            // 
            this.dgvDanhSachs.AllowUserToAddRows = false;
            this.dgvDanhSachs.AllowUserToDeleteRows = false;
            this.dgvDanhSachs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachs.Location = new System.Drawing.Point(2, 227);
            this.dgvDanhSachs.MultiSelect = false;
            this.dgvDanhSachs.Name = "dgvDanhSachs";
            this.dgvDanhSachs.ReadOnly = true;
            this.dgvDanhSachs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSachs.Size = new System.Drawing.Size(545, 200);
            this.dgvDanhSachs.TabIndex = 1;
            this.dgvDanhSachs.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachs_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hàng hóa";
            // 
            // txtSl
            // 
            this.txtSl.Location = new System.Drawing.Point(83, 143);
            this.txtSl.Name = "txtSl";
            this.txtSl.Size = new System.Drawing.Size(219, 20);
            this.txtSl.TabIndex = 5;
            this.txtSl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.D_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Số lượng";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(83, 186);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(219, 20);
            this.txtDonGia.TabIndex = 7;
            this.txtDonGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.D_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Đơn giá";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(403, 186);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(124, 23);
            this.btnXoa.TabIndex = 111;
            this.btnXoa.Text = "Xóa chi tiết";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Visible = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(403, 141);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(124, 23);
            this.btnSua.TabIndex = 110;
            this.btnSua.Text = "Sửa chi tiết";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Visible = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(403, 96);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(124, 23);
            this.btnThem.TabIndex = 109;
            this.btnThem.Text = "Thêm chi tiết";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cmbHangHoa
            // 
            this.cmbHangHoa.FormattingEnabled = true;
            this.cmbHangHoa.Location = new System.Drawing.Point(83, 96);
            this.cmbHangHoa.Name = "cmbHangHoa";
            this.cmbHangHoa.Size = new System.Drawing.Size(219, 21);
            this.cmbHangHoa.TabIndex = 112;
            // 
            // frmChiTietPhieuXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 435);
            this.Controls.Add(this.cmbHangHoa);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvDanhSachs);
            this.Controls.Add(this.lblTittle);
            this.Name = "frmChiTietPhieuXuat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmChiTietPhieuXuat";
            this.Load += new System.EventHandler(this.frmChiTietPhieuXuat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTittle;
        private System.Windows.Forms.DataGridView dgvDanhSachs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cmbHangHoa;
    }
}