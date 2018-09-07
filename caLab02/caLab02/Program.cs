using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caLab02
{
    public class Program
    {
        static void Main(string[] args)
        {
            Estacionamento[] estacionamento = new Estacionamento[5];
            
            int i;
            for (i = 0; i < 1; i++)
            {
                estacionamento[i] = new Estacionamento();
                estacionamento[i].solicitaDados();
            }
            Console.WriteLine("------------------ RELATÓRIO ---------------------");
            for (i = 0; i < 1; i++)
            {
                Console.WriteLine("VEÍCULO " + (i+1));
                estacionamento[i].imprimeCarro();
                estacionamento[i].totalPagar();
                Console.WriteLine();
            }
          

            Console.ReadLine();
        }
    }
}
