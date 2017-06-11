using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2011116302_ENT.Entityes
{
    public class Direccion
    {
        public int DireccionId { get; set; }

        String _descripcionDireccion;

        public Ubigeo _Ubigeo { get; set; }
        public int UbigeoId { get; set; }
        public Direccion()
        {
            _Ubigeo = new Ubigeo();
        }
        public Direccion(String descripcionDireccion)
        {
            DescripcionDireccion = descripcionDireccion;
        }
        public String DescripcionDireccion
        {
            get { return _descripcionDireccion; }
            set { _descripcionDireccion = value; }
        }
    }
}
