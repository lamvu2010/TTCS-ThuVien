namespace ThuVien.Views
{
    partial class frmDocGia
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
            System.Windows.Forms.Label pHAILabel;
            System.Windows.Forms.Label nGHENGHIEPLabel;
            System.Windows.Forms.Label tENLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDocGia));
            this.label1 = new System.Windows.Forms.Label();
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
            this.ThuVienDataSet = new ThuVien.ThuVienDataSet();
            this.bdsDocGia = new System.Windows.Forms.BindingSource(this.components);
            this.DocGiaTableAdapter = new ThuVien.ThuVienDataSetTableAdapters.DocGiaTableAdapter();
            this.tableAdapterManager = new ThuVien.ThuVienDataSetTableAdapters.TableAdapterManager();
            this.docGiaGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSOTHE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYCAP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGHENGHIEP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPHAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtlogin = new System.Windows.Forms.TextBox();
            this.lblogin = new System.Windows.Forms.Label();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnXacnhan = new DevExpress.XtraEditors.SimpleButton();
            this.cbboxGT = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtNghe = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtSoThe = new System.Windows.Forms.TextBox();
            this.bdsBaoMuon = new System.Windows.Forms.BindingSource(this.components);
            this.baoMuonTableAdapter = new ThuVien.ThuVienDataSetTableAdapters.BaoMuonTableAdapter();
            this.bdsSachMuon = new System.Windows.Forms.BindingSource(this.components);
            this.sachMuonTableAdapter = new ThuVien.ThuVienDataSetTableAdapters.SachMuonTableAdapter();
            this.btnReset = new DevExpress.XtraBars.BarButtonItem();
            pHAILabel = new System.Windows.Forms.Label();
            nGHENGHIEPLabel = new System.Windows.Forms.Label();
            tENLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThuVienDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDocGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docGiaGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbboxGT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBaoMuon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSachMuon)).BeginInit();
            this.SuspendLayout();
            // 
            // pHAILabel
            // 
            pHAILabel.AutoSize = true;
            pHAILabel.Location = new System.Drawing.Point(381, 136);
            pHAILabel.Name = "pHAILabel";
            pHAILabel.Size = new System.Drawing.Size(90, 25);
            pHAILabel.TabIndex = 19;
            pHAILabel.Text = "Giới tính";
            // 
            // nGHENGHIEPLabel
            // 
            nGHENGHIEPLabel.AutoSize = true;
            nGHENGHIEPLabel.Location = new System.Drawing.Point(31, 134);
            nGHENGHIEPLabel.Name = "nGHENGHIEPLabel";
            nGHENGHIEPLabel.Size = new System.Drawing.Size(121, 25);
            nGHENGHIEPLabel.TabIndex = 17;
            nGHENGHIEPLabel.Text = "Nghề nghiệp";
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.Location = new System.Drawing.Point(381, 75);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(97, 25);
            tENLabel.TabIndex = 15;
            tENLabel.Text = "Họ và tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(28, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Số thẻ";
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnReset, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
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
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
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
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Id = 2;
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.LargeImage")));
            this.btnSua.Name = "btnSua";
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(1067, 34);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 683);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1067, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 34);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 649);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1067, 34);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 649);
            // 
            // ThuVienDataSet
            // 
            this.ThuVienDataSet.DataSetName = "ThuVienDataSet";
            this.ThuVienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsDocGia
            // 
            this.bdsDocGia.DataMember = "DocGia";
            this.bdsDocGia.DataSource = this.ThuVienDataSet;
            this.bdsDocGia.CurrentChanged += new System.EventHandler(this.docGiaBindingSource_CurrentChanged);
            // 
            // DocGiaTableAdapter
            // 
            this.DocGiaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BaoMuonTableAdapter = null;
            this.tableAdapterManager.BaoTVTableAdapter = null;
            this.tableAdapterManager.ChiTietTacGiaTableAdapter = null;
            this.tableAdapterManager.DocGiaTableAdapter = this.DocGiaTableAdapter;
            this.tableAdapterManager.SachMuonTableAdapter = null;
            this.tableAdapterManager.SachTVTableAdapter = null;
            this.tableAdapterManager.SachXBTableAdapter = null;
            this.tableAdapterManager.TacGiaTableAdapter = null;
            this.tableAdapterManager.TaiLieuTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ThuVien.ThuVienDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // docGiaGridControl
            // 
            this.docGiaGridControl.DataSource = this.bdsDocGia;
            this.docGiaGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.docGiaGridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.docGiaGridControl.Location = new System.Drawing.Point(0, 34);
            this.docGiaGridControl.MainView = this.gridView1;
            this.docGiaGridControl.Margin = new System.Windows.Forms.Padding(4);
            this.docGiaGridControl.MenuManager = this.barManager1;
            this.docGiaGridControl.Name = "docGiaGridControl";
            this.docGiaGridControl.Size = new System.Drawing.Size(1067, 180);
            this.docGiaGridControl.TabIndex = 5;
            this.docGiaGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSOTHE,
            this.colNGAYCAP,
            this.colTEN,
            this.colNGHENGHIEP,
            this.colPHAI});
            this.gridView1.GridControl = this.docGiaGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colSOTHE
            // 
            this.colSOTHE.FieldName = "SOTHE";
            this.colSOTHE.MinWidth = 30;
            this.colSOTHE.Name = "colSOTHE";
            this.colSOTHE.Visible = true;
            this.colSOTHE.VisibleIndex = 0;
            this.colSOTHE.Width = 112;
            // 
            // colNGAYCAP
            // 
            this.colNGAYCAP.FieldName = "NGAYCAP";
            this.colNGAYCAP.MinWidth = 30;
            this.colNGAYCAP.Name = "colNGAYCAP";
            this.colNGAYCAP.Visible = true;
            this.colNGAYCAP.VisibleIndex = 1;
            this.colNGAYCAP.Width = 112;
            // 
            // colTEN
            // 
            this.colTEN.FieldName = "TEN";
            this.colTEN.MinWidth = 30;
            this.colTEN.Name = "colTEN";
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            this.colTEN.Width = 112;
            // 
            // colNGHENGHIEP
            // 
            this.colNGHENGHIEP.FieldName = "NGHENGHIEP";
            this.colNGHENGHIEP.MinWidth = 30;
            this.colNGHENGHIEP.Name = "colNGHENGHIEP";
            this.colNGHENGHIEP.Visible = true;
            this.colNGHENGHIEP.VisibleIndex = 3;
            this.colNGHENGHIEP.Width = 112;
            // 
            // colPHAI
            // 
            this.colPHAI.FieldName = "PHAI";
            this.colPHAI.MinWidth = 30;
            this.colPHAI.Name = "colPHAI";
            this.colPHAI.Visible = true;
            this.colPHAI.VisibleIndex = 4;
            this.colPHAI.Width = 112;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtlogin);
            this.groupBox1.Controls.Add(this.lblogin);
            this.groupBox1.Controls.Add(this.btnHuy);
            this.groupBox1.Controls.Add(this.btnXacnhan);
            this.groupBox1.Controls.Add(pHAILabel);
            this.groupBox1.Controls.Add(this.cbboxGT);
            this.groupBox1.Controls.Add(nGHENGHIEPLabel);
            this.groupBox1.Controls.Add(this.txtNghe);
            this.groupBox1.Controls.Add(tENLabel);
            this.groupBox1.Controls.Add(this.txtTen);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtSoThe);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(0, 214);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1067, 177);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            this.groupBox1.Visible = false;
            // 
            // txtlogin
            // 
            this.txtlogin.Location = new System.Drawing.Point(191, 67);
            this.txtlogin.Name = "txtlogin";
            this.txtlogin.Size = new System.Drawing.Size(143, 33);
            this.txtlogin.TabIndex = 24;
            this.txtlogin.Visible = false;
            // 
            // lblogin
            // 
            this.lblogin.AutoSize = true;
            this.lblogin.Location = new System.Drawing.Point(28, 70);
            this.lblogin.Name = "lblogin";
            this.lblogin.Size = new System.Drawing.Size(140, 25);
            this.lblogin.TabIndex = 23;
            this.lblogin.Text = "Tên đăng nhập";
            this.lblogin.Visible = false;
            this.lblogin.Click += new System.EventHandler(this.label2_Click);
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
            this.btnHuy.Click += new System.EventHandler(this.simpleButton1_Click_1);
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
            this.btnXacnhan.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // cbboxGT
            // 
            this.cbboxGT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDocGia, "PHAI", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.cbboxGT.Location = new System.Drawing.Point(500, 133);
            this.cbboxGT.Margin = new System.Windows.Forms.Padding(6);
            this.cbboxGT.MenuManager = this.barManager1;
            this.cbboxGT.Name = "cbboxGT";
            this.cbboxGT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbboxGT.Size = new System.Drawing.Size(106, 26);
            this.cbboxGT.TabIndex = 20;
            // 
            // txtNghe
            // 
            this.txtNghe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNghe.Location = new System.Drawing.Point(191, 130);
            this.txtNghe.Name = "txtNghe";
            this.txtNghe.Size = new System.Drawing.Size(133, 33);
            this.txtNghe.TabIndex = 18;
            // 
            // txtTen
            // 
            this.txtTen.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtTen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTen.Location = new System.Drawing.Point(500, 70);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(169, 33);
            this.txtTen.TabIndex = 16;
            // 
            // txtSoThe
            // 
            this.txtSoThe.Location = new System.Drawing.Point(191, 70);
            this.txtSoThe.Name = "txtSoThe";
            this.txtSoThe.Size = new System.Drawing.Size(100, 33);
            this.txtSoThe.TabIndex = 14;
            // 
            // bdsBaoMuon
            // 
            this.bdsBaoMuon.DataMember = "FK_BaoMuon_DocGia";
            this.bdsBaoMuon.DataSource = this.bdsDocGia;
            // 
            // baoMuonTableAdapter
            // 
            this.baoMuonTableAdapter.ClearBeforeFill = true;
            // 
            // bdsSachMuon
            // 
            this.bdsSachMuon.DataMember = "FK_SachMuon_DocGia1";
            this.bdsSachMuon.DataSource = this.bdsDocGia;
            // 
            // sachMuonTableAdapter
            // 
            this.sachMuonTableAdapter.ClearBeforeFill = true;
            // 
            // btnReset
            // 
            this.btnReset.Caption = "Reset";
            this.btnReset.Id = 4;
            this.btnReset.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.ImageOptions.Image")));
            this.btnReset.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnReset.ImageOptions.LargeImage")));
            this.btnReset.Name = "btnReset";
            this.btnReset.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReset_ItemClick);
            // 
            // frmDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1067, 703);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.docGiaGridControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDocGia";
            this.Text = "Độc Giả";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDocGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThuVienDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDocGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docGiaGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbboxGT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBaoMuon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSachMuon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.BindingSource bdsDocGia;
        private ThuVienDataSet ThuVienDataSet;
        private ThuVienDataSetTableAdapters.DocGiaTableAdapter DocGiaTableAdapter;
        private ThuVienDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl docGiaGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTHE;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYCAP;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colNGHENGHIEP;
        private DevExpress.XtraGrid.Columns.GridColumn colPHAI;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.ComboBoxEdit cbboxGT;
        private System.Windows.Forms.TextBox txtNghe;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtSoThe;
        private DevExpress.XtraEditors.SimpleButton btnXacnhan;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private System.Windows.Forms.Label lblogin;
        private System.Windows.Forms.TextBox txtlogin;
        private System.Windows.Forms.BindingSource bdsBaoMuon;
        private ThuVienDataSetTableAdapters.BaoMuonTableAdapter baoMuonTableAdapter;
        private System.Windows.Forms.BindingSource bdsSachMuon;
        private ThuVienDataSetTableAdapters.SachMuonTableAdapter sachMuonTableAdapter;
        private DevExpress.XtraBars.BarButtonItem btnReset;
    }
}