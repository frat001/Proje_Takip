using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Proje_Takip.Models.Personel
{
    public class PersonelBilgileri
    {
        [Key]
        public string PersonelBilgileriId { get; set; }

        [DisplayName("E-Posta")]
        public string Email { get; set; }

        [DisplayName("ŞİFRE")]
        [StringLength(25, ErrorMessage = "Maximum uzunluk 25 karakterden fazla olamaz")]
        public string Sifre { get; set; }

        [DisplayName("YETKİ")]
        [StringLength(15, ErrorMessage = "Maximum uzunluk 15 karakterden fazla olamaz")]
        public string Yetki { get; set; }

        [DisplayName("AD SOYAD")]
        [StringLength(50, ErrorMessage = "Maximum uzunluk 50 karakterden fazla olamaz")]
        public string AdSoyad { get; set; }

        [DisplayName("TC KİMLİK NO")]
        [StringLength(11, ErrorMessage = "Maximum uzunluk 11 karakterden fazla olamaz")]
        public string TcNo { get; set; }

        [DisplayName("DEPARTMANI")]
        public string Departman { get; set; }

        [StringLength(25, ErrorMessage = "Maximum uzunluk 25 karakterden fazla olamaz")]
        [DisplayName("GÖREVİ")]
        public string Gorev { get; set; }

        [DisplayName("AÇIKLAMA")]
        public string PozisyonAciklama { get; set; }

        [DisplayName("TELEFON NUMARASI")]
        [StringLength(15, ErrorMessage = "Maximum uzunluk 15 karakterden fazla olamaz")]
        public int TelNo { get; set; }

        [DisplayName("ADRES BİLGİLERİ")]
        public string Adres { get; set; }

        [DisplayName("MEDENİ HAL")]
        public string MedeniHal { get; set; }

        [DisplayName("YAKIN BİLGİSİ")]
        public string YakinBilgisi { get; set; }

        [DisplayName("YAKIN TC KİMLİK NUMARASI")]
        public string YakinTc { get; set; }
        [DisplayName("YAKIN ADI SOYADI")]
        public string YakinAdSoyad { get; set; }
        [DisplayName("YAKIN TELEFON NUMARASI")]
        public int YakinTel { get; set; }
        [DisplayName("DOĞUM TARİHİ")]
        public DateTime DogumTarihi { get; set; }
        [DisplayName("İŞE GİRİŞ TARİHİ")]
        public DateTime? İseGirisTarihi { get; set; }



    }
}