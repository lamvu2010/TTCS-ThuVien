using DevExpress.XtraSpellChecker.Parser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThuVien.Views
{
    public partial class frmSachTV : Form
    {
        int position;
        int soThe;
        public frmSachTV()
        {
            InitializeComponent();
            soThe = -1;
        }

        private void frmSach_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'thuVienDataSet.VIEW_SACHTV' table. You can move, or remove it, as needed.
            this.VIEW_SACHTVTableAdapter.Connection.ConnectionString = Program.connString;
            this.VIEW_SACHTVTableAdapter.Fill(this.ThuVienDataSet.VIEW_SACHTV);
            soThe = -1;
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

        private void btnMuon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (soThe == -1) return;
            position = bdsSachTV.Position;
            if (MessageBox.Show("Số thẻ: " + txtSoThe.Text + " Tên: " + txtTen.Text + "\nPhái: " + txtPhai.Text + " Nghề nghiệp: " + txtNgheNghiep.Text +
                "\nNgày cấp: " + txtNgayCap.Text +
                "\nBạn có muốn xác nhận cho mượn sách?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Int32 id_sach = int.Parse(((DataRowView)bdsSachTV[bdsSachTV.Position])["ID_SACH"].ToString());
                int excute = Program.ExecSqlNonQuery("EXEC SP_MUON_SACH '" + soThe + "', '" + id_sach + "'");
                if (excute == 0)
                {
                    MessageBox.Show("Mượn sách thành công");
                    this.VIEW_SACHTVTableAdapter.Fill(this.ThuVienDataSet.VIEW_SACHTV);
                    bdsSachTV.Position = position;
                }

                return;
            }
        }

        private void vIEW_SACHTVGridControl_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.VIEW_SACHTVTableAdapter.Fill(this.ThuVienDataSet.VIEW_SACHTV);
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
            position = bdsSachTV.Position;
            if (MessageBox.Show("Số thẻ: " + txtSoThe.Text + " Tên: " + txtTen.Text + "\nPhái: " + txtPhai.Text + " Nghề nghiệp: " + txtNgheNghiep.Text +
                "\nNgày cấp: " + txtNgayCap.Text +
                "\nBạn có muốn xác nhận trả sách đã mượn?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Int32 id_sach = int.Parse(((DataRowView)bdsSachTV[bdsSachTV.Position])["ID_SACH"].ToString());
                int excute = Program.ExecSqlNonQuery("EXEC SP_TRA_SACH '" + soThe + "', '" + id_sach + "'");
                if (excute == 0)
                {
                    MessageBox.Show("Trả sách thành công");
                    this.VIEW_SACHTVTableAdapter.Fill(this.ThuVienDataSet.VIEW_SACHTV);
                    bdsSachTV.Position = position;
                }

                return;
            }
        }

        private void btnExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }


        private void btnAccess_Click(object sender, EventArgs e)
        {
            soThe = int.Parse(txtSoThe.Text);
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
            else if (!myReader.Read())
            {
                MessageBox.Show("Không tìm được thông tin độc giả");
            }
            else if (myReader == null)
            {
                MessageBox.Show("Lỗi");
            }
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

        private void DocGiaPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
