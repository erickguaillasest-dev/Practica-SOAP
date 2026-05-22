using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente.NET
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crear cliente
            ServicioWebSOAP.WSOperacionesClient cliente = new ServicioWebSOAP.WSOperacionesClient();

            //utilizar metodo 

            //login
            if (cliente.Login("Pavel", "Pavel2020")) 
            {
                Console.WriteLine("Credenciales correctas");
            }
            else
            {
                Console.WriteLine("Credenciales incorrectas");

            }
             if(cliente.ProcesarPago(500, 10000)>=0)
            {
                Console.WriteLine("Pago realizado");

            }
            else
            {
                Console.WriteLine("Dinero insuficiente");
                }


                //cerrar conexion
                cliente.CloseAsync();
            Console.ReadKey();
        }
    }
}