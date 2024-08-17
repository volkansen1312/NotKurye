using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotKurye.DB_Classları
{
    public class NotkuryeDbContext : DbContext
    {
        public DbSet<Akademisyen> Akademisyenler { get; set; }
        public DbSet<Ogrenci> Ogrenciler { get; set; }
        public DbSet<Ders> Dersler { get; set; }
        public DbSet<GonderilenMailIcerikleri> MailIcerikleri { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = VSKB\\SQLEXPRESS01 ; Database = NotKuryeDB ; User ID = sa ; Password = 13125417 ; TrustServerCertificate = True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ogrenci>()
                .Property(o => o.OgrenciNo)
                .ValueGeneratedNever();
            modelBuilder.Entity<Akademisyen>()
                .Property(o => o.AkademikPersonelKimlikNo)
                .ValueGeneratedNever();
            modelBuilder.Entity<GonderilenMailIcerikleri>()
                .Property(e => e.ID)
                .ValueGeneratedOnAdd();
        }
    }
}
