using Quan_Ly_Kho.frm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Ly_Kho
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            

        }

       

        private void khoHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHangHoa frmhh = new frmHangHoa();
            frmhh.ShowDialog();
        }

        private void phiếuXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPhieuXuat frmpx = new frmPhieuXuat();
            frmpx.ShowDialog();
        }

        private void phiếuNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPhieuNhap frmpn = new frmPhieuNhap();
            frmpn.ShowDialog();
        }

        private void chiTiếtPhiếuXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChiTietPhieuXuat frmctpx = new frmChiTietPhieuXuat();
            frmctpx.ShowDialog();
        }

        private void chiTiếtPhiếuNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChiTietPhieuNhap frmctpn = new frmChiTietPhieuNhap();
            frmctpn.ShowDialog();
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhaCungCap frmncc = new frmNhaCungCap();
            frmncc.ShowDialog();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKhachHang frmkh = new frmKhachHang();
            frmkh.ShowDialog();
        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTaiKhoan frmtk = new frmTaiKhoan();
            frmtk.ShowDialog();
        }

        private void View()
        {
            SqlConnection con = new SqlConnection("server = (local)\\SQLEXPRESS;database=QLKhoHang;integrated security=SSPI");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from hanghoa", con);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter adt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adt.Fill(dt);
            adt.Dispose();
            dataGridView1.DataSource = dt;
            con.Close();
        }
        int CrrMa;
        private void frmMain_Load(object sender, EventArgs e)
        {
            View();
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            CrrMa = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }
    }
}
