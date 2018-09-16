using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaAluno_Materia
{
    public class Aluno
    {
        private String nome;
        private String numero_matricula;
        private int periodo;
        private Materia[] lista_materias; //associa a classe materia com a classe aluno
        private int indice_materia;

        public Aluno()
        {
            nome = " ";
            numero_matricula = " ";
            periodo = 0;
            lista_materias = new Materia[8];
            indice_materia = 0;
        }

        public Aluno(String nome, String numero_matricula, int periodo)
        {
            this.nome = nome;
            this.numero_matricula = numero_matricula;
            this.periodo = periodo;
            lista_materias = new Materia[8];
            indice_materia = 0;
        }

        public void showDados()
        {
            Console.WriteLine("Nome do aluno: " + nome + " - " + "Matrícula: " + numero_matricula + " - " + "Periodo: " + periodo);
        }


        public String imprimeMaterias()
        {
            String relatorio = "";
            for (int i = 0; i < indice_materia; i++)
            {
                relatorio = relatorio + lista_materias[i].getNome() + " - " + lista_materias[i].getCodigo() + "\r\n";
            }
            return relatorio;
        }



        public String getNome()
        {
            return nome;
        }

        public String getMatricula()
        {
            return numero_matricula;
        }

        public int getPeriodo()
        {
            return periodo;
        }

        public void setNome(String nome)
        {
            this.nome = nome;
        }

        public void setNumero(String numero_matricula)
        {
            this.numero_matricula = numero_matricula;
        }

        public void setPeriodo(int periodo)
        {
            this.periodo = periodo;
        }

        public void addMateria(Materia materia)
        {
            if (indice_materia < 8)
            {
                lista_materias[indice_materia] = materia;
                indice_materia++;
            }
            else
                Console.WriteLine("Número de matérias limite alcançado");
        }
    }
}
