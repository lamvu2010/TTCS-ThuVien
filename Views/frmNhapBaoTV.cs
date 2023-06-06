using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security;
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
        private int chenhLech;
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
            // TODO: This line of code loads data into the 'ThuVienDataSet.TaiLieu' table. You can move, or remove it, as needed.
            this.TaiLieuTableAdapter.Connection.ConnectionString = Program.connString;
            this.TaiLieuTableAdapter.Fill(this.ThuVienDataSet.TaiLieu);
            panelInput.Enabled= false;
            String sql = "Select MA,TUA From TaiLieu where LOAI=N'Báo'";
            SqlDataAdapter da = new SqlDataAdapter(sql, Program.conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Program.bds_dspm.DataSource = dt;
            cmbBao.DataSource = dt;
            cmbBao.DisplayMember = "TUA";
            cmbBao.ValueMember = "MA";
            cmbBao.Visible = false;
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
            int max = 1;
            List<int> list = new List<int>();
            foreach (DataRow row in ThuVienDataSet.BaoTV.Rows)
            {
                if (row["MABAO"].Equals(maBao))
                {
                    int temp = int.Parse(row["LAN"].ToString());
                    list.Add(temp);
                    if (temp > max) max = temp;
                }
            }
            for (int i = 1; i <= max; i++)
            {
                dem = i;
                if (list.Contains(dem) == false)
                {
                    return dem;
                }
            }
            return dem+1;
        }


        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            cmbBao.Visible = true;
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
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnTaiLai.Enabled = false;
            grid.Enabled = false;

        }

        private void baoTVGridControl_Click(object sender, EventArgs e)
        {
            
        }

        private void inputGroup_Enter(object sender, EventArgs e)
        {

        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (txtMABAO.Text.Trim() == "")
            {
                MessageBox.Show("Mời chọn mã báo");
                return;
            }
            if (txtSLNHAP.Text.Trim() == "")
            {
                MessageBox.Show("Mời nhập số lượng nhập");
                return;
            }
            if (int.Parse(txtSLNHAP.Text)<1)
            {
                MessageBox.Show("Số lượng nhập lớn hơn 0");
                return;
            }
            if(button!=null&&button.Equals("Them")) txtSLTON.Text = txtSLNHAP.Text;
            if (button != null && button.Equals("Sua"))
            {
                if (txtLAN.Text.Trim() == "")
                {
                    MessageBox.Show("Mời nhập lần xuất bản");
                    return;
                }
                
                txtSLTON.Text = (int.Parse(txtSLNHAP.Text) - chenhLech).ToString();
            }
            bdsBaoTV.EndEdit();
            bdsBaoTV.ResetCurrentItem();
            try
            {
                this.BaoTVTableAdapter.Connection.ConnectionString = Program.connPublisherString;
                this.BaoTVTableAdapter.Update(this.ThuVienDataSet.BaoTV);
                MessageBox.Show("Lưu thành công");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                bdsBaoTV.Position = position;
                this.BaoTVTableAdapter.Connection.ConnectionString = Program.connPublisherString;
                this.BaoTVTableAdapter.Fill(this.ThuVienDataSet.BaoTV);
            }
            if (button!=null&&button.Equals("Sua")) txtLAN.Enabled = true;
            button = null;
            panelInput.Enabled = false;
            txtLAN.Enabled = false;
            txtSLTON.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnTaiLai.Enabled = true;
            cmbBao.Visible = false;
            grid.Enabled = true;
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
            btnTaiLai.Enabled = true;
            cmbBao.Visible = false;
            grid.Enabled = true;
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
                    MessageBox.Show("Xóa thành công");
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
            position = bdsBaoTV.Position;
            cmbBao.Visible = true;
            int result = timBaoComboBox();
            if (result == -1) MessageBox.Show("Lỗi hiển thị combobox");
            button = "Sua";
            panelInput.Enabled = true;
            txtLAN.Enabled = false;
            txtSLTON.Enabled = false;
            txtLAN.Enabled = true;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnTaiLai.Enabled = false;
            this.grid.Enabled = false;
            chenhLech = int.Parse(txtSLNHAP.Text) - int.Parse(txtSLTON.Text);
        }

        private int timBaoComboBox()
        {
            string value = ((DataRowView)bdsBaoTV[bdsBaoTV.Position])["MABAO"].ToString().Trim();
            int index1 = bdsTaiLieu.Find("MA", value);
            if (index1 == -1)
            {
                MessageBox.Show("Không tìm thấy tựa tương ứng trong tài liệu");
                return -1;
            }
            string value2 = (((DataRowView)bdsTaiLieu[index1])["TUA"].ToString());
            int index2 = cmbBao.FindString(value2);
            if (index2 == -1)
            {
                MessageBox.Show("Không tìm thấy tựa trong combobox");
                return -1;
            }
            cmbBao.SelectedIndex = index2;
            return 0;
        }

        private void cmbBao_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (button!=null)
            {
                txtMABAO.Text = cmbBao.SelectedValue.ToString();
                txtLAN.Text = taoLan(cmbBao.SelectedValue.ToString()).ToString();
            }

        }

        private void btnTaiLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.BaoTVTableAdapter.Connection.ConnectionString = Program.connString;
            this.BaoTVTableAdapter.Fill(this.ThuVienDataSet.BaoTV);
        }
    }
}
