using System;
using System.ComponentModel.DataAnnotations;

namespace KutuphaneMVC2.Models
{
    public class Admin
    {
        [Key]
        public int AdminId { get; set; }

        [Required(ErrorMessage = "Kullanıcı adı zorunludur.")]
        [Display(Name = "Kullanıcı Adı")]
        public string KullaniciAdi { get; set; }

        [Required(ErrorMessage = "Ad alanı zorunludur.")]
        [Display(Name = "Ad")]
        public string Ad { get; set; }

        [Required(ErrorMessage = "Soyad alanı zorunludur.")]
        [Display(Name = "Soyad")]
        public string Soyad { get; set; }

        [Required(ErrorMessage = "E-posta alanı zorunludur.")]
        [EmailAddress(ErrorMessage = "Geçerli bir e-posta adresi giriniz.")]
        [Display(Name = "E-posta")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Şifre alanı zorunludur.")]
        [MinLength(6, ErrorMessage = "Şifre en az 6 karakter olmalıdır.")]
        [Display(Name = "Şifre")]
        public string Sifre { get; set; }

        [Display(Name = "Son Giriş Tarihi")]
        public DateTime? SonGirisTarihi { get; set; }

        [Display(Name = "Yetki Seviyesi")]
        public string YetkiSeviyesi { get; set; } = "Admin";

        [Display(Name = "Aktif Mi")]
        public bool AktifMi { get; set; } = true;
    }
} 