using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class CigarPartyTest
    {
        //instantiate the cigarparty class
        CigarParty partyTestUnit = new CigarParty();
        /*
         * haveParty(30, false) → false
         * haveParty(50, false) → true
         * haveParty(70, true) → true
         */
        [TestMethod]
        public void PartyTest()
        {
            Assert.AreEqual(false, partyTestUnit.HaveParty(30, false));
            Assert.AreEqual(true, partyTestUnit.HaveParty(50, false));
            Assert.AreEqual(true, partyTestUnit.HaveParty(70, true));
        }
    }
}
