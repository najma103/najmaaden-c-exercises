using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class AnimalGroupTest
    {
        AnimalGroupName groupNameTest = new AnimalGroupName();
        [TestMethod]
        /*
         * GetHerd("giraffe") → "Tower"
         * GetHerd("") -> "unknown"         
         * GetHerd("walrus") -> "unknown"
         * GetHerd("Rhino") -> "Crash"
         * GetHerd("rhino") -> "Crash"
         * GetHerd("elephants") -> "unknown"
         * 
         */
        public void AnimalGroupNameTest()
        {
            Assert.AreEqual("unknown", groupNameTest.GetHerd(""));
            Assert.AreEqual("unknown", groupNameTest.GetHerd("walrus"));
            Assert.AreEqual("Crash", groupNameTest.GetHerd("Rhino"));
            Assert.AreEqual("Crash", groupNameTest.GetHerd("rhino"));
            Assert.AreEqual("Tower", groupNameTest.GetHerd("Giraffe"));
            Assert.AreEqual("unknown", groupNameTest.GetHerd("elephants"));

        }
    }
}
