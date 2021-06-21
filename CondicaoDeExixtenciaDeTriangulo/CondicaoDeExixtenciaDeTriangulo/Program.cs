using System;

namespace CondicaoDeExixtenciaDeTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0, c = 0;
            



            do
            {


                Console.WriteLine("Digite o valor de a: ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite o valor de b: ");
                b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite o valor de c: ");
                c = Convert.ToInt32(Console.ReadLine());
                if (a > 0 || b > 0 || c > 0)
                {
                    int q = a * a;
                    int w = b * b;
                    int e = c * c;
                    int x = a + b;
                    int y = a + c;
                    int z = b + c;
                    int p = w + e;
                    int o = q + e;
                    int i = q + w;

                    if (a > b && a > c)
                    {
                        if (a < z)
                        {
                            if (q == p)
                            {
                                Console.WriteLine("Os pontos:" + a + ", " + b + " e " + c + " formam um triângulo retângulo em A, pois o maior lado é a = " + a + ".");
                            }
                            else if (q < p)
                            {
                                Console.WriteLine("O maior lado está em a, triângulo existe e é do tipo acutângulo.");
                            }
                            else if (q > p)
                            {
                                Console.WriteLine("O maior lado está em a, triângulo existe e é do tipo obtusângulo.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Os pontos:" + a + ", " + b + " e " + c + " não formam um triângulo.");
                        }
                    }
                    else if (b > a && b > c)
                    {
                        if (b < y)
                        {
                            if (w == o)
                            {
                                Console.WriteLine("Os pontos:" + a + ", " + b + " e " + c + " formam um triângulo retângulo em B, pois o maior lado é b = " + b + ".");
                            }
                            else if (w < o)
                            {
                                Console.WriteLine("O maior lado está em b, triângulo existe e é do tipo acutângulo.");
                            }
                            else if (w > o)
                            {
                                Console.WriteLine("O maior lado está em b, triângulo existe e é do tipo obtusângulo.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Os pontos:" + a + ", " + b + " e " + c + " não formam um triângulo.");
                        }
                    }
                    else if (c > a && c > b)
                    {
                        if (c < x)
                        {
                            if (e == i)
                            {
                                Console.WriteLine("Os pontos:" + a + ", " + b + " e " + c + " formam um triângulo retângulo em C, pois o maior lado é c = " + c + ".");
                            }
                            else if (e < i)
                            {
                                Console.WriteLine("O maior lado está em c, triângulo existe e é do tipo acutângulo.");
                            }
                            else if (e > i)
                            {
                                Console.WriteLine("O maior lado está em c, triângulo existe e é do tipo obtusângulo.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Os pontos:" + a + ", " + b + " e " + c + " não formam um triângulo.");
                        }
                    }

                    else if (a == b || a == c || b == c)
                    {
                        Console.WriteLine("Este é um triângulo acutângulo.");
                    }
                }
                

                else
                {
                    Console.WriteLine("Você digitou valores inválidos para lado de um triângulo");
                    break;
                }


            } while (a != 0 || b != 0 || c != 0);
        }
    }
}
