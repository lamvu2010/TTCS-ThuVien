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
            System.Windows.Forms.Label iD_BAOLabel;
            System.Windows.Forms.Label sLNHAPLabel;
            System.Windows.Forms.Label lANLabel;
            System.Windows.Forms.Label labelSLTON;
            System.Windows.Forms.Label mABAOLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhapBaoTV));
            this.ThuVienDataSet = new ThuVien.ThuVienDataSet();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnTaiLai = new DevExpress.XtraBars.BarButtonItem();
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
            this.grid = new DevExpress.XtraGrid.GridControl();
            this.bdsBaoMuon = new System.Windows.Forms.BindingSource(this.components);
            this.BaoMuonTableAdapter = new ThuVien.ThuVienDataSetTableAdapters.BaoMuonTableAdapter();
            this.panelInput = new DevExpress.XtraEditors.PanelControl();
            this.cmbBao = new System.Windows.Forms.ComboBox();
            this.txtMABAO = new DevExpress.XtraEditors.TextEdit();
            this.txtSLTON = new DevExpress.XtraEditors.SpinEdit();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.txtLAN = new DevExpress.XtraEditors.SpinEdit();
            this.txtSLNHAP = new DevExpress.XtraEditors.SpinEdit();
            this.txtID_BAO = new DevExpress.XtraEditors.TextEdit();
            this.bdsTaiLieu = new System.Windows.Forms.BindingSource(this.components);
            this.TaiLieuTableAdapter = new ThuVien.ThuVienDataSetTableAdapters.TaiLieuTableAdapter();
            iD_BAOLabel = new System.Windows.Forms.Label();
            sLNHAPLabel = new System.Windows.Forms.Label();
            lANLabel = new System.Windows.Forms.Label();
            labelSLTON = new System.Windows.Forms.Label();
            mABAOLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ThuVienDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBaoTV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBaoMuon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelInput)).BeginInit();
            this.panelInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMABAO.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSLTON.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLAN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSLNHAP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID_BAO.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTaiLieu)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_BAOLabel
            // 
            iD_BAOLabel.AutoSize = true;
            iD_BAOLabel.Location = new System.Drawing.Point(82, 71);
            iD_BAOLabel.Name = "iD_BAOLabel";
            iD_BAOLabel.Size = new System.Drawing.Size(63, 19);
            iD_BAOLabel.TabIndex = 2;
            iD_BAOLabel.Text = "ID Báo:";
            // 
            // sLNHAPLabel
            // 
            sLNHAPLabel.AutoSize = true;
            sLNHAPLabel.Location = new System.Drawing.Point(353, 142);
            sLNHAPLabel.Name = "sLNHAPLabel";
            sLNHAPLabel.Size = new System.Drawing.Size(119, 19);
            sLNHAPLabel.TabIndex = 4;
            sLNHAPLabel.Text = "Số lượng nhập:";
            // 
            // lANLabel
            // 
            lANLabel.AutoSize = true;
            lANLabel.Location = new System.Drawing.Point(39, 142);
            lANLabel.Name = "lANLabel";
            lANLabel.Size = new System.Drawing.Size(106, 19);
            lANLabel.TabIndex = 6;
            lANLabel.Text = "Lần xuất bản:";
            // 
            // labelSLTON
            // 
            labelSLTON.AutoSize = true;
            labelSLTON.Location = new System.Drawing.Point(359, 211);
            labelSLTON.Name = "labelSLTON";
            labelSLTON.Size = new System.Drawing.Size(107, 19);
            labelSLTON.TabIndex = 10;
            labelSLTON.Text = "Số lượng tồn:";
            // 
            // mABAOLabel1
            // 
            mABAOLabel1.AutoSize = true;
            mABAOLabel1.Location = new System.Drawing.Point(400, 71);
            mABAOLabel1.Name = "mABAOLabel1";
            mABAOLabel1.Size = new System.Drawing.Size(66, 19);
            mABAOLabel1.TabIndex = 11;
            mABAOLabel1.Text = "Mã báo:";
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
            this.btnReset,
            this.btnTaiLai});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 6;
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnTaiLai, true),
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
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Id = 2;
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.LargeImage")));
            this.btnSua.Name = "btnSua";
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 1;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.LargeImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnTaiLai
            // 
            this.btnTaiLai.Caption = "Tải lại";
            this.btnTaiLai.Id = 5;
            this.btnTaiLai.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTaiLai.ImageOptions.Image")));
            this.btnTaiLai.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTaiLai.ImageOptions.LargeImage")));
            this.btnTaiLai.Name = "btnTaiLai";
            this.btnTaiLai.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnTaiLai.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTaiLai_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 3;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.LargeImage")));
            this.btnThoat.Name = "btnThoat";
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
            this.gridView1.GridControl = this.grid;
            this.gridView1.Name = "gridView1";
            // 
            // colID_BAO
            // 
            this.colID_BAO.FieldName = "ID_BAO";
            this.colID_BAO.MinWidth = 30;
            this.colID_BAO.Name = "colID_BAO";
            this.colID_BAO.OptionsColumn.ReadOnly = true;
            this.colID_BAO.Visible = true;
            this.colID_BAO.VisibleIndex = 0;
            this.colID_BAO.Width = 112;
            // 
            // colMABAO
            // 
            this.colMABAO.FieldName = "MABAO";
            this.colMABAO.MinWidth = 30;
            this.colMABAO.Name = "colMABAO";
            this.colMABAO.OptionsColumn.ReadOnly = true;
            this.colMABAO.Visible = true;
            this.colMABAO.VisibleIndex = 1;
            this.colMABAO.Width = 112;
            // 
            // colLAN
            // 
            this.colLAN.FieldName = "LAN";
            this.colLAN.MinWidth = 30;
            this.colLAN.Name = "colLAN";
            this.colLAN.OptionsColumn.ReadOnly = true;
            this.colLAN.Visible = true;
            this.colLAN.VisibleIndex = 2;
            this.colLAN.Width = 112;
            // 
            // colSLNHAP
            // 
            this.colSLNHAP.FieldName = "SLNHAP";
            this.colSLNHAP.MinWidth = 30;
            this.colSLNHAP.Name = "colSLNHAP";
            this.colSLNHAP.OptionsColumn.ReadOnly = true;
            this.colSLNHAP.Visible = true;
            this.colSLNHAP.VisibleIndex = 3;
            this.colSLNHAP.Width = 112;
            // 
            // colSLTON
            // 
            this.colSLTON.FieldName = "SLTON";
            this.colSLTON.MinWidth = 30;
            this.colSLTON.Name = "colSLTON";
            this.colSLTON.OptionsColumn.ReadOnly = true;
            this.colSLTON.Visible = true;
            this.colSLTON.VisibleIndex = 4;
            this.colSLTON.Width = 112;
            // 
            // grid
            // 
            this.grid.DataSource = this.bdsBaoTV;
            this.grid.Dock = System.Windows.Forms.DockStyle.Top;
            this.grid.Location = new System.Drawing.Point(0, 34);
            this.grid.MainView = this.gridView1;
            this.grid.MenuManager = this.barManager1;
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(1234, 195);
            this.grid.TabIndex = 22;
            this.grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.grid.Click += new System.EventHandler(this.baoTVGridControl_Click);
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
            // panelInput
            // 
            this.panelInput.Controls.Add(this.cmbBao);
            this.panelInput.Controls.Add(mABAOLabel1);
            this.panelInput.Controls.Add(this.txtMABAO);
            this.panelInput.Controls.Add(labelSLTON);
            this.panelInput.Controls.Add(this.txtSLTON);
            this.panelInput.Controls.Add(this.btnHuy);
            this.panelInput.Controls.Add(this.btnXacNhan);
            this.panelInput.Controls.Add(lANLabel);
            this.panelInput.Controls.Add(this.txtLAN);
            this.panelInput.Controls.Add(sLNHAPLabel);
            this.panelInput.Controls.Add(this.txtSLNHAP);
            this.panelInput.Controls.Add(iD_BAOLabel);
            this.panelInput.Controls.Add(this.txtID_BAO);
            this.panelInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInput.Location = new System.Drawing.Point(0, 229);
            this.panelInput.Name = "panelInput";
            this.panelInput.Size = new System.Drawing.Size(1234, 639);
            this.panelInput.TabIndex = 32;
            // 
            // cmbBao
            // 
            this.cmbBao.FormattingEnabled = true;
            this.cmbBao.Location = new System.Drawing.Point(472, 16);
            this.cmbBao.Name = "cmbBao";
            this.cmbBao.Size = new System.Drawing.Size(329, 27);
            this.cmbBao.TabIndex = 13;
            this.cmbBao.SelectedIndexChanged += new System.EventHandler(this.cmbBao_SelectedIndexChanged);
            // 
            // txtMABAO
            // 
            this.txtMABAO.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsBaoTV, "MABAO", true));
            this.txtMABAO.EditValue = "";
            this.txtMABAO.Location = new System.Drawing.Point(472, 64);
            this.txtMABAO.MenuManager = this.barManager1;
            this.txtMABAO.Name = "txtMABAO";
            this.txtMABAO.Properties.ReadOnly = true;
            this.txtMABAO.Size = new System.Drawing.Size(329, 26);
            this.txtMABAO.TabIndex = 12;
            // 
            // txtSLTON
            // 
            this.txtSLTON.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsBaoTV, "SLTON", true));
            this.txtSLTON.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtSLTON.Location = new System.Drawing.Point(472, 207);
            this.txtSLTON.MenuManager = this.barManager1;
            this.txtSLTON.Name = "txtSLTON";
            this.txtSLTON.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtSLTON.Size = new System.Drawing.Size(150, 28);
            this.txtSLTON.TabIndex = 11;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(870, 124);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(98, 42);
            this.btnHuy.TabIndex = 8;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Location = new System.Drawing.Point(870, 48);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(98, 42);
            this.btnXacNhan.TabIndex = 8;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // txtLAN
            // 
            this.txtLAN.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsBaoTV, "LAN", true));
            this.txtLAN.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtLAN.Location = new System.Drawing.Point(157, 138);
            this.txtLAN.MenuManager = this.barManager1;
            this.txtLAN.Name = "txtLAN";
            this.txtLAN.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtLAN.Size = new System.Drawing.Size(150, 28);
            this.txtLAN.TabIndex = 7;
            // 
            // txtSLNHAP
            // 
            this.txtSLNHAP.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsBaoTV, "SLNHAP", true));
            this.txtSLNHAP.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtSLNHAP.Location = new System.Drawing.Point(472, 138);
            this.txtSLNHAP.MenuManager = this.barManager1;
            this.txtSLNHAP.Name = "txtSLNHAP";
            this.txtSLNHAP.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtSLNHAP.Size = new System.Drawing.Size(150, 28);
            this.txtSLNHAP.TabIndex = 5;
            // 
            // txtID_BAO
            // 
            this.txtID_BAO.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsBaoTV, "ID_BAO", true));
            this.txtID_BAO.Location = new System.Drawing.Point(157, 64);
            this.txtID_BAO.MenuManager = this.barManager1;
            this.txtID_BAO.Name = "txtID_BAO";
            this.txtID_BAO.Properties.ReadOnly = true;
            this.txtID_BAO.Size = new System.Drawing.Size(150, 26);
            this.txtID_BAO.TabIndex = 3;
            // 
            // bdsTaiLieu
            // 
            this.bdsTaiLieu.DataMember = "TaiLieu";
            this.bdsTaiLieu.DataSource = this.ThuVienDataSet;
            // 
            // TaiLieuTableAdapter
            // 
            this.TaiLieuTableAdapter.ClearBeforeFill = true;
            // 
            // frmNhapBaoTV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 888);
            this.Controls.Add(this.panelInput);
            this.Controls.Add(this.grid);
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
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBaoMuon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelInput)).EndInit();
            this.panelInput.ResumeLayout(false);
            this.panelInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMABAO.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSLTON.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLAN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSLNHAP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID_BAO.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTaiLieu)).EndInit();
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
        private DevExpress.XtraGrid.GridControl grid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colID_BAO;
        private DevExpress.XtraGrid.Columns.GridColumn colMABAO;
        private DevExpress.XtraGrid.Columns.GridColumn colLAN;
        private DevExpress.XtraGrid.Columns.GridColumn colSLNHAP;
        private DevExpress.XtraGrid.Columns.GridColumn colSLTON;
        private System.Windows.Forms.BindingSource bdsBaoMuon;
        private ThuVienDataSetTableAdapters.BaoMuonTableAdapter BaoMuonTableAdapter;
        private DevExpress.XtraEditors.PanelControl panelInput;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnXacNhan;
        private DevExpress.XtraEditors.SpinEdit txtLAN;
        private DevExpress.XtraEditors.SpinEdit txtSLNHAP;
        private DevExpress.XtraEditors.TextEdit txtID_BAO;
        private DevExpress.XtraEditors.SpinEdit txtSLTON;
        private System.Windows.Forms.ComboBox cmbBao;
        private DevExpress.XtraEditors.TextEdit txtMABAO;
        private System.Windows.Forms.BindingSource bdsTaiLieu;
        private ThuVienDataSetTableAdapters.TaiLieuTableAdapter TaiLieuTableAdapter;
        private DevExpress.XtraBars.BarButtonItem btnTaiLai;
    }
}