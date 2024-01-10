using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankTestPlus.Funcionarios
{
    public class Gerente : Funcionario
    {
        public Gerente(string cpf, string profissao) : base(6000, cpf, profissao)    // contrutor da classe base. cada funcionrio já tem uma base salarial.
        {
        }

        public override void AumentarSalario()    //palavra chave override para sobrescrever uma funcao abstract... ou 'virtual'.
        {
            Salario *= 1.20;
        }

        public override double GetBonificacao()   //palavra chave override para sobrescrever uma funcao abstract... ou 'virtual'.
        {
            return Salario *= 1.20;
        }
    }
}
