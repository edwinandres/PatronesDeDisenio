using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronBridge
{
    //Conecta al cliente con la abstraccion a utilizar
    internal class Abstraccion
    {
        //Referencia a la implementacion
        IBridge implementacion;
        Dictionary<string, double> productos;

        //Método 1, el mas usual
        //Constructor, recibimos la implementación concreta
        public Abstraccion(IBridge pImp, Dictionary<string, double> pProductos)
        {
            implementacion = pImp;
            productos = pProductos;
        }

        //Método 2, cuidado porque no deseamos hacer una fabrica
        public Abstraccion(int pTipo, Dictionary<string, double> pProductos)
        {
            if (pTipo == 1) implementacion = new Implementacion1();
            //if (pTipo == 2) implementacion = new Implementacion2();
            //if (pTipo == 3) implementacion = new Implementacion3();

            productos = pProductos;

        }

        //Estos métodos representan la interfaz que conoce el cliente
        public void MostrarTotales()
        {
            implementacion.MostrarTotales( productos);
        }

        public void Listar()
        {
            implementacion.ListarProductos(productos);
        }

    }
}
