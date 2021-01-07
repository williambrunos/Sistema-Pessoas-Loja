using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_23_WilliamBrunoSalesDePaulaLima
{
    //A classe PessoaFisica extende a classe Pessoa, ou seja: recebe de herança todos os seus atributos e métodos:
    class PessoaFisica: Pessoa
    {
        //Atributo específico encapsulado da classe PessoaFisica:
        private string cpfPessoa;

        //Métodos acessadores(getter's e setter's) da classe PessoaFisica:
        public void setCpf(string cpf)
        {
            cpfPessoa = cpf;
        }
        public string getCpfPessoa()
        {
            return cpfPessoa;
        }
    }
}
