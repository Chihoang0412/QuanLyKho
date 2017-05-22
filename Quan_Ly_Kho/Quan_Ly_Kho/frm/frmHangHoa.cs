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

namespace Quan_Ly_Kho.frm
{
    public partial class frmHangHoa : Form
    {
        public frmHangHoa()
        {
            InitializeComponent();
            View();
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
        }
        int CrrMa;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CrrMa = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            txtten.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtdvt.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtsl.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtxx.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtnn.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("server = (local)\\SQLEXPRESS;database=QLKhoHang;integrated security=SSPI");
            con.Open();
            string str = "insert into hanghoa(ten,donvitinh,soluong,xuatxu,nguoinhap) select N'{0}',N'{1}',N'{2}',N'{3}',N'{4}'";
            string them = string.Format(str, txtten.Text, txtdvt.Text,txtsl.Text,txtxx.Text,txtnn.Text);
            SqlCommand cmd = new SqlCommand(them, con);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("thanh cong");
                View();
                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("server = (local)\\SQLEXPRESS;database=QLKhoHang;integrated security=SSPI");
            con.Open();
            string str = "UPDATE hanghoa SET ten=N'{0}',donvitinh=N'{1}',soluong='{2}',xuatxu=N'{3}',nguoinhap=N'{4}' where ma='{5}'";
            string up = string.Format(str, txtten.Text, txtdvt.Text,int.Parse(txtsl.Text),txtxx.Text,txtnn.Text,CrrMa);
            SqlCommand cmd = new SqlCommand(up, con);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("thanh cong");
                View();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("server = (local)\\SQLEXPRESS;database=QLKhoHang;integrated security=SSPI");
            con.Open();
            DialogResult dr = MessageBox.Show("Ban co muon xoa khong?", "Chu y!", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                string str = "DELETE FROM hanghoa where Ma='{0}'";
                string delete = string.Format(str, CrrMa);
                SqlCommand cmd = new SqlCommand(delete, con);
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("thanh cong");
                    View();
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    con.Close();
                }
            }
        }
    }
}
