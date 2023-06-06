using DevExpress.XtraEditors;
using DevExpress.XtraExport.Helpers;
using DevExpress.XtraSpellChecker.Parser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThuVien.ThuVienDataSetTableAdapters;

namespace ThuVien.Views
{
    public partial class frmTacGia : Form
    {
        public frmTacGia()
        {
            InitializeComponent();
        }
        private int position;
        private void tacGiaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsTacGia.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ThuVienDataSet);

        }

        private void frmTacGia_Load(object sender, EventArgs e)
        {
            this.ThuVienDataSet.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'thuVienDataSet.ChiTietTacGia' table. You can move, or remove it, as needed.
            this.ChiTietTacGiaTableAdapter.Connection.ConnectionString = Program.connString;
            this.ChiTietTacGiaTableAdapter.Fill(this.ThuVienDataSet.ChiTietTacGia);
            // TODO: This line of code loads data into the 'thuVienDataSet.TacGia' table. You can move, or remove it, as needed.
            this.TacGiaTableAdapter.Connection.ConnectionString=Program.connString;
            this.TacGiaTableAdapter.Fill(this.ThuVienDataSet.TacGia);
            panelControl1.Enabled = false;
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            btnRefresh.Enabled = true;
            btnUndo.Enabled = false;
            btnExit.Enabled = true;
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // TODO: This line of code loads data into the 'thuVienDataSet.ChiTietTacGia' table. You can move, or remove it, as needed.
            this.ChiTietTacGiaTableAdapter.Connection.ConnectionString = Program.connString;
            this.ChiTietTacGiaTableAdapter.Fill(this.ThuVienDataSet.ChiTietTacGia);
            // TODO: This line of code loads data into the 'thuVienDataSet.TacGia' table. You can move, or remove it, as needed.
            this.TacGiaTableAdapter.Connection.ConnectionString = Program.connString;
            this.TacGiaTableAdapter.Fill(this.ThuVienDataSet.TacGia);
            
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            position = bdsTacGia.Position;
            bdsTacGia.AddNew();
            panelControl1.Enabled = true;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnRefresh.Enabled = false;
            btnUndo.Enabled = true;
            btnExit.Enabled = true;
            btnAdd.Enabled = false;
            grid.Enabled = false;
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsTacGia.CancelEdit();
            this.TacGiaTableAdapter.Connection.ConnectionString = Program.connString;
            this.TacGiaTableAdapter.Fill(this.ThuVienDataSet.TacGia);
            bdsTacGia.Position = position;
            panelControl1.Enabled = false;
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            btnRefresh.Enabled = true;
            btnUndo.Enabled = false;
            btnExit.Enabled = true;
            grid.Enabled = true;
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsCT_TG.Count > 0)
            {
                MessageBox.Show("Không thể xóa vì đã có thông tin trong sách", "Thông báo");
                return;
            }
            if (MessageBox.Show("Bạn chắc chắn muốn xóa tác giả?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                String ma = ((DataRowView)bdsTacGia[bdsTacGia.Position])["MATG"].ToString();
                try
                {
                    bdsTacGia.RemoveCurrent();
                    TacGiaTableAdapter.Connection.ConnectionString = Program.connPublisherString;
                    TacGiaTableAdapter.Update(this.ThuVienDataSet.TacGia);
                    MessageBox.Show("Xóa thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa\n" + ex.Message, "Error");
                    TacGiaTableAdapter.Fill(this.ThuVienDataSet.TacGia);
                    bdsTacGia.Position = bdsTacGia.Find("MATG", ma);
                }
            }
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            position = bdsTacGia.Position;
            panelControl1.Enabled = true;
            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnRefresh.Enabled = false;
            btnUndo.Enabled = true;
            btnExit.Enabled = true;
            grid.Enabled = false;
        }
        bool IsBirthYear(string input)
        {
            int year;
            bool isInteger = int.TryParse(input, out year);
            if (!isInteger)
            {
                return false;
            }
            bool isFourDigits = year > 0 && year < 10000;
            if (!isFourDigits)
            {
                return false;
            }
            return true;
        }
        private void btnConfirm_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtTEN.Text.Trim()=="")
            {
                MessageBox.Show("Mời nhập tên");
                return;
            }
            if (txtNAMSINH.Text.Trim() == "")
            {
                MessageBox.Show("Mời nhập năm sinh");
                return;
            }
            if (!IsBirthYear(txtNAMSINH.Text.Trim())) {
                MessageBox.Show("Không đúng dạng năm sinh 4 chữ số");
                return;
            }
            try
            {
                bdsTacGia.EndEdit();
                bdsTacGia.ResetCurrentItem();
                this.TacGiaTableAdapter.Connection.ConnectionString = Program.connPublisherString;
                this.TacGiaTableAdapter.Update(this.ThuVienDataSet.TacGia);
                
                MessageBox.Show("Lưu thành công", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi\n" + ex.Message);
                return;
            }
            panelControl1.Enabled = false;
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            btnRefresh.Enabled = true;
            btnUndo.Enabled = false;
            btnExit.Enabled = true;
            grid.Enabled = true;
        }
    }
}
