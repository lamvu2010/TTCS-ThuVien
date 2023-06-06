namespace ThuVien.Views
{
    partial class frmSachTV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSachTV));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnBorrow = new DevExpress.XtraBars.BarButtonItem();
            this.btnReturn = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.btnExit = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.ThuVienDataSet = new ThuVien.ThuVienDataSet();
            this.bdsSachTV = new System.Windows.Forms.BindingSource(this.components);
            this.VIEW_SACHTVTableAdapter = new ThuVien.ThuVienDataSetTableAdapters.VIEW_SACHTVTableAdapter();
            this.tableAdapterManager = new ThuVien.ThuVienDataSetTableAdapters.TableAdapterManager();
            this.vIEW_SACHTVGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID_SACH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTUA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTACGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLANXB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNAM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNHAXB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTINHTRANG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMUON = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DocGiaPanel = new DevExpress.XtraEditors.PanelControl();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAccess = new System.Windows.Forms.Button();
            this.labelNgayCap = new System.Windows.Forms.Label();
            this.labelPhai = new System.Windows.Forms.Label();
            this.labelNgheNghiep = new System.Windows.Forms.Label();
            this.labelTen = new System.Windows.Forms.Label();
            this.labelSoThe = new System.Windows.Forms.Label();
            this.txtNgayCap = new System.Windows.Forms.TextBox();
            this.txtPhai = new System.Windows.Forms.TextBox();
            this.txtNgheNghiep = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtSoThe = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThuVienDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSachTV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vIEW_SACHTVGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DocGiaPanel)).BeginInit();
            this.DocGiaPanel.SuspendLayout();
            this.SuspendLayout();
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
            this.btnBorrow,
            this.btnReturn,
            this.btnRefresh,
            this.btnExit});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 4;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnBorrow),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnReturn),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRefresh),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnExit)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnBorrow
            // 
            this.btnBorrow.Caption = "Mượn";
            this.btnBorrow.Id = 0;
            this.btnBorrow.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBorrow.ImageOptions.Image")));
            this.btnBorrow.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnBorrow.ImageOptions.LargeImage")));
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnBorrow.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMuon_ItemClick);
            // 
            // btnReturn
            // 
            this.btnReturn.Caption = "Trả";
            this.btnReturn.Id = 1;
            this.btnReturn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReturn.ImageOptions.Image")));
            this.btnReturn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnReturn.ImageOptions.LargeImage")));
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnReturn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReturn_ItemClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Caption = "Làm mới";
            this.btnRefresh.Id = 2;
            this.btnRefresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.ImageOptions.Image")));
            this.btnRefresh.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.ImageOptions.LargeImage")));
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefresh_ItemClick);
            // 
            // btnExit
            // 
            this.btnExit.Caption = "Thoát";
            this.btnExit.Id = 3;
            this.btnExit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.ImageOptions.Image")));
            this.btnExit.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnExit.ImageOptions.LargeImage")));
            this.btnExit.Name = "btnExit";
            this.btnExit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExit_ItemClick);
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
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(2);
            this.barDockControlTop.Size = new System.Drawing.Size(1087, 34);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 770);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(2);
            this.barDockControlBottom.Size = new System.Drawing.Size(1087, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 34);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(2);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 736);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1087, 34);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(2);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 736);
            // 
            // ThuVienDataSet
            // 
            this.ThuVienDataSet.DataSetName = "ThuVienDataSet";
            this.ThuVienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsSachTV
            // 
            this.bdsSachTV.DataMember = "VIEW_SACHTV";
            this.bdsSachTV.DataSource = this.ThuVienDataSet;
            // 
            // VIEW_SACHTVTableAdapter
            // 
            this.VIEW_SACHTVTableAdapter.ClearBeforeFill = true;
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
            // vIEW_SACHTVGridControl
            // 
            this.vIEW_SACHTVGridControl.DataSource = this.bdsSachTV;
            this.vIEW_SACHTVGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.vIEW_SACHTVGridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.vIEW_SACHTVGridControl.Location = new System.Drawing.Point(0, 34);
            this.vIEW_SACHTVGridControl.MainView = this.gridView1;
            this.vIEW_SACHTVGridControl.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.vIEW_SACHTVGridControl.MenuManager = this.barManager1;
            this.vIEW_SACHTVGridControl.Name = "vIEW_SACHTVGridControl";
            this.vIEW_SACHTVGridControl.Size = new System.Drawing.Size(1087, 185);
            this.vIEW_SACHTVGridControl.TabIndex = 5;
            this.vIEW_SACHTVGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.vIEW_SACHTVGridControl.Click += new System.EventHandler(this.vIEW_SACHTVGridControl_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID_SACH,
            this.colSTT,
            this.colTUA,
            this.colTACGIA,
            this.colLANXB,
            this.colNAM,
            this.colNHAXB,
            this.colCD,
            this.colGIA,
            this.colTINHTRANG,
            this.colMUON});
            this.gridView1.DetailHeight = 526;
            this.gridView1.GridControl = this.vIEW_SACHTVGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colID_SACH
            // 
            this.colID_SACH.FieldName = "ID_SACH";
            this.colID_SACH.MinWidth = 45;
            this.colID_SACH.Name = "colID_SACH";
            this.colID_SACH.OptionsColumn.ReadOnly = true;
            this.colID_SACH.Visible = true;
            this.colID_SACH.VisibleIndex = 0;
            this.colID_SACH.Width = 168;
            // 
            // colSTT
            // 
            this.colSTT.FieldName = "STT";
            this.colSTT.MinWidth = 45;
            this.colSTT.Name = "colSTT";
            this.colSTT.OptionsColumn.ReadOnly = true;
            this.colSTT.Visible = true;
            this.colSTT.VisibleIndex = 1;
            this.colSTT.Width = 168;
            // 
            // colTUA
            // 
            this.colTUA.FieldName = "TUA";
            this.colTUA.MinWidth = 45;
            this.colTUA.Name = "colTUA";
            this.colTUA.OptionsColumn.ReadOnly = true;
            this.colTUA.Visible = true;
            this.colTUA.VisibleIndex = 2;
            this.colTUA.Width = 168;
            // 
            // colTACGIA
            // 
            this.colTACGIA.FieldName = "TACGIA";
            this.colTACGIA.MinWidth = 45;
            this.colTACGIA.Name = "colTACGIA";
            this.colTACGIA.OptionsColumn.ReadOnly = true;
            this.colTACGIA.Visible = true;
            this.colTACGIA.VisibleIndex = 3;
            this.colTACGIA.Width = 168;
            // 
            // colLANXB
            // 
            this.colLANXB.FieldName = "LANXB";
            this.colLANXB.MinWidth = 45;
            this.colLANXB.Name = "colLANXB";
            this.colLANXB.OptionsColumn.ReadOnly = true;
            this.colLANXB.Visible = true;
            this.colLANXB.VisibleIndex = 4;
            this.colLANXB.Width = 168;
            // 
            // colNAM
            // 
            this.colNAM.FieldName = "NAM";
            this.colNAM.MinWidth = 45;
            this.colNAM.Name = "colNAM";
            this.colNAM.OptionsColumn.ReadOnly = true;
            this.colNAM.Visible = true;
            this.colNAM.VisibleIndex = 5;
            this.colNAM.Width = 168;
            // 
            // colNHAXB
            // 
            this.colNHAXB.FieldName = "NHAXB";
            this.colNHAXB.MinWidth = 45;
            this.colNHAXB.Name = "colNHAXB";
            this.colNHAXB.OptionsColumn.ReadOnly = true;
            this.colNHAXB.Visible = true;
            this.colNHAXB.VisibleIndex = 6;
            this.colNHAXB.Width = 168;
            // 
            // colCD
            // 
            this.colCD.FieldName = "CD";
            this.colCD.MinWidth = 45;
            this.colCD.Name = "colCD";
            this.colCD.OptionsColumn.ReadOnly = true;
            this.colCD.Visible = true;
            this.colCD.VisibleIndex = 7;
            this.colCD.Width = 168;
            // 
            // colGIA
            // 
            this.colGIA.FieldName = "GIA";
            this.colGIA.MinWidth = 45;
            this.colGIA.Name = "colGIA";
            this.colGIA.OptionsColumn.ReadOnly = true;
            this.colGIA.Visible = true;
            this.colGIA.VisibleIndex = 8;
            this.colGIA.Width = 168;
            // 
            // colTINHTRANG
            // 
            this.colTINHTRANG.FieldName = "TINHTRANG";
            this.colTINHTRANG.MinWidth = 45;
            this.colTINHTRANG.Name = "colTINHTRANG";
            this.colTINHTRANG.OptionsColumn.ReadOnly = true;
            this.colTINHTRANG.Visible = true;
            this.colTINHTRANG.VisibleIndex = 9;
            this.colTINHTRANG.Width = 168;
            // 
            // colMUON
            // 
            this.colMUON.FieldName = "MUON";
            this.colMUON.MinWidth = 45;
            this.colMUON.Name = "colMUON";
            this.colMUON.OptionsColumn.ReadOnly = true;
            this.colMUON.Visible = true;
            this.colMUON.VisibleIndex = 10;
            this.colMUON.Width = 168;
            // 
            // DocGiaPanel
            // 
            this.DocGiaPanel.AutoSize = true;
            this.DocGiaPanel.Controls.Add(this.btnCancel);
            this.DocGiaPanel.Controls.Add(this.btnAccess);
            this.DocGiaPanel.Controls.Add(this.labelNgayCap);
            this.DocGiaPanel.Controls.Add(this.labelPhai);
            this.DocGiaPanel.Controls.Add(this.labelNgheNghiep);
            this.DocGiaPanel.Controls.Add(this.labelTen);
            this.DocGiaPanel.Controls.Add(this.labelSoThe);
            this.DocGiaPanel.Controls.Add(this.txtNgayCap);
            this.DocGiaPanel.Controls.Add(this.txtPhai);
            this.DocGiaPanel.Controls.Add(this.txtNgheNghiep);
            this.DocGiaPanel.Controls.Add(this.txtTen);
            this.DocGiaPanel.Controls.Add(this.txtSoThe);
            this.DocGiaPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DocGiaPanel.Location = new System.Drawing.Point(0, 219);
            this.DocGiaPanel.Margin = new System.Windows.Forms.Padding(2);
            this.DocGiaPanel.Name = "DocGiaPanel";
            this.DocGiaPanel.Size = new System.Drawing.Size(1087, 551);
            this.DocGiaPanel.TabIndex = 10;
            this.DocGiaPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.DocGiaPanel_Paint);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(706, 34);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 39);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAccess
            // 
            this.btnAccess.Location = new System.Drawing.Point(556, 34);
            this.btnAccess.Margin = new System.Windows.Forms.Padding(2);
            this.btnAccess.Name = "btnAccess";
            this.btnAccess.Size = new System.Drawing.Size(95, 39);
            this.btnAccess.TabIndex = 10;
            this.btnAccess.Text = "Truy cập";
            this.btnAccess.UseVisualStyleBackColor = true;
            this.btnAccess.Click += new System.EventHandler(this.btnAccess_Click);
            // 
            // labelNgayCap
            // 
            this.labelNgayCap.AutoSize = true;
            this.labelNgayCap.Location = new System.Drawing.Point(552, 166);
            this.labelNgayCap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNgayCap.Name = "labelNgayCap";
            this.labelNgayCap.Size = new System.Drawing.Size(80, 19);
            this.labelNgayCap.TabIndex = 9;
            this.labelNgayCap.Text = "Ngày cấp:";
            // 
            // labelPhai
            // 
            this.labelPhai.AutoSize = true;
            this.labelPhai.Location = new System.Drawing.Point(357, 166);
            this.labelPhai.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPhai.Name = "labelPhai";
            this.labelPhai.Size = new System.Drawing.Size(50, 19);
            this.labelPhai.TabIndex = 8;
            this.labelPhai.Text = "Phái: ";
            // 
            // labelNgheNghiep
            // 
            this.labelNgheNghiep.AutoSize = true;
            this.labelNgheNghiep.Location = new System.Drawing.Point(64, 166);
            this.labelNgheNghiep.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNgheNghiep.Name = "labelNgheNghiep";
            this.labelNgheNghiep.Size = new System.Drawing.Size(105, 19);
            this.labelNgheNghiep.TabIndex = 7;
            this.labelNgheNghiep.Text = "Nghề nghiệp:";
            // 
            // labelTen
            // 
            this.labelTen.AutoSize = true;
            this.labelTen.Location = new System.Drawing.Point(86, 105);
            this.labelTen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTen.Name = "labelTen";
            this.labelTen.Size = new System.Drawing.Size(83, 19);
            this.labelTen.TabIndex = 6;
            this.labelTen.Text = "Họ và tên:";
            // 
            // labelSoThe
            // 
            this.labelSoThe.AutoSize = true;
            this.labelSoThe.Location = new System.Drawing.Point(104, 49);
            this.labelSoThe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSoThe.Name = "labelSoThe";
            this.labelSoThe.Size = new System.Drawing.Size(65, 19);
            this.labelSoThe.TabIndex = 5;
            this.labelSoThe.Text = "Số thẻ: ";
            // 
            // txtNgayCap
            // 
            this.txtNgayCap.Location = new System.Drawing.Point(638, 163);
            this.txtNgayCap.Margin = new System.Windows.Forms.Padding(2);
            this.txtNgayCap.Name = "txtNgayCap";
            this.txtNgayCap.ReadOnly = true;
            this.txtNgayCap.Size = new System.Drawing.Size(215, 27);
            this.txtNgayCap.TabIndex = 4;
            // 
            // txtPhai
            // 
            this.txtPhai.Location = new System.Drawing.Point(413, 163);
            this.txtPhai.Margin = new System.Windows.Forms.Padding(2);
            this.txtPhai.Name = "txtPhai";
            this.txtPhai.ReadOnly = true;
            this.txtPhai.Size = new System.Drawing.Size(101, 27);
            this.txtPhai.TabIndex = 3;
            // 
            // txtNgheNghiep
            // 
            this.txtNgheNghiep.Location = new System.Drawing.Point(175, 163);
            this.txtNgheNghiep.Margin = new System.Windows.Forms.Padding(2);
            this.txtNgheNghiep.Name = "txtNgheNghiep";
            this.txtNgheNghiep.ReadOnly = true;
            this.txtNgheNghiep.Size = new System.Drawing.Size(153, 27);
            this.txtNgheNghiep.TabIndex = 2;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(175, 103);
            this.txtTen.Margin = new System.Windows.Forms.Padding(2);
            this.txtTen.Name = "txtTen";
            this.txtTen.ReadOnly = true;
            this.txtTen.Size = new System.Drawing.Size(258, 27);
            this.txtTen.TabIndex = 1;
            // 
            // txtSoThe
            // 
            this.txtSoThe.Location = new System.Drawing.Point(175, 46);
            this.txtSoThe.Margin = new System.Windows.Forms.Padding(2);
            this.txtSoThe.Name = "txtSoThe";
            this.txtSoThe.Size = new System.Drawing.Size(258, 27);
            this.txtSoThe.TabIndex = 0;
            // 
            // frmSachTV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 790);
            this.Controls.Add(this.DocGiaPanel);
            this.Controls.Add(this.vIEW_SACHTVGridControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "frmSachTV";
            this.Text = "Sách thư viện";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThuVienDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSachTV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vIEW_SACHTVGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DocGiaPanel)).EndInit();
            this.DocGiaPanel.ResumeLayout(false);
            this.DocGiaPanel.PerformLayout();
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
        private DevExpress.XtraBars.BarButtonItem btnBorrow;
        private DevExpress.XtraBars.BarButtonItem btnReturn;
        private System.Windows.Forms.BindingSource bdsSachTV;
        private ThuVienDataSet ThuVienDataSet;
        private ThuVienDataSetTableAdapters.VIEW_SACHTVTableAdapter VIEW_SACHTVTableAdapter;
        private ThuVienDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl vIEW_SACHTVGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colID_SACH;
        private DevExpress.XtraGrid.Columns.GridColumn colSTT;
        private DevExpress.XtraGrid.Columns.GridColumn colTUA;
        private DevExpress.XtraGrid.Columns.GridColumn colTACGIA;
        private DevExpress.XtraGrid.Columns.GridColumn colLANXB;
        private DevExpress.XtraGrid.Columns.GridColumn colNAM;
        private DevExpress.XtraGrid.Columns.GridColumn colNHAXB;
        private DevExpress.XtraGrid.Columns.GridColumn colCD;
        private DevExpress.XtraGrid.Columns.GridColumn colGIA;
        private DevExpress.XtraGrid.Columns.GridColumn colTINHTRANG;
        private DevExpress.XtraGrid.Columns.GridColumn colMUON;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        private DevExpress.XtraBars.BarButtonItem btnExit;
        private DevExpress.XtraEditors.PanelControl DocGiaPanel;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAccess;
        private System.Windows.Forms.Label labelNgayCap;
        private System.Windows.Forms.Label labelPhai;
        private System.Windows.Forms.Label labelNgheNghiep;
        private System.Windows.Forms.Label labelTen;
        private System.Windows.Forms.Label labelSoThe;
        private System.Windows.Forms.TextBox txtNgayCap;
        private System.Windows.Forms.TextBox txtPhai;
        private System.Windows.Forms.TextBox txtNgheNghiep;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtSoThe;
    }
}