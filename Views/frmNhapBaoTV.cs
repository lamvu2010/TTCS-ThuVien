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
    public partial class frmNhapBaoTV : Form
    {
        public frmNhapBaoTV()
        {
            InitializeComponent();
        }

        private void baoTVBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsBaoTV.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ThuVienDataSet);

        }

        private void frmNhapBaoTV_Load(object sender, EventArgs e)
        {
            this.ThuVienDataSet.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'ThuVienDataSet.BaoMuon' table. You can move, or remove it, as needed.
            this.BaoMuonTableAdapter.Fill(this.ThuVienDataSet.BaoMuon);
            // TODO: This line of code loads data into the 'ThuVienDataSet.BaoTV' table. You can move, or remove it, as needed.
            this.BaoTVTableAdapter.Fill(this.ThuVienDataSet.BaoTV);

        }

        private void lbNSX_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}
