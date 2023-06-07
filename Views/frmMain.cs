using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using THUVIEN.Views;

namespace ThuVien.Views
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
            Form f = new frmLogin();
            f.MdiParent = this;
            f.Show();
        }
        private Form checkExists(Type t)
        {
            foreach (Form f in MdiChildren)
            {
                if (f.GetType() == t) return f;
            }
            return null;
        }

        public void SetWorkingSpace(String role)
        {
            if (role == "LogOut")
            {
                this.TENDANGNHAP.Text = "Tên đăng nhập";
                this.NHOM.Text = "Nhóm";
                this.TEN.Text = "Tên";
                this.HeThongPage.Visible = false;
                this.QuanLyPage.Visible = false;
                this.TraCuuPage.Visible = false;
                this.btnChangePassword.Enabled = false;
                this.btnExit.Enabled = false;
                this.btnLogin.Enabled = true;
            }
            else if (role != null)
            {
                this.TENDANGNHAP.Text = Program.userName;
                this.NHOM.Text = Program.group;
                if (Program.name != null)
                {
                    this.TEN.Text = Program.name;
                }
                if(Program.group != null && Program.group.Equals("DocGia"))
                {
                    this.TraCuuPage.Visible = true;
                    this.QuanLyGroup.Visible = false;
                    this.DocGiaGroup.Visible = true;
                    this.btnBorrowBookList.Enabled = false;
                    this.btnBorrowNewsList.Enabled = false;
                    this.btnChangePassword.Enabled = true;
                    this.btnExit.Enabled = true;
                    this.btnLogin.Enabled = false;
                }
                else if(Program.group != null && Program.group.Equals("QuanLy"))
                {
                    this.HeThongPage.Visible = true;
                    this.QuanLyPage.Visible = true;
                    this.TraCuuPage.Visible = true;
                    this.QuanLyGroup.Visible = true;
                    this.DocGiaGroup.Visible = false;
                    this.btnBorrowBookList.Enabled = true;
                    this.btnBorrowNewsList.Enabled = true;
                    this.btnChangePassword.Enabled = true;
                    this.btnExit.Enabled = true;
                    this.btnLogin.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Chưa xác định phân quyền người dùng");
            }
        }

        private void btnLogin_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.checkExists(typeof(frmLogin));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                f = new frmLogin();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult res = MessageBox.Show("Xác nhận đăng xuất tài khoản?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Program.LogOut();
                foreach (Form f in MdiChildren)
                {
                    f.Dispose();
                }
            }
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.HeThongPage.Visible = false;
            this.QuanLyPage.Visible = false;
            this.TraCuuPage.Visible = false;
            this.btnChangePassword.Enabled = false;
            this.btnExit.Enabled = false;
        }

        private void btnExit_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            DialogResult res = MessageBox.Show("Xác nhận đăng xuất tài khoản?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Program.LogOut();
                foreach (Form f in MdiChildren)
                {
                    f.Dispose();
                }
            }
        }

        private void btnSachTV_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.checkExists(typeof(frmSachTV));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                f = new frmSachTV();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnBaoTV_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.checkExists(typeof(frmBaoTV));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                f = new frmBaoTV();
                f.MdiParent = this;
                f.Show();
            }
        }


        private void barButtonItem11_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnBookBorrow_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.checkExists(typeof(frmSachDM));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                f = new frmSachDM();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnNewsBorrow_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.checkExists(typeof(frmBaoDM));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                f = new frmBaoDM();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnBorrowBookList_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.checkExists(typeof(frmDSSachMuon));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                f = new frmDSSachMuon();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnBorrowNewsList_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.checkExists(typeof(frmDSBaoMuon));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                f = new frmDSBaoMuon();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }

        private void btnReader_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.checkExists(typeof(frmDocGia));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                f = new frmDocGia();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnNews_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.checkExists(typeof(frmTuaBao));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                f = new frmTuaBao();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnNewsImport_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.checkExists(typeof(frmNhapBaoTV));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                f = new frmNhapBaoTV();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnBackup_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Program.group.Equals("DocGia")) return;
            if (MessageBox.Show("Bạn có muốn sao lưu dữ liệu","Xác nhận",MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                int excute = Program.ExecSqlNonQuery("EXEC SP_BACKUP");
                if (excute == 0)
                {
                    MessageBox.Show("Sao lưu thành công");
                }
                else MessageBox.Show("Sao lưu thất bại");
            }
        }

        private void btnRestore_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Program.group.Equals("DocGia")) return;
            if (MessageBox.Show("Bạn có muốn khôi phục dữ liệu lại trạng thái đã sao lưu trước đó", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Program.database = "master";
                if (Program.ConnectSql() == 1)
                {
                    int excute = Program.ExecSqlNonQuery("EXEC SP_RESTORE");
                    if (excute == 0)
                    {
                        MessageBox.Show("Khôi phục thành công");
                    }
                    else MessageBox.Show("Khôi phục thất bại");
                }
                Program.database = "ThuVien";
                if (Program.ConnectSql() != 1)
                {
                    MessageBox.Show("Lỗi kết nối lại database");
                }
            }
        }

        private void btnRestore2_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Program.group.Equals("DocGia")) return;
            if (MessageBox.Show("Bạn có muốn khôi phục dữ liệu lại trạng thái đã sao lưu vào chủ nhật tuần trước", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Program.database = "master";
                if (Program.ConnectSql() == 1)
                {
                    int excute = Program.ExecSqlNonQuery("EXEC SP_RESTORE_FULL");
                    if (excute == 0)
                    {
                        MessageBox.Show("Khôi phục thành công");
                    }
                    else MessageBox.Show("Khôi phục thất bại");
                }
                Program.database = "ThuVien";
                if (Program.ConnectSql() != 1)
                {
                    MessageBox.Show("Lỗi kết nối lại database");
                }
            }
        }

        private void btnBookImport_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.checkExists(typeof(frmQuanLySachXB));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                f = new frmQuanLySachXB();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnChangePassword_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.checkExists(typeof(frmDoiMatKhau));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                f = new frmDoiMatKhau();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnBook_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.checkExists(typeof(frmQuanLySach));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                f = new frmQuanLySach();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnTacGia_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.checkExists(typeof(frmTacGia));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                f = new frmTacGia();
                f.MdiParent = this;
                f.Show();
            }
        }
    }
}