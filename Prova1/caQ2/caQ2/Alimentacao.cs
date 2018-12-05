using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caQ2
{
    public class Alimentacao : Pagamentos
    {
        private String descricao;
        private double vlfatAliment;

        public Alimentacao() : base()
        {
            descricao = "";
            vlfatAliment = 0.0;
        }

        public Alimentacao(long cpf, double valor, int cod,
            String descricao, double vlfatAliment) : base(cpf, valor, cod)
        {
            this.descricao = descricao;
            this.vlfatAliment = vlfatAliment;
        }


        public String getDescricao()
        {
            return descricao;
        }

        public double getVlfatAliment()
        {
            return vlfatAliment;
        }

        public void setDescricao(String descricao)
        {
            this.descricao = descricao;
        }

        public void setVlfatAliment(double vlfatAliment)
        {
            this.vlfatAliment = vlfatAliment;
        }

        public override void faturar()
        {
            vlfatAliment = valor * 1.05;
        }

        public override void HistoricoPagamentos()
        { 
           Console.WriteLine("Alimentação - CPF: " + getCPF() + " Descrição: " + getDescricao()+ " Valor da fatura: " + getVlfatAliment() + " Código: " + getCod() + "\n");
        }
    }
}
