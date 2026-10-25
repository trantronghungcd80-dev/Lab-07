using System.ComponentModel;
using ShopManagerMini.Models;

namespace ShopManagerMini.Forms;

public partial class FrmCustomer : Form
{
    // Danh sách khách hàng lưu tạm trong bộ nhớ
    private static BindingList<Customer> _customerList = new();

    public FrmCustomer()
    {
        InitializeComponent();
    }

    private void FrmCustomer_Load(object sender, EventArgs e)
    {
        if (_customerList.Count == 0)
        {
            _customerList.Add(new Customer("KH01", "Nguyễn Văn An", "0901234567", "VIP"));
            _customerList.Add(new Customer("KH02", "Trần Thị Bích", "0912345678", "Thân thiết"));
            _customerList.Add(new Customer("KH03", "Lê Hoàng Nam", "0987654321", "Thường"));
            _customerList.Add(new Customer("KH04", "Phạm Thu Hà", "0933445566", "Tiềm năng"));
        }

        dgvCustomers.AutoGenerateColumns = false;
        LoadCustomerList(_customerList);

        if (cboLoaiKH.Items.Count > 0)
        {
            cboLoaiKH.SelectedIndex = 0;
        }
    }

    private void LoadCustomerList(IEnumerable<Customer> list)
    {
        dgvCustomers.DataSource = null;
        dgvCustomers.DataSource = new BindingList<Customer>(list.ToList());
    }

    private void btnThem_Click(object sender, EventArgs e)
    {
        string maKH = txtMaKH.Text.Trim();
        string hoTen = txtHoTen.Text.Trim();
        string soDienThoai = txtSoDienThoai.Text.Trim();
        string loaiKH = cboLoaiKH.SelectedItem?.ToString() ?? "";

        // Kiểm tra thông tin rỗng
        if (string.IsNullOrEmpty(maKH))
        {
            MessageBox.Show("Mã khách hàng không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtMaKH.Focus();
            return;
        }

        if (string.IsNullOrEmpty(hoTen))
        {
            MessageBox.Show("Họ tên khách hàng không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtHoTen.Focus();
            return;
        }

        if (string.IsNullOrEmpty(soDienThoai))
        {
            MessageBox.Show("Số điện thoại không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtSoDienThoai.Focus();
            return;
        }

        // Kiểm tra trùng mã khách hàng
        bool exists = _customerList.Any(c => c.MaKH.Equals(maKH, StringComparison.OrdinalIgnoreCase));
        if (exists)
        {
            MessageBox.Show($"Mã khách hàng '{maKH}' đã tồn tại! Vui lòng nhập mã khác.",
                            "Cảnh báo trùng mã",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
            txtMaKH.Focus();
            return;
        }

        Customer newCustomer = new Customer(maKH, hoTen, soDienThoai, loaiKH);
        _customerList.Add(newCustomer);
        LoadCustomerList(_customerList);

        MessageBox.Show("Thêm khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        ResetInput();
    }

    private void btnSua_Click(object sender, EventArgs e)
    {
        string maKH = txtMaKH.Text.Trim();
        if (string.IsNullOrEmpty(maKH))
        {
            MessageBox.Show("Vui lòng chọn khách hàng cần sửa từ danh sách!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        Customer? customer = _customerList.FirstOrDefault(c => c.MaKH.Equals(maKH, StringComparison.OrdinalIgnoreCase));
        if (customer == null)
        {
            MessageBox.Show($"Không tìm thấy khách hàng có mã '{maKH}' để sửa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        string hoTen = txtHoTen.Text.Trim();
        string soDienThoai = txtSoDienThoai.Text.Trim();
        string loaiKH = cboLoaiKH.SelectedItem?.ToString() ?? "";

        if (string.IsNullOrEmpty(hoTen))
        {
            MessageBox.Show("Họ tên khách hàng không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtHoTen.Focus();
            return;
        }

        if (string.IsNullOrEmpty(soDienThoai))
        {
            MessageBox.Show("Số điện thoại không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtSoDienThoai.Focus();
            return;
        }

        customer.HoTen = hoTen;
        customer.SoDienThoai = soDienThoai;
        customer.LoaiKH = loaiKH;

        LoadCustomerList(_customerList);
        MessageBox.Show("Cập nhật thông tin khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void btnXoa_Click(object sender, EventArgs e)
    {
        string maKH = txtMaKH.Text.Trim();
        if (string.IsNullOrEmpty(maKH))
        {
            MessageBox.Show("Vui lòng chọn khách hàng cần xóa từ danh sách!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        Customer? customer = _customerList.FirstOrDefault(c => c.MaKH.Equals(maKH, StringComparison.OrdinalIgnoreCase));
        if (customer == null)
        {
            MessageBox.Show($"Không tìm thấy khách hàng có mã '{maKH}' để xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa khách hàng '{customer.HoTen}' (Mã: {customer.MaKH})?",
                                              "Xác nhận xóa",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Question);
        if (result == DialogResult.Yes)
        {
            _customerList.Remove(customer);
            LoadCustomerList(_customerList);
            ResetInput();
            MessageBox.Show("Xóa khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    private void btnLamMoi_Click(object sender, EventArgs e)
    {
        ResetInput();
        LoadCustomerList(_customerList);
    }

    private void ResetInput()
    {
        txtMaKH.Clear();
        txtHoTen.Clear();
        txtSoDienThoai.Clear();
        if (cboLoaiKH.Items.Count > 0) cboLoaiKH.SelectedIndex = 0;
        txtMaKH.Enabled = true;
        txtTimKiem.Clear();
        txtMaKH.Focus();
    }

    private void btnTimKiem_Click(object sender, EventArgs e)
    {
        PerformSearch();
    }

    private void txtTimKiem_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            e.SuppressKeyPress = true;
            PerformSearch();
        }
    }

    private void PerformSearch()
    {
        string keyword = txtTimKiem.Text.Trim();
        if (string.IsNullOrEmpty(keyword))
        {
            LoadCustomerList(_customerList);
            return;
        }

        var filtered = _customerList.Where(c => 
            c.MaKH.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
            c.HoTen.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
            c.SoDienThoai.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
            c.LoaiKH.Contains(keyword, StringComparison.OrdinalIgnoreCase)).ToList();

        LoadCustomerList(filtered);

        if (filtered.Count == 0)
        {
            MessageBox.Show($"Không tìm thấy khách hàng nào phù hợp với từ khóa '{keyword}'!",
                            "Kết quả tìm kiếm",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }
    }

    private void btnHienTatCa_Click(object sender, EventArgs e)
    {
        txtTimKiem.Clear();
        LoadCustomerList(_customerList);
    }

    private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0 && e.RowIndex < dgvCustomers.Rows.Count)
        {
            DataGridViewRow row = dgvCustomers.Rows[e.RowIndex];
            txtMaKH.Text = row.Cells["colMaKH"].Value?.ToString() ?? "";
            txtHoTen.Text = row.Cells["colHoTen"].Value?.ToString() ?? "";
            txtSoDienThoai.Text = row.Cells["colSoDienThoai"].Value?.ToString() ?? "";
            cboLoaiKH.SelectedItem = row.Cells["colLoaiKH"].Value?.ToString();

            // Khóa mã KH khi đang xem/sửa
            txtMaKH.Enabled = false;
        }
    }
}
