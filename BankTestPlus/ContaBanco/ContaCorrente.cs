using BankTestPlus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using BankTestPlus.Funcionarios;

namespace BankTestPlus.ContaBanco
{
    public class ContaCorrente
    {
        public string DadosCompletoDaContaCorrente => $"Titular: {Titular.Nome}, Agência: {Agencia}, Numero: {Numero}, Saldo: {ObterSaldo()}";
        public static int TotalDeContasCorrente { get; private set; }      // não é possível definir o numero de contas, pois vai ser adicionada automaticamente para não haver erro algum
        public Cliente Titular { get; set; }                       // o campo titular é um tipo de cliente !!!
        public string Numero { get; set; }
        public string Agencia { get; set; }
        private double _saldo;

        public double Saldo
        {
            get => _saldo;                   
            set
            {
                if(value < 0)
                {
                    Console.WriteLine("O saldo não pode ser negativo");
                }
                else
                {
                    _saldo = value;
                }
            }
        }
        public ContaCorrente(Cliente titular, string numero, string agencia)                      // construtor da conta corrente
        {
            Titular = titular;
            Numero = numero;
            Agencia = agencia;
            TotalDeContasCorrente++;                               // a cada conta corrente criada, vai ser adicionada no total de contas correntes
        }

        public double ObterSaldo()
        {
            return _saldo;
        }

        public void SacarDinheiro(double valor)
        {
            if(_saldo < valor)
            {
                Console.WriteLine("Não é possivel sacar a mais do valor que possui na conta!");
            }
            else
            {
                _saldo -= valor;
            }
        }

        public void DepositarDinheiro(double valor)
        {
            if(valor < 0) 
            {
                Console.WriteLine("O valor do depósito deve ser maior que zero! Tente novamente.");
                return;
            }
            else
            {
                _saldo += valor;
            }
        }

        public bool TranferirDinheiro(double valor, ContaCorrente contaDestino) 
        {
            if(_saldo < valor)
            {
                return false;
            }
            else
            {
                _saldo -= valor;
                contaDestino._saldo += valor;                 // contaDestino.DepositarDinheiro(valor); seria o mesmo código! pois já tenho uma função para isso.
                return true;
            }
        }

    }
}