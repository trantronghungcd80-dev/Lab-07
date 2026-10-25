namespace ShopManagerMini.Forms;

partial class FrmAbout
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
        panelHeader = new Panel();
        lblHeader = new Label();
        panelContent = new Panel();
        lblTech = new Label();
        lblClass = new Label();
        lblStudent = new Label();
        lblSubject = new Label();
        lblVersion = new Label();
        lblAppName = new Label();
        btnDong = new Button();
        panelHeader.SuspendLayout();
        panelContent.SuspendLayout();
        SuspendLayout();
        // 
        // panelHeader
        // 
        panelHeader.BackColor = Color.FromArgb(52, 73, 94);
        panelHeader.Controls.Add(lblHeader);
        panelHeader.Dock = DockStyle.Top;
        panelHeader.Location = new Point(0, 0);
        panelHeader.Name = "panelHeader";
        panelHeader.Size = new Size(520, 55);
        panelHeader.TabIndex = 0;
        // 
        // lblHeader
        // 
        lblHeader.Dock = DockStyle.Fill;
        lblHeader.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
        lblHeader.ForeColor = Color.White;
        lblHeader.Location = new Point(0, 0);
        lblHeader.Name = "lblHeader";
        lblHeader.Size = new Size(520, 55);
        lblHeader.TabIndex = 0;
        lblHeader.Text = "GIỚI THIỆU ỨNG DỤNG";
        lblHeader.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // panelContent
        // 
        panelContent.BackColor = Color.White;
        panelContent.BorderStyle = BorderStyle.FixedSingle;
        panelContent.Controls.Add(lblTech);
        panelContent.Controls.Add(lblClass);
        panelContent.Controls.Add(lblStudent);
        panelContent.Controls.Add(lblSubject);
        panelContent.Controls.Add(lblVersion);
        panelContent.Controls.Add(lblAppName);
        panelContent.Location = new Point(25, 75);
        panelContent.Name = "panelContent";
        panelContent.Size = new Size(470, 240);
        panelContent.TabIndex = 1;
        // 
        // lblTech
        // 
        lblTech.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
        lblTech.Location = new Point(20, 190);
        lblTech.Name = "lblTech";
        lblTech.Size = new Size(430, 38);
        lblTech.TabIndex = 5;
        lblTech.Text = "• Công nghệ: C# WinForms, .NET 8, MDI Parent-Child Architecture, BindingList In-Memory";
        // 
        // lblClass
        // 
        lblClass.AutoSize = true;
        lblClass.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
        lblClass.Location = new Point(20, 155);
        lblClass.Name = "lblClass";
        lblClass.Size = new Size(71, 19);
        lblClass.TabIndex = 4;
        lblClass.Text = "• Lớp: CD80";
        // 
        // lblStudent
        // 
        lblStudent.AutoSize = true;
        lblStudent.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
        lblStudent.ForeColor = Color.FromArgb(41, 128, 185);
        lblStudent.Location = new Point(20, 120);
        lblStudent.Name = "lblStudent";
        lblStudent.Size = new Size(234, 19);
        lblStudent.TabIndex = 3;
        lblStudent.Text = "• Sinh viên thực hiện: Trần Trọng Hùng";
        // 
        // lblSubject
        // 
        lblSubject.AutoSize = true;
        lblSubject.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
        lblSubject.Location = new Point(20, 85);
        lblSubject.Name = "lblSubject";
        lblSubject.Size = new Size(393, 19);
        lblSubject.TabIndex = 2;
        lblSubject.Text = "• Môn học: COMP1019 - Lập trình trên Windows (Buổi 7: SDI & MDI)";
        // 
        // lblVersion
        // 
        lblVersion.AutoSize = true;
        lblVersion.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
        lblVersion.Location = new Point(20, 50);
        lblVersion.Name = "lblVersion";
        lblVersion.Size = new Size(111, 19);
        lblVersion.TabIndex = 1;
        lblVersion.Text = "• Phiên bản: 1.0.0";
        // 
        // lblAppName
        // 
        lblAppName.AutoSize = true;
        lblAppName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
        lblAppName.ForeColor = Color.FromArgb(44, 62, 80);
        lblAppName.Location = new Point(20, 15);
        lblAppName.Name = "lblAppName";
        lblAppName.Size = new Size(385, 21);
        lblAppName.TabIndex = 0;
        lblAppName.Text = "ỨNG DỤNG QUẢN LÝ CỬA HÀNG MINIMART";
        // 
        // btnDong
        // 
        btnDong.BackColor = Color.FromArgb(52, 73, 94);
        btnDong.Cursor = Cursors.Hand;
        btnDong.FlatStyle = FlatStyle.Flat;
        btnDong.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
        btnDong.ForeColor = Color.White;
        btnDong.Location = new Point(190, 330);
        btnDong.Name = "btnDong";
        btnDong.Size = new Size(140, 38);
        btnDong.TabIndex = 2;
        btnDong.Text = "Đóng";
        btnDong.UseVisualStyleBackColor = false;
        btnDong.Click += btnDong_Click;
        // 
        // FrmAbout
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(245, 247, 250);
        ClientSize = new Size(520, 385);
        Controls.Add(btnDong);
        Controls.Add(panelContent);
        Controls.Add(panelHeader);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "FrmAbout";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Giới thiệu ứng dụng";
        panelHeader.ResumeLayout(false);
        panelContent.ResumeLayout(false);
        panelContent.PerformLayout();
        ResumeLayout(false);
    }

    private Panel panelHeader;
    private Label lblHeader;
    private Panel panelContent;
    private Label lblAppName;
    private Label lblVersion;
    private Label lblSubject;
    private Label lblStudent;
    private Label lblClass;
    private Label lblTech;
    private Button btnDong;
}
