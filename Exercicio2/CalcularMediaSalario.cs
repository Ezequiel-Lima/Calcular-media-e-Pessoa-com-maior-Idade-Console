using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    public class CalcularMediaSalario
    {
        public double salarioX { get; set; }   
        public double salarioY { get; set; }

        public CalcularMediaSalario(double salarioX, double salarioY)
        {
            this.salarioX = salarioX;
            this.salarioY = salarioY;
        }

        public double calcularSalario()
        {
            double resultado = (salarioX + salarioY) / 2;
            return resultado;
        }
    }
}
