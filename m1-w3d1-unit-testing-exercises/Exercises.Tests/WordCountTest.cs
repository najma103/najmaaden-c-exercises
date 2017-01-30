using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Collections;

namespace Exercises.Tests
{
    [TestClass]
    public class WordCountTest
    {
        WordCount wcTest = new WordCount();
        [TestMethod]
         //GetCount(["ba", "ba", "black", "sheep"]) → {"ba" : 2, "black": 1, "sheep": 1 }
         //GetCount(["a", "b", "a", "c", "b"]) → {"b": 2, "c": 1, "a": 2}
         //GetCount([]) → {}
         //GetCount(["c", "b", "a"]) → {"b": 1, "c": 1, "a": 1}
        public void WCountTest()
        {

            Dictionary<string, int> expected = new Dictionary<string, int>()
            {
                {"ba", 2 },
                {"black", 1},
                {"sheep", 1}
            };
            Dictionary<string, int> actual = wcTest.GetCount(new string[] { "ba", "ba", "black", "sheep" });
            CollectionAssert.AreEqual(expected, actual);

            expected = new Dictionary<string, int>()
            {
                {"b", 2 },
                {"c", 1 },
                {"a", 2 }
            };
            actual = wcTest.GetCount(new string[] { "a", "b", "a", "c", "b" });
            CollectionAssert.AreEquivalent(expected, actual);
            expected = new Dictionary<string, int>()
            {
            };
            actual = wcTest.GetCount(new string[] { });
            CollectionAssert.AreEqual(expected, actual);

            expected = new Dictionary<string, int>()
            {
                {"b", 1 },
                {"c", 1 },
                {"a", 1 }
            };
            actual = wcTest.GetCount(new string[] { "c", "b", "a" });
            CollectionAssert.AreEquivalent(expected, actual);

        }
    }
}
