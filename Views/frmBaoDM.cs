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
    public partial class frmBaoDM : Form
    {
        public frmBaoDM()
        {
            InitializeComponent();
        }

        private void frmBaoDM_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'thuVienDataSet.VIEW_BAO_DANGMUON' table. You can move, or remove it, as needed.
            this.VIEW_BAO_DANGMUONTableAdapter.Connection.ConnectionString = Program.connString;
            this.VIEW_BAO_DANGMUONTableAdapter.Fill(this.ThuVienDataSet.VIEW_BAO_DANGMUON);

        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.VIEW_BAO_DANGMUONTableAdapter.Connection.ConnectionString = Program.connString;
            this.VIEW_BAO_DANGMUONTableAdapter.Fill(this.ThuVienDataSet.VIEW_BAO_DANGMUON);
        }

        private void btnExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }

        private void vIEW_BAO_DANGMUONGridControl_Click(object sender, EventArgs e)
        {

        }
    }
}
