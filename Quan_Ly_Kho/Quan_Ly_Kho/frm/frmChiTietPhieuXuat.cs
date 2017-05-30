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
    public partial class frmChiTietPhieuXuat : Form
    {
        private DataTable dtDanhSach = new DataTable();
        private DataTable dtHangHoa = new DataTable();
        private static int ma = 0;
        public frmChiTietPhieuXuat()
        {
            InitializeComponent();
        }

        private void frmChiTietPhieuXuat_Load(object sender, EventArgs e)
        {
            init();

            lblTittle.Text += System.Configuration.ConfigurationManager.AppSettings["mapx"].ToString();

            BUS_ChiTietPhieuXuat bus = new BUS_ChiTietPhieuXuat();
            dtDanhSach = bus.getChiTiet();
            dgvDanhSachs.DataSource = dtDanhSach;
            dtHangHoa = bus.getHangHoa();
            cmbHangHoa.DataSource = dtHangHoa;
            cmbHangHoa.DisplayMember = "ten";
            cmbHangHoa.ValueMember = "ma";
        }

        private void init()
        {
            txtDonGia.Text = "";
            txtSl.Text = "";
            btnSua.Visible = false;
            btnXoa.Visible = false;
        }

        private void dgvDanhSachs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btnSua.Visible = true;
                btnXoa.Visible = true;
                cmbHangHoa.Text = dgvDanhSachs.Rows[e.RowIndex].Cells["ten"].Value.ToString();
                txtDonGia.Text = dgvDanhSachs.Rows[e.RowIndex].Cells["dongia"].Value.ToString();
                txtSl.Text = dgvDanhSachs.Rows[e.RowIndex].Cells["soluong"].Value.ToString();
                ma = int.Parse(dgvDanhSachs.Rows[e.RowIndex].Cells["ma"].Value.ToString());
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (check())
            {
                BUS_ChiTietPhieuXuat bus = new BUS_ChiTietPhieuXuat();
                bool res = bus.Insert(int.Parse(cmbHangHoa.SelectedValue.ToString()), int.Parse(txtSl.Text.ToString()), int.Parse(txtDonGia.Text.ToString()));
                if (res)
                {
                    MessageBox.Show("Thêm chi tiết thành công");
                    frmChiTietPhieuXuat_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Thêm chi tiết không thành công");
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
                BUS_ChiTietPhieuXuat bus = new BUS_ChiTietPhieuXuat();
                bool res = bus.Update(ma, int.Parse(txtSl.Text.ToString()), int.Parse(txtDonGia.Text.ToString()), int.Parse(cmbHangHoa.SelectedValue.ToString()));
                if (res)
                {
                    MessageBox.Show("Cập nhật chi tiết thành công");
                    frmChiTietPhieuXuat_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Cập nhật chi tiết không thành công");
                }
            }
            else
            {
                MessageBox.Show("Cần nhập đủ thông tin");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            BUS_ChiTietPhieuXuat bus = new BUS_ChiTietPhieuXuat();
            bool res = bus.Delete(ma);
            if (res)
            {
                MessageBox.Show("Xóa chi tiết thành công");
                frmChiTietPhieuXuat_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Xóa chi tiết không thành công");
            }
        }

        private bool check()
        {
            if (txtDonGia.Text == "" || txtSl.Text == "") return false;
            else return true;
        }

        private void D_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) )
            {
                e.Handled = true;
            }
            if ( ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
