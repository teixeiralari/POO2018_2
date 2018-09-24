using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caVetor3D
{
    public class Vetor2D
    {
        protected double x;
        protected double y;


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
            return "(" + x + "; " + y + ")";
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
            return x * vet1.getX() + y * vet1.getY();
        }

        public virtual double norma()
        {
            return Math.Sqrt(x * x + y * y);
        }

        public double angulo(Vetor2D vet1)
        {
            return Math.Acos(prodEscalar(vet1) / (norma() * vet1.norma()));
        }

        public Vetor2D multiplica(double escalar)
        {
            Vetor2D aux = new Vetor2D(escalar * x, escalar * y);
            return aux;
        }

        public Vetor2D soma(Vetor2D vet1)
        {
            Vetor2D aux = new Vetor2D(x + vet1.getX(), y + vet1.getY());
            return aux;
        }

        public Vetor2D projVetor(Vetor2D vet1)
        {
            // projeta this em vet1;
            return vet1.multiplica(prodEscalar(vet1) / Math.Pow(vet1.norma(), 2));
        }
    }
}
