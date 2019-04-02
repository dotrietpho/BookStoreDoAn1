using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Database
{
    public class KhachHang
    {
        [Key]
        public string email { get; set; }
        public string MatKhau { get; set; }
        public string TenKH { get; set; }
        public string NgaySinh { get; set; }
        public int SDT { get; set; }
        public bool GioiTinh { get; set; }
        public int SoLanTruyCap { get; set; }
        public string AnhDaiDien { get; set; }
        public bool isDeleted { get; set; }
     
        public virtual GioHang GioHang { get; set; }
    }
}
