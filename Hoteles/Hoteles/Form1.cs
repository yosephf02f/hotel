using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hoteles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Categorias de servisios
            var categoria1 = new Categoria();
            categoria1.Id = 1;
            categoria1.Nombre = "Habitaciones";

            var categoria2 = new Categoria();
            categoria2.Id = 2;
            categoria2.Nombre = "Servicio al Cliente";


            //Habitaciones
            var habitacion1 = new Habitacion();
            habitacion1.Id = 1;
            habitacion1.Descripcion = "Habitacion Sencilla";
            habitacion1.Precio = 1000;
            habitacion1.Categoria = categoria1;

            var habitacion2 = new Habitacion();
            habitacion2.Id = 2;
            habitacion2.Descripcion = "Habitacion Doble";
            habitacion2.Precio = 1500;
            habitacion2.Categoria = categoria1;

            var habitacion3 = new Habitacion();
            habitacion3.Id = 3;
            habitacion3.Descripcion = "Cena para parejas";//servisios de comida o etc
            habitacion3.Precio = 1500;
            habitacion3.Categoria = categoria2;


            var listaDeHabitaciones = new List<Habitacion>();
            listaDeHabitaciones.Add(habitacion1);
            listaDeHabitaciones.Add(habitacion2);
            listaDeHabitaciones.Add(habitacion3);

            foreach (var h in listaDeHabitaciones)
            {
                MessageBox.Show(h.Descripcion + " "+ h.Categoria.Nombre);
            }



        }
    }
}

















