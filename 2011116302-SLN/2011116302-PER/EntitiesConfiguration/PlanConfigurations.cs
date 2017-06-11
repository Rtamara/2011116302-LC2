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
    class PlanConfigurations : EntityTypeConfiguration<Plan>
    {
        public PlanConfigurations()
        {
            ToTable("Plan");
            HasKey(pl => pl.PlanId);

            Property(pl => pl.CodigoPlan).HasColumnType("int");
            Property(pl => pl.TopeConsumo).HasMaxLength(20).HasColumnType("Varchar");
            Property(pl => pl.CargoFijo).HasMaxLength(20).HasColumnType("Varchar");
            //Property(pl => pl.CaracteristicaPlan).HasMaxLength(60).HasColumnType("Varchar");

            Property(pl => pl.PlanId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }
    }
}
