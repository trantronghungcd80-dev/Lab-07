using ShopManagerMini.Models;

namespace ShopManagerMini.Forms;

public partial class FrmLogin : Form
{
    // Danh sách tài khoản mẫu theo yêu cầu mục 5
    private readonly List<User> _sampleUsers = new()
    {
        new User("admin", "123", "Quản trị viên", "Admin"),
        new User("user", "123", "Nhân viên bán hàng", "User")
    };

    public User? LoggedInUser { get; private set; }

    public FrmLogin()
    {
        InitializeComponent();
    }

    private void btnLogin_Click(object sender, EventArgs e)
    {
        string username = txtUsername.Text.Trim();
        string password = txtPassword.Text.Trim();

        // 7.1 Kiểm tra bỏ trống username hoặc password
        if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
        {
            MessageBox.Show("Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu!",
                            "Cảnh báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
            if (string.IsNullOrEmpty(username))
            {
                txtUsername.Focus();
            }
            else
            {
                txtPassword.Focus();
            }
            return;
        }

        // Kiểm tra thông tin tài khoản
        User? foundUser = _sampleUsers.FirstOrDefault(u => 
            u.Username.Equals(username, StringComparison.OrdinalIgnoreCase) && 
            u.Password == password);

        if (foundUser != null)
        {
            LoggedInUser = foundUser;
            DialogResult = DialogResult.OK;
            Close();
        }
        else
        {
            MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác!",
                            "Lỗi đăng nhập",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
            txtPassword.Clear();
            txtPassword.Focus();
        }
    }

    private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
    {
        txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
    }

    private void btnExit_Click(object sender, EventArgs e)
    {
        DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát ứng dụng?",
                                              "Xác nhận thoát",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Question);
        if (result == DialogResult.Yes)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
