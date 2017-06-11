using _2011116302_ENT.Entityes;
using _2011116302_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2011116302_PER.Repositories
{
    public class AdministradorEquipoRepository : Repository<AdministradorEquipo>, IAdministradorEquipoRepository
    {
        public AdministradorEquipoRepository(_2011116302DbContext context) : base(context)
        {

        }

    }
}
