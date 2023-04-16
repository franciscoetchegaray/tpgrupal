using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tpgrupal02
{
    public partial class formulariopunto2 : Form
    {
        public formulariopunto2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string lugar = tLugar.Text;
            double distancia = Convert.ToDouble(tDistancia.Text);
            double velocidad = Convert.ToDouble(tVelocidad.Text);

            double tiempo = distancia / velocidad;

            MessageBox.Show("El tiempo que durará el viaje a "+ lugar +" es de " + tiempo.ToString() + " horas.");

        }
    }
}
