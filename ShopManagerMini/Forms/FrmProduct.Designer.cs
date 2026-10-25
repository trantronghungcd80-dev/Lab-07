namespace ShopManagerMini.Forms;

partial class FrmProduct
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
        DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
        panelHeader = new Panel();
        lblHeader = new Label();
        grpInfo = new GroupBox();
        nudSoLuong = new NumericUpDown();
        nudDonGia = new NumericUpDown();
        cboLoaiSP = new ComboBox();
        txtTenSP = new TextBox();
        txtMaSP = new TextBox();
        lblSoLuong = new Label();
        lblDonGia = new Label();
        lblLoaiSP = new Label();
        lblTenSP = new Label();
        lblMaSP = new Label();
        grpActions = new GroupBox();
        btnLamMoi = new Button();
        btnXoa = new Button();
        btnSua = new Button();
        btnThem = new Button();
        grpSearch = new GroupBox();
        btnHienTatCa = new Button();
        btnTimKiem = new Button();
        txtTimKiem = new TextBox();
        dgvProducts = new DataGridView();
        colMaSP = new DataGridViewTextBoxColumn();
        colTenSP = new DataGridViewTextBoxColumn();
        colLoaiSP = new DataGridViewTextBoxColumn();
        colDonGia = new DataGridViewTextBoxColumn();
        colSoLuong = new DataGridViewTextBoxColumn();
        colThanhTien = new DataGridViewTextBoxColumn();
        panelHeader.SuspendLayout();
        grpInfo.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)nudSoLuong).BeginInit();
        ((System.ComponentModel.ISupportInitialize)nudDonGia).BeginInit();
        grpActions.SuspendLayout();
        grpSearch.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
        SuspendLayout();
        // 
        // panelHeader
        // 
        panelHeader.BackColor = Color.FromArgb(41, 128, 185);
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
        lblHeader.Text = "QUẢN LÝ SẢN PHẨM";
        lblHeader.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // grpInfo
        // 
        grpInfo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        grpInfo.Controls.Add(nudSoLuong);
        grpInfo.Controls.Add(nudDonGia);
        grpInfo.Controls.Add(cboLoaiSP);
        grpInfo.Controls.Add(txtTenSP);
        grpInfo.Controls.Add(txtMaSP);
        grpInfo.Controls.Add(lblSoLuong);
        grpInfo.Controls.Add(lblDonGia);
        grpInfo.Controls.Add(lblLoaiSP);
        grpInfo.Controls.Add(lblTenSP);
        grpInfo.Controls.Add(lblMaSP);
        grpInfo.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
        grpInfo.Location = new Point(12, 56);
        grpInfo.Name = "grpInfo";
        grpInfo.Size = new Size(860, 115);
        grpInfo.TabIndex = 1;
        grpInfo.TabStop = false;
        grpInfo.Text = "Thông tin sản phẩm";
        // 
        // nudSoLuong
        // 
        nudSoLuong.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
        nudSoLuong.Location = new Point(690, 68);
        nudSoLuong.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
        nudSoLuong.Name = "nudSoLuong";
        nudSoLuong.Size = new Size(150, 24);
        nudSoLuong.TabIndex = 9;
        // 
        // nudDonGia
        // 
        nudDonGia.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
        nudDonGia.Increment = new decimal(new int[] { 1000, 0, 0, 0 });
        nudDonGia.Location = new Point(410, 68);
        nudDonGia.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
        nudDonGia.Name = "nudDonGia";
        nudDonGia.Size = new Size(180, 24);
        nudDonGia.TabIndex = 7;
        nudDonGia.ThousandsSeparator = true;
        // 
        // cboLoaiSP
        // 
        cboLoaiSP.DropDownStyle = ComboBoxStyle.DropDownList;
        cboLoaiSP.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
        cboLoaiSP.FormattingEnabled = true;
        cboLoaiSP.Items.AddRange(new object[] { "Đồ uống", "Thực phẩm", "Bánh kẹo", "Gia dụng", "Văn phòng phẩm", "Khác" });
        cboLoaiSP.Location = new Point(115, 68);
        cboLoaiSP.Name = "cboLoaiSP";
        cboLoaiSP.Size = new Size(190, 25);
        cboLoaiSP.TabIndex = 5;
        // 
        // txtTenSP
        // 
        txtTenSP.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
        txtTenSP.Location = new Point(410, 28);
        txtTenSP.Name = "txtTenSP";
        txtTenSP.PlaceholderText = "Nhập tên sản phẩm";
        txtTenSP.Size = new Size(430, 24);
        txtTenSP.TabIndex = 3;
        // 
        // txtMaSP
        // 
        txtMaSP.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
        txtMaSP.Location = new Point(115, 28);
        txtMaSP.Name = "txtMaSP";
        txtMaSP.PlaceholderText = "Ví dụ: SP01";
        txtMaSP.Size = new Size(190, 24);
        txtMaSP.TabIndex = 1;
        // 
        // lblSoLuong
        // 
        lblSoLuong.AutoSize = true;
        lblSoLuong.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
        lblSoLuong.Location = new Point(620, 71);
        lblSoLuong.Name = "lblSoLuong";
        lblSoLuong.Size = new Size(64, 17);
        lblSoLuong.TabIndex = 8;
        lblSoLuong.Text = "Số lượng:";
        // 
        // lblDonGia
        // 
        lblDonGia.AutoSize = true;
        lblDonGia.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
        lblDonGia.Location = new Point(325, 71);
        lblDonGia.Name = "lblDonGia";
        lblDonGia.Size = new Size(57, 17);
        lblDonGia.TabIndex = 6;
        lblDonGia.Text = "Đơn giá:";
        // 
        // lblLoaiSP
        // 
        lblLoaiSP.AutoSize = true;
        lblLoaiSP.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
        lblLoaiSP.Location = new Point(15, 71);
        lblLoaiSP.Name = "lblLoaiSP";
        lblLoaiSP.Size = new Size(55, 17);
        lblLoaiSP.TabIndex = 4;
        lblLoaiSP.Text = "Loại SP:";
        // 
        // lblTenSP
        // 
        lblTenSP.AutoSize = true;
        lblTenSP.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
        lblTenSP.Location = new Point(325, 31);
        lblTenSP.Name = "lblTenSP";
        lblTenSP.Size = new Size(51, 17);
        lblTenSP.TabIndex = 2;
        lblTenSP.Text = "Tên SP:";
        // 
        // lblMaSP
        // 
        lblMaSP.AutoSize = true;
        lblMaSP.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
        lblMaSP.Location = new Point(15, 31);
        lblMaSP.Name = "lblMaSP";
        lblMaSP.Size = new Size(50, 17);
        lblMaSP.TabIndex = 0;
        lblMaSP.Text = "Mã SP:";
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
        grpSearch.Text = "Tìm kiếm sản phẩm";
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
        txtTimKiem.PlaceholderText = "Nhập mã hoặc tên SP...";
        txtTimKiem.Size = new Size(180, 24);
        txtTimKiem.TabIndex = 0;
        txtTimKiem.KeyDown += txtTimKiem_KeyDown;
        // 
        // dgvProducts
        // 
        dgvProducts.AllowUserToAddRows = false;
        dgvProducts.AllowUserToDeleteRows = false;
        dgvProducts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvProducts.BackgroundColor = Color.White;
        dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvProducts.Columns.AddRange(new DataGridViewColumn[] { colMaSP, colTenSP, colLoaiSP, colDonGia, colSoLuong, colThanhTien });
        dgvProducts.Location = new Point(12, 255);
        dgvProducts.MultiSelect = false;
        dgvProducts.Name = "dgvProducts";
        dgvProducts.ReadOnly = true;
        dgvProducts.RowHeadersWidth = 30;
        dgvProducts.RowTemplate.Height = 28;
        dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvProducts.Size = new Size(860, 285);
        dgvProducts.TabIndex = 4;
        dgvProducts.CellClick += dgvProducts_CellClick;
        // 
        // colMaSP
        // 
        colMaSP.DataPropertyName = "MaSP";
        colMaSP.FillWeight = 80F;
        colMaSP.HeaderText = "Mã SP";
        colMaSP.Name = "colMaSP";
        colMaSP.ReadOnly = true;
        // 
        // colTenSP
        // 
        colTenSP.DataPropertyName = "TenSP";
        colTenSP.FillWeight = 160F;
        colTenSP.HeaderText = "Tên sản phẩm";
        colTenSP.Name = "colTenSP";
        colTenSP.ReadOnly = true;
        // 
        // colLoaiSP
        // 
        colLoaiSP.DataPropertyName = "LoaiSP";
        colLoaiSP.FillWeight = 100F;
        colLoaiSP.HeaderText = "Loại SP";
        colLoaiSP.Name = "colLoaiSP";
        colLoaiSP.ReadOnly = true;
        // 
        // colDonGia
        // 
        colDonGia.DataPropertyName = "DonGia";
        dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleRight;
        dataGridViewCellStyle1.Format = "N0";
        colDonGia.DefaultCellStyle = dataGridViewCellStyle1;
        colDonGia.FillWeight = 100F;
        colDonGia.HeaderText = "Đơn giá (VNĐ)";
        colDonGia.Name = "colDonGia";
        colDonGia.ReadOnly = true;
        // 
        // colSoLuong
        // 
        colSoLuong.DataPropertyName = "SoLuong";
        dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
        colSoLuong.DefaultCellStyle = dataGridViewCellStyle2;
        colSoLuong.FillWeight = 80F;
        colSoLuong.HeaderText = "Số lượng";
        colSoLuong.Name = "colSoLuong";
        colSoLuong.ReadOnly = true;
        // 
        // colThanhTien
        // 
        colThanhTien.DataPropertyName = "ThanhTien";
        colThanhTien.FillWeight = 110F;
        colThanhTien.HeaderText = "Thành tiền (VNĐ)";
        colThanhTien.Name = "colThanhTien";
        colThanhTien.ReadOnly = true;
        // 
        // FrmProduct
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(245, 247, 250);
        ClientSize = new Size(884, 552);
        Controls.Add(dgvProducts);
        Controls.Add(grpSearch);
        Controls.Add(grpActions);
        Controls.Add(grpInfo);
        Controls.Add(panelHeader);
        MinimumSize = new Size(800, 500);
        Name = "FrmProduct";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Quản lý sản phẩm";
        Load += FrmProduct_Load;
        panelHeader.ResumeLayout(false);
        grpInfo.ResumeLayout(false);
        grpInfo.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)nudSoLuong).EndInit();
        ((System.ComponentModel.ISupportInitialize)nudDonGia).EndInit();
        grpActions.ResumeLayout(false);
        grpSearch.ResumeLayout(false);
        grpSearch.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
        ResumeLayout(false);
    }

    private Panel panelHeader;
    private Label lblHeader;
    private GroupBox grpInfo;
    private Label lblMaSP;
    private TextBox txtMaSP;
    private Label lblTenSP;
    private TextBox txtTenSP;
    private Label lblLoaiSP;
    private ComboBox cboLoaiSP;
    private Label lblDonGia;
    private NumericUpDown nudDonGia;
    private Label lblSoLuong;
    private NumericUpDown nudSoLuong;
    private GroupBox grpActions;
    private Button btnThem;
    private Button btnSua;
    private Button btnXoa;
    private Button btnLamMoi;
    private GroupBox grpSearch;
    private TextBox txtTimKiem;
    private Button btnTimKiem;
    private Button btnHienTatCa;
    private DataGridView dgvProducts;
    private DataGridViewTextBoxColumn colMaSP;
    private DataGridViewTextBoxColumn colTenSP;
    private DataGridViewTextBoxColumn colLoaiSP;
    private DataGridViewTextBoxColumn colDonGia;
    private DataGridViewTextBoxColumn colSoLuong;
    private DataGridViewTextBoxColumn colThanhTien;
}
