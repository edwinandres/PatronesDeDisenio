using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronDecorador
{
    internal class Auto : IComponente
    {
        private string modelo;
        private string caracteristicas;
        private double costo;

        public Auto(string pmodelo, string pcaracteristicas, double pcosto)
        {
            modelo = pmodelo;
            caracteristicas = pcaracteristicas;
            costo = pcosto;
        }

        public void Puertas(bool pEstado)
        {
            if (pEstado) Console.WriteLine("Puertas cerradas");
            else Console.WriteLine("Puertas abiertas");
        }

        public override string ToString()
        {
            return string.Format($"Modelo {modelo},  {caracteristicas}");
        }

        public double Costo()
        {
            return costo;
        }

        public string Funciona()
        {
            return "Encendi el motor";
        }
    }
}
