using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Dados da primeira pessoa:");
                Console.Write("Nome:");
                string nome = Console.ReadLine();
                Console.Write("Sálario:");
                double salario = double.Parse(Console.ReadLine());
                Console.Write("Idade:");
                int idade = int.Parse(Console.ReadLine());

                Pessoa primeiraPessoa = new Pessoa(nome, salario, idade);

                Console.WriteLine("Dados da segunda pessoa:");
                Console.Write("Nome:");
                nome = Console.ReadLine();
                Console.Write("Sálario:");
                salario = double.Parse(Console.ReadLine());
                Console.Write("Idade:");
                idade = int.Parse(Console.ReadLine());

                Pessoa segundaPessoa = new Pessoa(nome, salario, idade);

                if(primeiraPessoa.idade > segundaPessoa.idade)
                {
                    Console.WriteLine($"\nPessoa mais velha: {primeiraPessoa.nome}");
                }
                else if (primeiraPessoa.idade < segundaPessoa.idade)
                {
                    Console.WriteLine($"\nPessoa mais velha: {segundaPessoa.nome}");
                }
                else
                {
                    Console.WriteLine("\nPessoas com a mesma idade");
                }

                CalcularMediaSalario calculo = new CalcularMediaSalario(primeiraPessoa.salario, segundaPessoa.salario);

                Console.WriteLine($"Média de Sálario: {calculo.calcularSalario().ToString("F2")}");
                Console.WriteLine("Pressione qualquer tecla para finalizar");

                Console.ReadKey();
            }
            catch (Exception falha)
            {
                Console.WriteLine($">{falha.Message}");
                Console.ReadKey();
            }
        }
    }
}
