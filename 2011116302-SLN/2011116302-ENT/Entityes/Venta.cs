using _2011116302_ENT.Enumerables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2011116302_ENT.Entityes
{
    public class Venta
    {
        public int VentaId { get; set; }

        int _NumeroVenta;
        String _ModalidadVenta;
        String _FechaVenta;
        Double _MontoVenta;

        public Evaluacion Evaluacion { get; set; }
        public int EvaluacionId { get; set; }
        public Cliente Cliente { get; set; }
        public int ClienteId { get; set; }
        public LineaTelefonica LineaTelefonica { get; set; }
        public int LineaTelefonicaId { get; set; }
        public TipoPago TipoPago { get; set; }
        public CentroAtencion CentroAtencion { get; set; }
        public int CentroAtencionId { get; set; }
        public Venta()
        {
            LineaTelefonica = new LineaTelefonica();
            Evaluacion = new Evaluacion();
            TipoPago = new TipoPago();
        }
        public Venta(int numeroVenta, String modalidadVenta, String fechaVenta, Double montoVenta, Cliente cliente, CentroAtencion centroAtencion)
        {
            NumeroVenta = numeroVenta;
            ModalidadVenta = modalidadVenta;
            FechaVenta = fechaVenta;
            MontoVenta = montoVenta;
            Cliente = cliente;
            CentroAtencion = centroAtencion;
        }
        public int NumeroVenta
        {
            get { return _NumeroVenta; }
            set { _NumeroVenta = value; }
        }
        public String ModalidadVenta
        {
            get { return _ModalidadVenta; }
            set { _ModalidadVenta = value; }
        }
        public String FechaVenta
        {
            get { return _FechaVenta; }
            set { _FechaVenta = value; }
        }
        public Double MontoVenta
        {
            get { return _MontoVenta; }
            set { _MontoVenta = value; }
        }
    }
}
