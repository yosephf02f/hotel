using Hoteles.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoteles.BL
{
    public class CategoriasBL
    {

        public List<Categoria> ListaDeCategorias { get; set; }

        public CategoriasBL()
        {
            ListaDeCategorias = new List<Categoria>();
            CrearDatosDePrueba();
        }

        private void CrearDatosDePrueba()
        {
            var categoria1 = new Categoria(1, "Habitaciones");
            var categoria2 = new Categoria(2, "Cervicio al cliente");
  //          var categoria3 = new Categoria(3, "Historial de Clientes");  //no se si dejarlo

            ListaDeCategorias.Add(categoria1);
            ListaDeCategorias.Add(categoria2);
     //       ListaDeCategorias.Add(categoria3);

        } 


    }
}



















