// See https://aka.ms/new-console-template for more information
using PatronEstrategia;

Console.WriteLine("Hello, World!");

string dato = "";
double x = 0;
double y = 0;
double r = 0;
string opcion = "";


IOperacion operacion = new Suma();

while (opcion != "5")
{
    Console.WriteLine("1:Suma, 2:Resta, 3:Multiplicacion, 4:Division, 5:Salir");
    opcion = Console.ReadLine();
    if (opcion == "5") break;

    Console.WriteLine("Escriba el valor de A");
    dato = Console.ReadLine();
    x = Convert.ToDouble(dato);

    Console.WriteLine("Escriba el valor de B");
    dato = Console.ReadLine();
    y = Convert.ToDouble(dato);

    if (opcion == "1") operacion= new Suma();
    if (opcion == "2") operacion = new Resta();
    if (opcion == "3") operacion = new Multiplicacion();
    if (opcion == "4") operacion = new Division();

    r = operacion.operacion(x, y);

    Console.WriteLine($"El resultado es {r}");
}