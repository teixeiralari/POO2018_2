using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaEmpregado
{
    class EmpregadoCLT : Empregado
    {
        double salarioBruto;

        public EmpregadoCLT() : base()
        {
            salarioBruto = 0.0;
        }

        public EmpregadoCLT(String nome, String cpf, String endereco, double salarioBruto) : base(nome, cpf, endereco)
        {
            this.salarioBruto = salarioBruto;
        }

        public override double salarioLiq()
        {
            if (salarioBruto <= 5000.0)
                return salarioBruto * 0.85;
            else
                return salarioBruto * 0.725;
        }

        public override string imprime()
        {
            return "CLT | " + nome + "\t| " + cpf + "\t| " + endereco + " | " + salarioLiq();
        }
    }
}
