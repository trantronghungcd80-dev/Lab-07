namespace ShopManagerMini.Forms;

partial class FrmCustomer
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
        grpInfo = new GroupBox();
        cboLoaiKH = new ComboBox();
        txtSoDienThoai = new TextBox();
        txtHoTen = new TextBox();
        txtMaKH = new TextBox();
        lblLoaiKH = new Label();
        lblSoDienThoai = new Label();
        lblHoTen = new Label();
        lblMaKH = new Label();
        grpActions = new GroupBox();
        btnLamMoi = new Button();
        btnXoa = new Button();
        btnSua = new Button();
        btnThem = new Button();
        grpSearch = new GroupBox();
        btnHienTatCa = new Button();
        btnTimKiem = new Button();
        txtTimKiem = new TextBox();
        dgvCustomers = new DataGridView();
        colMaKH = new DataGridViewTextBoxColumn();
        colHoTen = new DataGridViewTextBoxColumn();
        colSoDienThoai = new DataGridViewTextBoxColumn();
        colLoaiKH = new DataGridViewTextBoxColumn();
        panelHeader.SuspendLayout();
        grpInfo.SuspendLayout();
        grpActions.SuspendLayout();
        grpSearch.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
        SuspendLayout();
        // 
        // panelHeader
        // 
        panelHeader.BackColor = Color.FromArgb(39, 174, 96);
        panelHeader.Controls.Add(lblHeader);
        panelHeader.Dock = DockStyle.Top;
        panelHeader.Location = new Point(0, 0);
        panelHeader.Name = "panelHeader";
        panelHeader.Size = new Size(884, 50);
        panelHeader.TabIndex = 0;
        // 
        // lblHeader
        // 
        lblHeader.Dock = DockStyle.Fill;
        lblHeader.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
        lblHeader.ForeColor = Color.White;
        lblHeader.Location = new Point(0, 0);
        lblHeader.Name = "lblHeader";
        lblHeader.Size = new Size(884, 50);
        lblHeader.TabIndex = 0;
        lblHeader.Text = "QUẢN LÝ KHÁCH HÀNG";
        lblHeader.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // grpInfo
        // 
        grpInfo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        grpInfo.Controls.Add(cboLoaiKH);
        grpInfo.Controls.Add(txtSoDienThoai);
        grpInfo.Controls.Add(txtHoTen);
        grpInfo.Controls.Add(txtMaKH);
        grpInfo.Controls.Add(lblLoaiKH);
        grpInfo.Controls.Add(lblSoDienThoai);
        grpInfo.Controls.Add(lblHoTen);
        grpInfo.Controls.Add(lblMaKH);
        grpInfo.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
        grpInfo.Location = new Point(12, 56);
        grpInfo.Name = "grpInfo";
        grpInfo.Size = new Size(860, 115);
        grpInfo.TabIndex = 1;
        grpInfo.TabStop = false;
        grpInfo.Text = "Thông tin khách hàng";
        // 
        // cboLoaiKH
        // 
        cboLoaiKH.DropDownStyle = ComboBoxStyle.DropDownList;
        cboLoaiKH.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
        cboLoaiKH.FormattingEnabled = true;
        cboLoaiKH.Items.AddRange(new object[] { "Thường", "Thân thiết", "VIP", "Tiềm năng" });
        cboLoaiKH.Location = new Point(540, 68);
        cboLoaiKH.Name = "cboLoaiKH";
        cboLoaiKH.Size = new Size(300, 25);
        cboLoaiKH.TabIndex = 7;
        // 
        // txtSoDienThoai
        // 
        txtSoDienThoai.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
        txtSoDienThoai.Location = new Point(115, 68);
        txtSoDienThoai.Name = "txtSoDienThoai";
        txtSoDienThoai.PlaceholderText = "Ví dụ: 0901234567";
        txtSoDienThoai.Size = new Size(300, 24);
        txtSoDienThoai.TabIndex = 5;
        // 
        // txtHoTen
        // 
        txtHoTen.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
        txtHoTen.Location = new Point(540, 28);
        txtHoTen.Name = "txtHoTen";
        txtHoTen.PlaceholderText = "Nhập họ tên khách hàng";
        txtHoTen.Size = new Size(300, 24);
        txtHoTen.TabIndex = 3;
        // 
        // txtMaKH
        // 
        txtMaKH.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
        txtMaKH.Location = new Point(115, 28);
        txtMaKH.Name = "txtMaKH";
        txtMaKH.PlaceholderText = "Ví dụ: KH01";
        txtMaKH.Size = new Size(300, 24);
        txtMaKH.TabIndex = 1;
        // 
        // lblLoaiKH
        // 
        lblLoaiKH.AutoSize = true;
        lblLoaiKH.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
        lblLoaiKH.Location = new Point(445, 71);
        lblLoaiKH.Name = "lblLoaiKH";
        lblLoaiKH.Size = new Size(57, 17);
        lblLoaiKH.TabIndex = 6;
        lblLoaiKH.Text = "Loại KH:";
        // 
        // lblSoDienThoai
        // 
        lblSoDienThoai.AutoSize = true;
        lblSoDienThoai.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
        lblSoDienThoai.Location = new Point(15, 71);
        lblSoDienThoai.Name = "lblSoDienThoai";
        lblSoDienThoai.Size = new Size(88, 17);
        lblSoDienThoai.TabIndex = 4;
        lblSoDienThoai.Text = "Số điện thoại:";
        // 
        // lblHoTen
        // 
        lblHoTen.AutoSize = true;
        lblHoTen.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
        lblHoTen.Location = new Point(445, 31);
        lblHoTen.Name = "lblHoTen";
        lblHoTen.Size = new Size(50, 17);
        lblHoTen.TabIndex = 2;
        lblHoTen.Text = "Họ tên:";
        // 
        // lblMaKH
        // 
        lblMaKH.AutoSize = true;
        lblMaKH.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
        lblMaKH.Location = new Point(15, 31);
        lblMaKH.Name = "lblMaKH";
        lblMaKH.Size = new Size(51, 17);
        lblMaKH.TabIndex = 0;
        lblMaKH.Text = "Mã KH:";
        // 
        // grpActions
        // 
        grpActions.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        grpActions.Controls.Add(btnLamMoi);
        grpActions.Controls.Add(btnXoa);
        grpActions.Controls.Add(btnSua);
        grpActions.Controls.Add(btnThem);
        grpActions.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
        grpActions.Location = new Point(12, 177);
        grpActions.Name = "grpActions";
        grpActions.Size = new Size(450, 68);
        grpActions.TabIndex = 2;
        grpActions.TabStop = false;
        grpActions.Text = "Chức năng";
        // 
        // btnLamMoi
        // 
        btnLamMoi.BackColor = Color.FromArgb(149, 165, 166);
        btnLamMoi.Cursor = Cursors.Hand;
        btnLamMoi.FlatStyle = FlatStyle.Flat;
        btnLamMoi.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
        btnLamMoi.ForeColor = Color.White;
        btnLamMoi.Location = new Point(335, 23);
        btnLamMoi.Name = "btnLamMoi";
        btnLamMoi.Size = new Size(95, 32);
        btnLamMoi.TabIndex = 3;
        btnLamMoi.Text = "Làm mới";
        btnLamMoi.UseVisualStyleBackColor = false;
        btnLamMoi.Click += btnLamMoi_Click;
        // 
        // btnXoa
        // 
        btnXoa.BackColor = Color.FromArgb(231, 76, 60);
        btnXoa.Cursor = Cursors.Hand;
        btnXoa.FlatStyle = FlatStyle.Flat;
        btnXoa.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
        btnXoa.ForeColor = Color.White;
        btnXoa.Location = new Point(230, 23);
        btnXoa.Name = "btnXoa";
        btnXoa.Size = new Size(95, 32);
        btnXoa.TabIndex = 2;
        btnXoa.Text = "Xóa";
        btnXoa.UseVisualStyleBackColor = false;
        btnXoa.Click += btnXoa_Click;
        // 
        // btnSua
        // 
        btnSua.BackColor = Color.FromArgb(243, 156, 18);
        btnSua.Cursor = Cursors.Hand;
        btnSua.FlatStyle = FlatStyle.Flat;
        btnSua.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
        btnSua.ForeColor = Color.White;
        btnSua.Location = new Point(125, 23);
        btnSua.Name = "btnSua";
        btnSua.Size = new Size(95, 32);
        btnSua.TabIndex = 1;
        btnSua.Text = "Sửa";
        btnSua.UseVisualStyleBackColor = false;
        btnSua.Click += btnSua_Click;
        // 
        // btnThem
        // 
        btnThem.BackColor = Color.FromArgb(39, 174, 96);
        btnThem.Cursor = Cursors.Hand;
        btnThem.FlatStyle = FlatStyle.Flat;
        btnThem.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
        btnThem.ForeColor = Color.White;
        btnThem.Location = new Point(20, 23);
        btnThem.Name = "btnThem";
        btnThem.Size = new Size(95, 32);
        btnThem.TabIndex = 0;
        btnThem.Text = "Thêm";
        btnThem.UseVisualStyleBackColor = false;
        btnThem.Click += btnThem_Click;
        // 
        // grpSearch
        // 
        grpSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        grpSearch.Controls.Add(btnHienTatCa);
        grpSearch.Controls.Add(btnTimKiem);
        grpSearch.Controls.Add(txtTimKiem);
        grpSearch.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
        grpSearch.Location = new Point(475, 177);
        grpSearch.Name = "grpSearch";
        grpSearch.Size = new Size(397, 68);
        grpSearch.TabIndex = 3;
        grpSearch.TabStop = false;
        grpSearch.Text = "Tìm kiếm khách hàng";
        // 
        // btnHienTatCa
        // 
        btnHienTatCa.BackColor = Color.FromArgb(52, 73, 94);
        btnHienTatCa.Cursor = Cursors.Hand;
        btnHienTatCa.FlatStyle = FlatStyle.Flat;
        btnHienTatCa.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        btnHienTatCa.ForeColor = Color.White;
        btnHienTatCa.Location = new Point(300, 23);
        btnHienTatCa.Name = "btnHienTatCa";
        btnHienTatCa.Size = new Size(85, 32);
        btnHienTatCa.TabIndex = 2;
        btnHienTatCa.Text = "Tất cả";
        btnHienTatCa.UseVisualStyleBackColor = false;
        btnHienTatCa.Click += btnHienTatCa_Click;
        // 
        // btnTimKiem
        // 
        btnTimKiem.BackColor = Color.FromArgb(41, 128, 185);
        btnTimKiem.Cursor = Cursors.Hand;
        btnTimKiem.FlatStyle = FlatStyle.Flat;
        btnTimKiem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        btnTimKiem.ForeColor = Color.White;
        btnTimKiem.Location = new Point(205, 23);
        btnTimKiem.Name = "btnTimKiem";
        btnTimKiem.Size = new Size(90, 32);
        btnTimKiem.TabIndex = 1;
        btnTimKiem.Text = "Tìm kiếm";
        btnTimKiem.UseVisualStyleBackColor = false;
        btnTimKiem.Click += btnTimKiem_Click;
        // 
        // txtTimKiem
        // 
        txtTimKiem.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
        txtTimKiem.Location = new Point(15, 28);
        txtTimKiem.Name = "txtTimKiem";
        txtTimKiem.PlaceholderText = "Nhập mã, tên hoặc SĐT...";
        txtTimKiem.Size = new Size(180, 24);
        txtTimKiem.TabIndex = 0;
        txtTimKiem.KeyDown += txtTimKiem_KeyDown;
        // 
        // dgvCustomers
        // 
        dgvCustomers.AllowUserToAddRows = false;
        dgvCustomers.AllowUserToDeleteRows = false;
        dgvCustomers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        dgvCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvCustomers.BackgroundColor = Color.White;
        dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvCustomers.Columns.AddRange(new DataGridViewColumn[] { colMaKH, colHoTen, colSoDienThoai, colLoaiKH });
        dgvCustomers.Location = new Point(12, 255);
        dgvCustomers.MultiSelect = false;
        dgvCustomers.Name = "dgvCustomers";
        dgvCustomers.ReadOnly = true;
        dgvCustomers.RowHeadersWidth = 30;
        dgvCustomers.RowTemplate.Height = 28;
        dgvCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvCustomers.Size = new Size(860, 285);
        dgvCustomers.TabIndex = 4;
        dgvCustomers.CellClick += dgvCustomers_CellClick;
        // 
        // colMaKH
        // 
        colMaKH.DataPropertyName = "MaKH";
        colMaKH.FillWeight = 80F;
        colMaKH.HeaderText = "Mã KH";
        colMaKH.Name = "colMaKH";
        colMaKH.ReadOnly = true;
        // 
        // colHoTen
        // 
        colHoTen.DataPropertyName = "HoTen";
        colHoTen.FillWeight = 160F;
        colHoTen.HeaderText = "Họ và tên";
        colHoTen.Name = "colHoTen";
        colHoTen.ReadOnly = true;
        // 
        // colSoDienThoai
        // 
        colSoDienThoai.DataPropertyName = "SoDienThoai";
        colSoDienThoai.FillWeight = 120F;
        colSoDienThoai.HeaderText = "Số điện thoại";
        colSoDienThoai.Name = "colSoDienThoai";
        colSoDienThoai.ReadOnly = true;
        // 
        // colLoaiKH
        // 
        colLoaiKH.DataPropertyName = "LoaiKH";
        colLoaiKH.FillWeight = 100F;
        colLoaiKH.HeaderText = "Loại khách hàng";
        colLoaiKH.Name = "colLoaiKH";
        colLoaiKH.ReadOnly = true;
        // 
        // FrmCustomer
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(245, 247, 250);
        ClientSize = new Size(884, 552);
        Controls.Add(dgvCustomers);
        Controls.Add(grpSearch);
        Controls.Add(grpActions);
        Controls.Add(grpInfo);
        Controls.Add(panelHeader);
        MinimumSize = new Size(800, 500);
        Name = "FrmCustomer";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Quản lý khách hàng";
        Load += FrmCustomer_Load;
        panelHeader.ResumeLayout(false);
        grpInfo.ResumeLayout(false);
        grpInfo.PerformLayout();
        grpActions.ResumeLayout(false);
        grpSearch.ResumeLayout(false);
        grpSearch.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
        ResumeLayout(false);
    }

    private Panel panelHeader;
    private Label lblHeader;
    private GroupBox grpInfo;
    private Label lblMaKH;
    private TextBox txtMaKH;
    private Label lblHoTen;
    private TextBox txtHoTen;
    private Label lblSoDienThoai;
    private TextBox txtSoDienThoai;
    private Label lblLoaiKH;
    private ComboBox cboLoaiKH;
    private GroupBox grpActions;
    private Button btnThem;
    private Button btnSua;
    private Button btnXoa;
    private Button btnLamMoi;
    private GroupBox grpSearch;
    private TextBox txtTimKiem;
    private Button btnTimKiem;
    private Button btnHienTatCa;
    private DataGridView dgvCustomers;
    private DataGridViewTextBoxColumn colMaKH;
    private DataGridViewTextBoxColumn colHoTen;
    private DataGridViewTextBoxColumn colSoDienThoai;
    private DataGridViewTextBoxColumn colLoaiKH;
}
