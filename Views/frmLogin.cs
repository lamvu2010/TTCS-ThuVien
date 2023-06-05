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
using ThuVien;

namespace THUVIEN.Views
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnOK_Click_1(object sender, EventArgs e)
        {
            Program.login=txtUsername.Text;
            Program.password=txtPassword.Text;
            Program.password = this.txtPassword.Text.Trim();
            if (Program.login.Length == 0 || Program.password.Length == 0)
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu còn trống");
                return;
            }
            if (Program.ConnectSql() == 1)
            {
                SqlDataReader myReader = Program.ExecSqlDataReader("EXEC SP_DANGNHAP '" + Program.login + "'");
                if (myReader != null && myReader.Read())
                {
                    Program.group = myReader.GetString(1);
                    if (Program.group != "DocGia" && Program.group != "QuanLy")
                    {
                        MessageBox.Show("Lỗi không thể lấy được thông tin tài khoản");
                        myReader.Close();
                        return;
                    }
                    Program.userName = myReader.GetString(0);
                    Program.name = myReader.GetString(2);
                    Program.loginLogin = Program.login;
                    Program.loginPassword = Program.password;
                }
                myReader.Close();
                Program.f.SetWorkingSpace(Program.group);
                MessageBox.Show("Đăng nhập thành công");
                this.Dispose();
            }
        }

        private void frmLogin_Load_1(object sender, EventArgs e)
        {

        }
    }
}
