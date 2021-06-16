using System;

namespace Desafio_1
{
    class Program
    {
        static void Main(string[] args)
        {

            
            double valorProduto = 0, valorPago = 0, troco = 0;
            string valorPagoSolicitado = " ", valorProdutoSolicitado = " ";

            do
            {

                Console.WriteLine("Digte o valor do produto: ");
                valorProdutoSolicitado = Console.ReadLine();
                
                Console.WriteLine("Digte o valor do pago: ");
                valorPagoSolicitado = Console.ReadLine();

                
                if (valorProdutoSolicitado != string.Empty && valorPagoSolicitado != string.Empty ||)
                {
                    
                    valorProduto = Convert.ToDouble(valorProdutoSolicitado);
                    valorPago = Convert.ToDouble(valorPagoSolicitado);

                    if (valorProduto < valorPago)
                    {
                        troco = valorPago - valorProduto;

                        Console.WriteLine("O valor do seu troco é: " + Math.Round(troco, 2));
                    }
                    else if (valorProduto == valorPago)
                        Console.WriteLine("Não há troco");

                    else if (valorProduto > valorPago)
                        Console.WriteLine("Você não tem poder aquisitivo para esta compra (POBRE)");
                }

            } while (valorProdutoSolicitado != string.Empty && valorPagoSolicitado != string.Empty);
            Console.WriteLine("Ops, something is wrong!");
        }
    }
}
