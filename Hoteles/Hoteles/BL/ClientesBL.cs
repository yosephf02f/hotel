using Hoteles.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoteles.BL
{
    public class ClientesBL
    {
        public List<Cliente> ListaDeClientes { get; set; }
        public ClientesBL()
        {
            ListaDeClientes = new List<Cliente>();
            CrearDatosDePrueba();
        }
        private void CrearDatosDePrueba()
        {
            //llenar  id nobre telefono 
            var clienteDatosHistorial = new DatosDelCliente(1, "Clientes"); // CREAR CLASE-->


            var cliente1 = new Cliente(1, "Pedro", 89941908, clienteDatosHistorial);
            var cliente2 = new Cliente(2, "Juan", 95689900, clienteDatosHistorial);
            var cliente3 = new Cliente(3, "Jessica", 89128921, clienteDatosHistorial);

            ListaDeClientes.Add(cliente1);
            ListaDeClientes.Add(cliente2);
            ListaDeClientes.Add(cliente3);
        }


    }
}












