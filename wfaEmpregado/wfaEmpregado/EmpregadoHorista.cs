using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaEmpregado
{
    class EmpregadoHorista : Empregado
    {
        private int nHoras;
        private double valorHora;

        public EmpregadoHorista() : base()
        {
            nHoras = 0;
            valorHora = 0.0;
        }
        
        public EmpregadoHorista(String nome, String cpf, 
            String endereco, int nHoras, double valorHora) : base(nome, cpf, endereco)
        {
            this.nHoras = nHoras;
            this.valorHora = valorHora;
        }

        public int getHoras()
        {
            return nHoras;
        }

        public double getValor()
        {
            return valorHora;
        }

        public void setHoras(int nHoras)
        {
            this.nHoras = nHoras;
        }

        public void setValor(double valorHora)
        {
            this.valorHora = valorHora;
        }

        public override double salarioLiq()
        {
            if ((valorHora * nHoras) <= 5000.0)
                return valorHora * nHoras * 0.85;
            else
                return valorHora * nHoras * 0.725;
        }

        public override String imprime()
        {
            return "Horista | " + nome + " | " + cpf + "\t| " + endereco + " | " + salarioLiq();
        }
    }
}
