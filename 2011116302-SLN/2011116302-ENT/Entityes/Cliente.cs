using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2011116302_ENT.Entityes
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        /*
        public String NombreCliente { get; set; }
        public String ApePaternoCliente { get; set; }
        public String ApeMaternoCliente { get; set; }
        public String DniCliente { get; set; }
        public String FecNacimientoCliente { get; set; }
        public Double SueldoCliente { get; set; }
        public String CorreoCliente { get; set; }
        */
        String _NombreCliente;
        String _ApePaternoCliente;
        String _ApeMaternoCliente;
        String _DniCliente;
        String _FecNacimientoCliente;
        Double _SueldoCliente;
        String _CorreoCliente;
        public Cliente()
        {

        }
        public Cliente(String nombreCliente, String apePaternoCliente, String apeMaternoCliente, String dniCliente, String fecNacimientoCliente, Double sueldoCliente, String correoCliente)
        {
            _NombreCliente = nombreCliente;
            ApeMaternoCliente = apePaternoCliente;
            ApeMaternoCliente = apeMaternoCliente;
            DniCliente = dniCliente;
            FecNacimientoCliente = fecNacimientoCliente;
            SueldoCliente = sueldoCliente;
            CorreoCliente = correoCliente;
        }
        public String NombreCliente
        {
            get { return _NombreCliente; }
            set { _NombreCliente = value; }
        }
        public String ApePaternoCliente
        {
            get { return _ApePaternoCliente; }
            set { _ApePaternoCliente = value; }
        }
        public String ApeMaternoCliente
        {
            get { return _ApeMaternoCliente; }
            set { _ApeMaternoCliente = value; }
        }
        public String DniCliente
        {
            get { return _DniCliente; }
            set { _DniCliente = value; }
        }
        public String FecNacimientoCliente
        {
            get { return _FecNacimientoCliente; }
            set { _FecNacimientoCliente = value; }
        }
        public Double SueldoCliente
        {
            get { return _SueldoCliente; }
            set { _SueldoCliente = value; }
        }
        public String CorreoCliente
        {
            get { return _CorreoCliente; }
            set { _CorreoCliente = value; }
        }
    }
}
