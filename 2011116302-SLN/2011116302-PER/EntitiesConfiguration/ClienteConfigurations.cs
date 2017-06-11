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
    class ClienteConfigurations : EntityTypeConfiguration<Cliente>
    {
        public ClienteConfigurations()
        {
            ToTable("Cliente");
            HasKey(cl => cl.ClienteId);

            Property(cl => cl.NombreCliente).HasMaxLength(20).HasColumnType("Varchar");
            Property(cl => cl.ApePaternoCliente).HasMaxLength(20).HasColumnType("Varchar");
            Property(cl => cl.ApeMaternoCliente).HasMaxLength(20).HasColumnType("Varchar");
            Property(cl => cl.DniCliente).HasMaxLength(8).HasColumnType("Varchar");
            Property(cl => cl.FecNacimientoCliente).HasMaxLength(12).HasColumnType("Varchar");
            Property(cl => cl.SueldoCliente).HasColumnType("float");
            Property(cl => cl.CorreoCliente).HasMaxLength(30).HasColumnType("Varchar");

            Property(cl => cl.ClienteId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }
    }
}
