using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class NonStartTest
    {
        /*
         * GetPartialString("Hello", "There") → "ellohere"
         * GetPartialString("java", "code") → "avaode"	
         * GetPartialString("shotl", "java") → "hotlava"	
         */
        NonStart noneStarUnitTest = new NonStart();
        [TestMethod]
        public void NoneStartTestMethod()
        {
            Assert.AreEqual("ellohere", noneStarUnitTest.GetPartialString("Hello", "There"));
            Assert.AreEqual("avaode", noneStarUnitTest.GetPartialString("java", "code"));
            Assert.AreEqual("hotlava", noneStarUnitTest.GetPartialString("shotl", "java"));
        }
    }
}
