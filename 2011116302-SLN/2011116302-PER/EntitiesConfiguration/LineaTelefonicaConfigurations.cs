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
    class LineaTelefonicaConfigurations : EntityTypeConfiguration<LineaTelefonica>
    {
        public LineaTelefonicaConfigurations()
        {
            ToTable("LineaTelefonica");
            HasKey(lt => lt.LineaTelefonicaId);

            Property(lt => lt.numeroTelefonico).HasMaxLength(9).HasColumnType("Varchar");
            Property(lt => lt.iccid).HasMaxLength(12).HasColumnType("Varchar");
            Property(lt => lt.fechaActivacion).HasMaxLength(12).HasColumnType("Varchar");

            Property(lt => lt.LineaTelefonicaId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            //HasMany(al => al.AdministradorLinea).WithRequiredPrincipal(lt => lt.LineaTelefonica);//.HasForeignKey(al => al.AdministradorLineaId);
            //HasMany(al => al.AdministradorLinea).WithRequired(lt => lt.LineaTelefonica).HasForeignKey(lt => lt.AdministradorLineaId);
        }
    }
}
