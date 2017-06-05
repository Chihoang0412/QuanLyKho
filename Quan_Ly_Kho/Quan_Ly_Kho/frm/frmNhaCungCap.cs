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
    public partial class frmNhaCungCap : Form
    {
        public frmNhaCungCap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-PF25KAL\Kevin;Initial Catalog=QLKhoHang;Integrated Security=True");
            con.Open();
            string sql = "";
            if (txtEmp.Text != "")
            {
                sql = @"update nhacungcap set ten = N'" + txtEmp_nm.Text + "' ,diachi = N'" + txtEmp_add.Text + "',masothue = N'" + textBox2.Text + "' ,sdt = N'" + txtEmp_ctc.Text + "' where ma = N'" + txtEmp.Text + "'";
            }
            else
            {

                sql = @"insert into nhacungcap (ten,diachi,sdt,masothue) values (N'" + txtEmp_nm.Text + "',N'" + txtEmp_add.Text + "',N'" + txtEmp_ctc.Text + "',N'" + textBox2.Text + "')";

            }
            SqlCommand cmd = new SqlCommand(sql, con);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("thanh cong");

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
