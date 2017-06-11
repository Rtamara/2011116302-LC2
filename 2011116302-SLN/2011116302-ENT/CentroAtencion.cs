using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2011116302_ENT
{
    public class CentroAtencion
    {
        public int CentroAtencionId { get; set; }

        String _nombreCeAtencion;
        public Direccion _Direccion { get; set; }
        public int DireccionId { get; set; }
        public CentroAtencion()
        {
            _Direccion = new Direccion();
        }
        public CentroAtencion(String nombreCeAtencion)
        {
            NombreCeAtencion = nombreCeAtencion;
        }
        public String NombreCeAtencion
        {
            get { return _nombreCeAtencion; }
            set { _nombreCeAtencion = value; }
        }
    }
}
