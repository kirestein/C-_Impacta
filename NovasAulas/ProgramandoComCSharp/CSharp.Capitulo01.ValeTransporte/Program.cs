using System;

namespace CSharp.Capitulo01.ValeTransporte
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao cadastro de novos funcionários.");

            Console.WriteLine("Digite o nome do funcionário: ");
            var nome = Console.ReadLine();

            Console.WriteLine("Digite o salário deste funcionário: ");
            var salario = Convert.ToDecimal(Console.ReadLine());

            var desconto = salario * 0.06m;

            Console.WriteLine($"Funcionário cadastrado com sucesso! /n  " +
                              $"Nome: {nome}. /n" +
                              $"Salário: {salario}. ");


            var comando = Console.ReadKey();
            if (comando.Key == ConsoleKey.Escape)
            {
                Environment.Exit(0);
            }
        }
    }
}
