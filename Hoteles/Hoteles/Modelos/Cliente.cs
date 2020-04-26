using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoteles.Modelos
{
     public class Cliente
    {


        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Telefono { get; set; }
        public int CategoriaId { get; set; } //servira para el diseno del formulario
        public Categoria Categoria { get; set; }


        public Cliente(int id, String nombre, int telefono)
        {
            Id = id;
            Nombre = nombre;
            Telefono = telefono;


        }
    }
}
