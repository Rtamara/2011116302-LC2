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
    public class DireccionConfigurations : EntityTypeConfiguration<Direccion>
    {
        public DireccionConfigurations()
        {
            ToTable("Direccion");
            HasKey(dr => dr.DireccionId);

            Property(dr => dr.DescripcionDireccion).HasMaxLength(60).HasColumnType("Varchar");

            Property(dr => dr.DireccionId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            //HasRequired(ug => ug.Ubigeo).WithMany(dr => dr.Direccion);//.HasForeignKey(dr => dr.UbigeoId);
        }
    }
}
