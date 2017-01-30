using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class Lucky13Test
    {
        //instanciate lucky 13
        Lucky13 unitTest = new Lucky13();
        [TestMethod]
        public void TesGetLucky13()
        {
            //GetLucky([0, 2, 4]) → true
            //GetLucky([1, 2, 3]) → false
            //GetLucky([1, 2, 4]) → false
            Assert.AreEqual(true, unitTest.GetLucky(new int[] { 0, 2, 4 }));
            Assert.AreEqual(false, unitTest.GetLucky(new int[] { 1, 2, 3 }));
            Assert.AreEqual(false, unitTest.GetLucky(new int[] { 1, 2, 4 }));

        }
    }
}
