// See https://aka.ms/new-console-template for more information
using PatronProxy;

//Console.WriteLine("Hello, World!");

Proxy.ISujeto miProxy = new Proxy.ProxySencillo();

//No podemos acceder a la clase
//Proxy.Cocina
/*
miProxy.Peticion(1);
Console.WriteLine("-----");
miProxy.Peticion(2);
*/

Proxy.ISujeto miProxy2 = new Proxy.ProxySeguro();


miProxy2.Peticion(1);
Console.WriteLine("-----");
miProxy2.Peticion(2);


