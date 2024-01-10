using BankTestPlus.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankTestPlus
{
    public class Cliente
    {
        public string DadosCompledoDoCliente => $"Nome: {Nome}, CPF: {CPF}, Profissão: {Profissao}, Salario: {Salario}";
        public static int TotalDeCliente { get; private set; }   // não é possível definir um total de cliente, pois vai ser atribuido automaticamente no construtor.
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Profissao { get;  set; }
        public double Salario { get;  set; }

        public Cliente(string nome, string cpf, string profissao)
        {
            Nome = nome;
            CPF = cpf;
            Profissao = profissao;
            TotalDeCliente++;                                  //
        }

    }
}
 