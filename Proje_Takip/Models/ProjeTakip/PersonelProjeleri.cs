using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Web;
using Proje_Takip.Models.Personel;

namespace Proje_Takip.Models.ProjeTakip
{
    public class PersonelProjeleri
    {
        public PersonelProjeleri()
        {
            this.PersonelBilgileris = new HashSet<PersonelBilgileri>();
        }
        [Key]
        public int PersonelProjeId { get; set; }

        [DisplayName("Proje Başlığı")]
        [StringLength(150, ErrorMessage = "Maximum uzunluk 150 karakterden fazla olamaz")]
        public string ProjeBaslik { get; set; }
        public string ProjeAciklama { get; set; }
        public DateTime OlusturmaTarihi { get; set; }

        [DisplayName("Öncelik Durumu")]
        [StringLength(25, ErrorMessage = "Maximum uzunluk 25 karakterden fazla olamaz")]
        public string OncelikDurumu { get; set; }
        public int TamamlanmaOrani { get; set; }
        public DateTime? TamamlanmaTarihi { get; set; }
        public bool TamanlanmaDurumu { get; set; }

        public virtual ICollection<PersonelBilgileri> PersonelBilgileris { get; set; }


    }
}