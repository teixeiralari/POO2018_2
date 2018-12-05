using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caQ1
{
    class Program
    {
        static void Main(string[] args)
        {
            double res1, res2, pot1, pot2;
           
            Console.WriteLine("Insira o valor da resistência do r1: ");
            res1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insira o valor da potência do r1: ");
            pot1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insira o valor da resistência do r2: ");
            res2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insira o valor da potência do r2: ");
            pot2 = Convert.ToDouble(Console.ReadLine());
            Resistor r1 = new Resistor(res1,pot1);
            Resistor r2 = new Resistor(res2, pot2);

            Console.WriteLine("------------------ASSOCIAÇÃO EM SÉRIE-------------------");
            r1.resistorSerie(r2).imprimeResistor();
            Console.WriteLine("------------------ASSOCIAÇÃO EM PARALELO-------------------");
            r1.resistorParalelo(r2).imprimeResistor();

            Console.ReadLine(); 
        }
    }
}
