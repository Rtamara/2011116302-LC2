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
    class TrabajadorConfigurations: EntityTypeConfiguration<Trabajador>
    {
        public TrabajadorConfigurations()
        {
            ToTable("Trabajador");
            HasKey(tj => tj.TrabajadorId);

            Property(tj => tj.NombreTrabajador).HasMaxLength(40).HasColumnType("Varchar");
            Property(tj => tj.ApellidoPaTrabajador).HasMaxLength(40).HasColumnType("Varchar");
            Property(tj => tj.ApellidoMaTrabajador).HasMaxLength(40).HasColumnType("Varchar");
            Property(tj => tj.DniTrabajador).HasMaxLength(8).HasColumnType("Varchar");

            Property(tj => tj.TrabajadorId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }
    }
}
