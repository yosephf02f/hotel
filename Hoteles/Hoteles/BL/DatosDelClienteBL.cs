using Hoteles.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoteles.BL
{
    public class DatosDelClienteBL
    {
        public List<DatosDelCliente> ListaDeClientes { get; set; }

        public DatosDelClienteBL()
        {
            ListaDeClientes = new List<DatosDelCliente>();
            CrearDatosDePrueba();
        }

        private void CrearDatosDePrueba()
        {
            var datoDelCliente1 = new DatosDelCliente(1, "Cliente");
            var datoDelCliente2 = new DatosDelCliente(2, "Cliente2");
            //          var categoria3 = new Categoria(3, "Historial de Clientes");  //no se si dejarlo

            ListaDeClientes.Add(datoDelCliente1);
            ListaDeClientes.Add(datoDelCliente2);
            //       ListaDeCategorias.Add(categoria3);

        }

    }
}
