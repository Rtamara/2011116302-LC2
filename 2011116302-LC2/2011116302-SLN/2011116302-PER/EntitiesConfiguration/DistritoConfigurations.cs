﻿using _2011116302_ENT;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2011116302_PER.EntitiesConfiguration
{
    class DistritoConfigurations : EntityTypeConfiguration<Distrito>
    {
        public DistritoConfigurations()
        {
            ToTable("Distrito");
            HasKey(dt => dt.DistritoId);
        }
    }
}
