using _2011116302_ENT;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2011116302_PER.EntitiesConfiguration
{
    class TipoTrabajadorConfigurations : EntityTypeConfiguration<TipoTrabajador>
    {
        public TipoTrabajadorConfigurations()
        {
            ToTable("TipoTrabajador");
            HasKey(tt => tt.TipoTrabajadorId);
        }
    }
}
