using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronProxy
{
    internal class ProxyConductor
    {
        private readonly IConductor _conductor;
        public ProxyConductor(IConductor pConductor) 
        {
            _conductor = pConductor;
        }

        public class Bmw : IConductor
        {
            public void Conducir(int key)
            {
                if (key == 1) Console.WriteLine("run run");
                else Console.WriteLine("llave incorrecta");
            }
        }

    }
}
