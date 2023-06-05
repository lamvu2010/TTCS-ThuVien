namespace ThuVien.Views
{
    partial class frmDSSachMuon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDSSachMuon));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.btnExit = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.ThuVienDataSet = new ThuVien.ThuVienDataSet();
            this.bdsDSSachMuon = new System.Windows.Forms.BindingSource(this.components);
            this.VIEW_DS_MUON_SACHTableAdapter = new ThuVien.ThuVienDataSetTableAdapters.VIEW_DS_MUON_SACHTableAdapter();
            this.tableAdapterManager = new ThuVien.ThuVienDataSetTableAdapters.TableAdapterManager();
            this.vIEW_DS_MUON_SACHGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID_SACH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTUA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLANXB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTHE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPHAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYMUON = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTINHTRANG = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThuVienDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSSachMuon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vIEW_DS_MUON_SACHGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
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
            this.btnRefresh,
            this.btnExit});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 2;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.FloatLocation = new System.Drawing.Point(309, 194);
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRefresh),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnExit)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Caption = "Tải lại";
            this.btnRefresh.Id = 0;
            this.btnRefresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.ImageOptions.Image")));
            this.btnRefresh.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.ImageOptions.LargeImage")));
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefresh_ItemClick);
            // 
            // btnExit
            // 
            this.btnExit.Caption = "Thoát";
            this.btnExit.Id = 1;
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
            this.barDockControlTop.Size = new System.Drawing.Size(800, 34);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 430);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(800, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 34);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 396);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(800, 34);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 396);
            // 
            // ThuVienDataSet
            // 
            this.ThuVienDataSet.DataSetName = "ThuVienDataSet";
            this.ThuVienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsDSSachMuon
            // 
            this.bdsDSSachMuon.DataMember = "VIEW_DS_MUON_SACH";
            this.bdsDSSachMuon.DataSource = this.ThuVienDataSet;
            this.bdsDSSachMuon.CurrentChanged += new System.EventHandler(this.bdsDSSachMuon_CurrentChanged);
            // 
            // VIEW_DS_MUON_SACHTableAdapter
            // 
            this.VIEW_DS_MUON_SACHTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BaoMuonTableAdapter = null;
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
            // vIEW_DS_MUON_SACHGridControl
            // 
            this.vIEW_DS_MUON_SACHGridControl.DataSource = this.bdsDSSachMuon;
            this.vIEW_DS_MUON_SACHGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.vIEW_DS_MUON_SACHGridControl.Location = new System.Drawing.Point(0, 34);
            this.vIEW_DS_MUON_SACHGridControl.MainView = this.gridView1;
            this.vIEW_DS_MUON_SACHGridControl.MenuManager = this.barManager1;
            this.vIEW_DS_MUON_SACHGridControl.Name = "vIEW_DS_MUON_SACHGridControl";
            this.vIEW_DS_MUON_SACHGridControl.Size = new System.Drawing.Size(800, 220);
            this.vIEW_DS_MUON_SACHGridControl.TabIndex = 5;
            this.vIEW_DS_MUON_SACHGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.vIEW_DS_MUON_SACHGridControl.Click += new System.EventHandler(this.vIEW_DS_MUON_SACHGridControl_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID_SACH,
            this.colTUA,
            this.colSTT,
            this.colLANXB,
            this.colSOTHE,
            this.colTEN,
            this.colPHAI,
            this.colNGAYMUON,
            this.colTINHTRANG});
            this.gridView1.GridControl = this.vIEW_DS_MUON_SACHGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colID_SACH
            // 
            this.colID_SACH.FieldName = "ID_SACH";
            this.colID_SACH.MinWidth = 30;
            this.colID_SACH.Name = "colID_SACH";
            this.colID_SACH.Visible = true;
            this.colID_SACH.VisibleIndex = 0;
            this.colID_SACH.Width = 112;
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
            // colSTT
            // 
            this.colSTT.FieldName = "STT";
            this.colSTT.MinWidth = 30;
            this.colSTT.Name = "colSTT";
            this.colSTT.Visible = true;
            this.colSTT.VisibleIndex = 2;
            this.colSTT.Width = 112;
            // 
            // colLANXB
            // 
            this.colLANXB.FieldName = "LANXB";
            this.colLANXB.MinWidth = 30;
            this.colLANXB.Name = "colLANXB";
            this.colLANXB.Visible = true;
            this.colLANXB.VisibleIndex = 3;
            this.colLANXB.Width = 112;
            // 
            // colSOTHE
            // 
            this.colSOTHE.FieldName = "SOTHE";
            this.colSOTHE.MinWidth = 30;
            this.colSOTHE.Name = "colSOTHE";
            this.colSOTHE.Visible = true;
            this.colSOTHE.VisibleIndex = 4;
            this.colSOTHE.Width = 112;
            // 
            // colTEN
            // 
            this.colTEN.FieldName = "TEN";
            this.colTEN.MinWidth = 30;
            this.colTEN.Name = "colTEN";
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 5;
            this.colTEN.Width = 112;
            // 
            // colPHAI
            // 
            this.colPHAI.FieldName = "PHAI";
            this.colPHAI.MinWidth = 30;
            this.colPHAI.Name = "colPHAI";
            this.colPHAI.Visible = true;
            this.colPHAI.VisibleIndex = 6;
            this.colPHAI.Width = 112;
            // 
            // colNGAYMUON
            // 
            this.colNGAYMUON.FieldName = "NGAYMUON";
            this.colNGAYMUON.MinWidth = 30;
            this.colNGAYMUON.Name = "colNGAYMUON";
            this.colNGAYMUON.Visible = true;
            this.colNGAYMUON.VisibleIndex = 7;
            this.colNGAYMUON.Width = 112;
            // 
            // colTINHTRANG
            // 
            this.colTINHTRANG.FieldName = "TINHTRANG";
            this.colTINHTRANG.MinWidth = 30;
            this.colTINHTRANG.Name = "colTINHTRANG";
            this.colTINHTRANG.Visible = true;
            this.colTINHTRANG.VisibleIndex = 8;
            this.colTINHTRANG.Width = 112;
            // 
            // frmDSSachMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.vIEW_DS_MUON_SACHGridControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmDSSachMuon";
            this.Text = "Danh sách sách đang mượn";
            this.Load += new System.EventHandler(this.frmDSSachMuon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThuVienDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSSachMuon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vIEW_DS_MUON_SACHGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        private DevExpress.XtraBars.BarButtonItem btnExit;
        private System.Windows.Forms.BindingSource bdsDSSachMuon;
        private ThuVienDataSet ThuVienDataSet;
        private ThuVienDataSetTableAdapters.VIEW_DS_MUON_SACHTableAdapter VIEW_DS_MUON_SACHTableAdapter;
        private ThuVienDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl vIEW_DS_MUON_SACHGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colID_SACH;
        private DevExpress.XtraGrid.Columns.GridColumn colTUA;
        private DevExpress.XtraGrid.Columns.GridColumn colSTT;
        private DevExpress.XtraGrid.Columns.GridColumn colLANXB;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTHE;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colPHAI;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYMUON;
        private DevExpress.XtraGrid.Columns.GridColumn colTINHTRANG;
    }
}