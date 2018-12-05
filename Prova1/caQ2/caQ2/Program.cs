using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caQ2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pagamentos> pagamentos = new List<Pagamentos>();

            long cpf;
            double valor;
            int codigo;

            String descricao, estabelecimento;


            int aux = 0;
            int aux1 = 0;
            int aux2 = 0;
            while (aux != 6)
            {
                aux = aux1 + aux2;   
                Console.WriteLine("1 - Realizar um pagamento na área Alimentícia");
                Console.WriteLine("2 - Realizar um pagamento na área de Saúde");
                Console.WriteLine("3 - Emitir histórico de pagamentos");

                String opt = Console.ReadLine();
                switch (opt)
                { 
                   
                    case "1":
                        if (aux1 >= 3)
                        {
                            Console.WriteLine("Número máximo de pagamentos alimentícios realizados");
                        }
                        else
                        {
                            Console.WriteLine("Informe o CPF: ");
                            cpf = Convert.ToInt64(Console.ReadLine());
                            Console.WriteLine("Informe o Código: ");
                            codigo = Convert.ToInt16(Console.ReadLine());
                            Console.WriteLine("Informe a descricao do pagamento: ");
                            descricao = Console.ReadLine();
                            Console.WriteLine("Informe o valor do pagamento: ");
                            valor = Convert.ToDouble(Console.ReadLine());

                            Alimentacao alimentacao = new Alimentacao(cpf, valor, codigo, descricao, 0.0);
                            alimentacao.faturar();
                            pagamentos.Add(alimentacao);
                            aux1 += 1;
                        }
                                              
                        break;
                    case "2":
                        if (aux2 >= 3)
                        {
                            Console.WriteLine("Número máximo de pagamentos alimentícios realizados");
                        }
                        else
                        {
                            Console.WriteLine("Informe o CPF: ");
                            cpf = Convert.ToInt64(Console.ReadLine());
                            Console.WriteLine("Informe o Código: ");
                            codigo = Convert.ToInt16(Console.ReadLine());
                            Console.WriteLine("Informe o estabelecimento: ");
                            estabelecimento = Console.ReadLine();
                            Console.WriteLine("Informe o valor do pagamento: ");
                            valor = Convert.ToDouble(Console.ReadLine());

                            Saude saude = new Saude(cpf, valor, codigo, estabelecimento, 0.0);
                            saude.faturar();
                            pagamentos.Add(saude);
                            aux2 += 1;
                        }
                        break;
                    case "3":
                        for(int i=0; i < pagamentos.Count; i++)
                        {
                           pagamentos[i].HistoricoPagamentos();
                        }
                        break;
                    default:
                        Console.WriteLine("Escolha uma das opções acima");
                        break;
                }
            }

            Console.ReadLine();
        }
    }
}
