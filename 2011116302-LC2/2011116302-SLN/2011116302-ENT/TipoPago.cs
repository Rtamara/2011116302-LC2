using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2011116302_ENT
{
    public class TipoPago
    {
        public int TipoPagoId { get; set; }

        public string FormaPago { get; set; }
        public TipoPago()
        {

        }
        public TipoPago(string tipoPago)
        {
            FormaPago = tipoPago;
        }
    }
}
