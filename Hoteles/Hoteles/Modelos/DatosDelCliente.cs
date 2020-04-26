using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoteles.Modelos
{
    public class DatosDelCliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Numero { get; set; }

        public DatosDelCliente(int id, string nombre, int numero)
        {
            Id = id;
            Nombre = nombre;
            Numero = numero;
        }


    }
}
