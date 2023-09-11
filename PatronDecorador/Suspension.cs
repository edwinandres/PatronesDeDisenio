using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronDecorador
{
    internal class Suspension
    {

        private IComponente decoramosA;

        public Suspension(IComponente pComponente)
        {
            decoramosA = pComponente;
        }

        public override string ToString()
        {
            return $"Suspension de alto desempeño {decoramosA.ToString()}";
        }
        public double Costo()
        {
            return decoramosA.Costo() + 63850;
        }

        public string Funciona()
        {
            return decoramosA.Funciona() + " , Elevando suspensión";
        }

    }
}
