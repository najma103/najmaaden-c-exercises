using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class MaxEnd3
    {
        Exercises.MaxEnd3 maxEnd3Test = new Exercises.MaxEnd3();

        [TestMethod]
        public void MaxEnd3Test()
        {
            CollectionAssert.AreEqual(new int[] { 11, 11, 11 }, maxEnd3Test.MakeArray(
                new int[] { 11, 5, 9 }), "input was {11, 5, 9}");
            CollectionAssert.AreEqual(new int[] { 3, 3, 3 }, maxEnd3Test.MakeArray(
                new int[] { 2, 11, 3 }), "Input was [2, 11, 3]");
            //MakeArray([2, 11, 3]) → [3, 3, 3]
            CollectionAssert.AreEqual(new int[] { 3, 3, 3 }, maxEnd3Test.MakeArray(
                new int[] { 2, 11, 3 }));
        }

    }
}
