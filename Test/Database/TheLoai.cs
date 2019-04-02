using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Database
{
    public class TheLoai
    {
        [Key]
        public int id { get; set; }
        public string TenTL { get; set; }
        public bool isDeleted { get; set; }
        public ICollection<ChiTietTheLoai> ChiTietTheLoais { get; set; }
    }
}
