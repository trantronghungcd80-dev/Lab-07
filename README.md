# COMP1019 - BUỔI 7: BÀI LAB
## XÂY DỰNG ỨNG DỤNG QUẢN LÝ CỬA HÀNG MINI NHIỀU FORM (ShopManagerMini)

- **Môn học**: COMP1019 - Lập trình trên Windows
- **Sinh viên thực hiện**: Trần Trọng Hùng
- **Lớp**: CD80
- **Công nghệ**: C# WinForms, .NET 8 LTS, MDI (Multiple Document Interface), Lưu trữ dữ liệu trong bộ nhớ (`BindingList<T>`)

---

## 📌 1. Giới thiệu tổng quan
Dự án **ShopManagerMini** là ứng dụng Windows Forms đa cửa sổ (MDI - Multiple Document Interface) quản lý cửa hàng mini hoàn chỉnh theo yêu cầu bài thực hành Buổi 7. Ứng dụng đáp ứng đầy đủ các tiêu chuẩn kiến trúc giao diện, kiểm soát đa Form, phân quyền tài khoản, và thao tác CRUD dữ liệu trong bộ nhớ.

---

## 🗂️ 2. Cấu trúc Solution & Project
```text
Lab-07/
├── ShopManagerMini.sln             # Visual Studio Solution File
├── .gitignore                      # Cấu hình bỏ qua bin/obj/user files của .NET
├── README.md                       # Tài liệu hướng dẫn & giải đáp câu hỏi
└── ShopManagerMini/                # Project C# WinForms
    ├── ShopManagerMini.csproj      # File cấu hình .NET 8-windows
    ├── Program.cs                  # Điểm khởi chạy, điều phối đăng nhập & đăng xuất
    ├── Models/                     # Lớp dữ liệu (Data Models)
    │   ├── User.cs                 # Mô hình Người dùng (Username, Password, FullName, Role)
    │   ├── Product.cs              # Mô hình Sản phẩm (MaSP, TenSP, LoaiSP, DonGia, SoLuong)
    │   └── Customer.cs             # Mô hình Khách hàng (MaKH, HoTen, SoDienThoai, LoaiKH)
    └── Forms/                      # Các Form giao diện
        ├── FrmLogin.cs             # Màn hình Đăng nhập (Modal ShowDialog)
        ├── FrmLogin.Designer.cs
        ├── FrmMain.cs              # Màn hình chính MDI Parent (MenuStrip, StatusStrip, Timer)
        ├── FrmMain.Designer.cs
        ├── FrmProduct.cs           # Quản lý Sản phẩm (MDI Child, CRUD In-Memory)
        ├── FrmProduct.Designer.cs
        ├── FrmCustomer.cs          # Quản lý Khách hàng (MDI Child, CRUD In-Memory)
        ├── FrmCustomer.Designer.cs
        ├── FrmAbout.cs             # Giới thiệu ứng dụng & thông tin sinh viên
        └── FrmAbout.Designer.cs
```

---

## 🔑 3. Tài khoản đăng nhập mẫu
Hệ thống cung cấp sẵn 2 tài khoản mẫu (theo mục 5 của đề bài):

| Tên đăng nhập | Mật khẩu | Họ và tên | Vai trò | Quyền hạn |
| :--- | :--- | :--- | :--- | :--- |
| **admin** | `123` | Quản trị viên | Admin | Toàn quyền quản trị |
| **user** | `123` | Nhân viên bán hàng | User | Nhân viên bán hàng |

---

## ⚙️ 4. Các tính năng nổi bật đã hoàn thành

### 4.1. Đăng nhập hệ thống (`FrmLogin`)
- Hộp thoại đăng nhập độc lập hiển thị dưới dạng modal (`ShowDialog()`).
- Kiểm tra hợp lệ: Báo lỗi khi để trống tài khoản hoặc mật khẩu, cảnh báo khi thông tin sai.
- Hỗ trợ nút bật/tắt ẩn/hiện mật khẩu.
- Nút "Thoát" có hộp thoại xác nhận trước khi đóng.
- Đăng nhập thành công trả về `DialogResult.OK` và đóng gói thông tin `User` chuyển giao cho `FrmMain`.

### 4.2. Màn hình chính MDI (`FrmMain`)
- Thiết lập `IsMdiContainer = true` làm cửa sổ chứa các Form con.
- **MenuStrip** có phím tắt trực quan:
  - **Hệ thống**: Đăng xuất (`Ctrl + Q`), Thoát (`Alt + F4`).
  - **Danh mục**: Quản lý sản phẩm (`Ctrl + P`), Quản lý khách hàng (`Ctrl + K`).
  - **Trợ giúp**: Giới thiệu (`F1`).
- **StatusStrip**: Hiển thị họ tên người dùng, vai trò (Admin/User), phiên bản và đồng hồ thời gian thực (`Timer` cập nhật từng giây).
- **Chống mở trùng Form con**: Sử dụng phương thức generic `OpenMdiChild<T>()` duyệt qua `MdiChildren`. Nếu Form đã mở thì tự động kích hoạt `Activate()` và khôi phục `Normal`, tuyệt đối không tạo thêm Form trùng lặp.
- **Xác nhận an toàn**: Xác nhận khi thoát ứng dụng hoặc khi bấm đăng xuất. Hỗ trợ quy trình Đăng xuất quay lại Form đăng nhập mượt mà.

### 4.3. Quản lý sản phẩm (`FrmProduct`)
- Hiển thị danh sách sản phẩm bằng `DataGridView` với định dạng tiền tệ Việt Nam (`N0 VNĐ`) và tính tự động thành tiền.
- Chức năng **CRUD** đầy đủ:
  - **Thêm**: Kiểm tra trùng mã sản phẩm, kiểm tra đơn giá và số lượng không âm (`>= 0`).
  - **Sửa**: Cho phép sửa thông tin sản phẩm đã chọn từ lưới.
  - **Xóa**: Bắt buộc xác nhận `MessageBox.Show(..., YesNo)` trước khi xóa khỏi bộ nhớ.
  - **Làm mới**: Xóa trắng form nhập liệu và mở lại khóa mã sản phẩm.
  - **Tìm kiếm**: Tìm kiếm linh hoạt theo mã SP, tên SP hoặc loại sản phẩm. Hỗ trợ nhấn `Enter` và nút "Tất cả".

### 4.4. Quản lý khách hàng (`FrmCustomer`)
- Quản lý danh sách khách hàng gồm: Mã KH, Họ tên, Số điện thoại, Loại khách hàng (Thường, Thân thiết, VIP, Tiềm năng).
- Hỗ trợ đầy đủ thêm mới, sửa, xóa (có xác nhận), làm mới và tìm kiếm khách hàng nhanh chóng.

### 4.5. Màn hình Giới thiệu (`FrmAbout`)
- Trình bày thông tin sinh viên, lớp, môn học, phiên bản ứng dụng và công nghệ sử dụng dưới dạng thẻ trực quan.

---

## 📝 5. Trả lời câu hỏi nộp kèm (Mục 10 của đề bài)

### Câu 1: SDI và MDI khác nhau như thế nào?
- **SDI (Single Document Interface)**: Là mô hình ứng dụng đơn tài liệu. Mỗi cửa sổ/Form tồn tại và hiển thị riêng biệt trên màn hình desktop và thanh tác vụ (Taskbar). Mỗi Form là một cửa sổ độc lập cấp cao nhất (Top-level window). Ví dụ: Notepad, Windows Calculator.
- **MDI (Multiple Document Interface)**: Là mô hình ứng dụng đa tài liệu. Ứng dụng có một cửa sổ cha (`IsMdiContainer = true`) đóng vai trò là khung chứa toàn bộ không gian làm việc. Tất cả các cửa sổ con (`MdiParent = this`) chỉ có thể di chuyển, phóng to, thu nhỏ bên trong giới hạn của cửa sổ cha và không hiển thị thành nhiều mục riêng biệt trên Taskbar. Mô hình này giúp quản lý ứng dụng có nhiều màn hình chức năng gọn gàng, đồng bộ (ví dụ: Adobe Photoshop, Visual Studio, phần mềm kế toán/ERP).

### Câu 2: Vì sao Form đăng nhập nên dùng ShowDialog()?
- `ShowDialog()` hiển thị Form dưới dạng **modal window** (hộp thoại có tính chất khóa luồng giao diện cho đến khi người dùng đóng hộp thoại).
- Cần sử dụng `ShowDialog()` cho Form đăng nhập vì:
  1. **Bảo mật và kiểm soát luồng**: Ngăn chặn người dùng tương tác với bất kỳ phần nào khác của ứng dụng trước khi danh tính được xác thực.
  2. **Thuận tiện kiểm tra kết quả**: `ShowDialog()` trả về một `DialogResult` (`OK` hoặc `Cancel`). Trong hàm `Main()`, ta có thể kiểm tra trực tiếp: nếu `DialogResult == DialogResult.OK` thì mới khởi chạy Form chính, ngược lại nếu bấm nút Thoát/Cancel thì lập tức kết thúc ứng dụng mà không cần mở Form chính.
  3. **Quản lý giải phóng bộ nhớ**: Có thể đặt `FrmLogin` trong khối `using (...)` để tài nguyên của Form đăng nhập được giải phóng (`Dispose`) ngay sau khi hoàn thành.

### Câu 3: Trong bài lab này, dữ liệu user được truyền từ FrmLogin sang FrmMain bằng cách nào?
- Dữ liệu user được truyền thông qua kỹ thuật **Constructor Injection kết hợp Property**:
  1. Tại `FrmLogin`: Sau khi đối chiếu username và password trùng khớp với tài khoản mẫu, đối tượng `User` tương ứng được gán vào thuộc tính:
     ```csharp
     public User? LoggedInUser { get; private set; }
     ```
     Sau đó thiết lập `DialogResult = DialogResult.OK;` và đóng Form.
  2. Tại `Program.cs`: Khi `loginForm.ShowDialog()` trả về `OK`, chương trình lấy `loginForm.LoggedInUser` và truyền trực tiếp vào Constructor của `FrmMain`:
     ```csharp
     FrmMain mainForm = new FrmMain(loginForm.LoggedInUser);
     Application.Run(mainForm);
     ```
  3. Tại `FrmMain`: Constructor nhận tham số `User user` và lưu trữ vào biến `_currentUser` để cập nhật thông tin họ tên, phân quyền trên `StatusStrip` và điều khiển chức năng trong toàn bộ phiên làm việc.

### Câu 4: Nếu người dùng bấm menu sản phẩm nhiều lần, chương trình xử lý như thế nào để không mở trùng Form?
- Chương trình sử dụng phương thức generic `OpenMdiChild<T>()` kiểm tra danh sách các Form con đang tồn tại trong tập hợp `this.MdiChildren`:
  ```csharp
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
              form.Activate(); // Đưa Form đã mở lên trước mặt
              return;          // Kết thúc, không tạo Form mới
          }
      }

      // Nếu chưa có Form loại này, tiến hành khởi tạo mới
      T child = new T();
      child.MdiParent = this;
      child.Show();
  }
  ```
- Nhờ kiểm tra `if (form is T)`, nếu `FrmProduct` đã được mở từ trước, chương trình chỉ khôi phục trạng thái hiển thị (nếu đang bị thu nhỏ) và gọi `Activate()` để focus vào nó, tránh hoàn toàn việc khởi tạo nhiều instance trùng lặp gây tốn bộ nhớ và xung đột dữ liệu.

### Câu 5: Khi nào nên dùng constructor, khi nào nên dùng property để truyền dữ liệu giữa các Form?
- **Nên dùng Constructor**:
  - Khi dữ liệu cần truyền là **bắt buộc (mandatory)** để Form đích có thể khởi tạo và hoạt động bình thường (Ví dụ: `FrmMain` bắt buộc phải có thông tin `User` đã xác thực; Form chi tiết đơn hàng bắt buộc phải có `MaDonHang`).
  - Đảm bảo tính toàn vẹn (immutability), tránh lỗi `NullReferenceException` khi Form được tạo mà quên truyền dữ liệu.
- **Nên dùng Property**:
  - Khi dữ liệu là **tùy chọn (optional)** hoặc có thể được gán/thay đổi sau khi Form đã được khởi tạo (Ví dụ: thiết lập Theme màu, cấu hình hiển thị).
  - Khi cần **lấy dữ liệu trả về** từ Form con/Form dialog sau khi Form đó đóng (Ví dụ: lấy `loginForm.LoggedInUser`, hoặc Form chọn khách hàng trả về `selectedCustomer`).
  - Khi Form cần giữ constructor mặc định không tham số để tương thích với các bộ thiết kế trực quan (Visual Studio Designer) hoặc phương thức `Activator.CreateInstance()`.

---

## 🚀 6. Hướng dẫn cài đặt và chạy ứng dụng

### Yêu cầu môi trường
- Hệ điều hành: Windows 10/11
- .NET SDK: .NET 8.0 trở lên
- IDE: Visual Studio 2022 (khuyến nghị) hoặc Visual Studio Code / Terminal

### Chạy bằng Visual Studio
1. Mở file `ShopManagerMini.sln` bằng Visual Studio.
2. Chọn cấu hình `Debug` hoặc `Release` và nhấn **F5** (hoặc nút **Start**).

### Chạy bằng dòng lệnh (CLI)
```powershell
cd ShopManagerMini
dotnet build
dotnet run
```
