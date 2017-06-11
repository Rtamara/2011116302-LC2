using _2011116302_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2011116302_PER.Repositories
{
    public class UnityOfWork : IUnityOfWork
    {
        private readonly _2011116302DbContext _Context;
        // private static UnityOfWork _Instance;
        private static readonly object _Lock = new object();

        public IAdministradorEquipoRepository AdministradorEquipos { get; set; }
        public IAdministradorLineaRepository AdministradorLineas { get; set; }
        public ICentroAtencionRepository CentroAtencions { get; set; }
        public IClienteRepository Clientes { get; set; }
        public IContratoRepository Contratos { get; set; }
        public IDepartamentoRepository Departamentos { get; set; }
        public IDireccionRepository Direccions { get; set; }
        public IDistritoRepository Distritos { get; set; }
        public IEquipoCelularRepository EquipoCelulars { get; set; }
        public IEvaluacionRepository Evaluacions { get; set; }
        public ILineaTelefonicaRepository LineaTelefonicas { get; set; }
        public IPlanRepository Plans { get; set; }
        public IProvinciaRepository Provincias { get; set; }
        public ITrabajadorRepository Trabajadors { get; set; }
        public IUbigeoRepository Ubigeos { get; set; }
        public IVentaRepository Ventas { get; set; }

        public UnityOfWork()
        {

        }
        public UnityOfWork(_2011116302DbContext context)
        {
            _Context = context;

            AdministradorEquipos = new AdministradorEquipoRepository(_Context);
            AdministradorLineas = new AdministradorLineaRepository(_Context);
            CentroAtencions = new CentroAtencionRepository(_Context);
            Clientes = new ClienteRepository(_Context);
            Contratos = new ContratoRepository(_Context);
            Departamentos = new DepartamentoRepository(_Context);
            Direccions = new DireccionRepository(_Context);
            Distritos = new DistritoRepository(_Context);
            EquipoCelulars = new EquipoCelularRepository(_Context);
            Evaluacions = new EvaluacionRepository(_Context);
            LineaTelefonicas = new LineaTelefonicaRepository(_Context);
            Plans = new PlanRepository(_Context);
            Provincias = new ProvinciaRepository(_Context);
            Trabajadors = new TrabajadorRepository(_Context);
            Ubigeos = new UbigeoRepository(_Context);
            Ventas = new VentaRepository(_Context);
        }
        public void Dispose()
        {
            _Context.Dispose();
        }

        public int SaveChanges()
        {
            return _Context.SaveChanges();
        }

        public void StateModified(object Entity)
        {
            _Context.Entry(Entity).State = System.Data.Entity.EntityState.Modified;
        }
    }
}
