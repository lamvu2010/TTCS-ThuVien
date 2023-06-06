namespace ThuVien.Views
{
    partial class frmSachDM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSachDM));
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
            this.bdsSachDM = new System.Windows.Forms.BindingSource(this.components);
            this.VIEW_SACH_DANGMUONTableAdapter = new ThuVien.ThuVienDataSetTableAdapters.VIEW_SACH_DANGMUONTableAdapter();
            this.tableAdapterManager = new ThuVien.ThuVienDataSetTableAdapters.TableAdapterManager();
            this.vIEW_SACH_DANGMUONGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID_SACH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTUA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLANXB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYMUON = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTINHTRANG = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThuVienDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSachDM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vIEW_SACH_DANGMUONGridControl)).BeginInit();
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
            // bdsSachDM
            // 
            this.bdsSachDM.DataMember = "VIEW_SACH_DANGMUON";
            this.bdsSachDM.DataSource = this.ThuVienDataSet;
            // 
            // VIEW_SACH_DANGMUONTableAdapter
            // 
            this.VIEW_SACH_DANGMUONTableAdapter.ClearBeforeFill = true;
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
            // vIEW_SACH_DANGMUONGridControl
            // 
            this.vIEW_SACH_DANGMUONGridControl.DataSource = this.bdsSachDM;
            this.vIEW_SACH_DANGMUONGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.vIEW_SACH_DANGMUONGridControl.Location = new System.Drawing.Point(0, 34);
            this.vIEW_SACH_DANGMUONGridControl.MainView = this.gridView1;
            this.vIEW_SACH_DANGMUONGridControl.MenuManager = this.barManager1;
            this.vIEW_SACH_DANGMUONGridControl.Name = "vIEW_SACH_DANGMUONGridControl";
            this.vIEW_SACH_DANGMUONGridControl.Size = new System.Drawing.Size(800, 285);
            this.vIEW_SACH_DANGMUONGridControl.TabIndex = 5;
            this.vIEW_SACH_DANGMUONGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.vIEW_SACH_DANGMUONGridControl.Click += new System.EventHandler(this.vIEW_SACH_DANGMUONGridControl_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID_SACH,
            this.colTUA,
            this.colLANXB,
            this.colSTT,
            this.colNGAYMUON,
            this.colTINHTRANG});
            this.gridView1.GridControl = this.vIEW_SACH_DANGMUONGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colID_SACH
            // 
            this.colID_SACH.FieldName = "ID_SACH";
            this.colID_SACH.MinWidth = 30;
            this.colID_SACH.Name = "colID_SACH";
            this.colID_SACH.OptionsColumn.ReadOnly = true;
            this.colID_SACH.Visible = true;
            this.colID_SACH.VisibleIndex = 0;
            this.colID_SACH.Width = 112;
            // 
            // colTUA
            // 
            this.colTUA.FieldName = "TUA";
            this.colTUA.MinWidth = 30;
            this.colTUA.Name = "colTUA";
            this.colTUA.OptionsColumn.ReadOnly = true;
            this.colTUA.Visible = true;
            this.colTUA.VisibleIndex = 1;
            this.colTUA.Width = 112;
            // 
            // colLANXB
            // 
            this.colLANXB.FieldName = "LANXB";
            this.colLANXB.MinWidth = 30;
            this.colLANXB.Name = "colLANXB";
            this.colLANXB.OptionsColumn.ReadOnly = true;
            this.colLANXB.Visible = true;
            this.colLANXB.VisibleIndex = 2;
            this.colLANXB.Width = 112;
            // 
            // colSTT
            // 
            this.colSTT.FieldName = "STT";
            this.colSTT.MinWidth = 30;
            this.colSTT.Name = "colSTT";
            this.colSTT.OptionsColumn.ReadOnly = true;
            this.colSTT.Visible = true;
            this.colSTT.VisibleIndex = 3;
            this.colSTT.Width = 112;
            // 
            // colNGAYMUON
            // 
            this.colNGAYMUON.FieldName = "NGAYMUON";
            this.colNGAYMUON.MinWidth = 30;
            this.colNGAYMUON.Name = "colNGAYMUON";
            this.colNGAYMUON.OptionsColumn.ReadOnly = true;
            this.colNGAYMUON.Visible = true;
            this.colNGAYMUON.VisibleIndex = 4;
            this.colNGAYMUON.Width = 112;
            // 
            // colTINHTRANG
            // 
            this.colTINHTRANG.FieldName = "TINHTRANG";
            this.colTINHTRANG.MinWidth = 30;
            this.colTINHTRANG.Name = "colTINHTRANG";
            this.colTINHTRANG.OptionsColumn.ReadOnly = true;
            this.colTINHTRANG.Visible = true;
            this.colTINHTRANG.VisibleIndex = 5;
            this.colTINHTRANG.Width = 112;
            // 
            // frmSachDM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.vIEW_SACH_DANGMUONGridControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmSachDM";
            this.Text = "Sách đang mượn";
            this.Load += new System.EventHandler(this.frmSachDM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThuVienDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSachDM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vIEW_SACH_DANGMUONGridControl)).EndInit();
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
        private System.Windows.Forms.BindingSource bdsSachDM;
        private ThuVienDataSet ThuVienDataSet;
        private ThuVienDataSetTableAdapters.VIEW_SACH_DANGMUONTableAdapter VIEW_SACH_DANGMUONTableAdapter;
        private ThuVienDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl vIEW_SACH_DANGMUONGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colID_SACH;
        private DevExpress.XtraGrid.Columns.GridColumn colTUA;
        private DevExpress.XtraGrid.Columns.GridColumn colLANXB;
        private DevExpress.XtraGrid.Columns.GridColumn colSTT;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYMUON;
        private DevExpress.XtraGrid.Columns.GridColumn colTINHTRANG;
    }
}