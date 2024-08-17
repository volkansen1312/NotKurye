using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotKurye.DB_Classları
{
    public class GonderilenMailIcerikleri
    {
        [Key]
        public int ID { get; set; }
        public string OgrenciNo { get; set; }
        public string OgrenciAdi { get; set; }
        public string OgrenciSoyadi { get; set; }
        public string DersAdi { get; set; }
        public string SinavTuru { get; set; }
        public string OgrenciMailHesabi { get; set; }
        public int Not { get; set; }
        public string? Mesaj { get; set; }
    }
}
