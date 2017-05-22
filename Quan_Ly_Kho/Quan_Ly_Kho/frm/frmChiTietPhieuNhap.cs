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

namespace Quan_Ly_Kho.frm
{
    public partial class frmChiTietPhieuNhap : Form
    {
        BUS_ChiThietPhieuNhap bus = new BUS_ChiThietPhieuNhap();
        DataTable danhsach = new DataTable();
        DataTable hang = new DataTable();

        public frmChiTietPhieuNhap()
        {
            InitializeComponent();
        }

        private void frmChiTietPhieuNhap_Load(object sender, EventArgs e)
        {
            btnSua.Visible = false;
            btnXoa.Visible = false;
            danhsach = bus.getList();
            dgvDanhSach.DataSource = danhsach;
            hang = bus.getHangHoa();
            cmbTenHH.DataSource = hang;
            cmbTenHH.DisplayMember = "ten";
            cmbTenHH.ValueMember = "ma";
        }

        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btnSua.Visible = true;
                btnXoa.Visible = true;
                cmbTenHH.Text = dgvDanhSach.CurrentRow.Cells[2].Value.ToString();
                txtSl.Text = dgvDanhSach.CurrentRow.Cells[3].Value.ToString();
                txtDonGia.Text = dgvDanhSach.CurrentRow.Cells[4].Value.ToString();
                txtMa.Text = dgvDanhSach.CurrentRow.Cells[0].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int result = bus.Them(cmbTenHH.SelectedValue.ToString(), txtSl.Text.ToString(), txtDonGia.Text.ToString());
            if(result == 1)
            {
                MessageBox.Show("Thêm chi tiết thành công");
                frmChiTietPhieuNhap_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Thêm chi tiết không thành công");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int result = bus.Sua(cmbTenHH.SelectedValue.ToString(), txtSl.Text.ToString(), txtDonGia.Text.ToString(), txtMa.Text.ToString());
            if (result == 1)
            {
                MessageBox.Show("Sửa chi tiết thành công");
                frmChiTietPhieuNhap_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Sửa chi tiết không thành công");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int result = bus.Xoa(txtMa.Text.ToString());
            if (result == 1)
            {
                MessageBox.Show("Xóa chi tiết thành công");
                frmChiTietPhieuNhap_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Xóa chi tiết không thành công");
            }
        }
    }
}
