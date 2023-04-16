using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tpgrupal04
{
    public partial class formpunto4 : Form
    {
        public formpunto4()
        {
            InitializeComponent();
        }

        private void pasarAGB_Click(object sender, EventArgs e)
        {
            string nombreArchivo = tNombreArchivo.Text;
            double pesoMb = Convert.ToDouble(tCantDeMb.Text);
            double pesoGb = pesoMb / 1024;

            MessageBox.Show($"El archivo " +nombreArchivo+ "tiene un tamaño de "+ pesoGb +" gigabytes.");

        }
    }
}
