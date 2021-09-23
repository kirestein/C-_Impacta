using System;

namespace CSahrp.Capitulo02.GeradorSenha
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Informe  a quantidade de dígitos da senha (entre 4 e 10):!");

            //var qtdeDigitos = 0;

            //while (qtdeDigitos == 0)
            //{
            //    qtdeDigitos = ObterQtdeDigitos();
            //}

            int qtdeDigitos = 0;

            do
            {
                Console.WriteLine("Informe a quantidade de  digitos de senha (entre 4 e 10): ");
                qtdeDigitos = ObterQtdeDigitos();
            } while (qtdeDigitos == 0);

            var senha = "";
            var randomico = new Random();

            for (int i = 0; i < qtdeDigitos; i++)
            {
                var digito = randomico.Next(0, 10);

                senha += digito;
            }

            Console.WriteLine($"Senha gerada: {senha}.");
        }

        private static int ObterQtdeDigitos()
        {
            int.TryParse(Console.ReadLine(), out int qtdeDigitos);

            if (qtdeDigitos % 2 != 0 || qtdeDigitos is < 4 or > 10)
            {
                Console.WriteLine($"A quantidade de digitos {qtdeDigitos} é inválida.");
                qtdeDigitos = 0;
            }

            return qtdeDigitos;
        }
    }
}
