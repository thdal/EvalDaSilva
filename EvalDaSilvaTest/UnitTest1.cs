using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using EvalDaSilva;

namespace EvalDaSilvaTest
{
    [TestClass]
    public class FizzBuzzTest
    {
        [TestMethod]
        public void AliceDonneUnNombreMultipleDe3()
        {
            int nb = 24;

            String FizzStr = FizzBuzzGame.BobRepond(nb);

            Assert.AreEqual("Fizz", FizzStr);
        }

        [TestMethod]
        public void AliceDonneUnNombreMultipleDe5()
        {
            int nb = 25;

            String FizzStr = FizzBuzzGame.BobRepond(nb);

            Assert.AreEqual("Buzz", FizzStr);
        }

    }
}
