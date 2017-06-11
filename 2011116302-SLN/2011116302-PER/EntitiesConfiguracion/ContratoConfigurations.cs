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
    public class ContratoConfigurations : EntityTypeConfiguration<Contrato>
    {
        public ContratoConfigurations()
        {
            ToTable("Contrato");
            HasKey(ct => ct.ContratoId);

            Property(ct => ct.NumeroContrato).HasColumnType("int");
            Property(ct => ct.PlazoContrato).HasMaxLength(20).HasColumnType("Varchar");
            Property(ct => ct.FormaContrato).HasMaxLength(20).HasColumnType("Varchar");

            Property(ct => ct.ContratoId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

        }
    }
}
