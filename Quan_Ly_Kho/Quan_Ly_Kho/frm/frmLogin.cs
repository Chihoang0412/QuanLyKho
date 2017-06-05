using Quan_Ly_Kho.frm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Ly_Kho
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-PF25KAL\Kevin;Initial Catalog=QLKhoHang;Integrated Security=True");
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from taikhoan", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            foreach (DataRow dr in dt.Rows)
            {
                ACCOUNT acc = new ACCOUNT()
                {
                    Acc = dr[1].ToString(),
                    Pass = dr[2].ToString()
                };
                lstAcc.Add(acc);
            }
        }
        List<ACCOUNT> lstAcc = new List<ACCOUNT>();

        private void button1_Click(object sender, EventArgs e)
        {
            //if (textBox1.Text == "")
            //{
            //    lblthongbao.ForeColor = Color.Red;
            //    lblthongbao.Text = "Tên không được trống";
            //    textBox1.Focus();
            //    return;
            //}
            //if (textBox2.Text == "")
            //{
            //    lblthongbao.ForeColor = Color.Red;
            //    lblthongbao.Text = "mk không được trống";
            //    textBox2.Focus();
            //    return;
                bool ok = false;
            for (int i = 0; i < lstAcc.Count; i++)
            {
                if (textBox1.Text == lstAcc[i].Acc && textBox2.Text == lstAcc[i].Pass)
                {
                    System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    config.AppSettings.Settings["user"].Value = textBox1.Text.ToString();
                    config.Save(ConfigurationSaveMode.Modified);
                    ConfigurationManager.RefreshSection("appSettings");
                    MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK);
                    this.Hide();
                    frmMain frmMain = new frmMain();
                    frmMain.Show();
                    ok = true;
                    break;
                }
            }
            if (!ok)
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng", "Thông báo", MessageBoxButtons.OK);

        }


        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.ForeColor = Color.Black;
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox2.ForeColor = Color.Black;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmTaiKhoan frmtk = new frmTaiKhoan();
            frmtk.ShowDialog();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox1.PasswordChar = '\0';
                textBox2.PasswordChar = '\0';
            }
            else
            {
                textBox1.PasswordChar = '\0';
                textBox2.PasswordChar = '^';
            }
        }
    }

}
