namespace ShopManagerMini.Forms;

partial class FrmLogin
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
        lblTitle = new Label();
        lblUsername = new Label();
        txtUsername = new TextBox();
        lblPassword = new Label();
        txtPassword = new TextBox();
        chkShowPassword = new CheckBox();
        btnLogin = new Button();
        btnExit = new Button();
        lblHint = new Label();
        panelHeader = new Panel();
        panelHeader.SuspendLayout();
        SuspendLayout();
        // 
        // panelHeader
        // 
        panelHeader.BackColor = Color.FromArgb(41, 128, 185);
        panelHeader.Controls.Add(lblTitle);
        panelHeader.Dock = DockStyle.Top;
        panelHeader.Location = new Point(0, 0);
        panelHeader.Name = "panelHeader";
        panelHeader.Size = new Size(460, 65);
        panelHeader.TabIndex = 0;
        // 
        // lblTitle
        // 
        lblTitle.Dock = DockStyle.Fill;
        lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
        lblTitle.ForeColor = Color.White;
        lblTitle.Location = new Point(0, 0);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(460, 65);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "ĐĂNG NHẬP HỆ THỐNG";
        lblTitle.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // lblUsername
        // 
        lblUsername.AutoSize = true;
        lblUsername.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
        lblUsername.Location = new Point(45, 95);
        lblUsername.Name = "lblUsername";
        lblUsername.Size = new Size(111, 19);
        lblUsername.TabIndex = 1;
        lblUsername.Text = "Tên đăng nhập:";
        // 
        // txtUsername
        // 
        txtUsername.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
        txtUsername.Location = new Point(45, 120);
        txtUsername.Name = "txtUsername";
        txtUsername.PlaceholderText = "Nhập admin hoặc user";
        txtUsername.Size = new Size(370, 27);
        txtUsername.TabIndex = 2;
        // 
        // lblPassword
        // 
        lblPassword.AutoSize = true;
        lblPassword.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
        lblPassword.Location = new Point(45, 160);
        lblPassword.Name = "lblPassword";
        lblPassword.Size = new Size(75, 19);
        lblPassword.TabIndex = 3;
        lblPassword.Text = "Mật khẩu:";
        // 
        // txtPassword
        // 
        txtPassword.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
        txtPassword.Location = new Point(45, 185);
        txtPassword.Name = "txtPassword";
        txtPassword.PlaceholderText = "Nhập mật khẩu (123)";
        txtPassword.Size = new Size(370, 27);
        txtPassword.TabIndex = 4;
        txtPassword.UseSystemPasswordChar = true;
        // 
        // chkShowPassword
        // 
        chkShowPassword.AutoSize = true;
        chkShowPassword.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
        chkShowPassword.Location = new Point(45, 222);
        chkShowPassword.Name = "chkShowPassword";
        chkShowPassword.Size = new Size(122, 19);
        chkShowPassword.TabIndex = 5;
        chkShowPassword.Text = "Hiển thị mật khẩu";
        chkShowPassword.UseVisualStyleBackColor = true;
        chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
        // 
        // btnLogin
        // 
        btnLogin.BackColor = Color.FromArgb(41, 128, 185);
        btnLogin.Cursor = Cursors.Hand;
        btnLogin.FlatStyle = FlatStyle.Flat;
        btnLogin.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
        btnLogin.ForeColor = Color.White;
        btnLogin.Location = new Point(45, 255);
        btnLogin.Name = "btnLogin";
        btnLogin.Size = new Size(175, 40);
        btnLogin.TabIndex = 6;
        btnLogin.Text = "Đăng nhập";
        btnLogin.UseVisualStyleBackColor = false;
        btnLogin.Click += btnLogin_Click;
        // 
        // btnExit
        // 
        btnExit.BackColor = Color.FromArgb(231, 76, 60);
        btnExit.Cursor = Cursors.Hand;
        btnExit.FlatStyle = FlatStyle.Flat;
        btnExit.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
        btnExit.ForeColor = Color.White;
        btnExit.Location = new Point(240, 255);
        btnExit.Name = "btnExit";
        btnExit.Size = new Size(175, 40);
        btnExit.TabIndex = 7;
        btnExit.Text = "Thoát";
        btnExit.UseVisualStyleBackColor = false;
        btnExit.Click += btnExit_Click;
        // 
        // lblHint
        // 
        lblHint.Font = new Font("Segoe UI", 8.5F, FontStyle.Italic, GraphicsUnit.Point);
        lblHint.ForeColor = Color.Gray;
        lblHint.Location = new Point(12, 305);
        lblHint.Name = "lblHint";
        lblHint.Size = new Size(436, 35);
        lblHint.TabIndex = 8;
        lblHint.Text = "Mẫu: admin / 123 (Quản trị viên) | user / 123 (Nhân viên)";
        lblHint.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // FrmLogin
        // 
        AcceptButton = btnLogin;
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(245, 247, 250);
        CancelButton = btnExit;
        ClientSize = new Size(460, 350);
        Controls.Add(lblHint);
        Controls.Add(btnExit);
        Controls.Add(btnLogin);
        Controls.Add(chkShowPassword);
        Controls.Add(txtPassword);
        Controls.Add(lblPassword);
        Controls.Add(txtUsername);
        Controls.Add(lblUsername);
        Controls.Add(panelHeader);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "FrmLogin";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Đăng nhập hệ thống - ShopManagerMini";
        panelHeader.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    private Panel panelHeader;
    private Label lblTitle;
    private Label lblUsername;
    private TextBox txtUsername;
    private Label lblPassword;
    private TextBox txtPassword;
    private CheckBox chkShowPassword;
    private Button btnLogin;
    private Button btnExit;
    private Label lblHint;
}
