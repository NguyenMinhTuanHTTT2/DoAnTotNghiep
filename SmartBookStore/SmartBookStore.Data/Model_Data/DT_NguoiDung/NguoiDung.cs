using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBookStore.Data.Model_Data.DT_NguoiDung
{
    public class NguoiDung
    {
        [Key]
        public int MaNguoiDung { get; set; }

        [Required]
        [MaxLength(100)]
        public string Ten { get; set; } = string.Empty;

        [Required]
        [MaxLength(100)]
        public string Email { get; set; } = string.Empty;

        [Required]
        [MaxLength(100)]
        public string MatKhau { get; set; } = string.Empty;

        public int MaVaiTro { get; set; }

        public virtual VaiTro VaiTro { get; set; } = null!;

        public virtual ICollection<DT_GioHang.GioHang> GioHangs { get; set; } = new List<DT_GioHang.GioHang>();
        public virtual ICollection<DT_DonHang.DonHang> DonHangs { get; set; } = new List<DT_DonHang.DonHang>();
        public virtual ICollection<DT_HoTroAI.YeuCauHoTro> YeuCauHoTros { get; set; } = new List<DT_HoTroAI.YeuCauHoTro>();
    }
}
