using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaEmpregado
{
    class Empregado
    {
        protected String nome, cpf, endereco;

        public Empregado()
        {
            nome = cpf = endereco = "";
        }

        public Empregado(String nome, String cpf, String endereco)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.endereco = endereco;
        }

        public String getCPF()
        {
            return cpf;
        }

        public String getNome()
        {
            return nome;
        }

        public String getEndereco()
        {
            return endereco;
        }

        public void setCPF(String cpf)
        {
            this.cpf = cpf;
        }

        public void setNome(String nome)
        {
            this.nome = nome;
        }

        public void setEndereco(String endereco)
        {
            this.endereco = endereco;
        }

        public virtual double salarioLiq()
        {
            return 1.0;
        }

        public virtual String imprime()
        {
            return "";
        }
    }
}
