
namespace ThuVien.Views
{
    partial class frmQuanLySachXB
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
            System.Windows.Forms.Label mASACHXBLabel;
            System.Windows.Forms.Label mASACHLabel;
            System.Windows.Forms.Label nAMLabel;
            System.Windows.Forms.Label kHOGIAYLabel;
            System.Windows.Forms.Label nHAXBLabel;
            System.Windows.Forms.Label lANLabel;
            System.Windows.Forms.Label gIALabel;
            System.Windows.Forms.Label sOTRANGLabel;
            System.Windows.Forms.Label cDLabel;
            System.Windows.Forms.Label sLNHAPLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLySachXB));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnCapNhat = new DevExpress.XtraBars.BarButtonItem();
            this.btnUndo = new DevExpress.XtraBars.BarButtonItem();
            this.btnLuu = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.thuVienDataSet = new ThuVien.ThuVienDataSet();
            this.bdsSachXB = new System.Windows.Forms.BindingSource(this.components);
            this.sachXBTableAdapter = new ThuVien.ThuVienDataSetTableAdapters.SachXBTableAdapter();
            this.tableAdapterManager = new ThuVien.ThuVienDataSetTableAdapters.TableAdapterManager();
            this.sachXBGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMASACHXB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMASACH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNAM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKHOGIAY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTRANG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNHAXB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSLNHAP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl = new DevExpress.XtraEditors.PanelControl();
            this.txtSLNhap = new System.Windows.Forms.NumericUpDown();
            this.cmbTuaSach = new System.Windows.Forms.ComboBox();
            this.taiLieuSachBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbCD = new System.Windows.Forms.CheckBox();
            this.txtSoStrang = new DevExpress.XtraEditors.TextEdit();
            this.txtGia = new DevExpress.XtraEditors.TextEdit();
            this.txtLan = new System.Windows.Forms.NumericUpDown();
            this.txtNhaXB = new System.Windows.Forms.TextBox();
            this.txtKhoGiay = new DevExpress.XtraEditors.TextEdit();
            this.txtNam = new DevExpress.XtraEditors.TextEdit();
            this.txtMaSach = new DevExpress.XtraEditors.TextEdit();
            this.txtMaSachXB = new DevExpress.XtraEditors.TextEdit();
            this.taiLieu_SachTableAdapter = new ThuVien.ThuVienDataSetTableAdapters.TaiLieu_SachTableAdapter();
            this.virtualServerModeSource1 = new DevExpress.Data.VirtualServerModeSource(this.components);
            this.panelSachTV = new DevExpress.XtraEditors.PanelControl();
            this.sachTVDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_SACH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MASACHXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.capNhatToolStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themNhanhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bdsSachTV = new System.Windows.Forms.BindingSource(this.components);
            this.sachTVTableAdapter = new ThuVien.ThuVienDataSetTableAdapters.SachTVTableAdapter();
            this.bdsSachMuon = new System.Windows.Forms.BindingSource(this.components);
            this.sachMuonTableAdapter = new ThuVien.ThuVienDataSetTableAdapters.SachMuonTableAdapter();
            mASACHXBLabel = new System.Windows.Forms.Label();
            mASACHLabel = new System.Windows.Forms.Label();
            nAMLabel = new System.Windows.Forms.Label();
            kHOGIAYLabel = new System.Windows.Forms.Label();
            nHAXBLabel = new System.Windows.Forms.Label();
            lANLabel = new System.Windows.Forms.Label();
            gIALabel = new System.Windows.Forms.Label();
            sOTRANGLabel = new System.Windows.Forms.Label();
            cDLabel = new System.Windows.Forms.Label();
            sLNHAPLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thuVienDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSachXB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sachXBGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl)).BeginInit();
            this.panelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSLNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiLieuSachBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoStrang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKhoGiay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNam.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSach.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSachXB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.virtualServerModeSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelSachTV)).BeginInit();
            this.panelSachTV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sachTVDataGridView)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSachTV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSachMuon)).BeginInit();
            this.SuspendLayout();
            // 
            // mASACHXBLabel
            // 
            mASACHXBLabel.AutoSize = true;
            mASACHXBLabel.Location = new System.Drawing.Point(61, 33);
            mASACHXBLabel.Name = "mASACHXBLabel";
            mASACHXBLabel.Size = new System.Drawing.Size(97, 19);
            mASACHXBLabel.TabIndex = 0;
            mASACHXBLabel.Text = "MASACHXB:";
            // 
            // mASACHLabel
            // 
            mASACHLabel.AutoSize = true;
            mASACHLabel.Location = new System.Drawing.Point(75, 90);
            mASACHLabel.Name = "mASACHLabel";
            mASACHLabel.Size = new System.Drawing.Size(79, 19);
            mASACHLabel.TabIndex = 4;
            mASACHLabel.Text = "MASACH:";
            // 
            // nAMLabel
            // 
            nAMLabel.AutoSize = true;
            nAMLabel.Location = new System.Drawing.Point(545, 33);
            nAMLabel.Name = "nAMLabel";
            nAMLabel.Size = new System.Drawing.Size(49, 19);
            nAMLabel.TabIndex = 6;
            nAMLabel.Text = "NAM:";
            // 
            // kHOGIAYLabel
            // 
            kHOGIAYLabel.AutoSize = true;
            kHOGIAYLabel.Location = new System.Drawing.Point(71, 188);
            kHOGIAYLabel.Name = "kHOGIAYLabel";
            kHOGIAYLabel.Size = new System.Drawing.Size(85, 19);
            kHOGIAYLabel.TabIndex = 8;
            kHOGIAYLabel.Text = "KHOGIAY:";
            // 
            // nHAXBLabel
            // 
            nHAXBLabel.AutoSize = true;
            nHAXBLabel.Location = new System.Drawing.Point(92, 138);
            nHAXBLabel.Name = "nHAXBLabel";
            nHAXBLabel.Size = new System.Drawing.Size(66, 19);
            nHAXBLabel.TabIndex = 10;
            nHAXBLabel.Text = "NHAXB:";
            // 
            // lANLabel
            // 
            lANLabel.AutoSize = true;
            lANLabel.Location = new System.Drawing.Point(387, 35);
            lANLabel.Name = "lANLabel";
            lANLabel.Size = new System.Drawing.Size(45, 19);
            lANLabel.TabIndex = 11;
            lANLabel.Text = "LAN:";
            // 
            // gIALabel
            // 
            gIALabel.AutoSize = true;
            gIALabel.Location = new System.Drawing.Point(669, 184);
            gIALabel.Name = "gIALabel";
            gIALabel.Size = new System.Drawing.Size(43, 19);
            gIALabel.TabIndex = 12;
            gIALabel.Text = "GIA:";
            // 
            // sOTRANGLabel
            // 
            sOTRANGLabel.AutoSize = true;
            sOTRANGLabel.Location = new System.Drawing.Point(373, 188);
            sOTRANGLabel.Name = "sOTRANGLabel";
            sOTRANGLabel.Size = new System.Drawing.Size(89, 19);
            sOTRANGLabel.TabIndex = 14;
            sOTRANGLabel.Text = "SOTRANG:";
            // 
            // cDLabel
            // 
            cDLabel.AutoSize = true;
            cDLabel.Location = new System.Drawing.Point(772, 88);
            cDLabel.Name = "cDLabel";
            cDLabel.Size = new System.Drawing.Size(36, 19);
            cDLabel.TabIndex = 16;
            cDLabel.Text = "CD:";
            // 
            // sLNHAPLabel
            // 
            sLNHAPLabel.AutoSize = true;
            sLNHAPLabel.Location = new System.Drawing.Point(734, 35);
            sLNHAPLabel.Name = "sLNHAPLabel";
            sLNHAPLabel.Size = new System.Drawing.Size(74, 19);
            sLNHAPLabel.TabIndex = 18;
            sLNHAPLabel.Text = "SLNHAP:";
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
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4,
            this.barButtonItem5,
            this.barButtonItem6,
            this.btnThem,
            this.btnXoa,
            this.btnCapNhat,
            this.btnUndo,
            this.btnLuu,
            this.btnReload,
            this.btnThoat});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 13;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThem),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnXoa),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnCapNhat),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnUndo),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnLuu),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnReload),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThoat)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 6;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.LargeImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem7_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 7;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.LargeImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Caption = "Cập nhật";
            this.btnCapNhat.Id = 8;
            this.btnCapNhat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCapNhat.ImageOptions.Image")));
            this.btnCapNhat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCapNhat.ImageOptions.LargeImage")));
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnCapNhat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCapNhat_ItemClick);
            // 
            // btnUndo
            // 
            this.btnUndo.Caption = "Undo";
            this.btnUndo.Enabled = false;
            this.btnUndo.Id = 9;
            this.btnUndo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUndo.ImageOptions.Image")));
            this.btnUndo.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnUndo.ImageOptions.LargeImage")));
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnUndo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUndo_ItemClick);
            // 
            // btnLuu
            // 
            this.btnLuu.Caption = "Lưu";
            this.btnLuu.Enabled = false;
            this.btnLuu.Id = 10;
            this.btnLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.Image")));
            this.btnLuu.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.LargeImage")));
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnLuu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLuu_ItemClick);
            // 
            // btnReload
            // 
            this.btnReload.Caption = "Reload";
            this.btnReload.Id = 11;
            this.btnReload.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.ImageOptions.Image")));
            this.btnReload.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnReload.ImageOptions.LargeImage")));
            this.btnReload.Name = "btnReload";
            this.btnReload.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnReload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReload_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 12;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.LargeImage")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(1924, 34);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 709);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1924, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 34);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 675);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1924, 34);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 675);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Nhập sách";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Xóa sách";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.barButtonItem2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Cập nhật";
            this.barButtonItem3.Id = 2;
            this.barButtonItem3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.Image")));
            this.barButtonItem3.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.LargeImage")));
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Undo";
            this.barButtonItem4.Id = 3;
            this.barButtonItem4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.Image")));
            this.barButtonItem4.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.LargeImage")));
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Reload";
            this.barButtonItem5.Id = 4;
            this.barButtonItem5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.ImageOptions.Image")));
            this.barButtonItem5.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.ImageOptions.LargeImage")));
            this.barButtonItem5.Name = "barButtonItem5";
            this.barButtonItem5.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "Thoát";
            this.barButtonItem6.Id = 5;
            this.barButtonItem6.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem6.ImageOptions.Image")));
            this.barButtonItem6.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem6.ImageOptions.LargeImage")));
            this.barButtonItem6.Name = "barButtonItem6";
            this.barButtonItem6.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // thuVienDataSet
            // 
            this.thuVienDataSet.DataSetName = "ThuVienDataSet";
            this.thuVienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsSachXB
            // 
            this.bdsSachXB.DataMember = "SachXB";
            this.bdsSachXB.DataSource = this.thuVienDataSet;
            // 
            // sachXBTableAdapter
            // 
            this.sachXBTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BaoMuonTableAdapter = null;
            this.tableAdapterManager.BaoPHTableAdapter = null;
            this.tableAdapterManager.BaoTVTableAdapter = null;
            this.tableAdapterManager.ChiTietTacGiaTableAdapter = null;
            this.tableAdapterManager.DocGiaTableAdapter = null;
            this.tableAdapterManager.SachMuonTableAdapter = null;
            this.tableAdapterManager.SachTVTableAdapter = null;
            this.tableAdapterManager.SachXBTableAdapter = this.sachXBTableAdapter;
            this.tableAdapterManager.TacGiaTableAdapter = null;
            this.tableAdapterManager.TaiLieuTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ThuVien.ThuVienDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sachXBGridControl
            // 
            this.sachXBGridControl.DataSource = this.bdsSachXB;
            this.sachXBGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.sachXBGridControl.Location = new System.Drawing.Point(0, 34);
            this.sachXBGridControl.MainView = this.gridView1;
            this.sachXBGridControl.MenuManager = this.barManager1;
            this.sachXBGridControl.Name = "sachXBGridControl";
            this.sachXBGridControl.Size = new System.Drawing.Size(1479, 326);
            this.sachXBGridControl.TabIndex = 5;
            this.sachXBGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMASACHXB,
            this.colLAN,
            this.colMASACH,
            this.colNAM,
            this.colKHOGIAY,
            this.colSOTRANG,
            this.colNHAXB,
            this.colGIA,
            this.colCD,
            this.colSLNHAP});
            this.gridView1.GridControl = this.sachXBGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colMASACHXB
            // 
            this.colMASACHXB.FieldName = "MASACHXB";
            this.colMASACHXB.MinWidth = 30;
            this.colMASACHXB.Name = "colMASACHXB";
            this.colMASACHXB.OptionsColumn.AllowEdit = false;
            this.colMASACHXB.Visible = true;
            this.colMASACHXB.VisibleIndex = 0;
            this.colMASACHXB.Width = 112;
            // 
            // colLAN
            // 
            this.colLAN.FieldName = "LAN";
            this.colLAN.MinWidth = 30;
            this.colLAN.Name = "colLAN";
            this.colLAN.OptionsColumn.AllowEdit = false;
            this.colLAN.Visible = true;
            this.colLAN.VisibleIndex = 1;
            this.colLAN.Width = 112;
            // 
            // colMASACH
            // 
            this.colMASACH.FieldName = "MASACH";
            this.colMASACH.MinWidth = 30;
            this.colMASACH.Name = "colMASACH";
            this.colMASACH.OptionsColumn.AllowEdit = false;
            this.colMASACH.Visible = true;
            this.colMASACH.VisibleIndex = 2;
            this.colMASACH.Width = 112;
            // 
            // colNAM
            // 
            this.colNAM.FieldName = "NAM";
            this.colNAM.MinWidth = 30;
            this.colNAM.Name = "colNAM";
            this.colNAM.OptionsColumn.AllowEdit = false;
            this.colNAM.Visible = true;
            this.colNAM.VisibleIndex = 3;
            this.colNAM.Width = 112;
            // 
            // colKHOGIAY
            // 
            this.colKHOGIAY.FieldName = "KHOGIAY";
            this.colKHOGIAY.MinWidth = 30;
            this.colKHOGIAY.Name = "colKHOGIAY";
            this.colKHOGIAY.OptionsColumn.AllowEdit = false;
            this.colKHOGIAY.Visible = true;
            this.colKHOGIAY.VisibleIndex = 4;
            this.colKHOGIAY.Width = 112;
            // 
            // colSOTRANG
            // 
            this.colSOTRANG.FieldName = "SOTRANG";
            this.colSOTRANG.MinWidth = 30;
            this.colSOTRANG.Name = "colSOTRANG";
            this.colSOTRANG.OptionsColumn.AllowEdit = false;
            this.colSOTRANG.Visible = true;
            this.colSOTRANG.VisibleIndex = 5;
            this.colSOTRANG.Width = 112;
            // 
            // colNHAXB
            // 
            this.colNHAXB.FieldName = "NHAXB";
            this.colNHAXB.MinWidth = 30;
            this.colNHAXB.Name = "colNHAXB";
            this.colNHAXB.OptionsColumn.AllowEdit = false;
            this.colNHAXB.Visible = true;
            this.colNHAXB.VisibleIndex = 6;
            this.colNHAXB.Width = 112;
            // 
            // colGIA
            // 
            this.colGIA.FieldName = "GIA";
            this.colGIA.MinWidth = 30;
            this.colGIA.Name = "colGIA";
            this.colGIA.OptionsColumn.AllowEdit = false;
            this.colGIA.Visible = true;
            this.colGIA.VisibleIndex = 7;
            this.colGIA.Width = 112;
            // 
            // colCD
            // 
            this.colCD.FieldName = "CD";
            this.colCD.MinWidth = 30;
            this.colCD.Name = "colCD";
            this.colCD.OptionsColumn.AllowEdit = false;
            this.colCD.Visible = true;
            this.colCD.VisibleIndex = 8;
            this.colCD.Width = 112;
            // 
            // colSLNHAP
            // 
            this.colSLNHAP.FieldName = "SLNHAP";
            this.colSLNHAP.MinWidth = 30;
            this.colSLNHAP.Name = "colSLNHAP";
            this.colSLNHAP.OptionsColumn.AllowEdit = false;
            this.colSLNHAP.Visible = true;
            this.colSLNHAP.VisibleIndex = 9;
            this.colSLNHAP.Width = 112;
            // 
            // panelControl
            // 
            this.panelControl.Controls.Add(this.txtSLNhap);
            this.panelControl.Controls.Add(this.cmbTuaSach);
            this.panelControl.Controls.Add(sLNHAPLabel);
            this.panelControl.Controls.Add(cDLabel);
            this.panelControl.Controls.Add(this.cbCD);
            this.panelControl.Controls.Add(sOTRANGLabel);
            this.panelControl.Controls.Add(this.txtSoStrang);
            this.panelControl.Controls.Add(gIALabel);
            this.panelControl.Controls.Add(this.txtGia);
            this.panelControl.Controls.Add(lANLabel);
            this.panelControl.Controls.Add(this.txtLan);
            this.panelControl.Controls.Add(nHAXBLabel);
            this.panelControl.Controls.Add(this.txtNhaXB);
            this.panelControl.Controls.Add(kHOGIAYLabel);
            this.panelControl.Controls.Add(this.txtKhoGiay);
            this.panelControl.Controls.Add(nAMLabel);
            this.panelControl.Controls.Add(this.txtNam);
            this.panelControl.Controls.Add(mASACHLabel);
            this.panelControl.Controls.Add(this.txtMaSach);
            this.panelControl.Controls.Add(mASACHXBLabel);
            this.panelControl.Controls.Add(this.txtMaSachXB);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl.Enabled = false;
            this.panelControl.Location = new System.Drawing.Point(0, 360);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(1479, 349);
            this.panelControl.TabIndex = 6;
            // 
            // txtSLNhap
            // 
            this.txtSLNhap.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bdsSachXB, "SLNHAP", true));
            this.txtSLNhap.Location = new System.Drawing.Point(814, 31);
            this.txtSLNhap.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtSLNhap.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtSLNhap.Name = "txtSLNhap";
            this.txtSLNhap.Size = new System.Drawing.Size(105, 27);
            this.txtSLNhap.TabIndex = 21;
            this.txtSLNhap.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cmbTuaSach
            // 
            this.cmbTuaSach.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bdsSachXB, "MASACH", true));
            this.cmbTuaSach.DataSource = this.taiLieuSachBindingSource;
            this.cmbTuaSach.DisplayMember = "TUA";
            this.cmbTuaSach.FormattingEnabled = true;
            this.cmbTuaSach.Location = new System.Drawing.Point(164, 84);
            this.cmbTuaSach.Name = "cmbTuaSach";
            this.cmbTuaSach.Size = new System.Drawing.Size(430, 27);
            this.cmbTuaSach.TabIndex = 20;
            this.cmbTuaSach.ValueMember = "MA";
            this.cmbTuaSach.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // taiLieuSachBindingSource
            // 
            this.taiLieuSachBindingSource.DataMember = "TaiLieu_Sach";
            this.taiLieuSachBindingSource.DataSource = this.thuVienDataSet;
            // 
            // cbCD
            // 
            this.cbCD.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbCD.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bdsSachXB, "CD", true));
            this.cbCD.Location = new System.Drawing.Point(814, 86);
            this.cbCD.Name = "cbCD";
            this.cbCD.Size = new System.Drawing.Size(32, 24);
            this.cbCD.TabIndex = 17;
            this.cbCD.UseVisualStyleBackColor = true;
            // 
            // txtSoStrang
            // 
            this.txtSoStrang.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSachXB, "SOTRANG", true));
            this.txtSoStrang.Location = new System.Drawing.Point(468, 185);
            this.txtSoStrang.MenuManager = this.barManager1;
            this.txtSoStrang.Name = "txtSoStrang";
            this.txtSoStrang.Properties.DisplayFormat.FormatString = "n0";
            this.txtSoStrang.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtSoStrang.Size = new System.Drawing.Size(150, 26);
            this.txtSoStrang.TabIndex = 15;
            // 
            // txtGia
            // 
            this.txtGia.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSachXB, "GIA", true));
            this.txtGia.Location = new System.Drawing.Point(718, 181);
            this.txtGia.MenuManager = this.barManager1;
            this.txtGia.Name = "txtGia";
            this.txtGia.Properties.DisplayFormat.FormatString = "n0";
            this.txtGia.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtGia.Size = new System.Drawing.Size(201, 26);
            this.txtGia.TabIndex = 13;
            // 
            // txtLan
            // 
            this.txtLan.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bdsSachXB, "LAN", true));
            this.txtLan.Location = new System.Drawing.Point(438, 31);
            this.txtLan.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtLan.Name = "txtLan";
            this.txtLan.Size = new System.Drawing.Size(64, 27);
            this.txtLan.TabIndex = 12;
            this.txtLan.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtNhaXB
            // 
            this.txtNhaXB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsSachXB, "NHAXB", true));
            this.txtNhaXB.Location = new System.Drawing.Point(164, 135);
            this.txtNhaXB.Name = "txtNhaXB";
            this.txtNhaXB.Size = new System.Drawing.Size(755, 27);
            this.txtNhaXB.TabIndex = 11;
            // 
            // txtKhoGiay
            // 
            this.txtKhoGiay.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSachXB, "KHOGIAY", true));
            this.txtKhoGiay.Location = new System.Drawing.Point(162, 185);
            this.txtKhoGiay.MenuManager = this.barManager1;
            this.txtKhoGiay.Name = "txtKhoGiay";
            this.txtKhoGiay.Size = new System.Drawing.Size(150, 26);
            this.txtKhoGiay.TabIndex = 9;
            // 
            // txtNam
            // 
            this.txtNam.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSachXB, "NAM", true));
            this.txtNam.Location = new System.Drawing.Point(600, 30);
            this.txtNam.MenuManager = this.barManager1;
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(112, 26);
            this.txtNam.TabIndex = 7;
            // 
            // txtMaSach
            // 
            this.txtMaSach.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSachXB, "MASACH", true));
            this.txtMaSach.Location = new System.Drawing.Point(600, 84);
            this.txtMaSach.MenuManager = this.barManager1;
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Properties.ReadOnly = true;
            this.txtMaSach.Size = new System.Drawing.Size(110, 26);
            this.txtMaSach.TabIndex = 5;
            // 
            // txtMaSachXB
            // 
            this.txtMaSachXB.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSachXB, "MASACHXB", true));
            this.txtMaSachXB.Enabled = false;
            this.txtMaSachXB.Location = new System.Drawing.Point(164, 30);
            this.txtMaSachXB.MenuManager = this.barManager1;
            this.txtMaSachXB.Name = "txtMaSachXB";
            this.txtMaSachXB.Properties.ReadOnly = true;
            this.txtMaSachXB.Size = new System.Drawing.Size(180, 26);
            this.txtMaSachXB.TabIndex = 1;
            // 
            // taiLieu_SachTableAdapter
            // 
            this.taiLieu_SachTableAdapter.ClearBeforeFill = true;
            // 
            // panelSachTV
            // 
            this.panelSachTV.Controls.Add(this.sachTVDataGridView);
            this.panelSachTV.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelSachTV.Location = new System.Drawing.Point(1479, 34);
            this.panelSachTV.Name = "panelSachTV";
            this.panelSachTV.Size = new System.Drawing.Size(445, 675);
            this.panelSachTV.TabIndex = 11;
            // 
            // sachTVDataGridView
            // 
            this.sachTVDataGridView.AllowUserToAddRows = false;
            this.sachTVDataGridView.AllowUserToDeleteRows = false;
            this.sachTVDataGridView.AutoGenerateColumns = false;
            this.sachTVDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sachTVDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.ID_SACH,
            this.MASACHXB});
            this.sachTVDataGridView.ContextMenuStrip = this.contextMenuStrip1;
            this.sachTVDataGridView.DataSource = this.bdsSachTV;
            this.sachTVDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sachTVDataGridView.Location = new System.Drawing.Point(2, 2);
            this.sachTVDataGridView.MultiSelect = false;
            this.sachTVDataGridView.Name = "sachTVDataGridView";
            this.sachTVDataGridView.ReadOnly = true;
            this.sachTVDataGridView.RowHeadersWidth = 62;
            this.sachTVDataGridView.RowTemplate.Height = 28;
            this.sachTVDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.sachTVDataGridView.Size = new System.Drawing.Size(441, 671);
            this.sachTVDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "STT";
            this.dataGridViewTextBoxColumn2.HeaderText = "STT";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TINHTRANG";
            this.dataGridViewTextBoxColumn4.HeaderText = "TINHTRANG";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // ID_SACH
            // 
            this.ID_SACH.DataPropertyName = "ID_SACH";
            this.ID_SACH.HeaderText = "ID_SACH";
            this.ID_SACH.MinimumWidth = 8;
            this.ID_SACH.Name = "ID_SACH";
            this.ID_SACH.ReadOnly = true;
            this.ID_SACH.Visible = false;
            this.ID_SACH.Width = 150;
            // 
            // MASACHXB
            // 
            this.MASACHXB.DataPropertyName = "MASACHXB";
            this.MASACHXB.HeaderText = "MASACHXB";
            this.MASACHXB.MinimumWidth = 8;
            this.MASACHXB.Name = "MASACHXB";
            this.MASACHXB.ReadOnly = true;
            this.MASACHXB.Visible = false;
            this.MASACHXB.Width = 150;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.capNhatToolStripItem,
            this.themToolStripMenuItem,
            this.themNhanhToolStripMenuItem,
            this.xoaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(183, 132);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // capNhatToolStripItem
            // 
            this.capNhatToolStripItem.Name = "capNhatToolStripItem";
            this.capNhatToolStripItem.Size = new System.Drawing.Size(182, 32);
            this.capNhatToolStripItem.Text = "Cập nhật";
            this.capNhatToolStripItem.Click += new System.EventHandler(this.capNhatToolStripItem_Click);
            // 
            // themToolStripMenuItem
            // 
            this.themToolStripMenuItem.Name = "themToolStripMenuItem";
            this.themToolStripMenuItem.Size = new System.Drawing.Size(182, 32);
            this.themToolStripMenuItem.Text = "Thêm";
            this.themToolStripMenuItem.Click += new System.EventHandler(this.themToolStripMenuItem_Click);
            // 
            // themNhanhToolStripMenuItem
            // 
            this.themNhanhToolStripMenuItem.Name = "themNhanhToolStripMenuItem";
            this.themNhanhToolStripMenuItem.Size = new System.Drawing.Size(182, 32);
            this.themNhanhToolStripMenuItem.Text = "Thêm nhanh";
            this.themNhanhToolStripMenuItem.Click += new System.EventHandler(this.themNhanhToolStripMenuItem_Click);
            // 
            // xoaToolStripMenuItem
            // 
            this.xoaToolStripMenuItem.Name = "xoaToolStripMenuItem";
            this.xoaToolStripMenuItem.Size = new System.Drawing.Size(182, 32);
            this.xoaToolStripMenuItem.Text = "Xóa";
            this.xoaToolStripMenuItem.Click += new System.EventHandler(this.xoaToolStripMenuItem_Click);
            // 
            // bdsSachTV
            // 
            this.bdsSachTV.DataMember = "FK_SachTV_SachXB";
            this.bdsSachTV.DataSource = this.bdsSachXB;
            // 
            // sachTVTableAdapter
            // 
            this.sachTVTableAdapter.ClearBeforeFill = true;
            // 
            // bdsSachMuon
            // 
            this.bdsSachMuon.DataMember = "FK_SachMuon_SachTV1";
            this.bdsSachMuon.DataSource = this.bdsSachTV;
            // 
            // sachMuonTableAdapter
            // 
            this.sachMuonTableAdapter.ClearBeforeFill = true;
            // 
            // frmQuanLySachXB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1924, 729);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.sachXBGridControl);
            this.Controls.Add(this.panelSachTV);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmQuanLySachXB";
            this.Text = "Quản lý sách xuất bản";
            this.Load += new System.EventHandler(this.frmQuanLySachXB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thuVienDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSachXB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sachXBGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl)).EndInit();
            this.panelControl.ResumeLayout(false);
            this.panelControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSLNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiLieuSachBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoStrang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKhoGiay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNam.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSach.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSachXB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.virtualServerModeSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelSachTV)).EndInit();
            this.panelSachTV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sachTVDataGridView)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bdsSachTV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSachMuon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private System.Windows.Forms.BindingSource bdsSachXB;
        private ThuVienDataSet thuVienDataSet;
        private ThuVienDataSetTableAdapters.SachXBTableAdapter sachXBTableAdapter;
        private ThuVienDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.PanelControl panelControl;
        private DevExpress.XtraGrid.GridControl sachXBGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit txtMaSachXB;
        private DevExpress.XtraGrid.Columns.GridColumn colMASACHXB;
        private DevExpress.XtraGrid.Columns.GridColumn colLAN;
        private DevExpress.XtraGrid.Columns.GridColumn colMASACH;
        private DevExpress.XtraGrid.Columns.GridColumn colNAM;
        private DevExpress.XtraGrid.Columns.GridColumn colKHOGIAY;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTRANG;
        private DevExpress.XtraGrid.Columns.GridColumn colNHAXB;
        private DevExpress.XtraGrid.Columns.GridColumn colGIA;
        private DevExpress.XtraGrid.Columns.GridColumn colCD;
        private DevExpress.XtraGrid.Columns.GridColumn colSLNHAP;
        private DevExpress.XtraEditors.TextEdit txtKhoGiay;
        private DevExpress.XtraEditors.TextEdit txtNam;
        private DevExpress.XtraEditors.TextEdit txtMaSach;
        private System.Windows.Forms.CheckBox cbCD;
        private DevExpress.XtraEditors.TextEdit txtSoStrang;
        private DevExpress.XtraEditors.TextEdit txtGia;
        private System.Windows.Forms.NumericUpDown txtLan;
        private System.Windows.Forms.TextBox txtNhaXB;
        private System.Windows.Forms.ComboBox cmbTuaSach;
        private ThuVienDataSetTableAdapters.TaiLieu_SachTableAdapter taiLieu_SachTableAdapter;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnCapNhat;
        private DevExpress.XtraBars.BarButtonItem btnUndo;
        private DevExpress.XtraBars.BarButtonItem btnLuu;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private System.Windows.Forms.BindingSource taiLieuSachBindingSource;
        private DevExpress.Data.VirtualServerModeSource virtualServerModeSource1;
        private System.Windows.Forms.NumericUpDown txtSLNhap;
        private DevExpress.XtraEditors.PanelControl panelSachTV;
        private System.Windows.Forms.BindingSource bdsSachTV;
        private ThuVienDataSetTableAdapters.SachTVTableAdapter sachTVTableAdapter;
        private System.Windows.Forms.DataGridView sachTVDataGridView;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem capNhatToolStripItem;
        private System.Windows.Forms.ToolStripMenuItem themToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xoaToolStripMenuItem;
        private System.Windows.Forms.BindingSource bdsSachMuon;
        private ThuVienDataSetTableAdapters.SachMuonTableAdapter sachMuonTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_SACH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MASACHXB;
        private System.Windows.Forms.ToolStripMenuItem themNhanhToolStripMenuItem;
    }
}