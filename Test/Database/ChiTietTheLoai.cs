using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Database
{
    public class ChiTietTheLoai
    {
        [Key]
        [Column(Order = 1)]
        public int idSach { get; set; }
        [Key]
        [Column(Order = 2)]
        public int idTheLoai { get; set; }

        public Sach Sach { get; set; }
        public TheLoai TheLoai {get;set;}
    }
}
