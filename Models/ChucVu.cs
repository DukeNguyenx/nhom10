using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace QLNS.Models
{
    public class ChucVu
    { 
        [Key]
        [Display(Name ="Mã Chức vụ")]
        public string? MaChucvu { get; set; }
        [Display(Name ="Tên Chức vụ")]
        public string? TenChucvu { get; set; }
    }
}