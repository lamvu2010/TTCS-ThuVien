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
    public partial class frmBaoTV : Form
    {
        int soThe=-1;
        int position;
        public frmBaoTV()
        {
            InitializeComponent();
            soThe = -1;
        }

        private void frmBaoTV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'thuVienDataSet.VIEW_BAOTV' table. You can move, or remove it, as needed.
            this.VIEW_BAOTVTableAdapter.Connection.ConnectionString = Program.connString;
            this.VIEW_BAOTVTableAdapter.Fill(this.ThuVienDataSet.VIEW_BAOTV);
            if (Program.group.Equals("DocGia"))
            {
                btnBorrow.Enabled = false;
                btnReturn.Enabled = false;
                DocGiaPanel.Visible = false;
            }
            else
            {
                btnBorrow.Enabled = true;
                btnReturn.Enabled = true;
                DocGiaPanel.Visible = true;
                txtSoThe.Enabled = true;
            }
        }

        private void vIEW_BAOTVGridControl_Click(object sender, EventArgs e)
        {

        }

        private void btnBorrow_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (soThe == -1) return;
            position = bdsBaoTV.Position;
            if (MessageBox.Show("Số thẻ: "+txtSoThe.Text +" Tên: "+txtTen.Text +"\nPhái: "+txtPhai.Text +" Nghề nghiệp: "+txtNgheNghiep.Text +
                "\nNgày cấp: "+txtNgayCap.Text +
                "\nBạn có muốn xác nhận mượn cho độc giả?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Int32 id_bao = int.Parse(((DataRowView)bdsBaoTV[bdsBaoTV.Position])["ID_BAO"].ToString());
                int excute = Program.ExecSqlNonQuery("EXEC SP_MUON_BAO '" + soThe + "', '"+id_bao+"'");
                if (excute == 0)
                {
                    MessageBox.Show("Mượn báo thành công");
                    this.VIEW_BAOTVTableAdapter.Fill(this.ThuVienDataSet.VIEW_BAOTV);
                    bdsBaoTV.Position = position;
                }
                
                return;
            }
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            soThe = -1;
            try
            {
                this.VIEW_BAOTVTableAdapter.Fill(this.ThuVienDataSet.VIEW_BAOTV);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi reload: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnReturn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (soThe == -1) return;
            position = bdsBaoTV.Position;
            if (MessageBox.Show("Số thẻ: " + txtSoThe.Text + " Tên: " + txtTen.Text + "\nPhái: " + txtPhai.Text + " Nghề nghiệp: " + txtNgheNghiep.Text +
                "\nNgày cấp: " + txtNgayCap.Text +
                "\nBạn có muốn xác nhận trả?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Int32 id_bao = int.Parse(((DataRowView)bdsBaoTV[bdsBaoTV.Position])["ID_BAO"].ToString());
                int excute = Program.ExecSqlNonQuery("EXEC SP_TRA_BAO '" + soThe + "', '" + id_bao + "'");
                if (excute == 0)
                {
                    MessageBox.Show("Trả báo thành công");
                    this.VIEW_BAOTVTableAdapter.Fill(this.ThuVienDataSet.VIEW_BAOTV);
                    bdsBaoTV.Position = position;
                }

                return;
            }
        }

        private void btnExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }

        private void labelSoThe_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtTen.Text = "";
            txtNgheNghiep.Text = "";
            txtPhai.Text = "";
            txtNgayCap.Text = "";
            txtSoThe.Enabled = true;
            soThe = -1;
        }

        private void labelTen_Click(object sender, EventArgs e)
        {

        }

        
        private void btnAccess_Click(object sender, EventArgs e)
        {
            soThe=Int32.Parse(txtSoThe.Text);
            SqlDataReader myReader = Program.ExecSqlDataReader("EXEC SP_TimDocGia '" + soThe + "'");
            if (myReader != null && myReader.Read())
            {
                txtTen.Text = myReader.GetString(2);
                txtNgheNghiep.Text = myReader.GetString(3);
                txtPhai.Text = myReader.GetString(4);
                txtNgayCap.Text = myReader.GetDateTime(1).ToString();
                txtSoThe.Enabled = false;
                myReader.Close();
            }
            else if(!myReader.Read())
            {
                MessageBox.Show("Không tìm được thông tin độc giả");
            }
            else if(myReader == null)
            {
                MessageBox.Show("Lỗi");
            }
        }

        private void labelNgayCap_Click(object sender, EventArgs e)
        {

        }
    }
}
