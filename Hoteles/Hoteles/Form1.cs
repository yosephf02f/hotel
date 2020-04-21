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
            var habitacion1 = new Habitacion();
            habitacion1.Id = 1;
            habitacion1.Descripcion = "Habitacion Sencilla";
            habitacion1.Precio = 1000;




            var habitacion2 = new Habitacion();
            habitacion2.Id = 2;
            habitacion2.Descripcion = "Habitacion Doble";
            habitacion2.Precio = 1500;

            var listaDeHabitaciones = new List<Habitacion>();
            listaDeHabitaciones.Add(habitacion1);
            listaDeHabitaciones.Add(habitacion2);

            foreach (var h in listaDeHabitaciones)
            {
                MessageBox.Show(h.Descripcion);
            }



        }
    }
}

















