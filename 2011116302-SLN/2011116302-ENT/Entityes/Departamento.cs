using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2011116302_ENT.Entityes
{
    public class Departamento
    {
        public int DepartamentoId { get; set; }

        String _codigoDepartamento;
        String _nombreDepartamento;
        public Departamento()
        {

        }
        public Departamento(String codigoDepartamento, String nombreDepartamento)
        {
            _codigoDepartamento = codigoDepartamento;
            _nombreDepartamento = nombreDepartamento;
        }
        public String CodigoDepartamento
        {
            get { return _codigoDepartamento; }
            set { _codigoDepartamento = value; }
        }
        public String NombreDepartamento
        {
            get { return _nombreDepartamento; }
            set { _nombreDepartamento = value; }
        }
    }
}
