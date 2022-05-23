using business_layer.interfaces;
using business_layer.services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace unit_testing
{
    [TestClass]
    public class UnitTest1
    {
        private IGameIdeaService gameService = new GameIdeaService();
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(10, 10);
        }
    }
}
