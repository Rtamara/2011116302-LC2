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
    class AdministradorEquipoConfigurations:EntityTypeConfiguration<AdministradorEquipo>
    {
        public AdministradorEquipoConfigurations()
        {
            ToTable("AdministradorEquipo");
            HasKey(ae => ae.AdministradorEquipoId);

            Property(ae => ae.Modalidad).HasMaxLength(15).HasColumnType("Varchar");
            Property(ae => ae.Fecha).HasMaxLength(15).HasColumnType("Varchar");
            Property(ae => ae.StockDisponible).HasColumnType("int");

            Property(ae => ae.AdministradorEquipoId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }

    }
}
