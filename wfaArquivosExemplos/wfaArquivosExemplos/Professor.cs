using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaArquivosExemplos
{
    [Serializable]
    class Professor : Pessoa
    {
        private String formacao;

        public Professor()
        {
            formacao = "";
            tipo = 1;
        }

        public Professor(String nome, String endereco, int idade, String formacao, int tipo) :
            base(nome, endereco, idade, tipo)
        {
            this.formacao = formacao;
        }

        public string getFormacao()
        {
            return formacao;
        }

        public void setFormacao(String formacao)
        {
            this.formacao = formacao;
        }
    }
}
