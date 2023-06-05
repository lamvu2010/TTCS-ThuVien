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
    public partial class frmSachDM : Form
    {
        public frmSachDM()
        {
            InitializeComponent();
        }

        private void frmSachDM_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'thuVienDataSet.VIEW_SACH_DANGMUON' table. You can move, or remove it, as needed.
            this.VIEW_SACH_DANGMUONTableAdapter.Connection.ConnectionString = Program.connString;
            this.VIEW_SACH_DANGMUONTableAdapter.Fill(this.ThuVienDataSet.VIEW_SACH_DANGMUON);

        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.VIEW_SACH_DANGMUONTableAdapter.Connection.ConnectionString = Program.connString;
            this.VIEW_SACH_DANGMUONTableAdapter.Fill(this.ThuVienDataSet.VIEW_SACH_DANGMUON);
        }

        private void btnExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }

        private void vIEW_SACH_DANGMUONGridControl_Click(object sender, EventArgs e)
        {

        }
    }
}
