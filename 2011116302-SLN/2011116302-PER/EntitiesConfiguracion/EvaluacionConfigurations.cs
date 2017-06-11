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
    public class EvaluacionConfigurations : EntityTypeConfiguration<Evaluacion>
    {
        public EvaluacionConfigurations()
        {
            ToTable("Evaluacion");
            HasKey(el => el.EvaluacionId);

            Property(el => el.NumeroDocumento).HasColumnType("int");
            Property(el => el.Documento).HasMaxLength(60).HasColumnType("Varchar");
            Property(el => el.FechaEvaluacion).HasMaxLength(12).HasColumnType("Varchar");

            Property(el => el.EvaluacionId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            //HasRequired(cl => cl.Cliente).WithMany(ev => ev.Evaluacion);//.HasForeignKey(ev=>ev.ClienteId);
            //HasRequired(pl => pl.Plan).WithMany(ev => ev.Evaluacion);//.HasForeignKey(ev => ev.PlanId);
            //HasRequired(ec => ec.EquipoCelular).WithMany(ev => ev.Evaluacion);//.HasForeignKey(ev => ev.EquipoCelularId);
            //HasRequired(tb => tb.Trabajador).WithMany(ev => ev.Evaluacion);//.HasForeignKey(ev => ev.TrabajadorId);
            //HasRequired(ca => ca.CentroAtencion);//.WithRequiredPrincipal(ev => ev.Evaluacion);
            /*.Map(m =>
            {
                m.ToTable("CentroAtencionEvaluacion");
                m.MapLeftKey("EvaluacionId");
                m.MapRightKey("CentroAtencionId");
            });*/

        }
    }
}
