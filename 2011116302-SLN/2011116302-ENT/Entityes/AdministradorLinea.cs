using _2011116302_ENT.Enumerables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2011116302_ENT.Entityes
{
    public class AdministradorLinea
    {
        public int AdministradorLineaId { get; set; }

        public String numeroLinea { get; set; }
        public String modalidad { get; set; }

        public EstadoLinea Estado { get; set; }
    }
}
