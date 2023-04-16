using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tpgrupal03
{
    public partial class formpunto3 : Form
    {
        public formpunto3()
        {
            InitializeComponent();
        }

        private void CalcCantM3_Click(object sender, EventArgs e)
        {
            double ancho = Convert.ToDouble(tAncho.Text);
            double alto = Convert.ToDouble(tAlto.Text);
            double m3PorMetroCuadrado = Convert.ToDouble(tM3PorMetroCuadrado.Text);

            double area = ancho * alto;
            double arena = area * m3PorMetroCuadrado;

            MessageBox.Show($"Se necesitan {arena} metros cúbicos de arena para revocar la pared.");


        }
    }
}
