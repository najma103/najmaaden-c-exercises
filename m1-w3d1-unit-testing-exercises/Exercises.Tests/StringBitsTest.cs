using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class StringBitsTest
    {
        //GetBits("Hello") → "Hlo"	
        //GetBits("Hi") → "H"	
        //GetBits("Heeololeo") → "Hello"	

        StringBits BitsUnitTest = new StringBits();
        [TestMethod]
        public void StringBitsUnitTest()
        {
            Assert.AreEqual("Hlo", BitsUnitTest.GetBits("Hello"));
            Assert.AreEqual("H", BitsUnitTest.GetBits("Hi"));
            Assert.AreEqual("Hello", BitsUnitTest.GetBits("Heeololeo"));
        }
    }
}
