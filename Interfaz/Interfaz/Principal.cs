using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            ExtraerDatosIMN();
        }


        public void ExtraerDatosIMN()
        {
            cr.ac.imn.www.pronosticoCiudad conectar = new cr.ac.imn.www.pronosticoCiudad();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }
    }
}
