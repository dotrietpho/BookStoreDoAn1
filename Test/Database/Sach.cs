using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Database
{
    public class Sach
    {
        [Key]
        public int id { get; set; }
        public string TenSach { get; set; }
        public int GiaSach { get; set; }
        public string TenTacGia { get; set; }
        public int SoTrang { get; set; }
        public int SoLuongConLai { get; set; }
        public int SoLuongXem { get; set; }
        public string MoTa { get; set; }
        public bool isDeleted { get; set; }
        public ICollection<ChiTietTheLoai> ChiTietTheLoais { get; set; }
        public ICollection<ChiTietGioHang> ChiTietGioHangs { get; set; }

        public Sach(int id, string ten, int gia, string tenTacGia)
        {
            this.id = id;
            TenSach = ten;
            GiaSach = gia;
            TenTacGia = tenTacGia;
            isDeleted = false;
        }

        public Sach() { }
        public Sach(Sach a)
        {
            this.id = a.id;
            this.TenSach = a.TenSach;
            this.TenTacGia = a.TenTacGia;
            this.GiaSach = a.GiaSach;
            this.TenTacGia = a.TenTacGia;
            this.SoTrang = a.SoTrang;
            this.SoLuongConLai = a.SoLuongConLai;
            this.SoLuongXem = a.SoLuongXem;
            this.MoTa = a.MoTa;
            this.isDeleted = a.isDeleted;
        }
    }
}
