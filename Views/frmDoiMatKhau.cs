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

namespace ThuVien.Views
{
    public partial class frmDoiMatKhau : Form
    {
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (!txtMatKhauCu.Text.Equals(Program.loginPassword)){
                MessageBox.Show("Không đúng mật khẩu cũ", "Thông báo");
                return;
            }
            if(txtMatKhauMoi.Text.Contains(" "))
            {
                MessageBox.Show("Mật khẩu không chứa khoảng trắng","Thông báo");
                return;
            }

            if (!txtMatKhauMoi.Text.Equals(txtXacNhanLai.Text))
            {
                MessageBox.Show("Xác nhận mật khẩu không đúng","Thông báo");
                return;
            }

            if(MessageBox.Show("Xác nhận đổi mật khẩu?","Xác nhận",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                String sql = string.Format("EXEC SP_ChangePassword '{0}', '{1}', '{2}'", Program.loginLogin, txtMatKhauCu.Text, txtMatKhauMoi.Text);
                SqlConnection sqlConn = new SqlConnection();

                try
                {
                    sqlConn.ConnectionString = Program.connPublisherString;
                    sqlConn.Open();
                    SqlCommand cmd = new SqlCommand(sql, sqlConn);
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandTimeout = 600; //10 phút
                    if (sqlConn.State == ConnectionState.Closed) sqlConn.Open();

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Đổi mật khẩu thành công, vui lòng đăng nhập lại", "Thông báo");
                    Program.LogOut();
                    this.Dispose();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi");
                }
                finally
                {
                    sqlConn.Close();
                }
            }
            
        }
    }
}
