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
    public partial class frmTuaSach : Form
    {
        private int position;
        private String action;
        public frmTuaSach()
        {
            InitializeComponent();
        }

        private void frmTuaSach_Load(object sender, EventArgs e)
        {
            this.thuVienDataSet.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'thuVienDataSet.TaiLieu_Sach' table. You can move, or remove it, as needed.
            this.taiLieu_SachTableAdapter.Connection.ConnectionString = Program.connString;
            this.taiLieu_SachTableAdapter.Fill(this.thuVienDataSet.TaiLieu_Sach);

            panelControl1.Enabled = false;
            btnHuy.Enabled = btnLuu.Enabled = false;
            btnThem.Enabled = btnCapNhat.Enabled = btnXoa.Enabled = btnTaiLai.Enabled = btnThoat.Enabled = true;
            action = "None";
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }

        private void btnTaiLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.taiLieu_SachTableAdapter.Connection.ConnectionString = Program.connString;
            this.taiLieu_SachTableAdapter.Fill(this.thuVienDataSet.TaiLieu_Sach);
            bdsTaiLieu_Sach.MoveFirst();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SqlDataReader reader = Program.ExecSqlDataReader("Select dbo.AUTO_MATL()");
            String ma = "";
            if (reader.Read())
            {
                ma = reader.GetString(0);
                reader.Close();
            }
            else
            {
                MessageBox.Show("Lỗi lấy auto mã sách xuất bản");
                reader.Close();
                return;
            }
            bdsTaiLieu_Sach.AddNew();
            txtMa.Text = ma;
            position = bdsTaiLieu_Sach.Position;
            taiLieu_SachGridControl.Enabled = false;
            panelControl1.Enabled = true;
            btnHuy.Enabled = btnLuu.Enabled = true;
            btnThem.Enabled = btnCapNhat.Enabled = btnXoa.Enabled = btnTaiLai.Enabled = btnThoat.Enabled = false;
            action = "Them";
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(txtTua.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng đặt tên sách", "Thông báo");
                return;
            }
            try
            {
                String sql = "";
                if (action.Equals("Them"))
                {
                    sql = string.Format("INSERT INTO TaiLieu(TUA, LOAI) VALUES (N'{0}',N'Sách')", txtTua.Text);
                }
                else if (action.Equals("CapNhat"))
                {
                    sql = string.Format("UPDATE TaiLieu SET TUA = N'{0}' WHERE MA = '{1}'", txtTua.Text, txtMa.Text);
                }
                else
                {
                    MessageBox.Show("Lỗi");
                    return;
                }
                if (Program.ExecSqlNonQuery(sql) == 0)
                {
                    MessageBox.Show("Lưu thành công", "Thông báo");
                    panelControl1.Enabled = false;
                    taiLieu_SachGridControl.Enabled = true;
                    btnHuy.Enabled = btnLuu.Enabled = false;
                    btnThem.Enabled = btnCapNhat.Enabled = btnXoa.Enabled = btnTaiLai.Enabled = btnThoat.Enabled = true;
                    this.taiLieu_SachTableAdapter.Connection.ConnectionString = Program.connString;
                    this.taiLieu_SachTableAdapter.Fill(this.thuVienDataSet.TaiLieu_Sach);
                    if (action.Equals("Them")) bdsTaiLieu_Sach.MoveLast();
                    else bdsTaiLieu_Sach.Position = position;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
                return;
            }
            action = "None";
        }

        private void btnCapNhat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            action = "CapNhat";
            taiLieu_SachGridControl.Enabled = false;
            panelControl1.Enabled = true;
            btnHuy.Enabled = btnLuu.Enabled = true;
            btnThem.Enabled = btnCapNhat.Enabled = btnXoa.Enabled = btnTaiLai.Enabled = btnThoat.Enabled = false;
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsTaiLieu_Sach.CancelEdit();
            this.taiLieu_SachTableAdapter.Connection.ConnectionString = Program.connString;
            this.taiLieu_SachTableAdapter.Fill(this.thuVienDataSet.TaiLieu_Sach);
            bdsTaiLieu_Sach.Position = position;
            taiLieu_SachGridControl.Enabled = true;
            panelControl1.Enabled = false;
            btnHuy.Enabled = btnLuu.Enabled = false;
            btnThem.Enabled = btnCapNhat.Enabled = btnXoa.Enabled = btnTaiLai.Enabled = btnThoat.Enabled = true;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String sql = string.Format("SELECT COUNT(*) FROM SachXB WHERE MASACH = '{0}'", txtMa.Text);
            SqlDataReader reader = Program.ExecSqlDataReader(sql);
            try
            {
                reader.Read();
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
                reader.Close();
                return;
            }
            if(reader.GetInt32(0) > 0)
            {
                MessageBox.Show("Không thể xóa sách này", "Thông báo");
                reader.Close();
                return;
            }
            else
            {
                reader.Close();
            }
            if(MessageBox.Show("Bạn chắc chắn muốn xóa sách này?","Xác nhận",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                sql = string.Format("DELETE FROM TaiLieu WHERE MA = '{0}'", txtMa.Text);
                if(Program.ExecSqlNonQuery(sql) == 0)
                {
                    MessageBox.Show("Xóa thành công");
                    bdsTaiLieu_Sach.RemoveCurrent();
                }
                else
                {
                    return;
                }
            }
        }

        private void btnTaiLai_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.taiLieu_SachTableAdapter.Connection.ConnectionString = Program.connString;
            this.taiLieu_SachTableAdapter.Fill(this.thuVienDataSet.TaiLieu_Sach);
        }

        private void btnThoat_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }
    }
}
