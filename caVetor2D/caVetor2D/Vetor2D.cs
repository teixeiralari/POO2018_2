using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caVetor2D
{
    class Vetor2D
    {
        private double x;
        private double y;


        public Vetor2D()
        {
            x = y = 0.0;
        }

        public Vetor2D(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public String str()
        {
            return "(" + this.x + "; " + this.y + ")";
        }


        public double getX()
        {
            return x;
        }

        public double getY()
        {
            return y;
        }

        public void setX(double x)
        {
            this.x = x;
        }

        public void setY(double y)
        {
            this.y = y;
        }

        public double prodEscalar(Vetor2D vet1)
        {
            return this.x * vet1.getX() + this.y * vet1.getY();
        }

        public double norma()
        {
            return Math.Sqrt(this.x * this.x + this.y * this.y);
        }

       public double angulo(Vetor2D vet1)
        {
            return Math.Acos(this.prodEscalar(vet1) / (this.norma() * vet1.norma()));
        }

        public Vetor2D multiplica(double escalar)
        {
            Vetor2D aux = new Vetor2D(escalar * this.x, escalar * this.y);
            return aux;
        }

        public Vetor2D soma(Vetor2D vet1)
        {
            Vetor2D aux = new Vetor2D(this.x + vet1.getX(), this.y + vet1.getY());
            return aux;
        }

        public Vetor2D projVetor(Vetor2D vet1)
        {
            // projeta this em vet1;
            return vet1.multiplica(this.prodEscalar(vet1) / Math.Pow(vet1.norma(), 2));
        }

    }//fim da classe vetor2d
}
