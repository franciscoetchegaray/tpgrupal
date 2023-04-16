using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tpgrupal01
{
    public partial class formulario : Form
    {
        public formulario()
        {
            InitializeComponent();
            
        }

        private void calcperimetro_Click(object sender, EventArgs e)
        {
            double radio = Convert.ToDouble(tRadio.Text);
            string unidad = tUnidad.Text;
            double perimetro = 2 * 3.1416 * radio;

            if (unidad == "cm")
            {
                perimetro *= 100;
            }
            else if (unidad == "km")
            {
                perimetro /= 1000;
            }

            MessageBox.Show("El perimetro de el circulo es de: " + perimetro.ToString() +unidad);
        }

        private void tRadio_TextChanged(object sender, EventArgs e)
        {

        }

        private void botonarea_Click(object sender, EventArgs e)
        {
            double radio = Convert.ToDouble(tRadio.Text);
            string unidad = tUnidad.Text;
            double area = 3.14 * radio * radio;
            if (unidad == "cm")
            {
                area *= 100;
            }
            else if (unidad == "km")
            {
                area /= 1000;
            }
        }
    }
}
