using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caVetor3D
{
    public class Vetor3D : Vetor2D
    {
        private double z;

        public Vetor3D() : base()
        {
            z = 0.0;
        }

        public Vetor3D(double x, double y, double z) : base(x, y)
        {
            this.z = z;
        }

        public double getZ()
        {
            return z;
        }

        public void setZ(double z)
        {
            this.z = z;
        }

        public override double norma()
        {
            return Math.Sqrt(x * x + y * y + z * z);
        }

        public Vetor3D prodVetorial(Vetor3D vetor3D)
        {
            // [a2b3 − a3b2, a3b1 − a1b3, a1b2 − a2b1]
            Vetor3D vetor = new Vetor3D(y * vetor3D.z - z * vetor3D.y, 
                                        z * vetor3D.x - x * vetor3D.z, 
                                        x * vetor3D.y - y * vetor3D.x);
            return vetor;
        }

        public String tostr()
        {
            return '(' + x + " ," + y + " ," + z + ')';
        }


    }
}
