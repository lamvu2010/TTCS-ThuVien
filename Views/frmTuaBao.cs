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
    public partial class frmTuaBao : Form
    {
        int trangthai = 0;
        public frmTuaBao()
        {
            InitializeComponent();
        }
        private void frmTuaBao_Load(object sender, EventArgs e)
        {
            ThuVienDataSet.EnforceConstraints = false;

            this.TaiLieuTableAdapter.Connection.ConnectionString = Program.connString;
            this.TaiLieuTableAdapter.Fill(this.ThuVienDataSet.TaiLieu);

            this.BaoPHTableAdapter.Connection.ConnectionString = Program.connString;
            this.BaoPHTableAdapter.Fill(this.ThuVienDataSet.BaoPH);

            this.BaoTVTableAdapter.Connection.ConnectionString = Program.connString;
            this.BaoTVTableAdapter.Fill(this.ThuVienDataSet.BaoTV);
            
            this.VIEW_BAOPHTableAdapter.Connection.ConnectionString = Program.connString;
            this.VIEW_BAOPHTableAdapter.Fill(this.ThuVienDataSet.VIEW_BAOPH);            

        }

        private void baoPHGridControl_Click(object sender, EventArgs e)
        {

        }

        private void vIEW_BAOPHGridControl_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            groupBox1.Visible = groupBox1.Enabled = true;
            txtTua.Enabled = txtNamPH.Enabled = txtDinhKy.Enabled = txtNSX.Enabled = true;
            txtMaBao.Enabled = btnXoa.Enabled = btnSua.Enabled = false;
            txtMaBao.DataBindings.Clear();
            txtMaBao.Clear();
            SqlDataReader reader = Program.ExecSqlDataReader("Select dbo.AUTO_MATL()");
            if (reader.Read())
            {
                txtMaBao.Text = reader.GetString(0);
                reader.Close();
            }
            txtTua.DataBindings.Clear();
            txtNamPH.DataBindings.Clear();
            txtDinhKy.DataBindings.Clear();
            txtNSX.DataBindings.Clear();
            txtTua.Clear();
            txtNamPH.Clear();
            txtDinhKy.Clear();
            txtNSX.Clear();
            trangthai = 1;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            groupBox1.Visible = groupBox1.Enabled = true;
            txtMaBao.Enabled = txtTua.Enabled = txtNamPH.Enabled = txtDinhKy.Enabled = txtNSX.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = false;
            trangthai = 2;
            txtMaBao.DataBindings.Clear();
            txtTua.DataBindings.Clear();
            txtNamPH.DataBindings.Clear();
            txtDinhKy.DataBindings.Clear();
            txtNSX.DataBindings.Clear();
            txtMaBao.DataBindings.Add("Text", bdsVIEW_BAOPH, "MABAO");
            txtTua.DataBindings.Add("Text", bdsVIEW_BAOPH, "TUA");
            txtDinhKy.DataBindings.Add("Text", bdsVIEW_BAOPH, "DINHKY");
            txtNamPH.DataBindings.Add("Text", bdsVIEW_BAOPH, "NAMPH");
            txtNSX.DataBindings.Add("Text", bdsVIEW_BAOPH, "NSX");
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            groupBox1.Visible = groupBox1.Enabled = true;
            txtTua.Enabled = txtNamPH.Enabled = txtDinhKy.Enabled = txtNSX.Enabled = true;
            txtMaBao.Enabled = false;
            txtMaBao.DataBindings.Clear();
            txtTua.DataBindings.Clear();
            txtNamPH.DataBindings.Clear();
            txtDinhKy.DataBindings.Clear();
            txtNSX.DataBindings.Clear();
            txtMaBao.DataBindings.Add("Text", bdsVIEW_BAOPH, "MABAO");
            txtTua.DataBindings.Add("Text", bdsVIEW_BAOPH, "TUA");
            txtDinhKy.DataBindings.Add("Text", bdsVIEW_BAOPH, "DINHKY");
            txtNamPH.DataBindings.Add("Text", bdsVIEW_BAOPH, "NAMPH");
            txtNSX.DataBindings.Add("Text", bdsVIEW_BAOPH, "NSX");
            trangthai = 3;
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = true;
            trangthai = 0;
        }

        private void btnXacnhan_Click(object sender, EventArgs e)
        {
            if (trangthai == 1)
            {
                String ma = txtMaBao.Text;
                String tua = txtTua.Text;
                String namPH = txtNamPH.Text;
                String nsX = txtNSX.Text;
                String dinhKy = txtDinhKy.Text;
                if( ma.Length == 0 || tua.Length == 0 || namPH.Length == 0 || nsX.Length == 0 || dinhKy.Length == 0)
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin báo!");
                    return;
                }
                ThuVienDataSet.BaoPHRow rowBao;
                ThuVienDataSet.TaiLieuRow rowTL;
                rowBao = ThuVienDataSet.BaoPH.NewBaoPHRow();
                rowTL = ThuVienDataSet.TaiLieu.NewTaiLieuRow();
                rowBao.MABAO = ma;
                rowBao.NAMPH = namPH;
                rowBao.NSX = nsX;
                rowBao.DINHKY = dinhKy;
                rowTL.MA = ma;
                rowTL.TUA= tua;
                rowTL.LOAI = "Báo";
                try
                {
                    this.ThuVienDataSet.TaiLieu.AddTaiLieuRow(rowTL);
                    this.ThuVienDataSet.BaoPH.AddBaoPHRow(rowBao);
                    TaiLieuTableAdapter.Update(this.ThuVienDataSet.TaiLieu);
                    BaoPHTableAdapter.Update(this.ThuVienDataSet.BaoPH);
                    MessageBox.Show("Thêm thành công!");
                    this.VIEW_BAOPHTableAdapter.Fill(this.ThuVienDataSet.VIEW_BAOPH);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                SqlDataReader reader = Program.ExecSqlDataReader("Select dbo.AUTO_MATL()");
                if (reader.Read())
                {
                    txtMaBao.Text = reader.GetString(0);
                    reader.Close();
                }
            }
            else if (trangthai == 2)
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa tựa báo ?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    if(bdsBaoTV.Count > 0)
                    {
                        MessageBox.Show("Báo đã được nhập về thư viện, không thể xóa!");
                        return;
                    }
                    else
                    {
                        String ma = txtMaBao.Text;
                        try
                        {
                            bdsBaoPH.RemoveAt(bdsBaoPH.Find("MABAO",ma));
                            bdsTaiLieu.RemoveAt(bdsTaiLieu.Find("MA",ma));

                            bdsVIEW_BAOPH.RemoveCurrent();

                            this.BaoPHTableAdapter.Update(this.ThuVienDataSet.BaoPH);
                            this.TaiLieuTableAdapter.Update(this.ThuVienDataSet.TaiLieu);
                            MessageBox.Show("Xóa thành công!");
                            this.VIEW_BAOPHTableAdapter.Fill(this.ThuVienDataSet.VIEW_BAOPH);
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            return;
                        }
                    }
                }
            }
            else if(trangthai == 3)
            {
                String ma = txtMaBao.Text;
                String tua = txtTua.Text;
                String namPH = txtNamPH.Text;
                String nsX = txtNSX.Text;
                String dinhKy = txtDinhKy.Text;
                if (ma.Length == 0 || tua.Length == 0 || namPH.Length == 0 || nsX.Length == 0 || dinhKy.Length == 0)
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin báo!");
                    return;
                }
                else
                {
                    DataRowView view = bdsVIEW_BAOPH.Current as DataRowView;
                    DataRowView bao = bdsBaoPH[bdsBaoPH.Find("MABAO", ma)] as DataRowView;
                    DataRowView tailieu = bdsTaiLieu[bdsTaiLieu.Find("MA",ma)] as DataRowView;
                    bao.BeginEdit();
                    bao["NAMPH"] = namPH;
                    bao["NSX"] = nsX;
                    bao["dinhKy"] = dinhKy;
                    bao.EndEdit();
                    tailieu.BeginEdit();
                    tailieu["TUA"] = tua;
                    tailieu.EndEdit();
                    try
                    {
                        this.BaoPHTableAdapter.Update(this.ThuVienDataSet.BaoPH);
                        this.TaiLieuTableAdapter.Update(this.ThuVienDataSet.TaiLieu);
                        MessageBox.Show("Sửa thành công!");
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }
                }

            }
        }
    }
}
