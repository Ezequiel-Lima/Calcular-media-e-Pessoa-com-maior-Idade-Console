using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    public class Pessoa
    {
        public string nome { get; set; }
        public double salario { get; set; }
        public int idade { get; set; }

        public Pessoa(string nome, double salario, int idade)
        {
            this.nome = nome;
            this.salario = salario;
            this.idade = idade;
        }
    }
}
