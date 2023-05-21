using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace QLNS.Models
{
    public class Nhansu

    {
        [Key]
        [Required(ErrorMessage ="ID không được bỏ trống")]
        [Display(Name ="Mã nhân viên")]
        public string MaNV {get; set;}
        
        [Required(ErrorMessage ="Họ Và Tên không được bỏ trống")]
        [Display(Name ="Họ Và Tên")]
        public string Hoten {get; set;}
        [Display(Name ="Ngày Sinh")]
        public string NgaySinh {get; set;}
         [Display(Name ="Giới tính")]
        public string Gioitinh {get; set;}
        [Required(ErrorMessage ="Chức vụ không được bỏ trống")]
         [Display(Name ="Chức vụ")]
        public string Chucvu  {get; set;}
        public string MaPhong  {get; set;}
        [ForeignKey("MaPhong")]
        [Display(Name ="Mã Phòng")]
        public Phongban? TenPhong {get; set;} 
        [Required(ErrorMessage ="Số điện thoại không được bỏ trống")]
        [Display(Name ="Số điện thoại")]        
        public string SDT {get; set;}
        [Required(ErrorMessage ="Email không được bỏ trống")]
        public string Email {get; set;}
    }
}