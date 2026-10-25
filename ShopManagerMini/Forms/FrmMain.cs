using ShopManagerMini.Models;

namespace ShopManagerMini.Forms;

public partial class FrmMain : Form
{
    private readonly User _currentUser;

    public FrmMain(User user)
    {
        InitializeComponent();
        _currentUser = user;
    }

    private void FrmMain_Load(object sender, EventArgs e)
    {
        // 7.1 Hiển thị tên người dùng và vai trò trên StatusStrip
        lblStatusUser.Text = $"Người dùng: {_currentUser.FullName}";
        lblStatusRole.Text = $"Vai trò: {_currentUser.Role}";
        UpdateTime();
    }

    private void timerClock_Tick(object sender, EventArgs e)
    {
        UpdateTime();
    }

    private void UpdateTime()
    {
        lblStatusTime.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
    }

    /// <summary>
    /// 7.2 Mở Form con MDI và kiểm tra không mở trùng Form cùng loại
    /// </summary>
    private void OpenMdiChild<T>() where T : Form, new()
    {
        foreach (Form form in this.MdiChildren)
        {
            if (form is T)
            {
                if (form.WindowState == FormWindowState.Minimized)
                {
                    form.WindowState = FormWindowState.Normal;
                }
                form.Activate();
                return;
            }
        }

        T child = new T();
        child.MdiParent = this;
        child.Show();
    }

    private void menuQLSanPham_Click(object sender, EventArgs e)
    {
        OpenMdiChild<FrmProduct>();
    }

    private void menuQLKhachHang_Click(object sender, EventArgs e)
    {
        OpenMdiChild<FrmCustomer>();
    }

    private void menuGioiThieu_Click(object sender, EventArgs e)
    {
        OpenMdiChild<FrmAbout>();
    }

    private void menuDangXuat_Click(object sender, EventArgs e)
    {
        DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất khỏi hệ thống?",
                                              "Xác nhận đăng xuất",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Question);
        if (result == DialogResult.Yes)
        {
            this.Tag = "LOGOUT";
            this.Close();
        }
    }

    private void menuThoat_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
    {
        // Nếu người dùng không phải chọn Đăng xuất, hỏi xác nhận thoát ứng dụng
        if (this.Tag?.ToString() != "LOGOUT")
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình?",
                                                  "Xác nhận thoát",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }
    }
}
