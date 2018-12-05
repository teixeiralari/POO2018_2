using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaArquivosExemplos
{
    [Serializable]
    class Pessoa
    {
        protected String nome, endereco;
        protected int idade, tipo;

        public Pessoa()
        {
            nome = endereco = " ";
            idade = 0;
        }

        public Pessoa(String nome, String endereco, int idade, int tipo)
        {
            this.nome = nome; 
            this.endereco = endereco;
            this.idade = idade;
            this.tipo = tipo;
        }

        public string getNome()
        {
            return nome;
        }

        public void setNome(String nome)
        {
            this.nome = nome;
        }

        public string getEndereco()
        {
            return endereco;
        }

        public void setEndereco(String endereco)
        {
            this.endereco = endereco;
        }

        public int getIdade()
        {
            return idade;
        }

        public void setIdade(int idade)
        {
            this.idade = idade;
        }


    }
}
