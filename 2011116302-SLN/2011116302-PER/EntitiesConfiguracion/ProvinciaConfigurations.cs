using _2011116302_ENT.Entityes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2011116302_PER.EntitiesConfiguracion
{
    public class ProvinciaConfigurations : EntityTypeConfiguration<Provincia>
    {
        public ProvinciaConfigurations()
        {
            ToTable("Provincia");
            HasKey(pv => pv.ProvinciaId);

            Property(pv => pv.NombreProvincia).HasMaxLength(2).HasColumnType("Varchar");
            Property(pv => pv.NombreProvincia)
                .HasMaxLength(60)
                .HasColumnType("Varchar");

            Property(pv => pv.ProvinciaId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            //HasRequired(dp => dp.Departamento).WithMany(pv => pv.Provincia);//.HasForeignKey(pv => pv.DepartamentoId);
        }
    }
}
