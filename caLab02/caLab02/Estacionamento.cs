using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caLab02
{
    public class Estacionamento
    {
        String placa, marca;
        Tempo horaEntrada = new Tempo();
        Tempo horaSaida = new Tempo();

        public Estacionamento()
        {
            placa = marca = " ";
        }

        public Estacionamento(String placa, String marca)
        {
            this.placa = placa;
            this.marca = marca;
        }

        public void solicitaDados()
        {
            Console.WriteLine("------------ DADOS DO VEÍCULO -----------");
            Console.Write("Insira a placa do carro: ");
            placa = Console.ReadLine();
            Console.Write("Insira a marca do carro: ");
            marca = Console.ReadLine();
            Console.WriteLine("Horário de entrada: ");
            horaEntrada.solicitaTempo();
            Console.WriteLine("Horário de saída: ");
            horaSaida.solicitaTempo();
        }

        public void imprimeCarro()
        {
            Console.WriteLine("Placa: " + placa + " Marca: " + marca);
            Console.Write("Horário de entrada: ");
            horaEntrada.imprimeTempo();
            Console.Write("Horário de saída: ");
            horaSaida.imprimeTempo();
        }

        public void totalPagar()
        {
            Tempo totalHoras = horaSaida.subtraiTempo(horaEntrada);
            int qtd_horas = totalHoras.getHora() * 7;
            Console.Write("Tempo de estádia: ");
            totalHoras.imprimeTempo();
            Console.WriteLine("Valor total: R$ " + qtd_horas + ",00");
        }
    }
}
