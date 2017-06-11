using _2011116302_ENT.Enumerables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2011116302_ENT
{
    public class Plan
    {
        public int PlanId { get; set; }

        int _CodigoPlan;
        String _TopeConsumo;
        String _CargoFijo;
        String _CaracteristicaPlan;

        public TipoPlan TipoPlan { get; set; }
        public Plan()
        {
            TipoPlan = new TipoPlan();
        }
        public Plan(int codigoPlan, String topeConsumo, String cargoFijo, String caracteristicaPlan)
        {
            CodigoPlan = codigoPlan;
            TopeConsumo = topeConsumo;
            CargoFijo = cargoFijo;
            CaracteristicaPlan = caracteristicaPlan;
        }
        public int CodigoPlan
        {
            get { return _CodigoPlan; }
            set { _CodigoPlan = value; }
        }
        public String TopeConsumo
        {
            get { return _TopeConsumo; }
            set { _TopeConsumo = value; }
        }
        public String CargoFijo
        {
            get { return _CargoFijo; }
            set { _CargoFijo = value; }
        }
        public String CaracteristicaPlan
        {
            get { return _CaracteristicaPlan; }
            set { _CaracteristicaPlan = value; }
        }
    }
}
