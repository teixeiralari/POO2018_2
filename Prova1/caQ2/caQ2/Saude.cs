using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caQ2
{
    public class Saude : Pagamentos
    {
        private String estabelecimento;
        private double vlfatSaude;

        public Saude() : base()
        {
            estabelecimento = "";
            vlfatSaude = 0.0;
        }

        public Saude(long cpf, double valor, int cod, 
            String estabelecimento, double vlfatSaude) : base(cpf, valor, cod)
        {
            this.estabelecimento = estabelecimento;
            this.vlfatSaude = vlfatSaude;
        }

        public String getEstabelecimento()
        {
            return estabelecimento;
        }

        public double getVlfatSaude()
        {
            return vlfatSaude;
        }

        public void setEstabelecimento(String estabelecimento)
        {
            this.estabelecimento = estabelecimento;
        }

        public void setVlfatSaude(double vlfatSaude)
        {
            this.vlfatSaude = vlfatSaude;
        }

        public override void faturar()
        {
            vlfatSaude = valor * 1.12;
        }

        public override void HistoricoPagamentos()
        {
            Console.WriteLine("Saude - CPF: " + getCPF() + " Descrição: " + getEstabelecimento() + " Valor da fatura: " + getVlfatSaude() + " Código: " + getCod() + "\n");

        }
    }
}
