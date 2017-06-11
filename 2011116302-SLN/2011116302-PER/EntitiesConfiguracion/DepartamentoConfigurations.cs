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
    public class DepartamentoConfigurations : EntityTypeConfiguration<Departamento>
    {
        public DepartamentoConfigurations()
        {
            ToTable("Departamento");
            HasKey(dp => dp.DepartamentoId);

            Property(dp => dp.CodigoDepartamento).HasMaxLength(2).HasColumnType("Varchar");
            Property(dp => dp.NombreDepartamento)
               .HasMaxLength(60)
               .HasColumnType("Varchar");

            Property(dp => dp.DepartamentoId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }
    }
}
