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
    public partial class IMN : Form
    {
        public IMN()
        {
            InitializeComponent();
            ExtraerDatosIMN();
            this.CenterToScreen();
        }


        public void ExtraerDatosIMN()
        {
            cr.ac.imn.www.WSMeteorologicoService conectar = new cr.ac.imn.www.WSMeteorologicoService();
           // MessageBox.Show(  ""  + conectar.pronosticoRegionalxID(5)); 

            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void btnSanjose_Click(object sender, EventArgs e)
        {
           cr.ac.imn.www.WSMeteorologicoService conectar = new cr.ac.imn.www.WSMeteorologicoService();
           MessageBox.Show("" + conectar.pronosticoPorCiudadxID(1));

        }

        private void btnAlajuela_Click(object sender, EventArgs e)
        {
            cr.ac.imn.www.WSMeteorologicoService conectar = new cr.ac.imn.www.WSMeteorologicoService();
            MessageBox.Show("" + conectar.pronosticoPorCiudadxID(2));

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
