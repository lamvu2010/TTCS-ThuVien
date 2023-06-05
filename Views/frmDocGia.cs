using DevExpress.Utils.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThuVien.Views
{
    public partial class frmDocGia : Form
    {
        int newId()
        {
            int id = 1;
            int max = 1;
            List<int> list = new List<int>();
            foreach (DataRow row in ThuVienDataSet.DocGia.Rows)
            {
                int temp = Convert.ToInt32(row["SOTHE"]);
                list.Add(temp);
                if(temp > max) max = temp;
            }
            for(int i = 1; i <= max; i++)
            {
                id = i;
                if(list.Contains(id) == false)
                {
                    return id;
                }
            }
            return id + 1;
        }
        int trangthai = 0;
        public frmDocGia()
        {
            InitializeComponent();
        }

        private void frmDocGia_Load(object sender, EventArgs e)
        {
            ThuVienDataSet.EnforceConstraints = false;

            this.DocGiaTableAdapter.Connection.ConnectionString = Program.connString;
            this.DocGiaTableAdapter.Fill(this.ThuVienDataSet.DocGia);

            this.baoMuonTableAdapter.Connection.ConnectionString = Program.connString;
            this.baoMuonTableAdapter.Fill(this.ThuVienDataSet.BaoMuon);

            this.sachMuonTableAdapter.Connection.ConnectionString = Program.connString;
            this.sachMuonTableAdapter.Fill(this.ThuVienDataSet.SachMuon);

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            trangthai = 1;
            btnXoa.Enabled = btnSua.Enabled = false;
            groupBox1.Visible = true;
            groupBox1.Enabled = true;
            txtSoThe.Enabled = txtNghe.Enabled = txtTen.Enabled = cbboxGT.Enabled = true;
            label1.Visible = false;
            txtSoThe.Visible = false;
            txtlogin.Visible = true;
            lblogin.Visible = true;
            
            txtTen.DataBindings.Clear();
            txtSoThe.DataBindings.Clear();
            txtNghe.DataBindings.Clear();
            cbboxGT.DataBindings.Clear();
            txtTen.ResetText();
            txtSoThe.ResetText();
            txtNghe.ResetText();
        }

        //private void docGiaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        //{
        //    this.Validate();
        //    this.bdsDocGia.EndEdit();
        //    this.tableAdapterManager.UpdateAll(this.ThuVienDataSet);
        //}

        private void docGiaBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void sOTHELabel_Click(object sender, EventArgs e)
        {

        }

        private void pHAIRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tENTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (trangthai == 1)
            {
                //xác nhận thêm
                String ten = txtTen.Text;
                String nghe = txtNghe.Text;
                String gioitinh = cbboxGT.Text;
                String login = txtlogin.Text;
                String pass = "123";
                String group = "DocGia";
                String username = newId().ToString();
                if(ten.Length == 0||nghe.Length == 0||gioitinh.Length == 0||login.Length == 0)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                }
                else 
                {
                    ThuVienDataSet.DocGiaRow row;
                    row = ThuVienDataSet.DocGia.NewDocGiaRow();
                    row.SOTHE = newId();
                    row.TEN = ten;
                    row.NGHENGHIEP= nghe;
                    row.PHAI = gioitinh;
                    row.NGAYCAP = System.DateTime.Now;
                    try
                    {
                        int excute = Program.ExecSqlNonQuery("EXEC SP_TAOLOGIN "
                            + "'" + login + "' ," + "'" + pass + "' ," + "'" + username + "' ," + "'" + group + "'");
                        if (excute == 0)
                        {
                            MessageBox.Show("Thêm độc giả thành công"+"Tk:"+login+" Mk: 123");
                        }
                        else
                        {
                            MessageBox.Show("Lỗi tạo login cho độc giả");
                            return;
                        }
                        this.ThuVienDataSet.DocGia.AddDocGiaRow(row);
                        this.DocGiaTableAdapter.Update(this.ThuVienDataSet.DocGia);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Lỗi tạo độc giả, vui lòng kiểm tra lại thông tin");
                    }
                }
            }
            else if(trangthai == 2)
            {
                // xác nhận xóa
                if (MessageBox.Show("Bạn có chắc muốn xóa độc giả ?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    String username = txtSoThe.Text;
                    if (bdsSachMuon.Count > 0)
                    {
                        MessageBox.Show("Không thể xóa độc giả vì đã mượn sách !" + bdsSachMuon.Count.ToString());
                        return;
                    }
                    if (bdsBaoMuon.Count > 0)
                    {
                        MessageBox.Show("Không thể xóa độc giả vì đã mượn báo !");
                        return;
                    }
                    try
                    {
                        int id = int.Parse(((DataRowView)bdsDocGia[bdsDocGia.Position])["SOTHE"].ToString());
                        int excute = Program.ExecSqlNonQuery("EXEC SP_XOALOGIN "
                            + "'" + username + "'");
                        if (excute == 0)
                        {
                            MessageBox.Show("Xóa độc giả thành công");
                        }
                        bdsDocGia.RemoveCurrent();
                        this.DocGiaTableAdapter.Update(this.ThuVienDataSet.DocGia);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Xóa thất bại vì độc giả đã từng mượn sách hoặc báo");
                        this.DocGiaTableAdapter.Connection.ConnectionString = Program.connString;
                        this.DocGiaTableAdapter.Fill(this.ThuVienDataSet.DocGia);
                    }
                }
            }
            else if(trangthai ==3)
            {
                // xác nhận sửa
                String ten = txtTen.Text;
                String nghe = txtNghe.Text;
                String gioitinh = cbboxGT.Text;
                if (ten.Length == 0 || nghe.Length == 0 || gioitinh.Length == 0)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                }
                else
                {
                    DataRowView row = bdsDocGia.Current as DataRowView;
                    row.BeginEdit();
                    row["TEN"] = txtTen.Text;
                    row["NGHENGHIEP"] = txtNghe.Text;
                    row["PHAI"] = cbboxGT.Text;
                    row.EndEdit();
                    try
                    {
                        this.DocGiaTableAdapter.Update(this.ThuVienDataSet.DocGia);
                        MessageBox.Show("Sửa thành công");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi, vui lòng kiểm tra lại thông tin");
                    }
                }
            }
            else
            {
                if (MessageBox.Show("Bạn có muốn reset mật khẩu của tài khoản?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    try
                    {
                        int excute = Program.ExecSqlNonQuery("EXEC SP_RESETMKLOGIN " + "'" + txtSoThe.Text+"'");
                        if (excute == 0)
                        {
                            MessageBox.Show("Mk đã được reset '123'");
                            return;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi");
                    }
                }
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            trangthai = 2;
            btnThem.Enabled = btnSua.Enabled = false;
            groupBox1.Enabled=true;
            groupBox1.Visible = true;
            label1.Visible = true;
            txtSoThe.Visible = true;
            txtlogin.Visible = false;
            lblogin.Visible = false;
            txtSoThe.Enabled = txtNghe.Enabled = txtTen.Enabled = cbboxGT.Enabled = false;
            txtTen.DataBindings.Clear();
            txtSoThe.DataBindings.Clear();
            txtNghe.DataBindings.Clear();
            cbboxGT.DataBindings.Clear();
            txtTen.DataBindings.Add("Text", bdsDocGia, "TEN");
            txtSoThe.DataBindings.Add("Text", bdsDocGia, "SOTHE");
            txtNghe.DataBindings.Add("Text", bdsDocGia, "NGHENGHIEP");
            cbboxGT.DataBindings.Add("Text", bdsDocGia, "PHAI");
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            trangthai = 0;
            groupBox1.Visible = false;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = true;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            trangthai = 3;
            btnThem.Enabled = btnXoa.Enabled = false;
            groupBox1.Enabled = true;
            groupBox1.Visible = true;
            label1.Visible = true;
            txtSoThe.Visible = true;
            txtSoThe.Enabled = txtNghe.Enabled = txtTen.Enabled = cbboxGT.Enabled = true;
            txtSoThe.ReadOnly = true;
            txtlogin.Visible = false;
            lblogin.Visible = false;
            txtTen.DataBindings.Clear();
            txtSoThe.DataBindings.Clear();
            txtNghe.DataBindings.Clear();
            cbboxGT.DataBindings.Clear();
            txtTen.DataBindings.Add("Text", bdsDocGia, "TEN");
            txtSoThe.DataBindings.Add("Text", bdsDocGia, "SOTHE");
            txtNghe.DataBindings.Add("Text", bdsDocGia, "NGHENGHIEP");
            cbboxGT.DataBindings.Add("Text", bdsDocGia, "PHAI");
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            trangthai = 4;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = false;
            txtlogin.Visible = txtSoThe.Enabled = txtTen.Enabled = txtNghe.Enabled = cbboxGT.Enabled = false;
            groupBox1.Visible = true;
            groupBox1.Enabled = true;
            btnXacnhan.Enabled = btnHuy.Enabled= true;

            txtTen.DataBindings.Add("Text", bdsDocGia, "TEN");
            txtSoThe.DataBindings.Add("Text", bdsDocGia, "SOTHE");
            txtNghe.DataBindings.Add("Text", bdsDocGia, "NGHENGHIEP");
            cbboxGT.DataBindings.Add("Text", bdsDocGia, "PHAI");
        }
    }
}
