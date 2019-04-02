using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Database
{
    public class TaiKhoanAdmin
    {
        [Key]
        public string id { get; set; }
        public string TaiKhoan { get; set; }
        public string MatKhau { get; set; }
        public char MaXacNhan { get; set; }
        public int RoleId { get; set; }
    }
}
