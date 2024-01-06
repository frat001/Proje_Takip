using Proje_Takip.Models.Personel;
using Proje_Takip.Models.ProjeTakip;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Proje_Takip.Models.DataContext
{
    public class ProjeTakipDBContext : DbContext
    {
        public ProjeTakipDBContext() : base("ProjeTakipDB")
        {


        }

        public DbSet<PersonelBilgileri> personelBilgileris { get; set; }

        public DbSet<PersonelProjeleri> PersonelProjeleris { get; set; }
    }
}