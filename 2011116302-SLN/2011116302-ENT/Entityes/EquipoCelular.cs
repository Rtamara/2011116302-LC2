using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2011116302_ENT.Entityes
{
    public class EquipoCelular
    {
        public int EquipoCelularId { get; set; }

        String _MarcaEquipo;
        String _ModeloEquipo;
        String _Imei;
        String _ColorEquipo;
        Double _Precio;
        int _Cantidad;

        public AdministradorEquipo AdministradorEquipo { get; set; }
        public int AdministradorEquipoId { get; set; }
        public EquipoCelular()
        {
            AdministradorEquipo = new AdministradorEquipo();
        }
        public EquipoCelular(String marca, String modelo, String imei, String color, Double precio, int cantidad)
        {
            MarcaEquipo = marca;
            ModeloEquipo = modelo;
            Imei = imei;
            ColorEquipo = color;
            PrecioEquipo = precio;
            CantidadEquipo = cantidad;
        }
        public String MarcaEquipo
        {
            get { return _MarcaEquipo; }
            set { _MarcaEquipo = value; }
        }
        public String ModeloEquipo
        {
            get { return _ModeloEquipo; }
            set { _ModeloEquipo = value; }
        }
        public String Imei
        {
            get { return _Imei; }
            set { _Imei = value; }
        }
        public String ColorEquipo
        {
            get { return _ColorEquipo; }
            set { _ColorEquipo = value; }
        }
        public Double PrecioEquipo
        {
            get { return _Precio; }
            set { _Precio = value; }
        }
        public int CantidadEquipo
        {
            get { return _Cantidad; }
            set { _Cantidad = value; }
        }
    }
}
