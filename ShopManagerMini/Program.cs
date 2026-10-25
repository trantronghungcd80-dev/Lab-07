using ShopManagerMini.Forms;

namespace ShopManagerMini;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();

        // Vòng lặp đăng nhập hỗ trợ tính năng Đăng xuất
        while (true)
        {
            using (FrmLogin loginForm = new FrmLogin())
            {
                // Hiển thị Form đăng nhập dạng hộp thoại modal ShowDialog()
                DialogResult result = loginForm.ShowDialog();

                if (result != DialogResult.OK || loginForm.LoggedInUser == null)
                {
                    // Người dùng bấm Thoát hoặc đóng form đăng nhập
                    break;
                }

                // Truyền dữ liệu user sang FrmMain qua constructor
                FrmMain mainForm = new FrmMain(loginForm.LoggedInUser);
                Application.Run(mainForm);

                // Nếu người dùng không phải chọn Đăng xuất (Tag != "LOGOUT") thì thoát chương trình
                if (mainForm.Tag?.ToString() != "LOGOUT")
                {
                    break;
                }
            }
        }
    }
}
