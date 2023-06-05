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
    public partial class frmDSBaoMuon : Form
    {
        public frmDSBaoMuon()
        {
            InitializeComponent();
        }

        private void frmDSBaoMuon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'thuVienDataSet.VIEW_DS_MUON_BAO' table. You can move, or remove it, as needed.
            this.VIEW_DS_MUON_BAOTableAdapter.Connection.ConnectionString = Program.connString;
            this.VIEW_DS_MUON_BAOTableAdapter.Fill(this.ThuVienDataSet.VIEW_DS_MUON_BAO);

        }



        private void btnRefresh_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.VIEW_DS_MUON_BAOTableAdapter.Connection.ConnectionString = Program.connString;
            this.VIEW_DS_MUON_BAOTableAdapter.Fill(this.ThuVienDataSet.VIEW_DS_MUON_BAO);
        }

        private void btnExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }
    }
}
