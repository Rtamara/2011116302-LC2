﻿using _2011116302_ENT;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2011116302_PER.EntitiesConfiguration
{
    class UbigeoConfigurations : EntityTypeConfiguration<Ubigeo>
    {
        public UbigeoConfigurations()
        {
            ToTable("Ubigeo");
            HasKey(ug => ug.UbigeoId);
        }
    }
}
