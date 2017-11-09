using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OOAD_ExtraAssignment.Test
{
    [TestClass]
    public class UnitTest1
    {
        private IPartyService _partyService;

        [TestInitialize]
        public void Initialize()
        {
            _partyService = new FakePartyRepository();
        }
        [TestMethod]
        public void Get_PartyWithSnn9206242993_ShouldReturnEmilEkman()
        {
            const string ssn = "9206242993";
            Assert.AreEqual(_partyService.Get(ssn).Name, "Emil Ekman");
        }

        [TestMethod]
        public void Get_SnnNotFound_ShouldReturnInvalidOperationException()
        {
            Assert.ThrowsException<InvalidOperationException>(() => _partyService.Get("123432534654"));
        }
    }
}
