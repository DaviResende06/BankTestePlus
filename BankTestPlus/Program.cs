using BankTestPlus.Funcionarios;
using BankTestPlus.ContaBanco;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
using System.Reflection.Metadata;

namespace BankTestPlus;
public class Program
{
    static void Main(string[] args)
    {
        //PRETENDO TRAZER MAIS ATUALIZAÇÕES DE ACORDO COM MINHA EVOLUCÃO.
         
        //chamando os métodos
        CriarConta();       
        CriarFuncionarios();
        InvestirPoupanca();

        Console.ReadLine();
    }

    public static void CriarConta()
    {
        Cliente davi = new("Davi", "123.456.789-10", "desenvolvedor Back-end");
        davi.Salario = 2000;

        Cliente arthur = new("Arthur", "123.456.357-11", "desenvolvedor Back-end");
        arthur.Salario = 3000;

        ContaCorrente contaN1 = new(davi, "18397434", "0725");
        contaN1.Saldo = 2000;

        ContaCorrente contaN2 = new(arthur, "18445725", "0738");
        contaN2.Saldo = 3000;
        contaN2.TranferirDinheiro(500, contaN1);
        contaN2.SacarDinheiro(500);
        contaN2.DepositarDinheiro(1000);

        Console.WriteLine("Funcao CriarConta");
        Console.WriteLine($"Cliente -> {davi.DadosCompledoDoCliente}");
        Console.WriteLine($"Cliente -> {arthur.DadosCompledoDoCliente}");

        Console.WriteLine($"Dados completo da conta -> {contaN1.DadosCompletoDaContaCorrente}");
        Console.WriteLine($"Dados completo da conta -> {contaN2.DadosCompletoDaContaCorrente}");

        Console.WriteLine($"total clientes: {Cliente.TotalDeCliente}");
        Console.WriteLine($"total de contas correntes: {ContaCorrente.TotalDeContasCorrente}");
    }

    public static void CriarFuncionarios()
    {
        Console.WriteLine("\nFuncão CriarFuncionario()");
        OrganizarBonificacao organizarBonificacao = new();

        EstagiarioDeTI estagiarioDeTI = new("123.456.789-10", "Estágiario de TI");
        estagiarioDeTI.Nome = "Davi";
        organizarBonificacao.RegistrarFuncionario(estagiarioDeTI);

        Recepcionista recepcionista = new("987.654.320-01", "Recepcionista");
        recepcionista.Nome = "Gabriela";
        organizarBonificacao.RegistrarFuncionario(recepcionista);

        OperadordeCaixa operadorDeCaixa = new("457.276.439-04", "Operador de caixa");
        operadorDeCaixa.Nome = "pedro";
        organizarBonificacao.RegistrarFuncionario(operadorDeCaixa);

        Designer designer = new("346.135.964-38", "Designer");
        designer.Nome = "Rafael";
        organizarBonificacao.RegistrarFuncionario(designer);

        DesenvolvedorDeSoftware desenvolvedorDeSoftware = new("284.264.059-18", "Desenvolvedor de software");
        desenvolvedorDeSoftware.Nome = "Joao";
        organizarBonificacao.RegistrarFuncionario(desenvolvedorDeSoftware);

        SubGerente subGerente = new("423.368.7620-96", "Sub Gerente");
        subGerente.Nome = "roberta";
        organizarBonificacao.RegistrarFuncionario(subGerente);

        Gerente gerente = new("837.098.173-83", "Gerente");
        gerente.Nome = "Matheus";
        organizarBonificacao.RegistrarFuncionario(gerente);

        Console.WriteLine($"Dados completo do funcionario: {estagiarioDeTI.DadosCompletoDoFuncionario}");
        Console.WriteLine($"Dados completo do funcionario: {recepcionista.DadosCompletoDoFuncionario}");
        Console.WriteLine($"Dados completo do funcionario: {operadorDeCaixa.DadosCompletoDoFuncionario}");
        Console.WriteLine($"Dados completo do funcionario: {designer.DadosCompletoDoFuncionario}");  
        Console.WriteLine($"Dados completo do funcionario: {desenvolvedorDeSoftware.DadosCompletoDoFuncionario}");   
        Console.WriteLine($"Dados completo do funcionario: {subGerente.DadosCompletoDoFuncionario}");                
        Console.WriteLine($"Dados completo do funcionario: {gerente.DadosCompletoDoFuncionario}");

        Console.WriteLine($"O total de bonificacao da empresa é: {organizarBonificacao.GetTotalBonificacao()}");
        Console.WriteLine($"Total de funcionarios: {Funcionario.TotalDeFuncionarios}");
    }

    public static void InvestirPoupanca()
    {
        Console.WriteLine("___________________________________________________________________________________");

        Console.WriteLine("\nFUNCAO INVESTIR POUPANCA()");

        Console.WriteLine("Bem-vindo ao Banco TestPlus!");
        Console.Write("Digite o valor inicial do investimento: R$ ");              //Pergunta para ao usuário pelo valor inicial do investimento.

        double valorInicial = double.Parse(Console.ReadLine());                    //convertendo em double.

        ContaPoupanca.CondicaoPoupanca(valorInicial);                              //Investir na Poupança de acordo com valor informado pelo usuário.


        Console.ReadLine();
    }
}