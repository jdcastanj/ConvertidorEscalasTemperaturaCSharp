using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConversionEscalasTemperatura.Clases;

namespace ConversionEscalasTemperatura
{
    public partial class Form1 : Form
    {
        Temperatura temperatura = new Temperatura();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnconvertir_Click(object sender, EventArgs e)
        {
            lblresultado.Visible = true;
            double valorGrado;
            valorGrado = double.Parse(txtvalor.Text);
            temperatura.setGrados(valorGrado);
            lblresultado.Text = Convert.ToString(temperatura.convertirAFahrenheit());
        }

        private void btnconvertirkelvin_Click(object sender, EventArgs e)
        {
            lblresultado.Visible = true;
            double valorGrado;
            valorGrado = double.Parse(txtvalor.Text);
            temperatura.setGrados(valorGrado);
            lblresultado.Text = Convert.ToString(temperatura.convertirAKelvin());

        }
    }
}
