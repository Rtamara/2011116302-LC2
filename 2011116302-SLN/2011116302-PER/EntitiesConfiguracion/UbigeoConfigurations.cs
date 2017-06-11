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
    public class UbigeoConfigurations : EntityTypeConfiguration<Ubigeo>
    {
        public UbigeoConfigurations()
        {
            ToTable("Ubigeo");
            HasKey(ug => ug.UbigeoId);

            Property(ug => ug.CodigoUbigeo).HasMaxLength(6).HasColumnType("Varchar");
            /*
            HasRequired(pv => pv.Provincia).WithRequiredDependent(ug => ug.Ubigeo);
            HasRequired(dp => dp.Departamento).WithRequiredDependent(ug => ug.Ubigeo);
            HasRequired(dt => dt.Distrito).WithRequiredDependent(ug => ug.Ubigeo);
            */
            Property(ug => ug.UbigeoId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

        }
    }
}
