using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thuctap_Share.Models
{
    public enum Gender
    {
        [Display(Name = "Nam")]
        Nam = 1,
        [Display(Name = "Nữ")]
        Nu = 2
    }

    [Table("QuanLyGiangvien")]
    public class Giangvien
    {
        [Key]
        [Required(ErrorMessage = "Bạn Cần Nhập Mã Giảng Viên")]
        [Display(Name = "Mã giảng viên")]
        public int Magiangvien { get; set; }

        [Required(ErrorMessage = "Bạn Cần Nhập Họ Và Tên")]
        [Display(Name = "Họ và tên")]
        [StringLength(100)]
        public string Hovaten { get; set; }

        [Required, Range(1, int.MaxValue, ErrorMessage = "Chọn Giới Tính")]
        [Display(Name = "Giới Tính")]
        public Gender Gioitinh { get; set; }

        [Required(ErrorMessage = "Chọn Ngày Sinh"), Display(Name = "Ngày Sinh")]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? NgaySinh { get; set; }

        [Required(ErrorMessage = "Bạn Cần Nhập Số CMND/CCCD")]
        [Display(Name = "Số CMND/CCCD")]
        public int SoCMND { get; set; }

        [Required(ErrorMessage = "Chọn Ngày Cấp"), Display(Name = "Ngày Cấp")]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? Ngaycap { get; set; }

        [Required(ErrorMessage = "Bạn Cần Chọn Nơi Cấp")]
        [Display(Name = "Nơi Cấp")]
        [StringLength(100)]
        public string Noicap { get; set; }

        [Required(ErrorMessage = "Bạn Cần Chọn Địa Chỉ")]
        [Display(Name = "Địa Chỉ")]
        [StringLength(100)]
        public string Diachi { get; set; }

        [Required(ErrorMessage = "Bạn Cần Nhập Số sổ BHXH")]
        [Display(Name = "Số sổ BHXH")]
        [StringLength(100)]
        public string BHXH { get; set; }

        [Display(Name = "Trình độ đào tạo")]
        [StringLength(100)]
        public string Trinhdodaotao { get; set; }

        [Required(ErrorMessage = "Bạn Cần Nhập Chức Vụ")]
        [Display(Name = "Chức Vụ")]
        [StringLength(100)]
        public string Chucvu { get; set; }

        [Required(ErrorMessage = "Bạn Cần Nhập Tổ Bộ Môn")]
        [Display(Name = "Tổ Bộ Môn")]
        [StringLength(100)]
        public string Tobomon { get; set; }

        [Display(Name = "Văn Bản Quyết Định")]
        [Column(TypeName = "varchar(200)"), MaxLength(100)]
        public string Vanbanquyetdinh { get; set; }

        [NotMapped]
        [Display(Name = "Chọn Văn Bản Quyết Định")]
        public IFormFile ImageFile { get; set; }

        [Required(ErrorMessage = "Chọn Ngày Áp Dụng Chức Vụ"), Display(Name = "Ngày áp dụng chức vụ")]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? Ngayapdungchucvu { get; set; }

        [Required(ErrorMessage = "Chọn Ngày Bắt Đầu Làm Việc"), Display(Name = "Ngày bắt đầu làm việc")]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? Ngaybatdaulamviec { get; set; }
    }
    public class Luong
    {
        [Key]
        [Required(ErrorMessage = "Bạn Cần Chọn Loại Hợp Đồng")]
        [Display(Name = "Loại Hợp Đồng")]
        [StringLength(100)]
        public string Loaihopdong { get; set; }

        [Required(ErrorMessage = "Bạn Cần Chọn Lương Cơ Bản")]
        [Display(Name = "Lương Cơ Bản")]
        public int Lươngcoban { get; set; }

        [Required(ErrorMessage = "Bạn Cần Chọn Lương Cơ Bản")]
        [Display(Name = "Lương Cơ Bản")]
        public int Luongcoban { get; set; }

        [Display(Name = "Văn Bản Quyết Định")]
        [Column(TypeName = "varchar(200)"), MaxLength(100)]
        public string Vanbanquyetdinh { get; set; }

        [NotMapped]
        [Display(Name = "Chọn Văn Bản Quyết Định")]
        [StringLength(100)]
        public IFormFile ImageFile { get; set; }

        [Required(ErrorMessage = "Bạn Cần Chọn Bảo Hiểm Phải Đóng")]
        [Display(Name = "Bảo hiểm phải đóng")]
        [StringLength(100)]
        public string baohiemphaidong { get; set; }

        [Display(Name = "Ngạch/Hang ")]
        [StringLength(100)]
        public string Ngachhang { get; set; }

        [Display(Name = "Bậc Lượng")]
        [StringLength(100)]
        public string Bacluong { get; set; }

        [Display(Name = "Hệ Số Lương")]
        public int Hesoluong { get; set; }

        [Display(Name = "File đính kèm")]
        [Column(TypeName = "varchar(200)"), MaxLength(100)]
        public string Filedinhkem { get; set; }

        [NotMapped]
        [Display(Name = "Chọn Văn Bản Quyết Định")]
        [StringLength(100)]
        public IFormFile Image { get; set; }

        [Required(ErrorMessage = "Chọn Ngày Áp Dụng Ngạch Bậc"), Display(Name = "Ngày áp dụng ngạch bậc")]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? Ngayapdungngachbac { get; set; }
    }
}
