using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronEstrategia
{
    internal class Division : IOperacion
    {
        public double operacion(double x, double y)
        {
            return x / y;
        }
    }
}
