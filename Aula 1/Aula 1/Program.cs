using System;

namespace Aula_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var nome = "Erik";
            var idade = 36;


            if (idade >= 18)
                Console.WriteLine("Olá " + nome + ", você é maior de idade, pode entrar!");
            else
                Console.WriteLine("Olá " + nome + ", você não é maior de idade, portanto não pode entrar!");
        }
    }
}
