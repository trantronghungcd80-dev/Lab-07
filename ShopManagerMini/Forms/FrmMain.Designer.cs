namespace ShopManagerMini.Forms;

partial class FrmMain
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        menuStripMain = new MenuStrip();
        menuHeThong = new ToolStripMenuItem();
        menuDangXuat = new ToolStripMenuItem();
        toolStripMenuItemSep1 = new ToolStripSeparator();
        menuThoat = new ToolStripMenuItem();
        menuDanhMuc = new ToolStripMenuItem();
        menuQLSanPham = new ToolStripMenuItem();
        menuQLKhachHang = new ToolStripMenuItem();
        menuTroGiup = new ToolStripMenuItem();
        menuGioiThieu = new ToolStripMenuItem();
        statusStripMain = new StatusStrip();
        lblStatusUser = new ToolStripStatusLabel();
        lblStatusRole = new ToolStripStatusLabel();
        lblStatusSpring = new ToolStripStatusLabel();
        lblStatusApp = new ToolStripStatusLabel();
        lblStatusTime = new ToolStripStatusLabel();
        timerClock = new System.Windows.Forms.Timer(components);
        menuStripMain.SuspendLayout();
        statusStripMain.SuspendLayout();
        SuspendLayout();
        // 
        // menuStripMain
        // 
        menuStripMain.BackColor = Color.FromArgb(236, 240, 241);
        menuStripMain.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
        menuStripMain.Items.AddRange(new ToolStripItem[] { menuHeThong, menuDanhMuc, menuTroGiup });
        menuStripMain.Location = new Point(0, 0);
        menuStripMain.Name = "menuStripMain";
        menuStripMain.Size = new Size(1064, 27);
        menuStripMain.TabIndex = 1;
        menuStripMain.Text = "menuStripMain";
        // 
        // menuHeThong
        // 
        menuHeThong.DropDownItems.AddRange(new ToolStripItem[] { menuDangXuat, toolStripMenuItemSep1, menuThoat });
        menuHeThong.Name = "menuHeThong";
        menuHeThong.Size = new Size(79, 23);
        menuHeThong.Text = "&Hệ thống";
        // 
        // menuDangXuat
        // 
        menuDangXuat.Name = "menuDangXuat";
        menuDangXuat.ShortcutKeys = Keys.Control | Keys.Q;
        menuDangXuat.Size = new Size(196, 24);
        menuDangXuat.Text = "Đăng &xuất";
        menuDangXuat.Click += menuDangXuat_Click;
        // 
        // toolStripMenuItemSep1
        // 
        toolStripMenuItemSep1.Name = "toolStripMenuItemSep1";
        toolStripMenuItemSep1.Size = new Size(193, 6);
        // 
        // menuThoat
        // 
        menuThoat.Name = "menuThoat";
        menuThoat.ShortcutKeys = Keys.Alt | Keys.F4;
        menuThoat.Size = new Size(196, 24);
        menuThoat.Text = "&Thoát";
        menuThoat.Click += menuThoat_Click;
        // 
        // menuDanhMuc
        // 
        menuDanhMuc.DropDownItems.AddRange(new ToolStripItem[] { menuQLSanPham, menuQLKhachHang });
        menuDanhMuc.Name = "menuDanhMuc";
        menuDanhMuc.Size = new Size(84, 23);
        menuDanhMuc.Text = "&Danh mục";
        // 
        // menuQLSanPham
        // 
        menuQLSanPham.Name = "menuQLSanPham";
        menuQLSanPham.ShortcutKeys = Keys.Control | Keys.P;
        menuQLSanPham.Size = new Size(244, 24);
        menuQLSanPham.Text = "Quản lý &sản phẩm";
        menuQLSanPham.Click += menuQLSanPham_Click;
        // 
        // menuQLKhachHang
        // 
        menuQLKhachHang.Name = "menuQLKhachHang";
        menuQLKhachHang.ShortcutKeys = Keys.Control | Keys.K;
        menuQLKhachHang.Size = new Size(244, 24);
        menuQLKhachHang.Text = "Quản lý &khách hàng";
        menuQLKhachHang.Click += menuQLKhachHang_Click;
        // 
        // menuTroGiup
        // 
        menuTroGiup.DropDownItems.AddRange(new ToolStripItem[] { menuGioiThieu });
        menuTroGiup.Name = "menuTroGiup";
        menuTroGiup.Size = new Size(71, 23);
        menuTroGiup.Text = "&Trợ giúp";
        // 
        // menuGioiThieu
        // 
        menuGioiThieu.Name = "menuGioiThieu";
        menuGioiThieu.ShortcutKeys = Keys.F1;
        menuGioiThieu.Size = new Size(157, 24);
        menuGioiThieu.Text = "&Giới thiệu";
        menuGioiThieu.Click += menuGioiThieu_Click;
        // 
        // statusStripMain
        // 
        statusStripMain.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
        statusStripMain.Items.AddRange(new ToolStripItem[] { lblStatusUser, lblStatusRole, lblStatusSpring, lblStatusApp, lblStatusTime });
        statusStripMain.Location = new Point(0, 655);
        statusStripMain.Name = "statusStripMain";
        statusStripMain.Size = new Size(1064, 26);
        statusStripMain.TabIndex = 2;
        statusStripMain.Text = "statusStripMain";
        // 
        // lblStatusUser
        // 
        lblStatusUser.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
        lblStatusUser.ForeColor = Color.FromArgb(41, 128, 185);
        lblStatusUser.Name = "lblStatusUser";
        lblStatusUser.Size = new Size(153, 21);
        lblStatusUser.Text = "Người dùng: Quản trị viên";
        // 
        // lblStatusRole
        // 
        lblStatusRole.BorderSides = ToolStripStatusLabelBorderSides.Left;
        lblStatusRole.BorderStyle = Border3DStyle.Etched;
        lblStatusRole.Name = "lblStatusRole";
        lblStatusRole.Size = new Size(107, 21);
        lblStatusRole.Text = "Vai trò: Admin";
        // 
        // lblStatusSpring
        // 
        lblStatusSpring.Name = "lblStatusSpring";
        lblStatusSpring.Size = new Size(491, 21);
        lblStatusSpring.Spring = true;
        // 
        // lblStatusApp
        // 
        lblStatusApp.BorderSides = ToolStripStatusLabelBorderSides.Right;
        lblStatusApp.BorderStyle = Border3DStyle.Etched;
        lblStatusApp.ForeColor = Color.FromArgb(127, 140, 141);
        lblStatusApp.Name = "lblStatusApp";
        lblStatusApp.Size = new Size(130, 21);
        lblStatusApp.Text = "ShopManagerMini v1.0";
        // 
        // lblStatusTime
        // 
        lblStatusTime.Name = "lblStatusTime";
        lblStatusTime.Size = new Size(128, 21);
        lblStatusTime.Text = "25/10/2026 00:00:00";
        // 
        // timerClock
        // 
        timerClock.Enabled = true;
        timerClock.Interval = 1000;
        timerClock.Tick += timerClock_Tick;
        // 
        // FrmMain
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1064, 681);
        Controls.Add(statusStripMain);
        Controls.Add(menuStripMain);
        IsMdiContainer = true;
        MainMenuStrip = menuStripMain;
        MinimumSize = new Size(800, 600);
        Name = "FrmMain";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "ShopManagerMini - Hệ thống quản lý cửa hàng mini";
        FormClosing += FrmMain_FormClosing;
        Load += FrmMain_Load;
        menuStripMain.ResumeLayout(false);
        menuStripMain.PerformLayout();
        statusStripMain.ResumeLayout(false);
        statusStripMain.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    private MenuStrip menuStripMain;
    private ToolStripMenuItem menuHeThong;
    private ToolStripMenuItem menuDangXuat;
    private ToolStripSeparator toolStripMenuItemSep1;
    private ToolStripMenuItem menuThoat;
    private ToolStripMenuItem menuDanhMuc;
    private ToolStripMenuItem menuQLSanPham;
    private ToolStripMenuItem menuQLKhachHang;
    private ToolStripMenuItem menuTroGiup;
    private ToolStripMenuItem menuGioiThieu;
    private StatusStrip statusStripMain;
    private ToolStripStatusLabel lblStatusUser;
    private ToolStripStatusLabel lblStatusRole;
    private ToolStripStatusLabel lblStatusSpring;
    private ToolStripStatusLabel lblStatusApp;
    private ToolStripStatusLabel lblStatusTime;
    private System.Windows.Forms.Timer timerClock;
}
