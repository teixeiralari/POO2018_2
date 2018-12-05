using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaArquivosExemplos
{

    [Serializable]
    class Aluno : Pessoa
    {
        private String curso;

        public Aluno()
        {
            tipo = 2;
            curso = "";
        }

        public Aluno(String nome, String endereco, int idade, String curso, int tipo) :
            base (nome, endereco, idade, tipo)
        {
            this.curso = curso;
        }

        public string getCurso()
        {
            return curso;
        }

        public void setCurso(String curso)
        {
            this.curso = curso;
        }
    }
}
