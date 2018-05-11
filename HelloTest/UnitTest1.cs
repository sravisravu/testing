using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hello_World;

namespace HelloTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("Hello World", Program.createMesssage());
        }
    }
}
