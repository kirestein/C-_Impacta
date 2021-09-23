using System;

namespace CSharp.Capitulo02EstruturasDeControle.Testes
{
    [TestClass]
    public class RepeticaoTeste
    {
        [TestMethod]
        public void TestMethod1()
        {
            for(int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"{i} x {j} = {i * j}");
                }
            }
        }
    }
}
