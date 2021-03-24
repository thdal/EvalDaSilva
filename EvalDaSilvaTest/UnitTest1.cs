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

        [TestMethod]
        public void AliceDonneUnNombreMultipleDe3Et5()
        {
            int nb = 15;

            String FizzStr = FizzBuzzGame.BobRepond(nb);

            Assert.AreEqual("FizzBuzz", FizzStr);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "Doit être supérieur à 0")]
        public void ExceptioAliceDonneLeNombreZero()
        {
            int nb = 0;

            String FizzStr = FizzBuzzGame.BobRepond(nb);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "Ne doit pas être négatif")]
        public void ExceptionAliceDonneUnNombreNegatif()
        {
            int nb = -1;

            String FizzStr = FizzBuzzGame.BobRepond(nb);
        }

    }
}
