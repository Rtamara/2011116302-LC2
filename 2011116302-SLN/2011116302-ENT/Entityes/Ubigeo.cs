using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2011116302_ENT.Entityes
{
    public class Ubigeo
    {
        public int UbigeoId { get; set; }

        private Departamento Departamento { get; set; }
        private Provincia Provincia { get; set; }
        private Distrito Distrito { get; set; }
        private int DistritoId { get; set; }

        String _codUbigeo;
        public String CodigoUbigeo
        {
            get { return _codUbigeo; }
            set { _codUbigeo = value; }
        }
    }
}
