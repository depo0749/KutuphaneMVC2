using System;
using System.ComponentModel.DataAnnotations;

namespace KutuphaneMVC2.Models
{
    public class Odunc
    {
        [Key]
        public int OduncId { get; set; }

        [Required]
        public int KitapId { get; set; }
        public Kitap Kitap { get; set; }

        [Required]
        public int KullaniciId { get; set; }
        public Kullanici Kullanici { get; set; }

        [Required]
        public DateTime OduncAlmaTarihi { get; set; }

        [Required]
        public DateTime IadeTarihi { get; set; }

        public DateTime? GerceklesenIadeTarihi { get; set; }

        public bool TeslimEdildi { get; set; }

        public string? Notlar { get; set; }
    }
} 