using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caQ1
{
    public class Resistor
    {
        private double resistencia, potencia;

        public Resistor()
        {
            resistencia = potencia = 0.0;
        }

        public Resistor(double resistencia, double potencia)
        {
            this.resistencia = resistencia;
            this.potencia = potencia;
        }

        public double getResistencia()
        {
            return resistencia;
        }

        public double getPotencia()
        {
            return potencia;
        }

        public void setResistencia(double resistencia)
        {
            this.resistencia = resistencia;
        }

        public void setPotencia(double potencia)
        {
            this.potencia = potencia;
        }

        public Resistor resistorSerie(Resistor resistor)
        {
            if (resistor.getPotencia() < potencia)
                potencia = resistor.getPotencia();
            Resistor r = new Resistor(resistencia + resistor.getResistencia(), potencia);
            return r;
        }

        public Resistor resistorParalelo(Resistor resistor)
        {
            if (resistor.getPotencia() < potencia)
                potencia = resistor.getPotencia();
            Resistor r = new Resistor((resistencia * resistor.getResistencia())/(resistencia + resistor.getResistencia())
                , potencia);
            return r;
        }

        public void imprimeResistor()
        {
            Console.WriteLine("Resistência equivalente: " + getResistencia() +
                " Potência equivalente: " + getPotencia());
        }

    }
}
