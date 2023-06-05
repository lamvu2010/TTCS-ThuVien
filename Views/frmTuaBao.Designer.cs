namespace ThuVien.Views
{
    partial class frmTuaBao
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
            System.Windows.Forms.Label lbNSX;
            System.Windows.Forms.Label lbDinhKy;
            System.Windows.Forms.Label lbNamPH;
            System.Windows.Forms.Label lbTua;
            System.Windows.Forms.Label lbMaBao;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTuaBao));
            this.bdsBaoPH = new System.Windows.Forms.BindingSource(this.components);
            this.bdsVIEW_BAOPH = new System.Windows.Forms.BindingSource(this.components);
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
            this.BaoPHTableAdapter = new ThuVien.ThuVienDataSetTableAdapters.BaoPHTableAdapter();
            this.VIEW_BAOPHTableAdapter = new ThuVien.ThuVienDataSetTableAdapters.VIEW_BAOPHTableAdapter();
            this.tableAdapterManager = new ThuVien.ThuVienDataSetTableAdapters.TableAdapterManager();
            this.TaiLieuTableAdapter = new ThuVien.ThuVienDataSetTableAdapters.TaiLieuTableAdapter();
            this.vIEW_BAOPHGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMABAO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTUA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNAMPH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDINHKY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNSX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bdsTaiLieu = new System.Windows.Forms.BindingSource(this.components);
            this.bdsBaoTV = new System.Windows.Forms.BindingSource(this.components);
            this.BaoTVTableAdapter = new ThuVien.ThuVienDataSetTableAdapters.BaoTVTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNSX = new System.Windows.Forms.TextBox();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnXacnhan = new DevExpress.XtraEditors.SimpleButton();
            this.txtDinhKy = new System.Windows.Forms.TextBox();
            this.txtNamPH = new System.Windows.Forms.TextBox();
            this.txtTua = new System.Windows.Forms.TextBox();
            this.txtMaBao = new System.Windows.Forms.TextBox();
            lbNSX = new System.Windows.Forms.Label();
            lbDinhKy = new System.Windows.Forms.Label();
            lbNamPH = new System.Windows.Forms.Label();
            lbTua = new System.Windows.Forms.Label();
            lbMaBao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBaoPH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsVIEW_BAOPH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThuVienDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vIEW_BAOPHGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTaiLieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBaoTV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbNSX
            // 
            lbNSX.AutoSize = true;
            lbNSX.Location = new System.Drawing.Point(381, 136);
            lbNSX.Name = "lbNSX";
            lbNSX.Size = new System.Drawing.Size(42, 20);
            lbNSX.TabIndex = 19;
            lbNSX.Text = "NSX";
            // 
            // lbDinhKy
            // 
            lbDinhKy.AutoSize = true;
            lbDinhKy.Location = new System.Drawing.Point(376, 196);
            lbDinhKy.Name = "lbDinhKy";
            lbDinhKy.Size = new System.Drawing.Size(61, 20);
            lbDinhKy.TabIndex = 17;
            lbDinhKy.Text = "Định kỳ";
            // 
            // lbNamPH
            // 
            lbNamPH.AutoSize = true;
            lbNamPH.Location = new System.Drawing.Point(381, 75);
            lbNamPH.Name = "lbNamPH";
            lbNamPH.Size = new System.Drawing.Size(68, 20);
            lbNamPH.TabIndex = 15;
            lbNamPH.Text = "Năm PH";
            // 
            // lbTua
            // 
            lbTua.AutoSize = true;
            lbTua.BackColor = System.Drawing.Color.White;
            lbTua.Location = new System.Drawing.Point(28, 137);
            lbTua.Name = "lbTua";
            lbTua.Size = new System.Drawing.Size(67, 20);
            lbTua.TabIndex = 13;
            lbTua.Text = "Tên báo";
            // 
            // lbMaBao
            // 
            lbMaBao.AutoSize = true;
            lbMaBao.BackColor = System.Drawing.Color.White;
            lbMaBao.Location = new System.Drawing.Point(28, 73);
            lbMaBao.Name = "lbMaBao";
            lbMaBao.Size = new System.Drawing.Size(62, 20);
            lbMaBao.TabIndex = 13;
            lbMaBao.Text = "Mã báo";
            // 
            // bdsBaoPH
            // 
            this.bdsBaoPH.DataMember = "BaoPH";
            this.bdsBaoPH.DataSource = this.ThuVienDataSet;
            // 
            // bdsVIEW_BAOPH
            // 
            this.bdsVIEW_BAOPH.DataMember = "VIEW_BAOPH";
            this.bdsVIEW_BAOPH.DataSource = this.ThuVienDataSet;
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
            this.barDockControlTop.Size = new System.Drawing.Size(1203, 34);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 974);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1203, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 34);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 940);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1203, 34);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 940);
            // 
            // btnReset
            // 
            this.btnReset.Caption = "Reset";
            this.btnReset.Id = 4;
            this.btnReset.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.ImageOptions.Image")));
            this.btnReset.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnReset.ImageOptions.LargeImage")));
            this.btnReset.Name = "btnReset";
            // 
            // BaoPHTableAdapter
            // 
            this.BaoPHTableAdapter.ClearBeforeFill = true;
            // 
            // VIEW_BAOPHTableAdapter
            // 
            this.VIEW_BAOPHTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BaoMuonTableAdapter = null;
            this.tableAdapterManager.BaoPHTableAdapter = this.BaoPHTableAdapter;
            this.tableAdapterManager.BaoTVTableAdapter = null;
            this.tableAdapterManager.ChiTietTacGiaTableAdapter = null;
            this.tableAdapterManager.DocGiaTableAdapter = null;
            this.tableAdapterManager.SachMuonTableAdapter = null;
            this.tableAdapterManager.SachTVTableAdapter = null;
            this.tableAdapterManager.SachXBTableAdapter = null;
            this.tableAdapterManager.TacGiaTableAdapter = null;
            this.tableAdapterManager.TaiLieuTableAdapter = this.TaiLieuTableAdapter;
            this.tableAdapterManager.UpdateOrder = ThuVien.ThuVienDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // TaiLieuTableAdapter
            // 
            this.TaiLieuTableAdapter.ClearBeforeFill = true;
            // 
            // vIEW_BAOPHGridControl
            // 
            this.vIEW_BAOPHGridControl.DataSource = this.bdsVIEW_BAOPH;
            this.vIEW_BAOPHGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.vIEW_BAOPHGridControl.Location = new System.Drawing.Point(0, 34);
            this.vIEW_BAOPHGridControl.MainView = this.gridView1;
            this.vIEW_BAOPHGridControl.MenuManager = this.barManager1;
            this.vIEW_BAOPHGridControl.Name = "vIEW_BAOPHGridControl";
            this.vIEW_BAOPHGridControl.Size = new System.Drawing.Size(1203, 258);
            this.vIEW_BAOPHGridControl.TabIndex = 24;
            this.vIEW_BAOPHGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.vIEW_BAOPHGridControl.Click += new System.EventHandler(this.vIEW_BAOPHGridControl_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMABAO,
            this.colTUA,
            this.colNAMPH,
            this.colDINHKY,
            this.colNSX});
            this.gridView1.GridControl = this.vIEW_BAOPHGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colMABAO
            // 
            this.colMABAO.FieldName = "MABAO";
            this.colMABAO.MinWidth = 30;
            this.colMABAO.Name = "colMABAO";
            this.colMABAO.Visible = true;
            this.colMABAO.VisibleIndex = 0;
            this.colMABAO.Width = 112;
            // 
            // colTUA
            // 
            this.colTUA.FieldName = "TUA";
            this.colTUA.MinWidth = 30;
            this.colTUA.Name = "colTUA";
            this.colTUA.Visible = true;
            this.colTUA.VisibleIndex = 1;
            this.colTUA.Width = 112;
            // 
            // colNAMPH
            // 
            this.colNAMPH.FieldName = "NAMPH";
            this.colNAMPH.MinWidth = 30;
            this.colNAMPH.Name = "colNAMPH";
            this.colNAMPH.Visible = true;
            this.colNAMPH.VisibleIndex = 2;
            this.colNAMPH.Width = 112;
            // 
            // colDINHKY
            // 
            this.colDINHKY.FieldName = "DINHKY";
            this.colDINHKY.MinWidth = 30;
            this.colDINHKY.Name = "colDINHKY";
            this.colDINHKY.Visible = true;
            this.colDINHKY.VisibleIndex = 3;
            this.colDINHKY.Width = 112;
            // 
            // colNSX
            // 
            this.colNSX.FieldName = "NSX";
            this.colNSX.MinWidth = 30;
            this.colNSX.Name = "colNSX";
            this.colNSX.Visible = true;
            this.colNSX.VisibleIndex = 4;
            this.colNSX.Width = 112;
            // 
            // bdsTaiLieu
            // 
            this.bdsTaiLieu.AllowNew = true;
            this.bdsTaiLieu.DataMember = "TaiLieu";
            this.bdsTaiLieu.DataSource = this.ThuVienDataSet;
            // 
            // bdsBaoTV
            // 
            this.bdsBaoTV.DataMember = "FK_VIEW_BAOPH_BaoTV";
            this.bdsBaoTV.DataSource = this.bdsVIEW_BAOPH;
            // 
            // BaoTVTableAdapter
            // 
            this.BaoTVTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.txtNSX);
            this.groupBox1.Controls.Add(this.btnHuy);
            this.groupBox1.Controls.Add(this.btnXacnhan);
            this.groupBox1.Controls.Add(lbNSX);
            this.groupBox1.Controls.Add(lbDinhKy);
            this.groupBox1.Controls.Add(this.txtDinhKy);
            this.groupBox1.Controls.Add(lbNamPH);
            this.groupBox1.Controls.Add(this.txtNamPH);
            this.groupBox1.Controls.Add(lbTua);
            this.groupBox1.Controls.Add(lbMaBao);
            this.groupBox1.Controls.Add(this.txtTua);
            this.groupBox1.Controls.Add(this.txtMaBao);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(0, 292);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1203, 251);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            this.groupBox1.Visible = false;
            // 
            // txtNSX
            // 
            this.txtNSX.Location = new System.Drawing.Point(501, 130);
            this.txtNSX.Name = "txtNSX";
            this.txtNSX.Size = new System.Drawing.Size(168, 26);
            this.txtNSX.TabIndex = 23;
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
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
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
            this.btnXacnhan.Click += new System.EventHandler(this.btnXacnhan_Click);
            // 
            // txtDinhKy
            // 
            this.txtDinhKy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDinhKy.Location = new System.Drawing.Point(501, 192);
            this.txtDinhKy.Name = "txtDinhKy";
            this.txtDinhKy.Size = new System.Drawing.Size(168, 26);
            this.txtDinhKy.TabIndex = 18;
            // 
            // txtNamPH
            // 
            this.txtNamPH.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtNamPH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNamPH.Location = new System.Drawing.Point(500, 70);
            this.txtNamPH.Name = "txtNamPH";
            this.txtNamPH.Size = new System.Drawing.Size(169, 26);
            this.txtNamPH.TabIndex = 16;
            // 
            // txtTua
            // 
            this.txtTua.Location = new System.Drawing.Point(134, 134);
            this.txtTua.Name = "txtTua";
            this.txtTua.Size = new System.Drawing.Size(157, 26);
            this.txtTua.TabIndex = 14;
            // 
            // txtMaBao
            // 
            this.txtMaBao.Location = new System.Drawing.Point(134, 70);
            this.txtMaBao.Name = "txtMaBao";
            this.txtMaBao.Size = new System.Drawing.Size(157, 26);
            this.txtMaBao.TabIndex = 14;
            // 
            // frmTuaBao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 994);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.vIEW_BAOPHGridControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "frmTuaBao";
            this.Text = "Tựa Báo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTuaBao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdsBaoPH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsVIEW_BAOPH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThuVienDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vIEW_BAOPHGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTaiLieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBaoTV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnReset;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private ThuVienDataSet ThuVienDataSet;
        private System.Windows.Forms.BindingSource bdsBaoPH;
        private ThuVienDataSetTableAdapters.BaoPHTableAdapter BaoPHTableAdapter;
        private System.Windows.Forms.BindingSource bdsVIEW_BAOPH;
        private ThuVienDataSetTableAdapters.VIEW_BAOPHTableAdapter VIEW_BAOPHTableAdapter;
        private ThuVienDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl vIEW_BAOPHGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMABAO;
        private DevExpress.XtraGrid.Columns.GridColumn colTUA;
        private DevExpress.XtraGrid.Columns.GridColumn colNAMPH;
        private DevExpress.XtraGrid.Columns.GridColumn colDINHKY;
        private DevExpress.XtraGrid.Columns.GridColumn colNSX;
        private ThuVienDataSetTableAdapters.TaiLieuTableAdapter TaiLieuTableAdapter;
        private System.Windows.Forms.BindingSource bdsTaiLieu;
        private System.Windows.Forms.BindingSource bdsBaoTV;
        private ThuVienDataSetTableAdapters.BaoTVTableAdapter BaoTVTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNSX;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton btnXacnhan;
        private System.Windows.Forms.TextBox txtDinhKy;
        private System.Windows.Forms.TextBox txtNamPH;
        private System.Windows.Forms.TextBox txtTua;
        private System.Windows.Forms.TextBox txtMaBao;
    }
}