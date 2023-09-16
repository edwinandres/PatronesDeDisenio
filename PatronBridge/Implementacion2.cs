﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronBridge
{
    internal class Implementacion2 : IBridge

    {
       
        public void ListarProductos(Dictionary<string, double> pProductos)
        {
            foreach(KeyValuePair<string, double>p in pProductos)
            {
                if (p.Key[0] == 'C') Console.ForegroundColor = ConsoleColor.Green;
                if (p.Key[0] == 'M') Console.ForegroundColor = ConsoleColor.Yellow;
                if (p.Key[0] == 'D') Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine($"{p.Key} -- {p.Value}");

            }
        }

        public void MostrarTotales(Dictionary<string, double> pProductos)
        {
            double total = 0;
            double totalm = 0;
            double totalc = 0;
            double totald = 0;
            int cantidad = 0;

            foreach(KeyValuePair<string, double> p in pProductos)
            {
                total += p.Value;
                if (p.Key[0] == 'C') totalc += p.Value;
                if (p.Key[0] == 'M') totalm += p.Value;
                if (p.Key[0] == 'D') totald += p.Value;

                cantidad++;
            }
            Console.WriteLine($"El total de comida es ${totalc}");
            Console.WriteLine($"El total de medicamentos es ${totalm}");
            Console.WriteLine($"El total de deportes es ${totald}");
            Console.WriteLine($"El total de productos es ${total}");

        }
    }
}
