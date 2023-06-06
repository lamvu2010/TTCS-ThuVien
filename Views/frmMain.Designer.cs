namespace ThuVien.Views
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnLogin = new DevExpress.XtraBars.BarButtonItem();
            this.btnChangePassword = new DevExpress.XtraBars.BarButtonItem();
            this.btnExit = new DevExpress.XtraBars.BarButtonItem();
            this.btnSachTV = new DevExpress.XtraBars.BarButtonItem();
            this.btnBaoTV = new DevExpress.XtraBars.BarButtonItem();
            this.btnBookBorrow = new DevExpress.XtraBars.BarButtonItem();
            this.btnNewsBorrow = new DevExpress.XtraBars.BarButtonItem();
            this.btnBorrowBookList = new DevExpress.XtraBars.BarButtonItem();
            this.btnBorrowNewsList = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.btnBook = new DevExpress.XtraBars.BarButtonItem();
            this.btnNews = new DevExpress.XtraBars.BarButtonItem();
            this.btnBookImport = new DevExpress.XtraBars.BarButtonItem();
            this.btnNewsImport = new DevExpress.XtraBars.BarButtonItem();
            this.btnLibraryBook = new DevExpress.XtraBars.BarButtonItem();
            this.btnReader = new DevExpress.XtraBars.BarButtonItem();
            this.btnBackup = new DevExpress.XtraBars.BarButtonItem();
            this.btnRestore = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnRestore2 = new DevExpress.XtraBars.BarButtonItem();
            this.btnTacGia = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.TraCuuPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ThuVienGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.DocGiaGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.QuanLyGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.QuanLyPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.TaiLieuGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.NhapTheoKyGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.QuanLyDocGiaGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.HeThongPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.BRGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.TENDANGNHAP = new System.Windows.Forms.ToolStripStatusLabel();
            this.NHOM = new System.Windows.Forms.ToolStripStatusLabel();
            this.TEN = new System.Windows.Forms.ToolStripStatusLabel();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(123, 117, 123, 117);
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.btnLogin,
            this.btnChangePassword,
            this.btnExit,
            this.btnSachTV,
            this.btnBaoTV,
            this.btnBookBorrow,
            this.btnNewsBorrow,
            this.btnBorrowBookList,
            this.btnBorrowNewsList,
            this.barButtonItem5,
            this.btnBook,
            this.btnNews,
            this.btnBookImport,
            this.btnNewsImport,
            this.btnLibraryBook,
            this.btnReader,
            this.btnBackup,
            this.btnRestore,
            this.barButtonItem1,
            this.btnRestore2,
            this.btnTacGia});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(8);
            this.ribbon.MaxItemId = 33;
            this.ribbon.Name = "ribbon";
            this.ribbon.OptionsMenuMinWidth = 1360;
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.TraCuuPage,
            this.QuanLyPage,
            this.HeThongPage});
            this.ribbon.Size = new System.Drawing.Size(1200, 231);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.Click += new System.EventHandler(this.ribbon_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Caption = "Đăng nhập";
            this.btnLogin.Id = 1;
            this.btnLogin.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLogin.ImageOptions.Image")));
            this.btnLogin.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLogin.ImageOptions.LargeImage")));
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLogin_ItemClick);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Caption = "Đổi mật khẩu";
            this.btnChangePassword.Id = 2;
            this.btnChangePassword.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnChangePassword.ImageOptions.Image")));
            this.btnChangePassword.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnChangePassword.ImageOptions.LargeImage")));
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            this.btnChangePassword.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnChangePassword_ItemClick);
            // 
            // btnExit
            // 
            this.btnExit.Caption = "Thoát";
            this.btnExit.Id = 3;
            this.btnExit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.ImageOptions.Image")));
            this.btnExit.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnExit.ImageOptions.LargeImage")));
            this.btnExit.Name = "btnExit";
            this.btnExit.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            this.btnExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExit_ItemClick_1);
            // 
            // btnSachTV
            // 
            this.btnSachTV.Caption = "Sách trong thư viện";
            this.btnSachTV.Id = 4;
            this.btnSachTV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSachTV.ImageOptions.Image")));
            this.btnSachTV.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSachTV.ImageOptions.LargeImage")));
            this.btnSachTV.Name = "btnSachTV";
            this.btnSachTV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSachTV_ItemClick);
            // 
            // btnBaoTV
            // 
            this.btnBaoTV.Caption = "Báo trong thư viện";
            this.btnBaoTV.Id = 5;
            this.btnBaoTV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBaoTV.ImageOptions.Image")));
            this.btnBaoTV.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnBaoTV.ImageOptions.LargeImage")));
            this.btnBaoTV.Name = "btnBaoTV";
            this.btnBaoTV.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnBaoTV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBaoTV_ItemClick);
            // 
            // btnBookBorrow
            // 
            this.btnBookBorrow.Caption = "Sách đang mượn";
            this.btnBookBorrow.Id = 10;
            this.btnBookBorrow.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnBookBorrow.ImageOptions.SvgImage")));
            this.btnBookBorrow.Name = "btnBookBorrow";
            this.btnBookBorrow.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnBookBorrow.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBookBorrow_ItemClick);
            // 
            // btnNewsBorrow
            // 
            this.btnNewsBorrow.Caption = "Báo đang mượn";
            this.btnNewsBorrow.Id = 11;
            this.btnNewsBorrow.ImageOptions.Image = global::ThuVien.Properties.Resources.tải_xuống__3_;
            this.btnNewsBorrow.Name = "btnNewsBorrow";
            this.btnNewsBorrow.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnNewsBorrow.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNewsBorrow_ItemClick);
            // 
            // btnBorrowBookList
            // 
            this.btnBorrowBookList.Caption = "Danh sách mượn sách";
            this.btnBorrowBookList.Id = 12;
            this.btnBorrowBookList.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBorrowBookList.ImageOptions.Image")));
            this.btnBorrowBookList.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnBorrowBookList.ImageOptions.LargeImage")));
            this.btnBorrowBookList.Name = "btnBorrowBookList";
            this.btnBorrowBookList.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBorrowBookList_ItemClick);
            // 
            // btnBorrowNewsList
            // 
            this.btnBorrowNewsList.Caption = "Danh sách mượn báo";
            this.btnBorrowNewsList.Id = 13;
            this.btnBorrowNewsList.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnBorrowNewsList.ImageOptions.SvgImage")));
            this.btnBorrowNewsList.Name = "btnBorrowNewsList";
            this.btnBorrowNewsList.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBorrowNewsList_ItemClick);
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Id = 19;
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // btnBook
            // 
            this.btnBook.Caption = "Tựa sách";
            this.btnBook.Id = 17;
            this.btnBook.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBook.ImageOptions.Image")));
            this.btnBook.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnBook.ImageOptions.LargeImage")));
            this.btnBook.Name = "btnBook";
            this.btnBook.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnBook.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBook_ItemClick);
            // 
            // btnNews
            // 
            this.btnNews.Caption = "Tựa báo";
            this.btnNews.Id = 18;
            this.btnNews.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnNews.ImageOptions.SvgImage")));
            this.btnNews.Name = "btnNews";
            this.btnNews.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnNews.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNews_ItemClick);
            // 
            // btnBookImport
            // 
            this.btnBookImport.Caption = "Sách nhập theo kỳ";
            this.btnBookImport.Id = 23;
            this.btnBookImport.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBookImport.ImageOptions.Image")));
            this.btnBookImport.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnBookImport.ImageOptions.LargeImage")));
            this.btnBookImport.Name = "btnBookImport";
            this.btnBookImport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBookImport_ItemClick);
            // 
            // btnNewsImport
            // 
            this.btnNewsImport.Caption = "Báo nhập theo kỳ";
            this.btnNewsImport.Id = 24;
            this.btnNewsImport.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNewsImport.ImageOptions.Image")));
            this.btnNewsImport.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnNewsImport.ImageOptions.LargeImage")));
            this.btnNewsImport.Name = "btnNewsImport";
            this.btnNewsImport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNewsImport_ItemClick);
            // 
            // btnLibraryBook
            // 
            this.btnLibraryBook.Caption = "Sách thư viện";
            this.btnLibraryBook.Id = 26;
            this.btnLibraryBook.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLibraryBook.ImageOptions.SvgImage")));
            this.btnLibraryBook.Name = "btnLibraryBook";
            // 
            // btnReader
            // 
            this.btnReader.Caption = "Độc giả";
            this.btnReader.Id = 27;
            this.btnReader.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnReader.ImageOptions.SvgImage")));
            this.btnReader.Name = "btnReader";
            this.btnReader.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReader_ItemClick);
            // 
            // btnBackup
            // 
            this.btnBackup.Caption = "Sao lưu";
            this.btnBackup.Id = 28;
            this.btnBackup.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnBackup.ImageOptions.SvgImage")));
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBackup_ItemClick);
            // 
            // btnRestore
            // 
            this.btnRestore.Caption = "Phục hồi gần";
            this.btnRestore.Id = 29;
            this.btnRestore.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnRestore.ImageOptions.SvgImage")));
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRestore_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Id = 30;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // btnRestore2
            // 
            this.btnRestore2.Caption = "Phục hồi xa";
            this.btnRestore2.Id = 31;
            this.btnRestore2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnRestore2.ImageOptions.SvgImage")));
            this.btnRestore2.Name = "btnRestore2";
            this.btnRestore2.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnRestore2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRestore2_ItemClick);
            // 
            // btnTacGia
            // 
            this.btnTacGia.Caption = "Tác giả";
            this.btnTacGia.Id = 32;
            this.btnTacGia.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTacGia.ImageOptions.Image")));
            this.btnTacGia.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTacGia.ImageOptions.LargeImage")));
            this.btnTacGia.Name = "btnTacGia";
            this.btnTacGia.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnTacGia.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTacGia_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Tài khoản";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnLogin);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Tài khoản";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnChangePassword);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnExit);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Tiện ích tài khoản";
            // 
            // TraCuuPage
            // 
            this.TraCuuPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ThuVienGroup,
            this.DocGiaGroup,
            this.QuanLyGroup});
            this.TraCuuPage.Name = "TraCuuPage";
            this.TraCuuPage.Text = "Tra cứu, mượn, trả";
            // 
            // ThuVienGroup
            // 
            this.ThuVienGroup.ItemLinks.Add(this.btnSachTV);
            this.ThuVienGroup.ItemLinks.Add(this.btnBaoTV);
            this.ThuVienGroup.Name = "ThuVienGroup";
            this.ThuVienGroup.Text = "Thư viện";
            // 
            // DocGiaGroup
            // 
            this.DocGiaGroup.ItemLinks.Add(this.btnBookBorrow);
            this.DocGiaGroup.ItemLinks.Add(this.btnNewsBorrow);
            this.DocGiaGroup.Name = "DocGiaGroup";
            this.DocGiaGroup.Text = "Độc giả";
            // 
            // QuanLyGroup
            // 
            this.QuanLyGroup.ItemLinks.Add(this.btnBorrowBookList);
            this.QuanLyGroup.ItemLinks.Add(this.btnBorrowNewsList);
            this.QuanLyGroup.Name = "QuanLyGroup";
            this.QuanLyGroup.Text = "Quản lý";
            // 
            // QuanLyPage
            // 
            this.QuanLyPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.TaiLieuGroup,
            this.NhapTheoKyGroup,
            this.QuanLyDocGiaGroup});
            this.QuanLyPage.Name = "QuanLyPage";
            this.QuanLyPage.Text = "Quản lý";
            // 
            // TaiLieuGroup
            // 
            this.TaiLieuGroup.ItemLinks.Add(this.barButtonItem5);
            this.TaiLieuGroup.ItemLinks.Add(this.btnBook);
            this.TaiLieuGroup.ItemLinks.Add(this.btnNews);
            this.TaiLieuGroup.Name = "TaiLieuGroup";
            this.TaiLieuGroup.Text = "Sách và báo";
            // 
            // NhapTheoKyGroup
            // 
            this.NhapTheoKyGroup.ItemLinks.Add(this.btnBookImport);
            this.NhapTheoKyGroup.ItemLinks.Add(this.btnNewsImport);
            this.NhapTheoKyGroup.Name = "NhapTheoKyGroup";
            this.NhapTheoKyGroup.Text = "Nhập theo kỳ";
            // 
            // QuanLyDocGiaGroup
            // 
            this.QuanLyDocGiaGroup.ItemLinks.Add(this.btnReader);
            this.QuanLyDocGiaGroup.ItemLinks.Add(this.btnTacGia);
            this.QuanLyDocGiaGroup.Name = "QuanLyDocGiaGroup";
            this.QuanLyDocGiaGroup.Text = "Nhân vật";
            // 
            // HeThongPage
            // 
            this.HeThongPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.BRGroup});
            this.HeThongPage.Name = "HeThongPage";
            this.HeThongPage.Text = "Hệ thống";
            // 
            // BRGroup
            // 
            this.BRGroup.ItemLinks.Add(this.btnBackup);
            this.BRGroup.ItemLinks.Add(this.barButtonItem1, true);
            this.BRGroup.ItemLinks.Add(this.btnRestore);
            this.BRGroup.ItemLinks.Add(this.btnRestore2);
            this.BRGroup.Name = "BRGroup";
            this.BRGroup.Text = "Sao lưu và phục hồi dữ liệu";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 484);
            this.ribbonStatusBar.Margin = new System.Windows.Forms.Padding(12);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1200, 36);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TENDANGNHAP,
            this.NHOM,
            this.TEN});
            this.statusStrip1.Location = new System.Drawing.Point(0, 452);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 17, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1200, 32);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // TENDANGNHAP
            // 
            this.TENDANGNHAP.Name = "TENDANGNHAP";
            this.TENDANGNHAP.Size = new System.Drawing.Size(129, 25);
            this.TENDANGNHAP.Text = "Tên đăng nhập";
            this.TENDANGNHAP.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // NHOM
            // 
            this.NHOM.Name = "NHOM";
            this.NHOM.Size = new System.Drawing.Size(67, 25);
            this.NHOM.Text = "Nhóm ";
            // 
            // TEN
            // 
            this.TEN.Name = "TEN";
            this.TEN.Size = new System.Drawing.Size(38, 25);
            this.TEN.Text = "Tên";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // frmMain
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 520);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmMain";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btnLogin;
        private DevExpress.XtraBars.BarButtonItem btnChangePassword;
        private DevExpress.XtraBars.BarButtonItem btnExit;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel TENDANGNHAP;
        private System.Windows.Forms.ToolStripStatusLabel NHOM;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private System.Windows.Forms.ToolStripStatusLabel TEN;
        private DevExpress.XtraBars.BarButtonItem btnSachTV;
        private DevExpress.XtraBars.BarButtonItem btnBaoTV;
        private DevExpress.XtraBars.Ribbon.RibbonPage TraCuuPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ThuVienGroup;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup DocGiaGroup;
        private DevExpress.XtraBars.Ribbon.RibbonPage QuanLyPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup TaiLieuGroup;
        private DevExpress.XtraBars.BarButtonItem btnBookBorrow;
        private DevExpress.XtraBars.BarButtonItem btnNewsBorrow;
        private DevExpress.XtraBars.BarButtonItem btnBorrowBookList;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup QuanLyGroup;
        private DevExpress.XtraBars.BarButtonItem btnBorrowNewsList;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem btnBook;
        private DevExpress.XtraBars.BarButtonItem btnNews;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup NhapTheoKyGroup;
        private DevExpress.XtraBars.BarButtonItem btnBookImport;
        private DevExpress.XtraBars.BarButtonItem btnNewsImport;
        private DevExpress.XtraBars.BarButtonItem btnLibraryBook;
        private DevExpress.XtraBars.BarButtonItem btnReader;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup QuanLyDocGiaGroup;
        private DevExpress.XtraBars.BarButtonItem btnBackup;
        private DevExpress.XtraBars.BarButtonItem btnRestore;
        private DevExpress.XtraBars.Ribbon.RibbonPage HeThongPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup BRGroup;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btnRestore2;
        private DevExpress.XtraBars.BarButtonItem btnTacGia;
    }
}