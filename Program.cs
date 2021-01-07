using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
    Aula 2.3 - Curso de Fundamentos de Desenvolvimento com linguagem C#
    Aluno: William Bruno Sales de Paula Lima
    Professor: Marcondes Alexandre
 */
namespace Aula_23_WilliamBrunoSalesDePaulaLima
{
    //A classe Program possui objetos instanciados das classes PessoaFisica e PessoaJuridica:
    class Program
    {
        static void Main(string[] args)
        {
            //As variáveis n1 e n2 guardam a quantidade de objetos das classes PessoaFisica
            //e PessoaJuridica que vão ser criados:
            int n1, n2;
            do
            {
                Console.Write("Digite quantas pessoas físicas há: ");
                n1 = int.Parse(Console.ReadLine());
                Console.Write("Digite quantas pessoas jurídicas há: ");
                n2 = int.Parse(Console.ReadLine());

                if(n1 <= 0 || n2 <= 0)
                {
                    Console.WriteLine("Digite valores maiores do que 0!");
                }
            } while (n1 <= 0 || n2 <= 0);

            //Início da criação das matrizs de objetos PessoaFisica e PessoaJuridica:
            //Cada elemento da matriz foi criado, mas está referenciando um valor null, 
            //precisamos preenchê-los:
            PessoaFisica[] pessoaFisica = new PessoaFisica[n1];
            PessoaJuridica[] pessoaJuridica = new PessoaJuridica[n2];

            //Preenche o restante das variáveis da matriz com endereços de memória que
            //referenciam para cada objeto:
            for(int i = 0; i < n1; i++)
            {
                pessoaFisica[i] = new PessoaFisica();
            }
            for(int i = 0; i < n2; i++)
            {
                pessoaJuridica[i] = new PessoaJuridica();
            }

            //Agora sim podemos começar a programar com n1 instâncias da classe PessoaFisica
            //e n2 instâncias da classe PessoaJuridica:
            Console.WriteLine("====CADASTRO DE PESSOA FÍSICA DA LOJA====");
            //O loop a seguir preenche os atributos das instâncias da classe PessoaFisica por meio
            //de métodos setter's:
            for (int i = 0; i < n1; i++)
            {
                Console.WriteLine("Pessoa " + (i + 1));
                Console.Write("Nome: ");
                pessoaFisica[i].setNomePessoa(Console.ReadLine());

                Console.Write("Idade: ");
                pessoaFisica[i].setIdadePessoa(int.Parse(Console.ReadLine()));

                Console.Write("Telefone: ");
                pessoaFisica[i].setTelefonePessoa(long.Parse(Console.ReadLine()));

                Console.Write("CPF: ");
                pessoaFisica[i].setCpf(Console.ReadLine());
            }

            Console.WriteLine();

            Console.WriteLine("===CADASTRO DE PESSOA JURÍDICA DA LOJA====");

            //O loop a seguir preenche os atributos das instâncias da classe PessoaJuridica por meio
            //de métodos setter's:
            for (int i = 0; i < n2; i++)
            {
                Console.WriteLine("Pessoa " + (i + 1));
                Console.Write("Nome: ");
                pessoaJuridica[i].setNomePessoa(Console.ReadLine());

                Console.Write("Idade: ");
                pessoaJuridica[i].setIdadePessoa(int.Parse(Console.ReadLine()));

                Console.Write("Telfeone: ");
                pessoaJuridica[i].setTelefonePessoa(int.Parse(Console.ReadLine()));

                Console.Write("CNPJ: ");
                pessoaJuridica[i].setCpnjPessoa(Console.ReadLine());
            }


            Console.WriteLine("====INFORMAÇÕES DA PESSOA FÍSICA====");

            //O loop a seguir mostra os atributos de cada instância da classe PessoaFisica
            //através de métodos getter's:
            for (int i = 0; i < n1; i++)
            {
                Console.WriteLine("Pessoa " + (i + 1));
                Console.WriteLine("Nome: " + pessoaFisica[i].getNomePessoa());
                Console.WriteLine("Idade: " + pessoaFisica[i].getIdadePessoa());
                Console.WriteLine("Telefone: " + pessoaFisica[i].getTelefonePessoa());
                Console.WriteLine("CPF: " + pessoaFisica[i].getCpfPessoa());

                Console.WriteLine();
            }

            Console.WriteLine("====INFORMAÇÕES DA PESSOA JURÍDICA====");

            //O loop a seguir mostra os atributos de cada instância da classe PessoaJuridica
            //através de métodos getter's:
            for (int i = 0; i < n2; i++)
            {
                Console.WriteLine("Pessoa " + (i + 1));
                Console.WriteLine("Nome: " + pessoaJuridica[i].getNomePessoa());
                Console.WriteLine("Idade: " + pessoaJuridica[i].getIdadePessoa());
                Console.WriteLine("Telefone: " + pessoaJuridica[i].getTelefonePessoa());
                Console.WriteLine("CNPJ: " + pessoaJuridica[i].getCpnjPessoa());

                Console.WriteLine();
            }

            Console.WriteLine();

            Console.WriteLine("Press any key to continue . . .");
            Console.ReadKey();
        }
    }
}
