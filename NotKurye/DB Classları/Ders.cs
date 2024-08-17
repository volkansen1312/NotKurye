using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotKurye.DB_Classları
{
    public class Ders
    {
        [Key]
        public string DersKodu {  get; set; }
        public string DersAdi { get; set; }
        public int Kredi { get; set; }
        public int Acts { get; set; }
        public Akademisyen Akademisyen { get; set; }
        public ICollection<Ogrenci> Ogrenciler { get; set; }
    }
}
