using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2011116302_ENT
{
    public class TipoEvaluacion
    {
        public int TipoEvaluacionId { get; set; }

        public string DescripTipEvaluacion { get; set; }
        public TipoEvaluacion()
        {

        }
        public TipoEvaluacion(string tipoEvaluacion)
        {
            DescripTipEvaluacion = tipoEvaluacion;
        }
    }
}
