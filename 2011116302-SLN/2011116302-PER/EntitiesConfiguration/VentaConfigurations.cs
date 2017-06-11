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
    class VentaConfigurations : EntityTypeConfiguration<Venta>
    {
        public VentaConfigurations()
        {
            ToTable("Venta");
            HasKey(vt => vt.VentaId);

            Property(vt => vt.NumeroVenta).HasColumnType("int");
            Property(vt => vt.ModalidadVenta).HasMaxLength(20).HasColumnType("Varchar");
            Property(vt => vt.FechaVenta).HasMaxLength(15).HasColumnType("Varchar");
            Property(vt => vt.MontoVenta).HasColumnType("float");

            Property(vt => vt.VentaId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            //HasRequired(ct => ct.Contrato).WithMany(vt => vt.Venta).HasForeignKey(ct => ct.ContratoId);
            //HasMany(cl => cl.Cliente).WithRequired(vt => vt.Venta).HasForeignKey(vt => vt.ClienteId);
            //HasRequired(el => el.Evaluacion).WithMany(vt => vt.Venta).HasForeignKey(ct => ct.EvaluacionId);

            //HasRequired(ev => ev.Evaluacion).WithRequiredDependent(vt => vt.Venta);
            //HasRequired(ct => ct.Contrato).WithMany(vt => vt.Venta);//.HasForeignKey(vt=>vt.ContratoId);
            //HasRequired(cl => cl.Cliente).WithMany(vt => vt.Venta);//.HasForeignKey(vt => vt.ClienteId);
            //HasRequired(ca => ca.CentroAtencion).WithMany(vt => vt.Venta);//.HasForeignKey(vt => vt.CentroAtencionId);
        }
    }
}
