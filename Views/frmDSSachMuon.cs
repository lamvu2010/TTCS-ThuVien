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
    public partial class frmDSSachMuon : Form
    {
        public frmDSSachMuon()
        {
            InitializeComponent();
        }

        private void frmDSSachMuon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'thuVienDataSet.VIEW_DS_MUON_SACH' table. You can move, or remove it, as needed.
            this.VIEW_DS_MUON_SACHTableAdapter.Connection.ConnectionString = Program.connString;
            this.VIEW_DS_MUON_SACHTableAdapter.Fill(this.ThuVienDataSet.VIEW_DS_MUON_SACH);

        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.VIEW_DS_MUON_SACHTableAdapter.Connection.ConnectionString = Program.connString;
            this.VIEW_DS_MUON_SACHTableAdapter.Fill(this.ThuVienDataSet.VIEW_DS_MUON_SACH);
        }

        private void btnExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }

        private void bdsDSSachMuon_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void vIEW_DS_MUON_SACHGridControl_Click(object sender, EventArgs e)
        {

        }
    }
}
