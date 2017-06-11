using _2011116302_ENT;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2011116302_PER.EntitiesConfiguration
{
    class AdministradorLineaConfigurations:EntityTypeConfiguration<AdministradorLinea>
    {
        public AdministradorLineaConfigurations()
        {
            ToTable("AdministradorLinea");
            HasKey(al => al.AdministradorLineaId);

            Property(al => al.numeroLinea).HasMaxLength(9).HasColumnType("Varchar");
            Property(al => al.modalidad).HasMaxLength(12).HasColumnType("Varchar");

            Property(al => al.AdministradorLineaId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }

    }
}
