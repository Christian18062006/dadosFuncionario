using System;

namespace DadosFuncionários
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = string.Empty;
            double salarioBruto;
            double imposto;
            Console.WriteLine("Cadastro de funcionário.");
            Console.WriteLine("por favor, digite o nome do funcionário.");
            nome = Console.ReadLine();
            Console.WriteLine("digite o salário bruto.");
            salarioBruto = double.Parse(Console.ReadLine());
            Console.WriteLine("digite o imposto.");
            imposto = double.Parse(Console.ReadLine());
        }
    }
}
