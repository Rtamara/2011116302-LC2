using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2011116302_ENT.Entityes
{
    public class Distrito
    {
        public int DistritoId { get; set; }

        String _codigoDistrito;
        String _nombreDistrito;

        public Distrito()
        {
            Provincia = new Provincia();
        }
        public Distrito(String codigoDistrito, String nombreDistrito)
        {
            _codigoDistrito = codigoDistrito;
            _nombreDistrito = nombreDistrito;
        }
        public String CodigoDistrito
        {
            get { return _codigoDistrito; }
            set { _codigoDistrito = value; }
        }
        public String NombreDistrito
        {
            get { return _nombreDistrito; }
            set { _nombreDistrito = value; }
        }

        public Provincia Provincia { get; set; }
        public int ProvinciaId { get; set; }
    }
}
