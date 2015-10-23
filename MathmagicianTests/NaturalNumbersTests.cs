using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

// Need to add using namespace of the other project
using Mathmagician;

namespace MathmagicianTests
{
    [TestClass]
    public class NaturalNumbersTests
    {
        [TestMethod]
        public void EnsureICanCreateClassInstance()
        {
            // Bootstrapping test because you have yet to create a class
            // Make sure the build workflow is consistent and works well
            NaturalNumbers nats = new NaturalNumbers();
            // When you write tests you can ignore red squiggly lines because the class doesn't exist yet
            
            // Every test has the form of setup then assert
            Assert.IsNotNull(nats);
        }

        [TestMethod]
        public void ShouldPrintFirstNumber()
        {
            NaturalNumbers nats = new NaturalNumbers();
            int expected = 1;
            int actual = nats.GetFirst();
            Assert.AreEqual(expected, actual);
        }

        /*
        Educational Purposes example exception test

        [TestMethod]
        [ExpectedException(typeof(AccessViolationException))]
        // Exceptions themselves are just classes
        public void NoOneCanAccessPrivateDataMember()
        {
            NaturalNumbers nats = new NaturalNumbers();
            nats.first;
        }
        */

        [TestMethod]
        public void ShouldPrintNextNumber()
        {
            NaturalNumbers nats = new NaturalNumbers();
            int input = 1;
            int expected = 2;
            int actual = nats.GetNext(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShouldPrintNextNumberInput3()
        {
            NaturalNumbers nats = new NaturalNumbers();
            int input = 3;
            int expected = 4;
            int actual = nats.GetNext(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShouldPrintSequenceOfNumbers()
        {
            NaturalNumbers nats = new NaturalNumbers();
            int[] expected = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] actual = nats.GetSequence();
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShouldPrintAVariableSequenceOfNumbers()
        {
            NaturalNumbers nats = new NaturalNumbers();
            int input = 8;
            int[] expected = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            int[] actual = nats.GetSequence(input);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShouldProvideSameSequences()
        {
            NaturalNumbers nats = new NaturalNumbers();
            int input = 10;
            int[] sequencewithlength = nats.GetSequence(input);
            int[] sequencenolength = nats.GetSequence();
            CollectionAssert.AreEqual(sequencenolength, sequencewithlength);
        }

        [TestMethod]
        public void PrintSequenceOfNumbers()
        {
            NaturalNumbers nats = new NaturalNumbers();
            int length = 7;
            string expected = "1 2 3 4 5 6 7";
            string actual = nats.ToString(nats.GetSequence(length));
            Assert.AreEqual(expected, actual);
        }
    }
}
