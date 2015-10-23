using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mathmagician;

namespace MathmagicianTests
{
    [TestClass]
    public class FibonacciTests
    {
        [TestMethod]
        public void FibonacciEnsureICanCreateClassInstance()
        {
            FibonacciNumbers fib = new FibonacciNumbers();
            Assert.IsNotNull(fib);
        }

        [TestMethod]
        public void FibonacciShouldPrintFirstNumber()
        {
            FibonacciNumbers fib = new FibonacciNumbers();
            int expected = 1;
            int actual = fib.GetFirst();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FibonacciShouldPrintNextNumber()
        {
            FibonacciNumbers fib = new FibonacciNumbers();
            int inputA = 2;
            int inputB = 3;
            int expected = 5;
            int actual = fib.GetNext(inputA, inputB);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FibonacciShouldPrintOneOneWhenInputIsTwo()
        {
            FibonacciNumbers fib = new FibonacciNumbers();
            int input = 2;
            int[] expected = new int[] { 1, 1, };
            int[] actual = fib.GetSequence(input);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FibonacciShouldPrintAVariableSequenceOfNumbers()
        {
            FibonacciNumbers fib = new FibonacciNumbers();
            int input = 8;
            int[] expected = new int[] { 1,1,2,3,5,8,13,21 };
            int[] actual = fib.GetSequence(input);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FibonacciPrintSequenceOfNumbers()
        {
            FibonacciNumbers fib = new FibonacciNumbers();
            int length = 7;
            string expected = "1 1 2 3 5 8 13";
            string actual = fib.ToString(fib.GetSequence(length));
            Assert.AreEqual(expected, actual);
        }
    }
}
