
namespace ThuVien.Views
{
    partial class frmQuanLySach
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
            System.Windows.Forms.Label mALabel;
            System.Windows.Forms.Label tUALabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLySach));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barButtonThem = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonXoa = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonCapNhat = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonTaiLai = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonThoat = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.pnSach = new DevExpress.XtraEditors.PanelControl();
            this.taiLieu_SachGridControl = new DevExpress.XtraGrid.GridControl();
            this.bdsTaiLieu_Sach = new System.Windows.Forms.BindingSource(this.components);
            this.thuVienDataSet = new ThuVien.ThuVienDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.a = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pnQuanLySach = new DevExpress.XtraEditors.PanelControl();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.txtTuaSach = new DevExpress.XtraEditors.TextEdit();
            this.txtMaSach = new DevExpress.XtraEditors.TextEdit();
            this.groupControlTG = new DevExpress.XtraEditors.GroupControl();
            this.chiTietSach_TacGiaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemThem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.bdsChiTietSach_TacGia = new System.Windows.Forms.BindingSource(this.components);
            this.pnQuanLyTacGia = new DevExpress.XtraEditors.PanelControl();
            this.btnHuyTG = new DevExpress.XtraEditors.SimpleButton();
            this.btnXacNhan = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaTG = new DevExpress.XtraEditors.TextEdit();
            this.cmbTenTG = new System.Windows.Forms.ComboBox();
            this.bdsTacGia = new System.Windows.Forms.BindingSource(this.components);
            this.taiLieu_SachTableAdapter = new ThuVien.ThuVienDataSetTableAdapters.TaiLieu_SachTableAdapter();
            this.tableAdapterManager = new ThuVien.ThuVienDataSetTableAdapters.TableAdapterManager();
            this.chiTietSach_TacGiaTableAdapter = new ThuVien.ThuVienDataSetTableAdapters.ChiTietSach_TacGiaTableAdapter();
            this.tacGiaTableAdapter = new ThuVien.ThuVienDataSetTableAdapters.TacGiaTableAdapter();
            mALabel = new System.Windows.Forms.Label();
            tUALabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnSach)).BeginInit();
            this.pnSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taiLieu_SachGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTaiLieu_Sach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thuVienDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnQuanLySach)).BeginInit();
            this.pnQuanLySach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTuaSach.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSach.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlTG)).BeginInit();
            this.groupControlTG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietSach_TacGiaDataGridView)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsChiTietSach_TacGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnQuanLyTacGia)).BeginInit();
            this.pnQuanLyTacGia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaTG.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTacGia)).BeginInit();
            this.SuspendLayout();
            // 
            // mALabel
            // 
            mALabel.AutoSize = true;
            mALabel.Location = new System.Drawing.Point(91, 39);
            mALabel.Name = "mALabel";
            mALabel.Size = new System.Drawing.Size(38, 19);
            mALabel.TabIndex = 0;
            mALabel.Text = "MA:";
            // 
            // tUALabel
            // 
            tUALabel.AutoSize = true;
            tUALabel.Location = new System.Drawing.Point(347, 39);
            tUALabel.Name = "tUALabel";
            tUALabel.Size = new System.Drawing.Size(47, 19);
            tUALabel.TabIndex = 2;
            tUALabel.Text = "TUA:";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonThem,
            this.barButtonXoa,
            this.barButtonCapNhat,
            this.barButtonTaiLai,
            this.barButtonThoat});
            this.barManager1.MaxItemId = 5;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonThem),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonXoa),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonCapNhat),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonTaiLai),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonThoat)});
            this.bar1.Text = "Tools";
            // 
            // barButtonThem
            // 
            this.barButtonThem.Caption = "Thêm sách";
            this.barButtonThem.Id = 0;
            this.barButtonThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonThem.ImageOptions.Image")));
            this.barButtonThem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonThem.ImageOptions.LargeImage")));
            this.barButtonThem.Name = "barButtonThem";
            this.barButtonThem.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonThem_ItemClick);
            // 
            // barButtonXoa
            // 
            this.barButtonXoa.Caption = "Xóa sách";
            this.barButtonXoa.Id = 1;
            this.barButtonXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonXoa.ImageOptions.Image")));
            this.barButtonXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonXoa.ImageOptions.LargeImage")));
            this.barButtonXoa.Name = "barButtonXoa";
            this.barButtonXoa.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonXoa_ItemClick);
            // 
            // barButtonCapNhat
            // 
            this.barButtonCapNhat.Caption = "Cập nhật";
            this.barButtonCapNhat.Id = 2;
            this.barButtonCapNhat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonCapNhat.ImageOptions.Image")));
            this.barButtonCapNhat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonCapNhat.ImageOptions.LargeImage")));
            this.barButtonCapNhat.Name = "barButtonCapNhat";
            this.barButtonCapNhat.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonCapNhat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonCapNhat_ItemClick);
            // 
            // barButtonTaiLai
            // 
            this.barButtonTaiLai.Caption = "Tải lại";
            this.barButtonTaiLai.Id = 3;
            this.barButtonTaiLai.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonTaiLai.ImageOptions.Image")));
            this.barButtonTaiLai.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonTaiLai.ImageOptions.LargeImage")));
            this.barButtonTaiLai.Name = "barButtonTaiLai";
            this.barButtonTaiLai.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonTaiLai.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonTaiLai_ItemClick);
            // 
            // barButtonThoat
            // 
            this.barButtonThoat.Caption = "Thoát";
            this.barButtonThoat.Id = 4;
            this.barButtonThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonThoat.ImageOptions.Image")));
            this.barButtonThoat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonThoat.ImageOptions.LargeImage")));
            this.barButtonThoat.Name = "barButtonThoat";
            this.barButtonThoat.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonThoat_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1418, 34);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 563);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1418, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 34);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 529);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1418, 34);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 529);
            // 
            // pnSach
            // 
            this.pnSach.Controls.Add(this.taiLieu_SachGridControl);
            this.pnSach.Controls.Add(this.pnQuanLySach);
            this.pnSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnSach.Location = new System.Drawing.Point(0, 34);
            this.pnSach.Name = "pnSach";
            this.pnSach.Size = new System.Drawing.Size(813, 529);
            this.pnSach.TabIndex = 4;
            // 
            // taiLieu_SachGridControl
            // 
            this.taiLieu_SachGridControl.DataSource = this.bdsTaiLieu_Sach;
            this.taiLieu_SachGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.taiLieu_SachGridControl.Location = new System.Drawing.Point(2, 2);
            this.taiLieu_SachGridControl.MainView = this.gridView1;
            this.taiLieu_SachGridControl.MenuManager = this.barManager1;
            this.taiLieu_SachGridControl.Name = "taiLieu_SachGridControl";
            this.taiLieu_SachGridControl.Size = new System.Drawing.Size(809, 366);
            this.taiLieu_SachGridControl.TabIndex = 0;
            this.taiLieu_SachGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.taiLieu_SachGridControl.Click += new System.EventHandler(this.taiLieu_SachGridControl_Click);
            // 
            // bdsTaiLieu_Sach
            // 
            this.bdsTaiLieu_Sach.DataMember = "TaiLieu_Sach";
            this.bdsTaiLieu_Sach.DataSource = this.thuVienDataSet;
            // 
            // thuVienDataSet
            // 
            this.thuVienDataSet.DataSetName = "ThuVienDataSet";
            this.thuVienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMA,
            this.a});
            this.gridView1.GridControl = this.taiLieu_SachGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colMA
            // 
            this.colMA.FieldName = "MA";
            this.colMA.MinWidth = 30;
            this.colMA.Name = "colMA";
            this.colMA.OptionsColumn.AllowEdit = false;
            this.colMA.Visible = true;
            this.colMA.VisibleIndex = 0;
            this.colMA.Width = 112;
            // 
            // a
            // 
            this.a.FieldName = "TUA";
            this.a.MinWidth = 30;
            this.a.Name = "a";
            this.a.OptionsColumn.AllowEdit = false;
            this.a.Visible = true;
            this.a.VisibleIndex = 1;
            this.a.Width = 112;
            // 
            // pnQuanLySach
            // 
            this.pnQuanLySach.Controls.Add(this.btnHuy);
            this.pnQuanLySach.Controls.Add(this.btnLuu);
            this.pnQuanLySach.Controls.Add(tUALabel);
            this.pnQuanLySach.Controls.Add(this.txtTuaSach);
            this.pnQuanLySach.Controls.Add(mALabel);
            this.pnQuanLySach.Controls.Add(this.txtMaSach);
            this.pnQuanLySach.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnQuanLySach.Enabled = false;
            this.pnQuanLySach.Location = new System.Drawing.Point(2, 368);
            this.pnQuanLySach.Name = "pnQuanLySach";
            this.pnQuanLySach.Size = new System.Drawing.Size(809, 159);
            this.pnQuanLySach.TabIndex = 1;
            this.pnQuanLySach.Paint += new System.Windows.Forms.PaintEventHandler(this.pnQuanLySach_Paint);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(376, 94);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(110, 34);
            this.btnHuy.TabIndex = 5;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(213, 94);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(129, 34);
            this.btnLuu.TabIndex = 4;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtTuaSach
            // 
            this.txtTuaSach.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsTaiLieu_Sach, "TUA", true));
            this.txtTuaSach.Location = new System.Drawing.Point(400, 36);
            this.txtTuaSach.MenuManager = this.barManager1;
            this.txtTuaSach.Name = "txtTuaSach";
            this.txtTuaSach.Size = new System.Drawing.Size(280, 26);
            this.txtTuaSach.TabIndex = 3;
            // 
            // txtMaSach
            // 
            this.txtMaSach.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsTaiLieu_Sach, "MA", true));
            this.txtMaSach.Enabled = false;
            this.txtMaSach.Location = new System.Drawing.Point(135, 36);
            this.txtMaSach.MenuManager = this.barManager1;
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Properties.ReadOnly = true;
            this.txtMaSach.Size = new System.Drawing.Size(150, 26);
            this.txtMaSach.TabIndex = 1;
            // 
            // groupControlTG
            // 
            this.groupControlTG.Controls.Add(this.chiTietSach_TacGiaDataGridView);
            this.groupControlTG.Controls.Add(this.pnQuanLyTacGia);
            this.groupControlTG.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupControlTG.Location = new System.Drawing.Point(813, 34);
            this.groupControlTG.Name = "groupControlTG";
            this.groupControlTG.Size = new System.Drawing.Size(605, 529);
            this.groupControlTG.TabIndex = 5;
            this.groupControlTG.Text = "Tác giả";
            // 
            // chiTietSach_TacGiaDataGridView
            // 
            this.chiTietSach_TacGiaDataGridView.AllowUserToAddRows = false;
            this.chiTietSach_TacGiaDataGridView.AllowUserToDeleteRows = false;
            this.chiTietSach_TacGiaDataGridView.AutoGenerateColumns = false;
            this.chiTietSach_TacGiaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.chiTietSach_TacGiaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.chiTietSach_TacGiaDataGridView.ContextMenuStrip = this.contextMenuStrip1;
            this.chiTietSach_TacGiaDataGridView.DataSource = this.bdsChiTietSach_TacGia;
            this.chiTietSach_TacGiaDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chiTietSach_TacGiaDataGridView.Location = new System.Drawing.Point(2, 34);
            this.chiTietSach_TacGiaDataGridView.Name = "chiTietSach_TacGiaDataGridView";
            this.chiTietSach_TacGiaDataGridView.ReadOnly = true;
            this.chiTietSach_TacGiaDataGridView.RowHeadersWidth = 62;
            this.chiTietSach_TacGiaDataGridView.RowTemplate.Height = 28;
            this.chiTietSach_TacGiaDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.chiTietSach_TacGiaDataGridView.Size = new System.Drawing.Size(601, 334);
            this.chiTietSach_TacGiaDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MATG";
            this.dataGridViewTextBoxColumn2.HeaderText = "MATG";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TEN";
            this.dataGridViewTextBoxColumn3.HeaderText = "TEN";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "NAMSINH";
            this.dataGridViewTextBoxColumn4.HeaderText = "NAMSINH";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemThem,
            this.toolStripMenuItemXoa});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(186, 68);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // toolStripMenuItemThem
            // 
            this.toolStripMenuItemThem.Name = "toolStripMenuItemThem";
            this.toolStripMenuItemThem.Size = new System.Drawing.Size(185, 32);
            this.toolStripMenuItemThem.Text = "Thêm tác giả";
            this.toolStripMenuItemThem.Click += new System.EventHandler(this.toolStripMenuItemThem_Click);
            // 
            // toolStripMenuItemXoa
            // 
            this.toolStripMenuItemXoa.Name = "toolStripMenuItemXoa";
            this.toolStripMenuItemXoa.Size = new System.Drawing.Size(185, 32);
            this.toolStripMenuItemXoa.Text = "Xóa";
            this.toolStripMenuItemXoa.Click += new System.EventHandler(this.toolStripMenuItemXoa_Click);
            // 
            // bdsChiTietSach_TacGia
            // 
            this.bdsChiTietSach_TacGia.DataMember = "FK_TaiLieu_Sach_ChiTietSach_TacGia";
            this.bdsChiTietSach_TacGia.DataSource = this.bdsTaiLieu_Sach;
            // 
            // pnQuanLyTacGia
            // 
            this.pnQuanLyTacGia.Controls.Add(this.btnHuyTG);
            this.pnQuanLyTacGia.Controls.Add(this.btnXacNhan);
            this.pnQuanLyTacGia.Controls.Add(this.label1);
            this.pnQuanLyTacGia.Controls.Add(this.txtMaTG);
            this.pnQuanLyTacGia.Controls.Add(this.cmbTenTG);
            this.pnQuanLyTacGia.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnQuanLyTacGia.Enabled = false;
            this.pnQuanLyTacGia.Location = new System.Drawing.Point(2, 368);
            this.pnQuanLyTacGia.Name = "pnQuanLyTacGia";
            this.pnQuanLyTacGia.Size = new System.Drawing.Size(601, 159);
            this.pnQuanLyTacGia.TabIndex = 1;
            // 
            // btnHuyTG
            // 
            this.btnHuyTG.Location = new System.Drawing.Point(356, 94);
            this.btnHuyTG.Name = "btnHuyTG";
            this.btnHuyTG.Size = new System.Drawing.Size(112, 34);
            this.btnHuyTG.TabIndex = 4;
            this.btnHuyTG.Text = "Hủy";
            this.btnHuyTG.Click += new System.EventHandler(this.btnHuyTG_Click);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Location = new System.Drawing.Point(223, 94);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(112, 34);
            this.btnXacNhan.TabIndex = 3;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tác giả";
            // 
            // txtMaTG
            // 
            this.txtMaTG.Location = new System.Drawing.Point(104, 34);
            this.txtMaTG.MenuManager = this.barManager1;
            this.txtMaTG.Name = "txtMaTG";
            this.txtMaTG.Properties.ReadOnly = true;
            this.txtMaTG.Size = new System.Drawing.Size(139, 26);
            this.txtMaTG.TabIndex = 1;
            // 
            // cmbTenTG
            // 
            this.cmbTenTG.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bdsChiTietSach_TacGia, "MATG", true));
            this.cmbTenTG.DataSource = this.bdsTacGia;
            this.cmbTenTG.DisplayMember = "TEN";
            this.cmbTenTG.FormattingEnabled = true;
            this.cmbTenTG.Location = new System.Drawing.Point(249, 33);
            this.cmbTenTG.Name = "cmbTenTG";
            this.cmbTenTG.Size = new System.Drawing.Size(252, 27);
            this.cmbTenTG.TabIndex = 0;
            this.cmbTenTG.ValueMember = "MATG";
            this.cmbTenTG.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.cmbTenTG.SelectedValueChanged += new System.EventHandler(this.cmbTuaTG_SelectedValueChanged);
            // 
            // bdsTacGia
            // 
            this.bdsTacGia.DataMember = "TacGia";
            this.bdsTacGia.DataSource = this.thuVienDataSet;
            // 
            // taiLieu_SachTableAdapter
            // 
            this.taiLieu_SachTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BaoMuonTableAdapter = null;
            this.tableAdapterManager.BaoPHTableAdapter = null;
            this.tableAdapterManager.BaoTVTableAdapter = null;
            this.tableAdapterManager.ChiTietTacGiaTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.DocGiaTableAdapter = null;
            this.tableAdapterManager.SachMuonTableAdapter = null;
            this.tableAdapterManager.SachTVTableAdapter = null;
            this.tableAdapterManager.SachXBTableAdapter = null;
            this.tableAdapterManager.TacGiaTableAdapter = null;
            this.tableAdapterManager.TaiLieuTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ThuVien.ThuVienDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // chiTietSach_TacGiaTableAdapter
            // 
            this.chiTietSach_TacGiaTableAdapter.ClearBeforeFill = true;
            // 
            // tacGiaTableAdapter
            // 
            this.tacGiaTableAdapter.ClearBeforeFill = true;
            // 
            // frmQuanLySach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1418, 563);
            this.Controls.Add(this.pnSach);
            this.Controls.Add(this.groupControlTG);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmQuanLySach";
            this.Text = "Quản lý sách";
            this.Load += new System.EventHandler(this.frmQuanLySach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnSach)).EndInit();
            this.pnSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.taiLieu_SachGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTaiLieu_Sach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thuVienDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnQuanLySach)).EndInit();
            this.pnQuanLySach.ResumeLayout(false);
            this.pnQuanLySach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTuaSach.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSach.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlTG)).EndInit();
            this.groupControlTG.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chiTietSach_TacGiaDataGridView)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bdsChiTietSach_TacGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnQuanLyTacGia)).EndInit();
            this.pnQuanLyTacGia.ResumeLayout(false);
            this.pnQuanLyTacGia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaTG.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTacGia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem barButtonThem;
        private DevExpress.XtraBars.BarButtonItem barButtonXoa;
        private DevExpress.XtraBars.BarButtonItem barButtonCapNhat;
        private DevExpress.XtraBars.BarButtonItem barButtonTaiLai;
        private DevExpress.XtraBars.BarButtonItem barButtonThoat;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.BindingSource bdsTaiLieu_Sach;
        private ThuVienDataSet thuVienDataSet;
        private DevExpress.XtraEditors.PanelControl pnSach;
        private DevExpress.XtraEditors.GroupControl groupControlTG;
        private ThuVienDataSetTableAdapters.TaiLieu_SachTableAdapter taiLieu_SachTableAdapter;
        private ThuVienDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.PanelControl pnQuanLySach;
        private DevExpress.XtraGrid.GridControl taiLieu_SachGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMA;
        private DevExpress.XtraGrid.Columns.GridColumn a;
        private DevExpress.XtraEditors.TextEdit txtMaSach;
        private DevExpress.XtraEditors.TextEdit txtTuaSach;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private System.Windows.Forms.BindingSource bdsChiTietSach_TacGia;
        private ThuVienDataSetTableAdapters.ChiTietSach_TacGiaTableAdapter chiTietSach_TacGiaTableAdapter;
        private System.Windows.Forms.DataGridView chiTietSach_TacGiaDataGridView;
        private DevExpress.XtraEditors.PanelControl pnQuanLyTacGia;
        private DevExpress.XtraEditors.SimpleButton btnXacNhan;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtMaTG;
        private System.Windows.Forms.ComboBox cmbTenTG;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.BindingSource bdsTacGia;
        private ThuVienDataSetTableAdapters.TacGiaTableAdapter tacGiaTableAdapter;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemThem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemXoa;
        private DevExpress.XtraEditors.SimpleButton btnHuyTG;
    }
}