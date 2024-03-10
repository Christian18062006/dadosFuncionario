using System;

namespace DadosFuncionários
{
    class Program
    {
        public static double calculaSalario(double salarioBruto, double imposto)
        {
            double salarioLiquido = salarioBruto - (salarioBruto * imposto / 100);
            return (salarioLiquido);
        }
        public static double almentaSalario(double salarioBruto, double quantidadeAlmento)
        {
            double almento = (quantidadeAlmento * salarioBruto) / 100;
            return (almento);
        }
        static void Main(string[] args)
        {
            double quantidadeAlmento;
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
            double salarioLiquido = calculaSalario(salarioBruto, imposto);
            Console.Write($"Nome do funcionário: {nome}");
            Console.WriteLine($"Salário líquido: {salarioLiquido.ToString("C2")}");
            Console.WriteLine("agora, digite a porcentagem que deseja almentar no salário.");
            quantidadeAlmento = double.Parse(Console.ReadLine());
            double almento = almentaSalario(salarioBruto, quantidadeAlmento);
            salarioBruto += almento;

            double novoSalario = calculaSalario(salarioBruto, imposto);
            Console.WriteLine($"o novo salário é: {novoSalario.ToString("C2")}");
            //usando a classe//
            DadosFuncionario funcionario = new DadosFuncionario();
            funcionario.nome = nome;
            funcionario.salarioBruto = salarioBruto;
            funcionario.imposto = imposto;
            double salario1 = funcionario.salarioLiquido();
            Console.Write(funcionario.nome);
            Console.WriteLine($"O salário líquido do funcionário é: {salario1.ToString("C2")}");
            funcionario.almentaSalario();
        }
    }
}
