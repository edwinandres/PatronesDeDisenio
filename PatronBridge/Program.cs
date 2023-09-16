// See https://aka.ms/new-console-template for more information
using PatronBridge;

Console.WriteLine("Hello, World!");

Dictionary<string , double> productos = new Dictionary<string, double>();

productos.Add("C1", 1.1);
productos.Add("C2", 1.2);
productos.Add("M3", 1.3);
productos.Add("M4", 1.4);
productos.Add("M5", 1.5);
productos.Add("D6", 1.6);
productos.Add("D7", 1.7);
productos.Add("C8", 1.8);
productos.Add("D9", 1.9);
productos.Add("D10", 1.10);

//Creamos el bridge

Abstraccion bridge = new Abstraccion(new Implementacion3(), productos);

bridge.MostrarTotales();
bridge.Listar();