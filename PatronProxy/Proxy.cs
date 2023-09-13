using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronProxy
{
    internal class Proxy
    {
        //Se usa anidamiento dentro de la clase
        //Cualquier clase privada y anidada solo sea conocida por el proxy
        public interface ISujeto
        {
            void Peticion(int pOpcion);
        }

        public class ProxySencillo : ISujeto
        {
            private Cocina cocina;
            public void Peticion(int pOpcion)
            {
                if (cocina == null)
                {
                    Console.WriteLine("Activando el sujeto");
                    cocina = new Cocina();
                }
                if (pOpcion == 1) cocina.RecetaSecreta();
                if (pOpcion == 2) cocina.Cocinar(5);
            }
        }

        public class ProxySeguro : ISujeto
        {
            private Cocina cocina;
            public void Peticion(int pOpcion)
            {
                string password;
                Console.WriteLine("Dame el password");
                password = Console.ReadLine();

                if(password == "abc123")
                {
                    if(cocina == null)
                    {
                        Console.WriteLine("Activando el sujeto");
                        cocina = new Cocina();
                    }
                    if (pOpcion == 1) cocina.RecetaSecreta();
                    if (pOpcion == 2) cocina.Cocinar(5);
                }
                else
                {
                    Console.WriteLine("Acceso Denegado");
                }


            }
        }

        private class Cocina
        {
            public void RecetaSecreta()
            {
                Console.WriteLine("Pan, Aceite de oliva, Especias, Jamosn, Queso");
            }

            public void Cocinar(int n)
            {
                Console.WriteLine("Cocinando {0} recetas", n);
            }
        }
    }
}
