using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBookStore.Data.Model_Data.DT_Sach
{
    public class TacGia
    {
        [Key]
        public int MaTacGia { get; set; }

        [Required]
        [MaxLength(100)]
        public string TenTacGia { get; set; } = string.Empty;

        public virtual ICollection<Sach_TacGia> Sach_TacGias { get; set; } = new List<Sach_TacGia>();
    }
}
