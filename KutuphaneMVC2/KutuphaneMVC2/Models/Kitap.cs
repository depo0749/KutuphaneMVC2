using System;
using System.ComponentModel.DataAnnotations;

namespace KutuphaneMVC2.Models
{
    public class Kitap
    {
        [Key]
        public int KitapId { get; set; }

        [Required(ErrorMessage = "Kitap adı zorunludur.")]
        [Display(Name = "Kitap Adı")]
        public string KitapAdi { get; set; }

        [Required(ErrorMessage = "Yazar adı zorunludur.")]
        [Display(Name = "Yazar")]
        public string Yazar { get; set; }

        [Display(Name = "Yayın Evi")]
        public string YayinEvi { get; set; }

        [Display(Name = "Basım Yılı")]
        public int? BasimYili { get; set; }

        [Required(ErrorMessage = "Sayfa sayısı zorunludur.")]
        [Display(Name = "Sayfa Sayısı")]
        public int SayfaSayisi { get; set; }

        [Display(Name = "Kategori")]
        public string Kategori { get; set; }

        [Display(Name = "Stok Durumu")]
        public bool StokDurumu { get; set; }

        [Display(Name = "ISBN")]
        public string ISBN { get; set; }

        [Display(Name = "Açıklama")]
        public string Aciklama { get; set; }

        [Display(Name = "Eklenme Tarihi")]
        public DateTime EklenmeTarihi { get; set; } = DateTime.Now;
    }
} 