using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaAluno_Materia
{
    public class Materia
    {
        private String nome;
        private String codigo;

        public Materia()
        {
            nome = codigo = " ";
        } 

        public Materia(String nome, String codigo)
        {
            this.nome = nome;
            this.codigo = codigo;
        }

        public String getNome()
        {
            return nome;
        }

        public String getCodigo()
        {
            return codigo;
        }

        public void setNome(String nome)
        {
            this.nome = nome;
        }

        public void setCodigo(String codigo)
        {
            this.codigo = codigo;
        }

        public String showMaterias()
        {
            return nome + " - " + codigo;
        }
    }
}
