//using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        public void EstruturaForTeste()
        {
            var i = 0;

            for (Console.WriteLine(); i < 4; i++)
            {

            }
        }
    }

    internal class TestClassAttribute : Attribute
    {
    }

    internal class TestMethodAttribute : Attribute
    {
    }
}
