﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace De01_NguyenPhamPhuHuy_CNTT_6251071038
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class SanPham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SanPham()
        {
            this.SPtheoMaus = new HashSet<SPtheoMau>();
        }
        [DisplayName("Mã Sản Phẩm")]
        public string MaSanPham { get; set; }

        [DisplayName("Tên Sản Phẩm")]
        public string TenSanPham { get; set; }

        [DisplayName("Mã Phân Loại")]
        public string MaPhanLoai { get; set; }

        [DisplayName("Giá Nhập")]
        [RegularExpression(@"^\d[0-9]+$", ErrorMessage = "Vui lòng nhập số không âm")]
        public Nullable<long> GiaNhap { get; set; }

        [DisplayName("Đơn Giá Bán Nhỏ Nhất")]
        [RegularExpression(@"^\d[0-9]+$", ErrorMessage = "Vui lòng nhập số không âm")]
        public Nullable<long> DonGiaBanNhoNhat { get; set; }

        [DisplayName("Đơn Giá Bán Lớn Nhất")]
        [RegularExpression(@"^\d[0-9]+$", ErrorMessage = "Vui lòng nhập số không âm")]
        public Nullable<long> DonGiaBanLonNhat { get; set; }

        [DisplayName("Trạng Thái")]
        public Nullable<bool> TrangThai { get; set; }

        [DisplayName("Mô Tả Ngắn")]
        public string MoTaNgan { get; set; }

        [DisplayName("Ảnh Đại Diện")]
        [RegularExpression(@"^.+\.jpg$", ErrorMessage = "Định dạng ảnh phải là '.jpg'.")]
        public string AnhDaiDien { get; set; }

        [DisplayName("Nổi Bật")]
        public Nullable<bool> NoiBat { get; set; }

        [DisplayName("Mã Phân Loại Phụ")]
        public string MaPhanLoaiPhu { get; set; }

        [Display(Name = "Phân Loại")]
        public virtual PhanLoai PhanLoai { get; set; }

        [Display(Name = "Phân Loại Phụ")]
        public virtual PhanLoaiPhu PhanLoaiPhu { get; set; }

        [DisplayName("Sản Phẩm Theo Màu")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SPtheoMau> SPtheoMaus { get; set; }
    }
}
