using BankTestPlus.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankTestPlus
{
    public class OrganizarBonificacao 
    {
        private double _totalBonificacao;

        public void RegistrarFuncionario(Funcionario funcionario)        //funcao para registrar funcionario e atribuir a bonificacao parar obter o total de bonificação da empresa
        {                                                        
            _totalBonificacao += funcionario.GetBonificacao();
        }

        public double GetTotalBonificacao()                     // adquirir o total de bonificação da empresa
        {
            return _totalBonificacao;
        }
    }
}
