using System;
using System.Collections.Generic;
using System.Text;

namespace DadosFuncionários
{
    class DadosFuncionario
    {
        public string nome = string.Empty;
        public double salarioBruto;
        public double imposto;
        public double salarioLiquido()
        {
            double salarioLiquido = salarioBruto - (salarioBruto * imposto / 100);
            return (salarioLiquido);
        }
        public void almentaSalario()
        {
            double quantidadeAlmento;
            Console.WriteLine("digite a quantidade que deseja alterar no salário.");
            quantidadeAlmento = double.Parse(Console.ReadLine());
            double almento = (quantidadeAlmento * salarioBruto) / 100;
            salarioBruto += almento;
            double novoSalario = salarioBruto - (salarioBruto * imposto / 100);
            Console.WriteLine($"O novo salário é: {novoSalario.ToString("C2")}");
                   }
    }

    }
