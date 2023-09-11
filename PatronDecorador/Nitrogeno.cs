using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronDecorador
{
    internal class Nitrogeno : IComponente
    {
        //variable de referencia hacia quien se decora
        private IComponente decoramosA;

        //pasamos el objeto que va a ser decorado
        public Nitrogeno(IComponente pComponente)
        {
            decoramosA = pComponente;
        }

        public override string ToString()
        {
            return $"Sistema de Nitrogeno \r\n {decoramosA.ToString()}";
        }

        public double Costo()
        {
            //El costo de lo que se decora mas el costo de este componente
            return decoramosA.Costo()+ 45000;
        }

        public string Funciona()
        {
            return decoramosA.Funciona() + " , Nitrogeno listo";
        }

        public void UsaN()
        {
            Console.WriteLine("Nitrogeno en uso");
        }
    }
}
