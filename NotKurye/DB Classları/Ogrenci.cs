using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotKurye.DB_Classları
{
    public class Ogrenci : Kişi
    {
        [Key]
        public long OgrenciNo { get; set; }
        public ICollection<Ders> Dersler { get; set; }
    }
}
