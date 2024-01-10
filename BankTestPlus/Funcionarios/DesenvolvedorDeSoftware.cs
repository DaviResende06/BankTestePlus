using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankTestPlus.Funcionarios
{
    public class DesenvolvedorDeSoftware : Funcionario
    {
        public DesenvolvedorDeSoftware(string cpf, string profissao) : base(3800, cpf, profissao)   // contrutor da classe base.
        {
        }

        public override void AumentarSalario()     //palavra chave override para sobrescrever uma funcao abstract... ou 'virtual'.
        {
            Salario *= 1.10;
        }

        public override double GetBonificacao()   //palavra chave override para sobrescrever uma funcao abstract... ou 'virtual'.
        {
            return Salario *= 1.15;
        }
    }
}
