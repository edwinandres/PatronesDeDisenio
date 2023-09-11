// See https://aka.ms/new-console-template for more information
using PatronDecorador;

Console.WriteLine("Hello, World!");

IComponente miAuto = new Auto("2018", "4 puertas", 200000);
Console.WriteLine(miAuto);

//Hacer cast para usar metodos de Auto
((Auto)miAuto).Puertas(true);
Console.WriteLine("------");

miAuto = new SistemaSonido(miAuto);

Console.WriteLine(miAuto.Costo());
Console.WriteLine(miAuto.Funciona());
Console.WriteLine(miAuto);

Console.WriteLine("------");

miAuto = new Nitrogeno(miAuto);

Console.WriteLine(miAuto.Costo());
Console.WriteLine(miAuto.Funciona());
Console.WriteLine(miAuto);

Console.WriteLine("------");

((Nitrogeno)miAuto).UsaN();
Console.WriteLine(miAuto);

// La siguiente linea da error. Una vez decoramos , no se pueden usar metodos especificos
((Suspension)miAuto).Costo();
