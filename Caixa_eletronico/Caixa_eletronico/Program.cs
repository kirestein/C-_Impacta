using System;

namespace Caixa_eletronico
{
    class Program
    {
        static void Main(string[] args)
        {
            int moeda01 = 0;
            int moeda05 = 0;
            int moeda10 = 0;
            int moeda25 = 0;
            int moeda50 = 0;
            int moeda1 = 0;
            int cedula2 = 0;
            int cedula5 = 0;
            int cedula10 = 0;
            int cedula20 = 0;
            int cedula50 = 0;
            int cedula100 = 0;
            double valor = 0;

            do
            {

                Console.WriteLine("Digite o valor a ser sacado:");
                valor = Convert.ToDouble(Console.ReadLine());


                while(valor != 0)
                {
                    if (valor >= 100)
                    {
                        valor -= 100;
                        cedula100++;
                    }
                    else if (valor >= 50 && valor < 100)
                    {
                        valor -= 50;
                        cedula50++;
                    }
                    else if (valor >= 20 && valor < 50)
                    {
                        valor -= 20;
                        cedula20++;
                    }
                    else if (valor >= 10 && valor < 20)
                    {
                        valor -= 10;
                        cedula10++;
                    }
                    else if (valor >= 5 && valor < 10)
                    {
                        valor -= 5;
                        cedula5++;
                    }
                    else if (valor >= 2 && valor < 5)
                    {
                        valor -= 2;
                        cedula2++;
                    }
                    else if (valor >= 1 && valor < 2)
                    {
                        valor -= 1;
                        moeda1++;
                    }
                    else if (valor >= 0.50 && valor < 1)
                    {
                        valor -= 0.50;
                        moeda50++;
                    }
                    else if (valor >= 0.25 && valor < 0.50)
                    {
                        valor -= 0.25;
                        moeda25++;
                    }
                    else if (valor >= 0.10 && valor < 0.10)
                    {
                        valor -= 0.1;
                        moeda10++;
                    }
                    else if (valor >= 0.05 && valor < 0.10)
                    {
                        valor -= 0.05;
                        moeda05++;
                    }
                    else if (valor >= 0.01 && valor < 0.05)
                    {
                        valor -= 0.01;
                        moeda01++;
                    }
                }
                
                

                if (moeda01 != 0)
                    {
                        Console.WriteLine($"Moeda de 0,01: {moeda01}");
                    }
                if (moeda05 != 0)
                    {
                        Console.WriteLine($"Moeda de 0,05: {moeda05}");
                    }
                 if (moeda10 != 0)
                    {
                        Console.WriteLine($"Moeda de 0,10: {moeda10}");
                    }
                 if (moeda25 != 0)
                    {
                        Console.WriteLine($"Moeda de 0,25: {moeda25}");
                    }
                 if (moeda50 != 0)
                    {
                        Console.WriteLine($"Moeda de 0,50: {moeda50}");
                    }
                 if (moeda1 != 0)
                    {
                        Console.WriteLine($"Moeda de 1,00: {moeda1}");
                    }
                 if (cedula2 != 0)
                    {
                        Console.WriteLine($"Cedula de 2,00: {cedula2}");
                    }
                 if (cedula5 != 0)
                    {
                        Console.WriteLine($"Cedula de 5,00: {cedula5}");
                    }
                 if (cedula10 != 0)
                    {
                        Console.WriteLine($"Cedula de 10,00: {cedula10}");
                    }
                 if (cedula20 != 0)
                    {
                        Console.WriteLine($"Cedula de 20,00: {cedula20}");
                    }
                 if (cedula50 != 0)
                    {
                        Console.WriteLine($"Cedula de 50,00: {cedula50}");
                    }
                 if (cedula100 != 0)
                    {
                        Console.WriteLine($"Cedula de 100,00: {cedula100}");
                    }
            } while (valor > -1);

        }
    }
}
