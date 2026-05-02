using Microsoft.EntityFrameworkCore;
using KutuphaneMVC2.Models;

namespace KutuphaneMVC2.Data
{
    public class KutuphaneContext : DbContext
    {
        public KutuphaneContext(DbContextOptions<KutuphaneContext> options)
            : base(options)
        {
        }

        public DbSet<Kitap> Kitaplar { get; set; }
        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<Admin> Adminler { get; set; }
        public DbSet<KitapOdunc> KitapOdunc { get; set; }
        public DbSet<Odunc> Oduncler { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Admin tablosu için varsayılan admin kullanıcısı
            modelBuilder.Entity<Admin>().HasData(
                new Admin
                {
                    AdminId = 1,
                    KullaniciAdi = "admin",
                    Ad = "Admin",
                    Soyad = "User",
                    Email = "admin@kutuphane.com",
                    Sifre = "Admin123!", // Gerçek uygulamada hash'lenmiş olmalı
                    YetkiSeviyesi = "SuperAdmin",
                    AktifMi = true,
                    SonGirisTarihi = new DateTime(2024, 1, 1) // Statik tarih
                }
            );

            // Örnek kullanıcı
            modelBuilder.Entity<Kullanici>().HasData(
                new Kullanici
                {
                    KullaniciId = 1,
                    Ad = "Ahmet",
                    Soyad = "Yılmaz",
                    Email = "ahmet@example.com",
                    Sifre = "Kullanici123!", // Gerçek uygulamada hash'lenmiş olmalı
                    Telefon = "5551234567",
                    Adres = "İstanbul, Türkiye",
                    UyelikTarihi = new DateTime(2024, 1, 1),
                    AktifMi = true,
                    SonGirisTarihi = new DateTime(2024, 1, 1)
                }
            );

            // Örnek kitaplar
            modelBuilder.Entity<Kitap>().HasData(
                new Kitap
                {
                    KitapId = 1,
                    KitapAdi = "Suç ve Ceza",
                    Yazar = "Fyodor Dostoyevski",
                    YayinEvi = "İş Bankası Kültür Yayınları",
                    BasimYili = 2020,
                    SayfaSayisi = 704,
                    Kategori = "Roman",
                    StokDurumu = true,
                    ISBN = "978-975-458-717-0",
                    Aciklama = "Klasik Rus edebiyatının başyapıtlarından biri",
                    EklenmeTarihi = new DateTime(2024, 1, 1) // Statik tarih
                },
                new Kitap
                {
                    KitapId = 2,
                    KitapAdi = "1984",
                    Yazar = "George Orwell",
                    YayinEvi = "Can Yayınları",
                    BasimYili = 2019,
                    SayfaSayisi = 352,
                    Kategori = "Distopik Roman",
                    StokDurumu = true,
                    ISBN = "978-975-07-1029-4",
                    Aciklama = "Distopik edebiyatın en önemli eserlerinden biri",
                    EklenmeTarihi = new DateTime(2024, 1, 1) // Statik tarih
                }
            );
        }
    }
} 