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
    public class EquipoCelularConfigurations : EntityTypeConfiguration<EquipoCelular>
    {
        public EquipoCelularConfigurations()
        {
            ToTable("EquipoCelular");
            HasKey(ec => ec.EquipoCelularId);

            Property(ec => ec.MarcaEquipo).HasMaxLength(20).HasColumnType("Varchar");
            Property(ec => ec.ModeloEquipo).HasMaxLength(20).HasColumnType("Varchar");
            Property(ec => ec.ColorEquipo).HasMaxLength(20).HasColumnType("Varchar");
            Property(ec => ec.Imei).HasMaxLength(15).HasColumnType("Varchar");
            Property(ec => ec.PrecioEquipo).HasColumnType("float");
            Property(ec => ec.CantidadEquipo).HasColumnType("int");

            Property(ec => ec.EquipoCelularId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            //HasRequired(ae => ae.AdministradorEquipo).WithMany(ec => ec.EquipoCelular).HasForeignKey(ec => ec.AdministradorEquipoId);
        }
    }
}
