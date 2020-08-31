using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionEscalasTemperatura.Clases
{
    public class Temperatura
    {
        private double grados;
        public void setGrados(double valor) 
        {
            this.grados = valor;
        }
        public double getGrados() 
        {
            return this.grados;
        }
        public double convertirAFahrenheit()
        {
            double total;
                total=(this.getGrados() * 9 / 5) +32;
            return total;
        }
        public double convertirAKelvin() 
        {
            double total;
            total = (this.getGrados() +273.15);
            return total;

        }

    }
}
