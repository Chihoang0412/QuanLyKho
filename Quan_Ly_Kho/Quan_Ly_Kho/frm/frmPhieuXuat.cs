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
    public partial class frmPhieuXuat : Form
    {
        private DataTable dtDanhSach = new DataTable();
        private DataTable dtKhachHang = new DataTable();
        private static int ma = 1;
        public frmPhieuXuat()
        {
            InitializeComponent();
        }

        private void frmPhieuXuat_Load(object sender, EventArgs e)
        {
            init();

            BUS_PhieuXuat bus = new BUS_PhieuXuat();
            dtDanhSach = bus.getList();
            dgvDanhSach.DataSource = dtDanhSach;
            dtKhachHang = bus.getKhachHang();
            cmbNguoiXuat.DataSource = dtKhachHang;
            cmbNguoiXuat.DisplayMember = "ten";
            cmbNguoiXuat.ValueMember = "ma";
        }

        private void init()
        {
            btnChiTiet.Visible = false;
            btnSua.Visible = false;
            btnXoa.Visible = false;
            txtGhiChu.Text = "";
            txtLyDo.Text = "";
            txtTen.Text = "";
            dtpNgay.Value = DateTime.Now;
        }

        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btnChiTiet.Visible = true;
                btnSua.Visible = true;
                btnXoa.Visible = true;
                txtTen.Text = dgvDanhSach.Rows[e.RowIndex].Cells["tenPx"].Value.ToString();
                txtLyDo.Text = dgvDanhSach.Rows[e.RowIndex].Cells["lydoxuat"].Value.ToString();
                txtGhiChu.Text = dgvDanhSach.Rows[e.RowIndex].Cells["ghichu"].Value.ToString();
                cmbNguoiXuat.Text = dgvDanhSach.Rows[e.RowIndex].Cells["tenKh"].Value.ToString();
                dtpNgay.Value = Convert.ToDateTime(dgvDanhSach.Rows[e.RowIndex].Cells["ngayxuat"].Value);
                ma = int.Parse(dgvDanhSach.Rows[e.RowIndex].Cells["ma"].Value.ToString());
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (check())
            {
                BUS_PhieuXuat bus = new BUS_PhieuXuat();
                bool res = bus.Insert(txtTen.Text.ToString(), txtLyDo.Text.ToString(), int.Parse(cmbNguoiXuat.SelectedValue.ToString()), txtGhiChu.Text.ToString());
                if (res)
                {
                    MessageBox.Show("Thêm phiếu xuất thành công");
                    frmPhieuXuat_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Thêm phiếu xuất không thành công");
                }
            }
            else
            {
                MessageBox.Show("Cần nhập đủ thông tin");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (check())
            {
                BUS_PhieuXuat bus = new BUS_PhieuXuat();
                bool res = bus.Update(txtTen.Text.ToString(), txtLyDo.Text.ToString(), int.Parse(cmbNguoiXuat.SelectedValue.ToString()), txtGhiChu.Text.ToString(), ma);
                if (res)
                {
                    MessageBox.Show("Cập nhật phiếu xuất thành công");
                    frmPhieuXuat_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Cập nhật phiếu xuất không thành công");
                }
            } else
            {
                MessageBox.Show("Cần nhập đủ thông tin");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            BUS_PhieuXuat bus = new BUS_PhieuXuat();
            bool res = bus.Delete(ma);
            if (res)
            {
                MessageBox.Show("Xóa phiếu xuất thành công");
                frmPhieuXuat_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Xóa phiếu xuất không thành công");
            }
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings["mapx"].Value = ma.ToString();
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
            this.Visible = false;
            frmChiTietPhieuXuat chitiet = new frmChiTietPhieuXuat();
            chitiet.ShowDialog();
            this.Visible = true;
        }

        private bool check()
        {
            if (txtGhiChu.Text == "" || txtLyDo.Text == "" || txtTen.Text == "") return false;
            else return true;
        }
    }
}
