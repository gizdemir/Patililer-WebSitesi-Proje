using Microsoft.EntityFrameworkCore;
using Patililer.Models;
using Patililer.Models.Siniflar;

namespace Patililer.Data
{

    public class PatililerDBContext : DbContext
    {
        public PatililerDBContext()
        {
        }

        public PatililerDBContext(DbContextOptions<PatililerDBContext> options) : base(options)
        {
        }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Adres> Adres { get; set; }
        public DbSet<Hakkimizda> Hakkimizdas { get; set; }
        public DbSet<Ilanlar> Ilanlars { get; set; }
        public DbSet<Iletisim> Iletisims { get; set; }
        public DbSet<Yorumlar> Yorumlars { get; set; }
        public DbSet<Userr> userrs { get; set; }
        public DbSet<Rolee> rolees { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ilanlar>().HasData(

                new Ilanlar { ID = 1, Aciklama = "1.hayvan", Baslik = "köpek", Cinsiyet = "erkek", IlanImage = "kdsk", Tarih = Convert.ToDateTime("10.03.2022"), Yas = 1 },
                new Ilanlar { ID = 2, Aciklama = "2.hayvan", Baslik = "kedi", Cinsiyet = "erkek", IlanImage = "kdsk", Tarih = Convert.ToDateTime("10.02.2022"), Yas = 2 },
                new Ilanlar { ID = 3, Aciklama = "3.hayvan", Baslik = "kedi", Cinsiyet = "dişi", IlanImage = "kdsk", Tarih = Convert.ToDateTime("10.04.2022"), Yas = 3 },
                new Ilanlar { ID = 4, Aciklama = "4.hayvan", Baslik = "köpek", Cinsiyet = "dişi", IlanImage = "kdsk", Tarih = Convert.ToDateTime("10.01.2022"), Yas = 1 }
            );




            modelBuilder.Entity<Hakkimizda>().HasData(

                new Hakkimizda { ID = 1, Aciklama = "Ücretsiz evcil hayvan sahiplendirme ilanlarına göz atabilir, bir canlı sahiplenebilirsin.Aradığın canlıyı bulamadıysan, arıyorum ilanı bırakabilirsin.Pet için eş arıyorsan, eş arıyorum ilanı ekleyebilirsin. Dikkat :Kimseye ödeme yapmayın,dolandırılma riski var! Bu site satış sitesi değildir.Size yakın şehirlerden elden satın almaya özen gösterin.", FotoUrl = "dsds" }

            );
            modelBuilder.Entity<Iletisim>().HasData(

                new Iletisim { ID = 1, AdSoyad = "xcx", Konu = "fdf", Mail = "dfd", Mesaj = "fdf" }
                 );
            modelBuilder.Entity<Rolee>().HasData(

             new Rolee { RoleeID = 1, RoleeName = "Aday" },
             new Rolee { RoleeID = 2, RoleeName = "Uye" },
             new Rolee { RoleeID = 3, RoleeName = "Admin" },
             new Rolee { RoleeID = 4, RoleeName = "Supervisor" }
             );

            modelBuilder.Entity<Userr>().HasData(

                new Userr { UserrID = 1, Emaill = "aday@hotmail.com", Passwordd = "123456", RoleeID = 1 },
                new Userr { UserrID = 2, Emaill = "uye@hotmail.com", Passwordd = "123456", RoleeID = 2 },
                new Userr { UserrID = 3, Emaill = "admin@hotmail.com", Passwordd = "123456", RoleeID = 3 },
                new Userr { UserrID = 4, Emaill = "supervisor@hotmail.com", Passwordd = "123456", RoleeID = 4 },
                new Userr { UserrID = 5, Emaill = "uye2@hotmail.com", Passwordd = "123456", RoleeID = 2 }
                );
            modelBuilder.Entity<Admin>().HasData(
                new Admin { ID=1,Kullanici="gizem",Sifre="123"}
                );
        }




    }
}
