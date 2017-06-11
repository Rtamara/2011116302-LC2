using _2011116302_ENT.Enumerables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2011116302_ENT
{
    public class Evaluacion
    {
        public int EvaluacionId { get; set; }

        int _NumeroDocumento;
        String _Documento;
        String _FechaEvaluacion;

        public EstadoEvaluacion EstadoEvaluacion { get; set; }
        public TipoEvaluacion TipoEvaluacion { get; set; }
        public EquipoCelular EquipoCelular { get; set; }
        public Cliente Cliente { get; set; }
        private int ClienteId { get; set; }
        public Plan Plan { get; set; }
        public int PlanId { get; set; }
        public CentroAtencion CentroAtencion { get; set; }
        private int CentroAtencionId { get; set; }
        public Trabajador Trabajador { get; set; }
        public int TrabajadorId { get; set; }
        public LineaTelefonica LineaTelefonica { get; set; }
        private int LineaTelefonicaId { get; set; }

        public Evaluacion()
        {
            EquipoCelular = new EquipoCelular();
            EstadoEvaluacion = new EstadoEvaluacion();
            TipoEvaluacion = new TipoEvaluacion();
        }
        public Evaluacion(int numDocumento, String documento, String fecEvaluacion, Cliente cliente, Plan plan, LineaTelefonica lineaTelefonica, CentroAtencion centroAtencion, Trabajador trabajador)
        {
            NumeroDocumento = numDocumento;
            Documento = documento;
            FechaEvaluacion = fecEvaluacion;
            Cliente = cliente;
            Plan = plan;
            CentroAtencion = centroAtencion;
            Trabajador = trabajador;
        }
        public int NumeroDocumento
        {
            get { return _NumeroDocumento; }
            set { _NumeroDocumento = value; }
        }
        public String Documento
        {
            get { return _Documento; }
            set { _Documento = value; }
        }
        public String FechaEvaluacion
        {
            get { return _FechaEvaluacion; }
            set { _FechaEvaluacion = value; }
        }
    }
}
