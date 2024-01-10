using BankTestPlus.Funcionarios;
using BankTestPlus.ContaBanco;
using System;

namespace BankTestPlus.ContaBanco
{
    public class ContaPoupanca : ContaCorrente
    {
        public ContaPoupanca(Cliente titular, string numero, string agencia) : base(titular, numero, agencia)
        {
        }

        public static void CondicaoPoupanca(double valorInvestido)           
        {
            Console.WriteLine($"Investimento em nosso banco de 0.46% a.m\n");

            for (int contadorMes = 1; contadorMes <=12; contadorMes++)    //1° inicialização, 2° a condicao para ser executado, 3° o encremento
            {
                valorInvestido *= 1.0036;                                          // o mesmo que  valorInvestido = valorInvestido + valorInvestido *0.0036;
                                                                                                 // a cada 1 no contadorMes, esse valor é multiplicado até 12. 
                Console.WriteLine($"Após {contadorMes}° mês, você receberá: R$ {valorInvestido} Reais.");
            }
        }
    }
}