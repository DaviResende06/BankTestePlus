using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankTestPlus.Funcionarios
{
    public abstract class Funcionario  // classe abstrata, como se fosse um modelo a ser seguido para as classes que irão herdar essas propriedades(campos).
    {
        public static int TotalDeFuncionarios { get; private set; }  // set privado, para não ser possível mudar o valor real de total de funcionarios.
        public string DadosCompletoDoFuncionario => $"Nome: {Nome}, CPF: {CPF}, Profissão: {Profissao}, Salário: {Salario}";
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Profissao { get; set; }
        public double Salario { get; protected set; }   // set protegido, estão eu não posso definir o valor fora da classe Funcionarios e seus herdeiros

        public Funcionario(double salario, string cpf, string profissao) // todos os funcionarios terão essa base de construção
        {
            Salario = salario;
            CPF = cpf;
            Profissao = profissao;
            TotalDeFuncionarios++;
        }

        public abstract void AumentarSalario();  //todas as classes herdadas de funcionários terão que colocar esse método abstrato, usando a palavra chave override.

        public abstract double GetBonificacao();  // todas as classes herdadas de funcionários terão que colocar essa função abstrata, usando a palavra chave override.
    }
}
