using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2011116302_ENT
{
    public class Provincia
    {
        public int ProvinciaId { get; set; }

        String _codigoProvincia;
        String _nombreProvincia;
        public Departamento Departamento { get; set; }
        public int DepartamentoId { get; set; }
        public Provincia()
        {
            Departamento = new Departamento();
        }
        public Provincia(String codigoProvincia, String nomProvincia)
        {
            _codigoProvincia = codigoProvincia;
            _nombreProvincia = nomProvincia;
        }
        public String CodigoProvincia
        {
            get { return _codigoProvincia; }
            set { _codigoProvincia = value; }
        }
        public String NombreProvincia
        {
            get { return _nombreProvincia; }
            set { _nombreProvincia = value; }
        }
    }
}
