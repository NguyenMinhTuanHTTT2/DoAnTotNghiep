using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBookStore.Data.Model_Data.DT_Sach
{
    public class DanhMuc
    {
        [Key]
        public int MaDanhMuc { get; set; }

        [Required]
        [MaxLength(150)]
        public string TenDanhMuc { get; set; } = string.Empty;

        [MaxLength(500)]
        public string? MoTa { get; set; }

        // Quan hệ 1 - N: DanhMuc -> Thể loại
        // 1 Danh mục có nhiều Thể loại
        public virtual ICollection<TheLoai> TheLoais { get; set; } = new List<TheLoai>();
        }
    }
