using _2011116302_ENT;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2011116302_PER
{
    public class _2011116302DbContext:DbContext
    {
        public DbSet<AdministradorEquipo> AdministradorEquipos { get; set; }
        public DbSet<AdministradorLinea> AdministradorLineas { get; set; }
        public DbSet<CentroAtencion> CentroAtencions { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Contrato> Contratos { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Direccion> Direccions { get; set; }
        public DbSet<Distrito> Distritos { get; set; }
        public DbSet<EquipoCelular> EquipoCelulars { get; set; }
        public DbSet<EstadoEvaluacion> EstadoEvaluacions { get; set; }
        public DbSet<Evaluacion> Evaluacions { get; set; }
        public DbSet<TipoLinea> TipoLineas { get; set; }
        public DbSet<LineaTelefonica> LineaTelefonicas { get; set; }
        public DbSet<Plan> Plans { get; set; }
        public DbSet<Provincia> Provincias { get; set; }
        public DbSet<TipoEvaluacion> TipoEvaluacions { get; set; }
        public DbSet<TipoPago> TipoPagos { get; set; }
        public DbSet<TipoPlan> TipoPlans { get; set; }
        public DbSet<TipoTrabajador> TipoTrabajadors { get; set; }
        public DbSet<Ubigeo> Ubigeos { get; set; }
        public DbSet<Venta> Ventas { get; set; }
        public DbSet<Trabajador> Trabajadors { get; set; }
       
    }
}
