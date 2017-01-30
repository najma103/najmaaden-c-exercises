using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercises;

namespace Exercises.Tests
{
    [TestClass]
    public class SameFirstLastTest
    {
        SameFirstLast firstLast = new SameFirstLast();
        [TestMethod]
        public void TestFirstLast()
        {
            //IsItTheSame([1, 2, 3]) → false
            //IsItTheSame([1, 2, 3, 1]) → true
            //IsItTheSame([1, 2, 1]) → true
            Assert.AreEqual(false, firstLast.IsItTheSame(new int[] { 1, 2, 3 }));
            Assert.AreEqual(true, firstLast.IsItTheSame(new int[] { 1, 2, 3, 1 }));
            Assert.AreEqual(true, firstLast.IsItTheSame(new int[] { 1, 2, 1 }));
        }
    }
}
