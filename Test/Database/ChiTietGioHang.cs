using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Database
{
    public class ChiTietGioHang
    {
        [Key]
        [Column(Order = 1)]
        public string idGioHang { get; set; }
        [Key]
        [Column(Order = 2)]
        public string idSach { get; set; }

        public GioHang GioHang { get; set; }
        public Sach Sach { get; set; }
    }
}
