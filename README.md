# Quản Lý Sinh Viên - BT2.2

## Giới thiệu

Ứng dụng quản lý thông tin sinh viên được xây dựng bằng **Windows Forms** trên nền tảng **.NET Framework 4.8**. Chương trình cho phép người dùng thêm, sửa, xóa và hiển thị danh sách sinh viên với các thông tin cơ bản như: Mã số sinh viên, Họ tên, Giới tính, Điểm trung bình và Chuyên ngành.

## Chức năng

- ✅ **Thêm sinh viên mới**: Nhập thông tin và thêm vào danh sách
- ✅ **Cập nhật thông tin**: Sửa đổi thông tin sinh viên đã có
- ✅ **Xóa sinh viên**: Xóa sinh viên khỏi danh sách
- ✅ **Hiển thị danh sách**: Xem toàn bộ sinh viên trong bảng
- ✅ **Thống kê giới tính**: Đếm số lượng sinh viên Nam/Nữ

## Yêu cầu hệ thống

### Phần mềm cần thiết

- **Hệ điều hành**: Windows 7 trở lên
- **Framework**: .NET Framework 4.8
- **IDE** (để phát triển): Visual Studio 2019 hoặc mới hơn

### Cài đặt .NET Framework 4.8

Nếu máy tính chưa có .NET Framework 4.8, tải tại:
- [Microsoft .NET Framework 4.8 (Offline Installer)](https://dotnet.microsoft.com/download/dotnet-framework/net48)

## Hướng dẫn cài đặt

### Cách 1: Chạy từ mã nguồn

1. **Clone repository về máy**:
   ```bash
   git clone https://github.com/truongchuot111205-art/Quan-Ly-Sinh-Vien.git
   cd Quan-Ly-Sinh-Vien
   ```

2. **Mở project bằng Visual Studio**:
   - Mở file `BT2.2.sln` hoặc `BT2.2.csproj`
   - Chờ Visual Studio tải các dependencies

3. **Build và chạy chương trình**:
   - Nhấn **F5** hoặc chọn **Debug > Start Debugging**
   - Hoặc nhấn **Ctrl+F5** để chạy không debug

### Cách 2: Chạy file thực thi (.exe)

1. Tải file **BT2.2.exe** từ thư mục `bin/Debug` hoặc `bin/Release`
2. Đảm bảo đã cài đặt .NET Framework 4.8
3. Double-click vào file **BT2.2.exe** để chạy

## Hướng dẫn sử dụng

### 1. Thêm sinh viên mới

<img width="308" height="412" alt="image" src="https://github.com/user-attachments/assets/8b76ee4a-a5cf-4ea4-a722-df901f1ecf55" />

1. Nhập đầy đủ thông tin vào các trường:
   - **MSSV** (Mã số sinh viên)
   - **Họ tên**
   - **Giới tính** (chọn Nam/Nữ)
   - **Điểm TB** (điểm trung bình)
   - **Chuyên ngành** (chọn từ dropdown)

2. Nhấn nút **Thêm/Sửa**
3. <img width="301" height="459" alt="image" src="https://github.com/user-attachments/assets/b7df7c41-b24a-4045-a1ef-159f70e8b004" />

4. Thông báo "Thêm mới dữ liệu thành công!" sẽ hiện ra
<img width="906" height="610" alt="image" src="https://github.com/user-attachments/assets/b976b6a4-0a1f-4b32-8225-0c2952aceef4" />

### 2. Cập nhật thông tin sinh viên
<img width="901" height="601" alt="image" src="https://github.com/user-attachments/assets/01c76f74-994a-4d5d-b676-b2b392bd6bbe" />

1. Click vào dòng sinh viên cần sửa trong bảng
2. Thông tin sẽ tự động điền vào các trường nhập liệu
3. Chỉnh sửa thông tin cần thiết
4. Nhấn nút **Thêm/Sửa**
5. Thông báo "Cập nhật dữ liệu thành công!" sẽ hiện ra
<img width="244" height="150" alt="image" src="https://github.com/user-attachments/assets/3e919b40-ac68-4f85-85b3-187e477b6fdf" />

### 3. Xóa sinh viên
<img width="892" height="596" alt="image" src="https://github.com/user-attachments/assets/79fd428e-8812-458d-93ab-cc782a00ff75" />

1. Nhập **MSSV** của sinh viên cần xóa
2. Nhấn nút **Xóa**
3. Xác nhận trong hộp thoại "Bạn có muốn xóa?"
4. Chọn **Yes** để xóa, **No** để hủy

### 4. Xem thống kê
<img width="899" height="598" alt="image" src="https://github.com/user-attachments/assets/a20617f9-0b79-40e1-9842-aa79efb1e436" />

- Số lượng sinh viên **Nam** và **Nữ** được hiển thị tự động ở cuối form

## Cấu trúc dự án

```
BT2.2/
│
├── Form1.cs                 # Logic xử lý chính
├── Form1.Designer.cs        # Thiết kế giao diện (auto-generated)
├── Form1.resx              # Resources của Form1
├── Program.cs              # Entry point của ứng dụng
├── App.config              # Cấu hình ứng dụng
├── BT2.2.csproj           # File project
└── Properties/             # Thông tin assembly và resources
    ├── AssemblyInfo.cs
    ├── Resources.Designer.cs
    └── Settings.Designer.cs
```

## Lỗi thường gặp

### Lỗi: "Vui lòng nhập đầy đủ thông tin sinh viên!"
**Nguyên nhân**: Chưa điền đầy đủ các trường MSSV, Họ tên hoặc Điểm TB  
**Giải pháp**: Kiểm tra và nhập đầy đủ tất cả các trường bắt buộc

### Lỗi: "Không tìm thấy MSSV cần xóa!"
**Nguyên nhân**: MSSV nhập vào không tồn tại trong danh sách  
**Giải pháp**: Kiểm tra lại MSSV hoặc chọn sinh viên từ bảng trước khi xóa

### Lỗi: Không chạy được file .exe
**Nguyên nhân**: Thiếu .NET Framework 4.8  
**Giải pháp**: Tải và cài đặt .NET Framework 4.8 từ Microsoft

## Công nghệ sử dụng

- **Ngôn ngữ**: C#
- **Framework**: .NET Framework 4.8
- **GUI**: Windows Forms
- **IDE**: Visual Studio

## Tác giả

- **Môn học**: Lập trình trên môi trường Windows
- **Lớp**: [23DATA1]
- **Nhóm thực hiện**: [Nhóm 10]
- **Thành viên**:
  - [Phạm Duy Khánh] 
  - [Trân Duy Thái] 
  - [Phạm Nguyễn Minh Sơn] 
  - [Nguyễn Nhật Lâm]

## Giấy phép

Dự án này được phát triển cho mục đích học tập.

## Liên hệ

Nếu có thắc mắc hoặc góp ý, vui lòng liên hệ qua:
- Email: [email của bạn]
- GitHub: [link GitHub profile]

---

⭐ **Lưu ý**: Đây là dự án học tập, vui lòng không sử dụng cho mục đích thương mại.
