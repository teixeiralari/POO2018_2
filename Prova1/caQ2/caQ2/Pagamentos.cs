using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caQ2
{
    public class Pagamentos
    {
        protected long cpf;
        protected double valor;
        protected int cod;

        public Pagamentos()
        {
            cpf = 0;
            valor = 0.0;
            cod = 0;
        }

        public Pagamentos(long cpf, double valor, int cod)
        {
            this.cpf = cpf;
            this.valor = valor;
            this.cod = cod;
        }

        public long getCPF()
        {
            return cpf;
        }

        public double getValor()
        {
            return valor;
        }

        public int getCod()
        {
            return cod;
        }

        public void setCPF(long cpf)
        {
            this.cpf = cpf;
        }

        public void setValor(double valor)
        {
            this.valor = valor;
        }

        public void setCod(int cod)
        {
            this.cod = cod;
        }

        public virtual void faturar()
        { }

        public virtual void HistoricoPagamentos()
        {
        }
    }
}
