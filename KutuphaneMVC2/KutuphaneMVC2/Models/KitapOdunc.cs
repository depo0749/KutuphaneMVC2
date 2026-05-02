using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KutuphaneMVC2.Models
{
    public class KitapOdunc
    {
        [Key]
        public int OduncId { get; set; }

        [Required]
        public int KitapId { get; set; }

        [Required]
        public int KullaniciId { get; set; }

        [Display(Name = "Alınma Tarihi")]
        public DateTime AlinmaTarihi { get; set; } = DateTime.Now;

        [Display(Name = "İade Tarihi")]
        public DateTime? IadeTarihi { get; set; }

        [Required]
        [Display(Name = "Beklenen İade Tarihi")]
        public DateTime BeklenenIadeTarihi { get; set; }

        [Display(Name = "Durum")]
        public string Durum { get; set; } = "Ödünç Alındı";

        [ForeignKey("KitapId")]
        public virtual Kitap Kitap { get; set; }

        [ForeignKey("KullaniciId")]
        public virtual Kullanici Kullanici { get; set; }
    }
} 