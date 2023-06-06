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
    public partial class frmQuanLySach : Form
    {
        private String action = "None";
        private int position;
        public frmQuanLySach()
        {
            InitializeComponent();
        }

        private void frmQuanLySach_Load(object sender, EventArgs e)
        {
            this.thuVienDataSet.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'thuVienDataSet.TacGia' table. You can move, or remove it, as needed.
            this.tacGiaTableAdapter.Connection.ConnectionString = Program.connString;
            this.tacGiaTableAdapter.Fill(this.thuVienDataSet.TacGia);
            // TODO: This line of code loads data into the 'thuVienDataSet.TaiLieu_Sach' table. You can move, or remove it, as needed.
            this.taiLieu_SachTableAdapter.Connection.ConnectionString = Program.connString;
            this.taiLieu_SachTableAdapter.Fill(this.thuVienDataSet.TaiLieu_Sach);
            // TODO: This line of code loads data into the 'thuVienDataSet.ChiTietSach_TacGia' table. You can move, or remove it, as needed.
            this.chiTietSach_TacGiaTableAdapter.Connection.ConnectionString = Program.connString;
            this.chiTietSach_TacGiaTableAdapter.Fill(this.thuVienDataSet.ChiTietSach_TacGia);

        }

        private void taiLieu_SachGridControl_Click(object sender, EventArgs e)
        {

        }

        private void pnQuanLySach_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbTenTG.SelectedValue != null)
            {
                txtMaTG.Text = cmbTenTG.SelectedValue.ToString();  
            }
            else
            {
                txtMaTG.Text = "";
            }
        }

        private void barButtonThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }

        private void cmbTuaTG_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbTenTG.SelectedValue != null)
            {
                txtMaTG.Text = cmbTenTG.SelectedValue.ToString();
            }
            else
            {
                txtMaTG.Text = "";
            }
        }

        private void barButtonTaiLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.chiTietSach_TacGiaTableAdapter.Connection.ConnectionString = Program.connString;
            this.chiTietSach_TacGiaTableAdapter.Fill(this.thuVienDataSet.ChiTietSach_TacGia);

            this.taiLieu_SachTableAdapter.Connection.ConnectionString = Program.connString;
            this.taiLieu_SachTableAdapter.Fill(this.thuVienDataSet.TaiLieu_Sach);
        }

        private void barButtonThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String maSach = "";
            SqlDataReader reader = Program.ExecSqlDataReader("Select dbo.AUTO_MATL()");
            if (reader.Read())
            {
                maSach = reader.GetString(0);
                reader.Close();
            }
            else
            {
                MessageBox.Show("Lỗi lấy auto mã sách");
                reader.Close();
                return;
            }
            action = "Them";
            position = bdsTaiLieu_Sach.Position;
            bdsTaiLieu_Sach.AddNew();
            txtMaSach.Text = maSach;
            taiLieu_SachGridControl.Enabled = false;
            groupControlTG.Enabled = false;
            pnQuanLySach.Enabled = true;
            barDockControlTop.Enabled = false;
        }

        private void barButtonCapNhat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            action = "CapNhat";
            taiLieu_SachGridControl.Enabled = false;
            pnQuanLySach.Enabled = true;
            barDockControlTop.Enabled = false;
            groupControlTG.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(txtTuaSach.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng điền tựa sách", "Thông báo");
                return;
            }
            String sql;
            if (action.Equals("Them"))
            {
                sql = string.Format("INSERT INTO TaiLieu(TUA,LOAI) VALUES (N'{0}',N'Sách')", txtTuaSach.Text.Trim());
            }
            else if(action.Equals("CapNhat"))
            {
                sql = string.Format("UPDATE TaiLieu SET TUA = N'{0}' WHERE MA = '{1}'", txtTuaSach.Text.Trim(), txtMaSach.Text);
            }
            else
            {
                MessageBox.Show("Lỗi");
                return;
            }
            if (Program.ExecSqlNonQuery(sql)==0)
            {
                action = "None";
                bdsTaiLieu_Sach.EndEdit();
                bdsTaiLieu_Sach.ResetCurrentItem();
                barDockControlTop.Enabled = true;
                taiLieu_SachGridControl.Enabled = true;
                pnQuanLySach.Enabled = false;
                groupControlTG.Enabled = true;
                MessageBox.Show("Lưu thành công", "Thông báo");
            }
            else
            {
                MessageBox.Show("Lưu thất bại", "Thông báo");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            bdsTaiLieu_Sach.CancelEdit();
            if (action.Equals("Them"))
            {
                bdsTaiLieu_Sach.RemoveCurrent();
                bdsTaiLieu_Sach.Position = position;
            }
            else if (action.Equals("CapNhat"))
            {
                bdsTaiLieu_Sach.ResetCurrentItem();
            }
            barDockControlTop.Enabled = true;
            taiLieu_SachGridControl.Enabled = true;
            pnQuanLySach.Enabled = false;
            groupControlTG.Enabled = true;
            action = "None";
        }

        private void barButtonXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String sql = string.Format("SELECT COUNT(*) FROM SachXB WHERE MASACH = '{0}'", txtMaSach.Text);
            SqlDataReader reader = Program.ExecSqlDataReader(sql);
            try
            {
                reader.Read();
                if(reader.GetInt32(0) > 0)
                {
                    MessageBox.Show("Không thế xóa do đã có thông tin sách xuất bản", "Thông báo");
                    reader.Close();
                    return;
                }
                else
                {
                    reader.Close();
                }
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
                reader.Close();
                return;
            }

            if(bdsChiTietSach_TacGia.Count > 0)
            {
                MessageBox.Show("Không thể xóa do đã có liên kết sách và tác giả");
                return;
            }

            if(MessageBox.Show("Bạn chắc chắn muốn xóa sách này?","Xác nhận",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                sql = string.Format("DELETE FROM TaiLieu WHERE MA = '{0}'", txtMaSach.Text);
                if(Program.ExecSqlNonQuery(sql) == 0)
                {
                    bdsTaiLieu_Sach.RemoveCurrent();
                    MessageBox.Show("Xóa thành công", "Thông báo");
                }
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if(bdsChiTietSach_TacGia.Count == 0)
            {
                toolStripMenuItemXoa.Visible = false;
            }
            else
            {
                toolStripMenuItemXoa.Visible = true;
            }
        }

        private void toolStripMenuItemThem_Click(object sender, EventArgs e)
        {
            barDockControlTop.Enabled = false;
            taiLieu_SachGridControl.Enabled = false;
            chiTietSach_TacGiaDataGridView.Enabled = false;
            pnQuanLyTacGia.Enabled = true;
            bdsChiTietSach_TacGia.AddNew();
            cmbTenTG.SelectedIndex = 0;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if(txtMaTG.Text.Length == 0)
            {
                MessageBox.Show("Lỗi");
                return;
            }
            int count = 0;
            for(int i=0; i<chiTietSach_TacGiaDataGridView.Rows.Count - 1; i++)
            {
                DataGridViewRow row = chiTietSach_TacGiaDataGridView.Rows[i];
                if (row.Cells["dataGridViewTextBoxColumn2"].Value.ToString().Equals(txtMaTG.Text))
                {
                    MessageBox.Show("Sách đã có thông tin tác giả này" + count, "Thông báo");
                    return;
                }
            }

            String sql = string.Format("INSERT INTO ChiTietTacGia VALUES ('{0}','{1}')", txtMaSach.Text, txtMaTG.Text);
            if (Program.ExecSqlNonQuery(sql) == 0)
            {
                bdsChiTietSach_TacGia.EndEdit();
                chiTietSach_TacGiaTableAdapter.Connection.ConnectionString = Program.connString;
                chiTietSach_TacGiaTableAdapter.Fill(this.thuVienDataSet.ChiTietSach_TacGia);
                MessageBox.Show("Thêm thành công", "Thông báo");
                pnQuanLyTacGia.Enabled = false;
                chiTietSach_TacGiaDataGridView.Enabled = true;
                taiLieu_SachGridControl.Enabled = true;
                barDockControlTop.Enabled = true;
            }
        }

        private void btnHuyTG_Click(object sender, EventArgs e)
        {
            bdsChiTietSach_TacGia.CancelEdit();
            pnQuanLyTacGia.Enabled = false;
            chiTietSach_TacGiaDataGridView.Enabled = true;
            taiLieu_SachGridControl.Enabled = true;
            barDockControlTop.Enabled = true;
        }

        private void toolStripMenuItemXoa_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn chắc chắn muốn xóa?","Xác nhận",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                String sql = string.Format("DELETE FROM ChiTietTacGia WHERE MASACH = '{0}' AND MATG = '{1}'", txtMaSach.Text, txtMaTG.Text);
                if(Program.ExecSqlNonQuery(sql) == 0)
                {
                    bdsChiTietSach_TacGia.RemoveCurrent();
                    MessageBox.Show("Xóa thành công", "Thông báo");
                }
            }
        }
    }
}
