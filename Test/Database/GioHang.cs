using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Database
{
    public class GioHang
    {
        [Key]
        public int id { get; set; }
        public int TongTienGioHang { get; set; }
        public string TinhTrang { get; set; }
        public bool isDeleted { get; set; }
        public ICollection<ChiTietGioHang> ChiTietGioHangs { get; set; }
    
    }
}
