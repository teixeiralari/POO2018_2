using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caVetor3D
{
    class Program
    {
        static void Main(string[] args)
        {
            Vetor3D u = new Vetor3D(1, 3, 4);
            Vetor3D v = new Vetor3D(8, -5, -6);

            Console.WriteLine("Produto vetorial u x v: " + u.prodVetorial(v).tostr());
            Console.WriteLine("Módulo do vetor u: " + u.norma());
            Console.ReadLine();
        }
    }
}
