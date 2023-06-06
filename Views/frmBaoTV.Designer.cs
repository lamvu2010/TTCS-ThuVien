namespace ThuVien.Views
{
    partial class frmBaoTV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBaoTV));
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
            this.bdsBaoTV = new System.Windows.Forms.BindingSource(this.components);
            this.VIEW_BAOTVTableAdapter = new ThuVien.ThuVienDataSetTableAdapters.VIEW_BAOTVTableAdapter();
            this.tableAdapterManager = new ThuVien.ThuVienDataSetTableAdapters.TableAdapterManager();
            this.vIEW_BAOTVGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID_BAO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTUA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLANPH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNAMPH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDINHKY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNSX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSLTON = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DocGiaPanel = new DevExpress.XtraEditors.PanelControl();
            this.labelNgayCap = new System.Windows.Forms.Label();
            this.labelPhai = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTen = new System.Windows.Forms.Label();
            this.txtNgheNghiep = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtNgayCap = new System.Windows.Forms.TextBox();
            this.txtPhai = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAccess = new System.Windows.Forms.Button();
            this.labelSoThe = new System.Windows.Forms.Label();
            this.txtSoThe = new System.Windows.Forms.TextBox();
            this.thuVienDataSet1 = new ThuVien.ThuVienDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThuVienDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBaoTV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vIEW_BAOTVGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DocGiaPanel)).BeginInit();
            this.DocGiaPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thuVienDataSet1)).BeginInit();
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
            this.btnBorrow.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBorrow_ItemClick);
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
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.barDockControlTop.Size = new System.Drawing.Size(1058, 34);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 541);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.barDockControlBottom.Size = new System.Drawing.Size(1058, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 34);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 507);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1058, 34);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 507);
            // 
            // ThuVienDataSet
            // 
            this.ThuVienDataSet.DataSetName = "ThuVienDataSet";
            this.ThuVienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsBaoTV
            // 
            this.bdsBaoTV.DataMember = "VIEW_BAOTV";
            this.bdsBaoTV.DataSource = this.ThuVienDataSet;
            // 
            // VIEW_BAOTVTableAdapter
            // 
            this.VIEW_BAOTVTableAdapter.ClearBeforeFill = true;
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
            // vIEW_BAOTVGridControl
            // 
            this.vIEW_BAOTVGridControl.DataSource = this.bdsBaoTV;
            this.vIEW_BAOTVGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.vIEW_BAOTVGridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.vIEW_BAOTVGridControl.Location = new System.Drawing.Point(0, 34);
            this.vIEW_BAOTVGridControl.MainView = this.gridView1;
            this.vIEW_BAOTVGridControl.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.vIEW_BAOTVGridControl.MenuManager = this.barManager1;
            this.vIEW_BAOTVGridControl.Name = "vIEW_BAOTVGridControl";
            this.vIEW_BAOTVGridControl.Size = new System.Drawing.Size(1058, 208);
            this.vIEW_BAOTVGridControl.TabIndex = 5;
            this.vIEW_BAOTVGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.vIEW_BAOTVGridControl.Click += new System.EventHandler(this.vIEW_BAOTVGridControl_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID_BAO,
            this.colTUA,
            this.colLANPH,
            this.colNAMPH,
            this.colDINHKY,
            this.colNSX,
            this.colSLTON});
            this.gridView1.DetailHeight = 385;
            this.gridView1.GridControl = this.vIEW_BAOTVGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colID_BAO
            // 
            this.colID_BAO.FieldName = "ID_BAO";
            this.colID_BAO.MinWidth = 37;
            this.colID_BAO.Name = "colID_BAO";
            this.colID_BAO.OptionsColumn.ReadOnly = true;
            this.colID_BAO.Visible = true;
            this.colID_BAO.VisibleIndex = 0;
            this.colID_BAO.Width = 137;
            // 
            // colTUA
            // 
            this.colTUA.FieldName = "TUA";
            this.colTUA.MinWidth = 37;
            this.colTUA.Name = "colTUA";
            this.colTUA.OptionsColumn.ReadOnly = true;
            this.colTUA.Visible = true;
            this.colTUA.VisibleIndex = 1;
            this.colTUA.Width = 137;
            // 
            // colLANPH
            // 
            this.colLANPH.FieldName = "LANPH";
            this.colLANPH.MinWidth = 37;
            this.colLANPH.Name = "colLANPH";
            this.colLANPH.OptionsColumn.ReadOnly = true;
            this.colLANPH.Visible = true;
            this.colLANPH.VisibleIndex = 2;
            this.colLANPH.Width = 137;
            // 
            // colNAMPH
            // 
            this.colNAMPH.FieldName = "NAMPH";
            this.colNAMPH.MinWidth = 37;
            this.colNAMPH.Name = "colNAMPH";
            this.colNAMPH.OptionsColumn.ReadOnly = true;
            this.colNAMPH.Visible = true;
            this.colNAMPH.VisibleIndex = 3;
            this.colNAMPH.Width = 137;
            // 
            // colDINHKY
            // 
            this.colDINHKY.FieldName = "DINHKY";
            this.colDINHKY.MinWidth = 37;
            this.colDINHKY.Name = "colDINHKY";
            this.colDINHKY.OptionsColumn.ReadOnly = true;
            this.colDINHKY.Visible = true;
            this.colDINHKY.VisibleIndex = 4;
            this.colDINHKY.Width = 137;
            // 
            // colNSX
            // 
            this.colNSX.FieldName = "NSX";
            this.colNSX.MinWidth = 37;
            this.colNSX.Name = "colNSX";
            this.colNSX.OptionsColumn.ReadOnly = true;
            this.colNSX.Visible = true;
            this.colNSX.VisibleIndex = 5;
            this.colNSX.Width = 137;
            // 
            // colSLTON
            // 
            this.colSLTON.FieldName = "SLTON";
            this.colSLTON.MinWidth = 37;
            this.colSLTON.Name = "colSLTON";
            this.colSLTON.OptionsColumn.ReadOnly = true;
            this.colSLTON.Visible = true;
            this.colSLTON.VisibleIndex = 6;
            this.colSLTON.Width = 137;
            // 
            // DocGiaPanel
            // 
            this.DocGiaPanel.Controls.Add(this.labelNgayCap);
            this.DocGiaPanel.Controls.Add(this.labelPhai);
            this.DocGiaPanel.Controls.Add(this.label1);
            this.DocGiaPanel.Controls.Add(this.labelTen);
            this.DocGiaPanel.Controls.Add(this.txtNgheNghiep);
            this.DocGiaPanel.Controls.Add(this.txtTen);
            this.DocGiaPanel.Controls.Add(this.txtNgayCap);
            this.DocGiaPanel.Controls.Add(this.txtPhai);
            this.DocGiaPanel.Controls.Add(this.btnCancel);
            this.DocGiaPanel.Controls.Add(this.btnAccess);
            this.DocGiaPanel.Controls.Add(this.labelSoThe);
            this.DocGiaPanel.Controls.Add(this.txtSoThe);
            this.DocGiaPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DocGiaPanel.Location = new System.Drawing.Point(0, 242);
            this.DocGiaPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DocGiaPanel.Name = "DocGiaPanel";
            this.DocGiaPanel.Size = new System.Drawing.Size(1058, 299);
            this.DocGiaPanel.TabIndex = 10;
            // 
            // labelNgayCap
            // 
            this.labelNgayCap.AutoSize = true;
            this.labelNgayCap.Location = new System.Drawing.Point(590, 153);
            this.labelNgayCap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNgayCap.Name = "labelNgayCap";
            this.labelNgayCap.Size = new System.Drawing.Size(80, 19);
            this.labelNgayCap.TabIndex = 11;
            this.labelNgayCap.Text = "Ngày cấp:";
            this.labelNgayCap.Click += new System.EventHandler(this.labelNgayCap_Click);
            // 
            // labelPhai
            // 
            this.labelPhai.AutoSize = true;
            this.labelPhai.Location = new System.Drawing.Point(394, 153);
            this.labelPhai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPhai.Name = "labelPhai";
            this.labelPhai.Size = new System.Drawing.Size(45, 19);
            this.labelPhai.TabIndex = 10;
            this.labelPhai.Text = "Phái:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 153);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nghề nghiệp:";
            // 
            // labelTen
            // 
            this.labelTen.AutoSize = true;
            this.labelTen.Location = new System.Drawing.Point(105, 91);
            this.labelTen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTen.Name = "labelTen";
            this.labelTen.Size = new System.Drawing.Size(83, 19);
            this.labelTen.TabIndex = 8;
            this.labelTen.Text = "Họ và tên:";
            this.labelTen.Click += new System.EventHandler(this.labelTen_Click);
            // 
            // txtNgheNghiep
            // 
            this.txtNgheNghiep.Location = new System.Drawing.Point(196, 150);
            this.txtNgheNghiep.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNgheNghiep.Name = "txtNgheNghiep";
            this.txtNgheNghiep.ReadOnly = true;
            this.txtNgheNghiep.Size = new System.Drawing.Size(165, 27);
            this.txtNgheNghiep.TabIndex = 7;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(196, 88);
            this.txtTen.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTen.Name = "txtTen";
            this.txtTen.ReadOnly = true;
            this.txtTen.Size = new System.Drawing.Size(269, 27);
            this.txtTen.TabIndex = 6;
            // 
            // txtNgayCap
            // 
            this.txtNgayCap.Location = new System.Drawing.Point(678, 150);
            this.txtNgayCap.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNgayCap.Name = "txtNgayCap";
            this.txtNgayCap.ReadOnly = true;
            this.txtNgayCap.Size = new System.Drawing.Size(252, 27);
            this.txtNgayCap.TabIndex = 5;
            // 
            // txtPhai
            // 
            this.txtPhai.Location = new System.Drawing.Point(447, 150);
            this.txtPhai.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPhai.Name = "txtPhai";
            this.txtPhai.ReadOnly = true;
            this.txtPhai.Size = new System.Drawing.Size(87, 27);
            this.txtPhai.TabIndex = 4;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(758, 20);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(116, 40);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Hủy bỏ";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAccess
            // 
            this.btnAccess.Location = new System.Drawing.Point(555, 20);
            this.btnAccess.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAccess.Name = "btnAccess";
            this.btnAccess.Size = new System.Drawing.Size(116, 40);
            this.btnAccess.TabIndex = 2;
            this.btnAccess.Text = "Truy cập";
            this.btnAccess.UseVisualStyleBackColor = true;
            this.btnAccess.Click += new System.EventHandler(this.btnAccess_Click);
            // 
            // labelSoThe
            // 
            this.labelSoThe.AutoSize = true;
            this.labelSoThe.Location = new System.Drawing.Point(123, 33);
            this.labelSoThe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSoThe.Name = "labelSoThe";
            this.labelSoThe.Size = new System.Drawing.Size(65, 19);
            this.labelSoThe.TabIndex = 1;
            this.labelSoThe.Text = "Số thẻ: ";
            this.labelSoThe.Click += new System.EventHandler(this.labelSoThe_Click);
            // 
            // txtSoThe
            // 
            this.txtSoThe.Location = new System.Drawing.Point(196, 30);
            this.txtSoThe.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSoThe.Name = "txtSoThe";
            this.txtSoThe.Size = new System.Drawing.Size(269, 27);
            this.txtSoThe.TabIndex = 0;
            // 
            // thuVienDataSet1
            // 
            this.thuVienDataSet1.DataSetName = "ThuVienDataSet";
            this.thuVienDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frmBaoTV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 561);
            this.Controls.Add(this.DocGiaPanel);
            this.Controls.Add(this.vIEW_BAOTVGridControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmBaoTV";
            this.Text = "Báo thư viện";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmBaoTV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThuVienDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBaoTV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vIEW_BAOTVGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DocGiaPanel)).EndInit();
            this.DocGiaPanel.ResumeLayout(false);
            this.DocGiaPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thuVienDataSet1)).EndInit();
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
        private System.Windows.Forms.BindingSource bdsBaoTV;
        private ThuVienDataSet ThuVienDataSet;
        private ThuVienDataSetTableAdapters.VIEW_BAOTVTableAdapter VIEW_BAOTVTableAdapter;
        private ThuVienDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl vIEW_BAOTVGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colID_BAO;
        private DevExpress.XtraGrid.Columns.GridColumn colTUA;
        private DevExpress.XtraGrid.Columns.GridColumn colLANPH;
        private DevExpress.XtraGrid.Columns.GridColumn colNAMPH;
        private DevExpress.XtraGrid.Columns.GridColumn colDINHKY;
        private DevExpress.XtraGrid.Columns.GridColumn colNSX;
        private DevExpress.XtraGrid.Columns.GridColumn colSLTON;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        private DevExpress.XtraBars.BarButtonItem btnExit;
        private DevExpress.XtraEditors.PanelControl DocGiaPanel;
        private System.Windows.Forms.Label labelSoThe;
        private System.Windows.Forms.TextBox txtSoThe;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAccess;
        private System.Windows.Forms.Label labelTen;
        private System.Windows.Forms.TextBox txtNgheNghiep;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtNgayCap;
        private System.Windows.Forms.TextBox txtPhai;
        private System.Windows.Forms.Label labelNgayCap;
        private System.Windows.Forms.Label labelPhai;
        private System.Windows.Forms.Label label1;
        private ThuVienDataSet thuVienDataSet1;
    }
}