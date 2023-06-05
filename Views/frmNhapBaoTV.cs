using DevExpress.XtraEditors;
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
using ThuVien.ThuVienDataSetTableAdapters;

namespace ThuVien.Views
{
    public partial class frmNhapBaoTV : Form
    {
        public frmNhapBaoTV()
        {
            InitializeComponent();
        }
        private int position;
        private String button;
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
            this.BaoMuonTableAdapter.Connection.ConnectionString = Program.connString;
            this.BaoMuonTableAdapter.Fill(this.ThuVienDataSet.BaoMuon);
            // TODO: This line of code loads data into the 'ThuVienDataSet.BaoTV' table. You can move, or remove it, as needed.
            this.BaoTVTableAdapter.Connection.ConnectionString = Program.connString;
            this.BaoTVTableAdapter.Fill(this.ThuVienDataSet.BaoTV);
            panelInput.Enabled= false;
            String sql = "Select MA,TUA From TaiLieu where LOAI=N'Báo'";
            SqlDataAdapter da = new SqlDataAdapter(sql, Program.conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Program.bds_dspm.DataSource = dt;
            cmbBao.DataSource = dt;
            cmbBao.DisplayMember = "TUA";
            cmbBao.ValueMember = "MA";
            cmbBao.SelectedIndex = 0;
        }
        private int newId()
        {
            int id = 1;
            int max = 1;
            List<int> list = new List<int>();
            foreach (DataRow row in ThuVienDataSet.BaoTV.Rows)
            {
                int temp = Convert.ToInt32(row["ID_BAO"]);
                list.Add(temp);
                if (temp > max) max = temp;
            }
            for (int i = 1; i <= max; i++)
            {
                id = i;
                if (list.Contains(id) == false)
                {
                    return id;
                }
            }
            return id + 1;
        }

        private int taoLan(String maBao)
        {
            int dem = 1;
            foreach (DataRow row in ThuVienDataSet.BaoTV.Rows)
            {
                if (row["MABAO"].Equals(maBao)) dem++;
            }
            foreach (DataRow row in ThuVienDataSet.BaoTV.Rows)
            {
                if (row["MABAO"].Equals(maBao) && row["LAN"].Equals(dem))
                {
                    MessageBox.Show("Lỗi lần xuất bản không tuần tự");
                    return -1;
                }
            }
            return dem;
        }

        private void lbNSX_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            position=bdsBaoTV.Position;
            bdsBaoTV.AddNew();
            panelInput.Enabled = true;
            txtID_BAO.Text = newId().ToString();
            
            
            button = "Them";
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            txtSLTON.Enabled = false;
            txtLAN.Enabled = false;
            btnThem.Enabled = false;
        }

        private void baoTVGridControl_Click(object sender, EventArgs e)
        {
            
        }

        private void inputGroup_Enter(object sender, EventArgs e)
        {

        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if(button.Equals("Them")) ((DataRowView)bdsBaoTV[bdsBaoTV.Position])["SLTON"] = Int32.Parse(txtSLNHAP.Text);
            bdsBaoTV.EndEdit();
            bdsBaoTV.ResetCurrentItem();
            try
            {
                MessageBox.Show(((DataRowView)bdsBaoTV[bdsBaoTV.Position])["MABAO"].ToString());
                MessageBox.Show(cmbBao.SelectedValue.ToString());
                this.BaoTVTableAdapter.Connection.ConnectionString = Program.connPublisherString;
                this.BaoTVTableAdapter.Update(this.ThuVienDataSet.BaoTV);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                bdsBaoTV.Position = position;
                this.BaoTVTableAdapter.Connection.ConnectionString = Program.connPublisherString;
                this.BaoTVTableAdapter.Fill(this.ThuVienDataSet.BaoTV);
            }
            if (button.Equals("Sua")) txtLAN.Enabled = true;
            button = null;
            panelInput.Enabled = false;
            txtLAN.Enabled = false;
            txtSLTON.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            bdsBaoTV.CancelEdit();
            bdsBaoTV.Position = position;
            this.BaoTVTableAdapter.Connection.ConnectionString = Program.connPublisherString;
            this.BaoTVTableAdapter.Fill(this.ThuVienDataSet.BaoTV);
            panelInput.Enabled = false;
            txtSLTON.Enabled= false;
            txtLAN.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = true; 
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsBaoMuon.Count > 0)
            {
                MessageBox.Show("Không thể xóa vì đã có thông tin mượn", "Thông báo");
                return;
            }
            if (MessageBox.Show("Bạn chắc chắn muốn xóa sách này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                String id_bao = txtID_BAO.Text;
                try
                {
                    bdsBaoTV.RemoveCurrent();
                    BaoTVTableAdapter.Connection.ConnectionString = Program.connPublisherString;
                    this.BaoTVTableAdapter.Update(this.ThuVienDataSet.BaoTV);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa\n" + ex.Message, "Error");
                    this.BaoTVTableAdapter.Connection.ConnectionString=Program.connString;
                    this.BaoTVTableAdapter.Fill(this.ThuVienDataSet.BaoTV);
                    bdsBaoTV.Position = bdsBaoTV.Find("ID_BAO", id_bao);
                }
            }
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            button = "Sua";
            panelInput.Enabled = true;
            txtLAN.Enabled = false;
            txtSLTON.Enabled = false;
            txtLAN.Enabled = true;
        }

        

        private void cmbBao_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMABAO.Text = cmbBao.SelectedValue.ToString();
            txtLAN.Text = taoLan(cmbBao.SelectedValue.ToString()).ToString();

        }

        
    }
}
