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
    class DistritoConfigurations : EntityTypeConfiguration<Distrito>
    {
        public DistritoConfigurations()
        {
            ToTable("Distrito");
            HasKey(dt => dt.DistritoId);

            Property(dt => dt.CodigoDistrito).HasMaxLength(2).HasColumnType("Varchar");
            Property(dt => dt.NombreDistrito)
                .HasMaxLength(60)
                .HasColumnType("Varchar");

            Property(dt => dt.DistritoId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            //HasRequired(pv => pv.Provincia).WithMany(dt => dt.Distrito);//.HasForeignKey(dt => dt.ProvinciaId);
        }
    }
}
