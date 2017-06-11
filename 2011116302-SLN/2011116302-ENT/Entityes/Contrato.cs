using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2011116302_ENT.Entityes
{
    public class Contrato
    {
        public int ContratoId { get; set; }

        int _NumeroContrato;
        String _PlazoContrato;
        String _FormaContrato;
        public int NumeroContrato
        {
            get { return _NumeroContrato; }
            set { _NumeroContrato = value; }
        }
        public String PlazoContrato
        {
            get { return _PlazoContrato; }
            set { _PlazoContrato = value; }
        }
        public String FormaContrato
        {
            get { return _FormaContrato; }
            set { _FormaContrato = value; }
        }
        public Venta Venta { get; set; }
        public int VentaId { get; set; }
        public Contrato()
        {
            Venta = new Venta();
        }
        public Contrato(int numeroContrato, String plazoContrato, String formaContrato)
        {
            NumeroContrato = numeroContrato;
            PlazoContrato = plazoContrato;
            FormaContrato = formaContrato;
        }
    }
}
