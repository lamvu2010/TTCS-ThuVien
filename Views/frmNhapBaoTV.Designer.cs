namespace ThuVien.Views
{
    partial class frmNhapBaoTV
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhapBaoTV));
            System.Windows.Forms.Label lbSLN;
            System.Windows.Forms.Label lbLan;
            System.Windows.Forms.Label lbMaBao;
            System.Windows.Forms.Label lbIDBao;
            this.ThuVienDataSet = new ThuVien.ThuVienDataSet();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnReset = new DevExpress.XtraBars.BarButtonItem();
            this.bdsBaoTV = new System.Windows.Forms.BindingSource(this.components);
            this.BaoTVTableAdapter = new ThuVien.ThuVienDataSetTableAdapters.BaoTVTableAdapter();
            this.tableAdapterManager = new ThuVien.ThuVienDataSetTableAdapters.TableAdapterManager();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID_BAO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMABAO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSLNHAP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSLTON = new DevExpress.XtraGrid.Columns.GridColumn();
            this.baoTVGridControl = new DevExpress.XtraGrid.GridControl();
            this.bdsBaoMuon = new System.Windows.Forms.BindingSource(this.components);
            this.BaoMuonTableAdapter = new ThuVien.ThuVienDataSetTableAdapters.BaoMuonTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSLN = new System.Windows.Forms.TextBox();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnXacnhan = new DevExpress.XtraEditors.SimpleButton();
            this.txtLan = new System.Windows.Forms.TextBox();
            this.txtMaBao = new System.Windows.Forms.TextBox();
            this.txtIDBao = new System.Windows.Forms.TextBox();
            lbSLN = new System.Windows.Forms.Label();
            lbLan = new System.Windows.Forms.Label();
            lbMaBao = new System.Windows.Forms.Label();
            lbIDBao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ThuVienDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBaoTV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baoTVGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBaoMuon)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ThuVienDataSet
            // 
            this.ThuVienDataSet.DataSetName = "ThuVienDataSet";
            this.ThuVienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnXoa,
            this.btnSua,
            this.btnThoat,
            this.btnReset});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 5;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.LargeImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 1;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.LargeImage")));
            this.btnXoa.Name = "btnXoa";
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Id = 2;
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.LargeImage")));
            this.btnSua.Name = "btnSua";
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 3;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.LargeImage")));
            this.btnThoat.Name = "btnThoat";
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1234, 34);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 868);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1234, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 34);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 834);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1234, 34);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 834);
            // 
            // btnReset
            // 
            this.btnReset.Caption = "Reset";
            this.btnReset.Id = 4;
            this.btnReset.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.ImageOptions.Image")));
            this.btnReset.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnReset.ImageOptions.LargeImage")));
            this.btnReset.Name = "btnReset";
            // 
            // bdsBaoTV
            // 
            this.bdsBaoTV.DataMember = "BaoTV";
            this.bdsBaoTV.DataSource = this.ThuVienDataSet;
            // 
            // BaoTVTableAdapter
            // 
            this.BaoTVTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BaoMuonTableAdapter = null;
            this.tableAdapterManager.BaoPHTableAdapter = null;
            this.tableAdapterManager.BaoTVTableAdapter = this.BaoTVTableAdapter;
            this.tableAdapterManager.ChiTietTacGiaTableAdapter = null;
            this.tableAdapterManager.DocGiaTableAdapter = null;
            this.tableAdapterManager.SachMuonTableAdapter = null;
            this.tableAdapterManager.SachTVTableAdapter = null;
            this.tableAdapterManager.SachXBTableAdapter = null;
            this.tableAdapterManager.TacGiaTableAdapter = null;
            this.tableAdapterManager.TaiLieuTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ThuVien.ThuVienDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID_BAO,
            this.colMABAO,
            this.colLAN,
            this.colSLNHAP,
            this.colSLTON});
            this.gridView1.GridControl = this.baoTVGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colID_BAO
            // 
            this.colID_BAO.FieldName = "ID_BAO";
            this.colID_BAO.MinWidth = 30;
            this.colID_BAO.Name = "colID_BAO";
            this.colID_BAO.Visible = true;
            this.colID_BAO.VisibleIndex = 0;
            this.colID_BAO.Width = 112;
            // 
            // colMABAO
            // 
            this.colMABAO.FieldName = "MABAO";
            this.colMABAO.MinWidth = 30;
            this.colMABAO.Name = "colMABAO";
            this.colMABAO.Visible = true;
            this.colMABAO.VisibleIndex = 1;
            this.colMABAO.Width = 112;
            // 
            // colLAN
            // 
            this.colLAN.FieldName = "LAN";
            this.colLAN.MinWidth = 30;
            this.colLAN.Name = "colLAN";
            this.colLAN.Visible = true;
            this.colLAN.VisibleIndex = 2;
            this.colLAN.Width = 112;
            // 
            // colSLNHAP
            // 
            this.colSLNHAP.FieldName = "SLNHAP";
            this.colSLNHAP.MinWidth = 30;
            this.colSLNHAP.Name = "colSLNHAP";
            this.colSLNHAP.Visible = true;
            this.colSLNHAP.VisibleIndex = 3;
            this.colSLNHAP.Width = 112;
            // 
            // colSLTON
            // 
            this.colSLTON.FieldName = "SLTON";
            this.colSLTON.MinWidth = 30;
            this.colSLTON.Name = "colSLTON";
            this.colSLTON.Visible = true;
            this.colSLTON.VisibleIndex = 4;
            this.colSLTON.Width = 112;
            // 
            // baoTVGridControl
            // 
            this.baoTVGridControl.DataSource = this.bdsBaoTV;
            this.baoTVGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.baoTVGridControl.Location = new System.Drawing.Point(0, 34);
            this.baoTVGridControl.MainView = this.gridView1;
            this.baoTVGridControl.MenuManager = this.barManager1;
            this.baoTVGridControl.Name = "baoTVGridControl";
            this.baoTVGridControl.Size = new System.Drawing.Size(1234, 294);
            this.baoTVGridControl.TabIndex = 22;
            this.baoTVGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // bdsBaoMuon
            // 
            this.bdsBaoMuon.DataMember = "FK_BaoMuon_BaoTV";
            this.bdsBaoMuon.DataSource = this.bdsBaoTV;
            // 
            // BaoMuonTableAdapter
            // 
            this.BaoMuonTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.txtSLN);
            this.groupBox1.Controls.Add(this.btnHuy);
            this.groupBox1.Controls.Add(this.btnXacnhan);
            this.groupBox1.Controls.Add(lbSLN);
            this.groupBox1.Controls.Add(lbLan);
            this.groupBox1.Controls.Add(this.txtLan);
            this.groupBox1.Controls.Add(lbMaBao);
            this.groupBox1.Controls.Add(this.txtMaBao);
            this.groupBox1.Controls.Add(lbIDBao);
            this.groupBox1.Controls.Add(this.txtIDBao);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(0, 328);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1234, 270);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            this.groupBox1.Visible = false;
            // 
            // txtSLN
            // 
            this.txtSLN.Location = new System.Drawing.Point(501, 130);
            this.txtSLN.Name = "txtSLN";
            this.txtSLN.Size = new System.Drawing.Size(168, 26);
            this.txtSLN.TabIndex = 23;
            // 
            // btnHuy
            // 
            this.btnHuy.Appearance.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Appearance.Options.UseFont = true;
            this.btnHuy.Location = new System.Drawing.Point(741, 73);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(112, 34);
            this.btnHuy.TabIndex = 22;
            this.btnHuy.Text = "Hủy";
            // 
            // btnXacnhan
            // 
            this.btnXacnhan.Appearance.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacnhan.Appearance.Options.UseFont = true;
            this.btnXacnhan.Location = new System.Drawing.Point(741, 129);
            this.btnXacnhan.Name = "btnXacnhan";
            this.btnXacnhan.Size = new System.Drawing.Size(112, 34);
            this.btnXacnhan.TabIndex = 21;
            this.btnXacnhan.Text = "Xác nhận";
            // 
            // lbSLN
            // 
            lbSLN.AutoSize = true;
            lbSLN.Location = new System.Drawing.Point(381, 136);
            lbSLN.Name = "lbSLN";
            lbSLN.Size = new System.Drawing.Size(112, 20);
            lbSLN.TabIndex = 19;
            lbSLN.Text = "Số lượng nhập";
            // 
            // lbLan
            // 
            lbLan.AutoSize = true;
            lbLan.Location = new System.Drawing.Point(31, 134);
            lbLan.Name = "lbLan";
            lbLan.Size = new System.Drawing.Size(76, 20);
            lbLan.TabIndex = 17;
            lbLan.Text = "Lần nhập";
            // 
            // txtLan
            // 
            this.txtLan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLan.Location = new System.Drawing.Point(191, 130);
            this.txtLan.Name = "txtLan";
            this.txtLan.Size = new System.Drawing.Size(133, 26);
            this.txtLan.TabIndex = 18;
            // 
            // lbMaBao
            // 
            lbMaBao.AutoSize = true;
            lbMaBao.Location = new System.Drawing.Point(381, 75);
            lbMaBao.Name = "lbMaBao";
            lbMaBao.Size = new System.Drawing.Size(62, 20);
            lbMaBao.TabIndex = 15;
            lbMaBao.Text = "Mã báo";
            // 
            // txtMaBao
            // 
            this.txtMaBao.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtMaBao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaBao.Location = new System.Drawing.Point(500, 70);
            this.txtMaBao.Name = "txtMaBao";
            this.txtMaBao.Size = new System.Drawing.Size(169, 26);
            this.txtMaBao.TabIndex = 16;
            // 
            // lbIDBao
            // 
            lbIDBao.AutoSize = true;
            lbIDBao.BackColor = System.Drawing.Color.White;
            lbIDBao.Location = new System.Drawing.Point(28, 73);
            lbIDBao.Name = "lbIDBao";
            lbIDBao.Size = new System.Drawing.Size(57, 20);
            lbIDBao.TabIndex = 13;
            lbIDBao.Text = "ID báo";
            // 
            // txtIDBao
            // 
            this.txtIDBao.Location = new System.Drawing.Point(191, 70);
            this.txtIDBao.Name = "txtIDBao";
            this.txtIDBao.Size = new System.Drawing.Size(100, 26);
            this.txtIDBao.TabIndex = 14;
            // 
            // frmNhapBaoTV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 888);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.baoTVGridControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmNhapBaoTV";
            this.Text = "Nhập Báo Thư Viện";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmNhapBaoTV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ThuVienDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBaoTV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baoTVGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBaoMuon)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ThuVienDataSet ThuVienDataSet;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnReset;
        private System.Windows.Forms.BindingSource bdsBaoTV;
        private ThuVienDataSetTableAdapters.BaoTVTableAdapter BaoTVTableAdapter;
        private ThuVienDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl baoTVGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colID_BAO;
        private DevExpress.XtraGrid.Columns.GridColumn colMABAO;
        private DevExpress.XtraGrid.Columns.GridColumn colLAN;
        private DevExpress.XtraGrid.Columns.GridColumn colSLNHAP;
        private DevExpress.XtraGrid.Columns.GridColumn colSLTON;
        private System.Windows.Forms.BindingSource bdsBaoMuon;
        private ThuVienDataSetTableAdapters.BaoMuonTableAdapter BaoMuonTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSLN;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton btnXacnhan;
        private System.Windows.Forms.TextBox txtLan;
        private System.Windows.Forms.TextBox txtMaBao;
        private System.Windows.Forms.TextBox txtIDBao;
    }
}