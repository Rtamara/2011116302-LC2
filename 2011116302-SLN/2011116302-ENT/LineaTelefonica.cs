using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2011116302_ENT
{
    public class LineaTelefonica
    {
        public int LineaTelefonicaId { get; set; }

        public String numeroTelefonico { get; set; }
        public String iccid { get; set; }
        public String fechaActivacion { get; set; }

        public AdministradorLinea AdministradorLinea { get; set; }
        public int AdministradorLineaId { get; set; }
        public LineaTelefonica()
        {
            AdministradorLinea = new AdministradorLinea();
        }
    }
}
