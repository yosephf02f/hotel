﻿using Hoteles.BL;
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



            var habitacionesBL = new HabitacionesBL();
            listaDeHabitacionesBindingSource.DataSource = habitacionesBL.ListaDeHabitaciones;




            var categoriasBL = new CategoriasBL();
            listaDeCategoriasBindingSource.DataSource = categoriasBL.ListaDeCategorias;

        }


    }
}

















