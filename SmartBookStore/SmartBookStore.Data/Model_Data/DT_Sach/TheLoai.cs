using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBookStore.Data.Model_Data.DT_Sach
{
    public class TheLoai
    {
        [Key]
        public int MaTheLoai { get; set; }

        [Required]
        [MaxLength(100)]
        public string TenTheLoai { get; set; } = string.Empty;

        public virtual ICollection<Sach_TheLoai> Sach_TheLoais { get; set; } = new List<Sach_TheLoai>();
    }
}
