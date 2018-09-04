using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caVetor2D
{
    class Program
    {
        static void Main(string[] args)
        {
            Vetor2D vet1 = new Vetor2D(4, 5);
            Vetor2D vet2 = new Vetor2D(7, 8);

            Console.WriteLine("Módulo do vetor vet1: " + vet1.norma());
            Console.WriteLine("Produto escalar entre os vetores vet1 e vet2: " + vet1.prodEscalar(vet2));
            Console.WriteLine("Angulo entre os vetores vet1 e vet2: " + vet1.angulo(vet2) + " rad");
            Console.WriteLine("Projeção vet1 em vet2: " + vet1.projVetor(vet2).str());
            Console.WriteLine("Soma vet1 e vet2: " + vet1.soma(vet2).str());
            Console.ReadLine();
        }
    }
}
