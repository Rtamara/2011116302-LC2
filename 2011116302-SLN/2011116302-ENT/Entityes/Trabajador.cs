using _2011116302_ENT.Enumerables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2011116302_ENT.Entityes
{
    public class Trabajador
    {
        public int TrabajadorId { get; set; }

        String _nombreTrabajador;
        String _apePaternoTrabajador;
        String _apMaternoTrabajador;
        String _dniTrabajador;

        public TipoTrabajador TipoTrabajador { get; set; }
        public Trabajador()
        {
            TipoTrabajador = new TipoTrabajador();
        }
        public Trabajador(String nombreTrabajador, String apellidoPaTrabajador, String apMaternoTrabajador, String dniTrabajador)
        {
            NombreTrabajador = nombreTrabajador;
            ApellidoPaTrabajador = apellidoPaTrabajador;
            ApellidoMaTrabajador = apMaternoTrabajador;
            DniTrabajador = dniTrabajador;
        }
        public String NombreTrabajador
        {
            get { return _nombreTrabajador; }
            set { _nombreTrabajador = value; }
        }
        public String ApellidoPaTrabajador
        {
            get { return _apePaternoTrabajador; }
            set { _apePaternoTrabajador = value; }
        }
        public String ApellidoMaTrabajador
        {
            get { return _apMaternoTrabajador; }
            set { _apMaternoTrabajador = value; }
        }
        public String DniTrabajador
        {
            get { return _dniTrabajador; }
            set { _dniTrabajador = value; }
        }
    }
}
