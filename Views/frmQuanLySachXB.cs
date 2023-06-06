using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThuVien.Views
{
    public partial class frmQuanLySachXB : Form
    {
        private int position;
        private string action = "None";

        public frmQuanLySachXB()
        {
            InitializeComponent();
        }

        private void frmQuanLySachXB_Load(object sender, EventArgs e)
        {
            this.thuVienDataSet.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'thuVienDataSet.SachMuon' table. You can move, or remove it, as needed.
            this.sachMuonTableAdapter.Connection.ConnectionString = Program.connPublisherString;
            this.sachMuonTableAdapter.Fill(this.thuVienDataSet.SachMuon);
            // TODO: This line of code loads data into the 'thuVienDataSet.SachTV' table. You can move, or remove it, as needed.
            this.sachTVTableAdapter.Connection.ConnectionString = Program.connPublisherString;
            this.sachTVTableAdapter.Fill(this.thuVienDataSet.SachTV);
            // TODO: This line of code loads data into the 'thuVienDataSet.TaiLieu_Sach' table. You can move, or remove it, as needed.
            this.taiLieu_SachTableAdapter.Connection.ConnectionString = Program.connPublisherString;
            this.taiLieu_SachTableAdapter.Fill(this.thuVienDataSet.TaiLieu_Sach);
            // TODO: This line of code loads data into the 'thuVienDataSet.SachXB' table. You can move, or remove it, as needed.
            this.sachXBTableAdapter.Connection.ConnectionString = Program.connPublisherString;
            this.sachXBTableAdapter.Fill(this.thuVienDataSet.SachXB);

        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if(cmbTuaSach.SelectedValue != null)
                {
                    txtMaSach.Text = cmbTuaSach.SelectedValue.ToString();
                    String sql = string.Format("Select LAN FROM SACHXB WHERE MASACH = '{0}'", txtMaSach.Text);
                    SqlDataReader reader = Program.ExecSqlDataReader(sql);
                    int val = 1;
                    while (reader.Read())
                    {
                        if (reader.GetInt32(0) >= val)
                        {
                            val = reader.GetInt32(0) + 1;
                        }
                    }
                    txtLan.Value = val;
                    reader.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Lỗi");
            }
        }


        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            action = "Them";
            String masxb = "";
            SqlDataReader reader = Program.ExecSqlDataReader("Select dbo.AUTO_MASXB()");
            if (reader.Read())
            {
                masxb = reader.GetString(0);
                reader.Close();
            }
            else
            {
                MessageBox.Show("Lỗi lấy auto mã sách xuất bản");
                reader.Close();
                action = "None";
                return;
            }
            panelControl.Enabled = true;
            sachXBGridControl.Enabled = panelSachTV.Enabled = false;
            btnThem.Enabled = btnXoa.Enabled = btnCapNhat.Enabled = btnReload.Enabled = btnThoat.Enabled = false;
            btnUndo.Enabled = btnLuu.Enabled = true;
            position = bdsSachXB.Position;
            bdsSachXB.AddNew();
            txtMaSachXB.Text = masxb;
            cbCD.Checked = false;
            cmbTuaSach.SelectedIndex = 0;
            txtLan.Value = 1;
            txtSLNhap.Value = 1;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(bdsSachTV.Count > 0)
            {
                MessageBox.Show("Không thể xóa vì đã có thông tin sách thư viện","Thông báo");
                return;
            }
            if(MessageBox.Show("Bạn chắc chắn muốn xóa sách này?","Xác nhận",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                String masachxb = txtMaSachXB.Text;
                try
                {
                    bdsSachXB.RemoveCurrent();
                    sachXBTableAdapter.Connection.ConnectionString = Program.connPublisherString;
                    this.sachXBTableAdapter.Update(this.thuVienDataSet.SachXB);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Lỗi xóa\n" + ex.Message,"Error");
                    this.sachXBTableAdapter.Fill(this.thuVienDataSet.SachXB);
                    bdsSachXB.Position = bdsSachXB.Find("MASACHXB", masachxb);
                }
            }
        }

        private void btnCapNhat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.action = "CapNhat";
            this.position = bdsSachXB.Position;
            sachXBGridControl.Enabled = panelSachTV.Enabled = false;
            panelControl.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnCapNhat.Enabled = btnReload.Enabled = btnThoat.Enabled = false;
            btnUndo.Enabled = btnLuu.Enabled = true;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                sachXBTableAdapter.Connection.ConnectionString = Program.connPublisherString;
                sachXBTableAdapter.Fill(this.thuVienDataSet.SachXB);
                sachTVTableAdapter.Connection.ConnectionString = Program.connPublisherString;
                sachTVTableAdapter.Fill(this.thuVienDataSet.SachTV);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi reload: " + ex.Message, "Error", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            action = "None";
            bdsSachXB.CancelEdit();
            sachXBTableAdapter.Connection.ConnectionString = Program.connPublisherString;
            sachXBTableAdapter.Fill(this.thuVienDataSet.SachXB);
            sachTVTableAdapter.Connection.ConnectionString = Program.connPublisherString;
            sachTVTableAdapter.Fill(this.thuVienDataSet.SachTV);
            bdsSachXB.Position = position;
            panelControl.Enabled = false;
            sachXBGridControl.Enabled = panelSachTV.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnCapNhat.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnUndo.Enabled = btnLuu.Enabled = false;
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Check validation
            if(txtNhaXB.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng điền tên nhà xuất bản","Lỗi");
                return;
            }
            if(txtGia.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng điền giá sách","Lỗi");
                return;
            }
            if(!Regex.IsMatch(txtNam.Text, @"^\d{4}$"))
            {
                MessageBox.Show("Vui lòng kiểm tra lại năm xuất bản","Lỗi");
                return;
            }
            if (action.Equals("Them"))
            {
                String sql = string.Format("Select LAN FROM SACHXB WHERE MASACH = '{0}'", txtMaSach.Text);
                SqlDataReader reader = Program.ExecSqlDataReader(sql);
                while (reader.Read())
                {
                    if(reader.GetInt32(0) == txtLan.Value)
                    {
                        MessageBox.Show("Bạn đã nhập số xuất bản của sách này","Thông báo");
                        reader.Close();
                        return;
                   }
                }
                reader.Close();
            }
            if(txtSLNhap.Value < bdsSachTV.Count)
            {
                MessageBox.Show("Số lượng nhập đang nhỏ hơn số lượng sách thư viện","Lỗi");
                return;
            }
            try
            {
                bdsSachXB.EndEdit();
                bdsSachXB.ResetCurrentItem();
                this.sachXBTableAdapter.Connection.ConnectionString = Program.connPublisherString;
                this.sachXBTableAdapter.Update(this.thuVienDataSet.SachXB);
                MessageBox.Show("Lưu thành công","Thông báo");
                action = "None";
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi\n" + ex.Message);
                return;
            }
            sachXBGridControl.Enabled = panelSachTV.Enabled = true;
            panelControl.Enabled = false;
            btnThem.Enabled = btnXoa.Enabled = btnCapNhat.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnUndo.Enabled = btnLuu.Enabled = false;
        }

        private void capNhatToolStripItem_Click(object sender, EventArgs e)
        {
                try
                {
                    int id = int.Parse(((DataRowView)bdsSachTV[bdsSachTV.Position])["ID_SACH"].ToString());
                    String str = Interaction.InputBox("Nhập trạng thái:", "Cập nhật","").Trim();
                    if(str == null)
                    {
                        return;
                    }
                    else if(MessageBox.Show("Bạn chắc chắn muốn cập nhật?","Xác nhận",MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        return; 
                    }
                    String sql = string.Format("UPDATE SachTV SET TINHTRANG = N'{0}' WHERE ID_SACH = {1}", str ,id);
                    if (Program.ExecSqlNonQuery(sql) != 0)
                    {
                        return;
                    }
                    MessageBox.Show("Cập nhật thành công");
                    sachTVTableAdapter.Connection.ConnectionString = Program.connPublisherString;
                    sachTVTableAdapter.Fill(this.thuVienDataSet.SachTV);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Lỗi\n" + ex.Message);
                }
        }


        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            themToolStripMenuItem.Visible = true;
            themNhanhToolStripMenuItem.Visible = true;

            if (bdsSachTV.Count == 0)
            {
                themToolStripMenuItem.Visible = true;
                themNhanhToolStripMenuItem.Visible = true;
                capNhatToolStripItem.Visible = false;
                xoaToolStripMenuItem.Visible = false;
            }
            else if(bdsSachTV.Count == txtSLNhap.Value)
            {
                themNhanhToolStripMenuItem.Visible = false;
                themToolStripMenuItem.Visible = false;
                capNhatToolStripItem.Visible = true;
                xoaToolStripMenuItem.Visible = true;
            }
            else 
            {
                themToolStripMenuItem.Visible = true;
                themNhanhToolStripMenuItem.Visible = true;
                capNhatToolStripItem.Visible = true;
                xoaToolStripMenuItem.Visible = true;
            }
        }

        private void themToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String sql = string.Format("Select MAX(STT) FROM SachTV WHERE MASACHXB = '{0}'", txtMaSachXB.Text);
            SqlDataReader reader = Program.ExecSqlDataReader(sql);
            int stt = 1;
            if (reader.Read())
            {
                try
                {
                    int tmp = reader.GetInt32(0) + 1;
                    stt = tmp;
                }
                catch(Exception ex)
                {
                    stt = 1;
                }
            }
            reader.Close();
            sql = string.Format("INSERT INTO SachTV (STT,MASACHXB,TINHTRANG) VALUES({0}, '{1}', N'{2}')", stt, txtMaSachXB.Text, "Tốt");
            try
            {
                Program.ExecSqlNonQuery(sql);
                sachTVTableAdapter.Connection.ConnectionString = Program.connPublisherString;
                sachTVTableAdapter.Fill(this.thuVienDataSet.SachTV);
                bdsSachTV.MoveLast();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Lỗi");
            }
        }

        private void xoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(bdsSachMuon.Count > 0)
            {
                MessageBox.Show("Không thể xóa do đã có thông tin mượn");
                return;
            }
            int stt = int.Parse (((DataRowView)bdsSachTV[bdsSachTV.Position])["STT"].ToString());
            try
            {
                bdsSachTV.RemoveCurrent();
                sachTVTableAdapter.Connection.ConnectionString = Program.connPublisherString;
                this.sachTVTableAdapter.Update(this.thuVienDataSet.SachTV);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi\n" + ex.Message);
                this.sachTVTableAdapter.Fill(this.thuVienDataSet.SachTV);
                bdsSachTV.Position = bdsSachTV.Find("STT", stt);
            }
        }

        private void themNhanhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int num = ((int)txtSLNhap.Value - bdsSachTV.Count);
            String masxb = txtMaSachXB.Text;
            try
            {
                String sql = string.Format("EXEC SP_THEMSACHTV {0},'{1}'", num, masxb);
                if (Program.ExecSqlNonQuery(sql) == 0)
                {
                    sachTVTableAdapter.Connection.ConnectionString = Program.connPublisherString;
                    sachTVTableAdapter.Fill(this.thuVienDataSet.SachTV);
                    MessageBox.Show("Thêm thành công");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
