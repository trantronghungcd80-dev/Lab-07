using System.ComponentModel;
using ShopManagerMini.Models;

namespace ShopManagerMini.Forms;

public partial class FrmProduct : Form
{
    // Dữ liệu sản phẩm lưu trong bộ nhớ (static để không bị mất khi đóng/mở lại Form)
    private static BindingList<Product> _productList = new();

    public FrmProduct()
    {
        InitializeComponent();
    }

    private void FrmProduct_Load(object sender, EventArgs e)
    {
        // Khởi tạo dữ liệu mẫu nếu danh sách đang trống
        if (_productList.Count == 0)
        {
            _productList.Add(new Product("SP01", "Bánh mì hoa cúc", "Bánh kẹo", 35000, 50));
            _productList.Add(new Product("SP02", "Sữa tươi Vinamilk 1L", "Đồ uống", 32000, 100));
            _productList.Add(new Product("SP03", "Nước ngọt Coca-Cola 330ml", "Đồ uống", 10000, 150));
            _productList.Add(new Product("SP04", "Mì Hảo Hảo tôm chua cay", "Thực phẩm", 4500, 300));
            _productList.Add(new Product("SP05", "Dầu ăn Simply 1L", "Gia dụng", 58000, 45));
            _productList.Add(new Product("SP06", "Bút bi Thiên Long", "Văn phòng phẩm", 5000, 200));
        }

        dgvProducts.AutoGenerateColumns = false;
        LoadProductList(_productList);

        if (cboLoaiSP.Items.Count > 0)
        {
            cboLoaiSP.SelectedIndex = 0;
        }
    }

    private void LoadProductList(IEnumerable<Product> list)
    {
        dgvProducts.DataSource = null;
        dgvProducts.DataSource = new BindingList<Product>(list.ToList());
    }

    private void btnThem_Click(object sender, EventArgs e)
    {
        string maSP = txtMaSP.Text.Trim();
        string tenSP = txtTenSP.Text.Trim();
        string loaiSP = cboLoaiSP.SelectedItem?.ToString() ?? "";
        decimal donGia = nudDonGia.Value;
        int soLuong = (int)nudSoLuong.Value;

        // Kiểm tra thông tin rỗng
        if (string.IsNullOrEmpty(maSP))
        {
            MessageBox.Show("Mã sản phẩm không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtMaSP.Focus();
            return;
        }

        if (string.IsNullOrEmpty(tenSP))
        {
            MessageBox.Show("Tên sản phẩm không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtTenSP.Focus();
            return;
        }

        if (string.IsNullOrEmpty(loaiSP))
        {
            MessageBox.Show("Vui lòng chọn loại sản phẩm!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            cboLoaiSP.Focus();
            return;
        }

        // 7.3 Không cho đơn giá hoặc số lượng âm
        if (donGia < 0 || soLuong < 0)
        {
            MessageBox.Show("Đơn giá và số lượng phải lớn hơn hoặc bằng 0!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        // 7.3 Không cho thêm sản phẩm trùng mã
        bool exists = _productList.Any(p => p.MaSP.Equals(maSP, StringComparison.OrdinalIgnoreCase));
        if (exists)
        {
            MessageBox.Show($"Mã sản phẩm '{maSP}' đã tồn tại! Vui lòng nhập mã khác.",
                            "Cảnh báo trùng mã",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
            txtMaSP.Focus();
            return;
        }

        Product newProduct = new Product(maSP, tenSP, loaiSP, donGia, soLuong);
        _productList.Add(newProduct);
        LoadProductList(_productList);

        MessageBox.Show("Thêm sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        ResetInput();
    }

    private void btnSua_Click(object sender, EventArgs e)
    {
        string maSP = txtMaSP.Text.Trim();
        if (string.IsNullOrEmpty(maSP))
        {
            MessageBox.Show("Vui lòng chọn sản phẩm cần sửa từ danh sách!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        Product? product = _productList.FirstOrDefault(p => p.MaSP.Equals(maSP, StringComparison.OrdinalIgnoreCase));
        if (product == null)
        {
            MessageBox.Show($"Không tìm thấy sản phẩm có mã '{maSP}' để cập nhật!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        string tenSP = txtTenSP.Text.Trim();
        string loaiSP = cboLoaiSP.SelectedItem?.ToString() ?? "";
        decimal donGia = nudDonGia.Value;
        int soLuong = (int)nudSoLuong.Value;

        if (string.IsNullOrEmpty(tenSP))
        {
            MessageBox.Show("Tên sản phẩm không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtTenSP.Focus();
            return;
        }

        if (donGia < 0 || soLuong < 0)
        {
            MessageBox.Show("Đơn giá và số lượng phải lớn hơn hoặc bằng 0!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        product.TenSP = tenSP;
        product.LoaiSP = loaiSP;
        product.DonGia = donGia;
        product.SoLuong = soLuong;

        LoadProductList(_productList);
        MessageBox.Show("Cập nhật thông tin sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void btnXoa_Click(object sender, EventArgs e)
    {
        string maSP = txtMaSP.Text.Trim();
        if (string.IsNullOrEmpty(maSP))
        {
            MessageBox.Show("Vui lòng chọn sản phẩm cần xóa từ danh sách!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        Product? product = _productList.FirstOrDefault(p => p.MaSP.Equals(maSP, StringComparison.OrdinalIgnoreCase));
        if (product == null)
        {
            MessageBox.Show($"Không tìm thấy sản phẩm có mã '{maSP}' để xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        // 7.3 Khi xóa phải hỏi xác nhận
        DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa sản phẩm '{product.TenSP}' (Mã: {product.MaSP})?",
                                              "Xác nhận xóa",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Question);
        if (result == DialogResult.Yes)
        {
            _productList.Remove(product);
            LoadProductList(_productList);
            ResetInput();
            MessageBox.Show("Xóa sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    private void btnLamMoi_Click(object sender, EventArgs e)
    {
        ResetInput();
        LoadProductList(_productList);
    }

    private void ResetInput()
    {
        txtMaSP.Clear();
        txtTenSP.Clear();
        if (cboLoaiSP.Items.Count > 0) cboLoaiSP.SelectedIndex = 0;
        nudDonGia.Value = 0;
        nudSoLuong.Value = 0;
        txtMaSP.Enabled = true;
        txtTimKiem.Clear();
        txtMaSP.Focus();
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
            LoadProductList(_productList);
            return;
        }

        var filtered = _productList.Where(p => 
            p.MaSP.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
            p.TenSP.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
            p.LoaiSP.Contains(keyword, StringComparison.OrdinalIgnoreCase)).ToList();

        LoadProductList(filtered);

        if (filtered.Count == 0)
        {
            MessageBox.Show($"Không tìm thấy sản phẩm nào phù hợp với từ khóa '{keyword}'!",
                            "Kết quả tìm kiếm",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }
    }

    private void btnHienTatCa_Click(object sender, EventArgs e)
    {
        txtTimKiem.Clear();
        LoadProductList(_productList);
    }

    private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0 && e.RowIndex < dgvProducts.Rows.Count)
        {
            DataGridViewRow row = dgvProducts.Rows[e.RowIndex];
            txtMaSP.Text = row.Cells["colMaSP"].Value?.ToString() ?? "";
            txtTenSP.Text = row.Cells["colTenSP"].Value?.ToString() ?? "";
            cboLoaiSP.SelectedItem = row.Cells["colLoaiSP"].Value?.ToString();
            
            if (decimal.TryParse(row.Cells["colDonGia"].Value?.ToString(), out decimal donGia))
            {
                nudDonGia.Value = donGia;
            }

            if (int.TryParse(row.Cells["colSoLuong"].Value?.ToString(), out int soLuong))
            {
                nudSoLuong.Value = soLuong;
            }

            // Khóa mã sản phẩm khi đang xem/sửa
            txtMaSP.Enabled = false;
        }
    }
}
