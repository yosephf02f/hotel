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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void habitacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formHabitaciones = new Form1();
            formHabitaciones.MdiParent = this;
            formHabitaciones.Show();

        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
          //  var formClientes = new Form(); crea form clieente

        }
    }
}
