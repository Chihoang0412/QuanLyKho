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
    public partial class frmKhachHang : Form
    {

       
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-PF25KAL\Kevin;Initial Catalog=QLKhoHang;Integrated Security=True");
            con.Open();
            string sql = "";
            if (txtEmp.Text != "")
            {
                sql = @"update khachhang set ten = N'" + txtEmp_nm.Text + "' ,diachi = N'" + txtEmp_add.Text + "',masothue = N'" + textBox2 .Text + "' ,sdt = N'" + txtEmp_ctc.Text + "' where ma = N'" + txtEmp.Text + "'";
            }
            else
            {
                
                    sql = @"insert into khachhang (ten,diachi,sdt,masothue) values (N'" + txtEmp_nm.Text + "',N'" + txtEmp_add.Text + "',N'" + txtEmp_ctc.Text + "',N'" + textBox2 .Text + "')";
                
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

        private void Gv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.Gv.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                txtEmp.Text = row.Cells[0].Value.ToString();
                txtEmp_nm.Text = row.Cells[1].Value.ToString();
                txtEmp_add.Text = row.Cells[2].Value.ToString();
                txtEmp_ctc.Text = row.Cells[3].Value.ToString();
                txtEmp_pos.Text = row.Cells[4].Value.ToString();

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
    }

