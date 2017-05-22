using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quan_Ly_Kho.BLL;
using System.Configuration;

namespace Quan_Ly_Kho.frm
{
    public partial class frmPhieuNhap : Form
    {
        BUS_PhieuNhap bus = new BUS_PhieuNhap();
        private DataTable pn = new DataTable();
        private DataTable ncc = new DataTable();
        public frmPhieuNhap()
        {
            InitializeComponent();
        }

        private void frmPhieuNhap_Load(object sender, EventArgs e)
        {
            btnSua.Visible = false;
            btnXoa.Visible = false;
            label5.Visible = false;
            txtMa.Visible = false;
            pn = bus.GetList();
            ncc = bus.getNcc();
            dgvDanhSach.DataSource = pn;
            cmbNcc.DataSource = ncc;
            cmbNcc.DisplayMember = "ten";
            cmbNcc.ValueMember = "ma";
        }

        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                panel1.Enabled = true;
                btnSua.Visible = true;
                btnXoa.Visible = true;
                btnChiTiet.Visible = true;
                txtMa.Visible = true;
                label5.Visible = true;
                txtMa.Text = dgvDanhSach.CurrentRow.Cells[0].Value.ToString();
                txtTen.Text = dgvDanhSach.CurrentRow.Cells[1].Value.ToString();
                txtGhiChu.Text = dgvDanhSach.CurrentRow.Cells[3].Value.ToString();
                cmbNcc.Text = dgvDanhSach.CurrentRow.Cells[2].Value.ToString();
                dtpNgayNhap.Value = Convert.ToDateTime(dgvDanhSach.CurrentRow.Cells[4].Value);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int result = bus.Them(txtTen.Text.ToString(), (int)cmbNcc.SelectedValue, txtGhiChu.Text.ToString());
            if(result == 1)
            {
                MessageBox.Show("Thêm thành công");
                frmPhieuNhap_Load(sender, e);
                
            }
            else
            {
                MessageBox.Show("Thêm không thành công");
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int result = bus.Sua(txtTen.Text.ToString(), (int)cmbNcc.SelectedValue, txtGhiChu.Text.ToString(), int.Parse(txtMa.Text.ToString()));
            if (result == 1)
            {
                MessageBox.Show("Sửa thành công");
                frmPhieuNhap_Load(sender, e);
                btnSua.Visible = false;
                btnXoa.Visible = false;
            }
            else
            {
                MessageBox.Show("Sửa không thành công");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int result = bus.Xoa( int.Parse(txtMa.Text.ToString()));
            if (result == 1)
            {
                MessageBox.Show("Xóa thành công");
                frmPhieuNhap_Load(sender, e);
                btnSua.Visible = false;
                btnXoa.Visible = false;
                btnChiTiet.Visible = false;
            }
            else
            {
                MessageBox.Show("Xóa không thành công");
            }
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings["mapn"].Value = txtMa.Text.ToString();
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");

            this.Visible = false;
            frmChiTietPhieuNhap chitiet = new frmChiTietPhieuNhap();
            chitiet.ShowDialog();
            this.Visible = true;
        }
    }
}
