using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_23_WilliamBrunoSalesDePaulaLima
{
    //A classe Pessoa Juridica extende a classe Pessoa, ou seja: recebe de herança seus atributos e métodos:
    class PessoaJuridica: Pessoa
    {
        //Atributo específico encapsulado da classe PessoaJuridica:
        private string cnpjPessoa;

        //Métodos acessadores(getter's e setter's) da classe PessoaJuridica:
        public void setCpnjPessoa(string cnpj)
        {
            cnpjPessoa = cnpj;
        }
        public string getCpnjPessoa()
        {
            return cnpjPessoa;
        }

    }
}
