using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronDecorador
{
    internal class SistemaSonido : IComponente
    {
        private IComponente decoramosA;

        public SistemaSonido(IComponente pComponente)
        {
            decoramosA = pComponente;
        }

        public override string ToString()
        {
            return $"Radio 350XZ + {decoramosA.ToString()}";
        }
        public double Costo()
        {
            return decoramosA.Costo() + 3500;
        }

        public string Funciona()
        {
           return decoramosA.Funciona() + " , Enciende el radio";
        }
    }
}
