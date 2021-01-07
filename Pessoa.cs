using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_23_WilliamBrunoSalesDePaulaLima
{
    //Esta classe Pessoa é a superclasse na qual será estendida para as outras subclasses
    public class Pessoa
    {
        //Atributos encapsulados com private:
        private string nomePessoa;
        private int idadePessoa;
        //O atributo telefonePessoa foi modificada para long por conta de bugs em runtime
        //ligados ao tamanho da variável:
        private long telefonePessoa;
        //Métodos acessadores(getter's e setter's) públicos:
        public void setNomePessoa(string nome)
        {
            nomePessoa = nome;
        }
        public string getNomePessoa()
        {
            return nomePessoa;
        }
        public void setIdadePessoa(int idade)
        {
            if (idade > 0)
            {
                idadePessoa = idade;
            }
            else
            {
                Console.WriteLine("IDADE INVÁLIDA!");
            }
        }
        public int getIdadePessoa()
        {
            return idadePessoa;
        }
        public void setTelefonePessoa(long telefone)
        {
            telefonePessoa = telefone;
        }
        public long getTelefonePessoa()
        {
            return telefonePessoa;
        }
        
    }
}
