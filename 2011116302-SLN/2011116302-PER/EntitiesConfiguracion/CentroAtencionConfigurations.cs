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
    public class CentroAtencionConfigurations : EntityTypeConfiguration<CentroAtencion>
    {
        public CentroAtencionConfigurations()
        {
            ToTable("CentroAtencion");
            HasKey(ca => ca.CentroAtencionId);

            Property(ca => ca.NombreCeAtencion).HasMaxLength(60).HasColumnType("Varchar");

            Property(ca => ca.CentroAtencionId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            //HasRequired(dr => dr.Direccion).WithRequiredPrincipal(ca => ca.CentroAtencion);
        }
    }
}
