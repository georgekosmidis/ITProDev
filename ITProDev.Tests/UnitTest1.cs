using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace itprodev.tests
{
    [TestClass]
    public class HelloWorldTests
    {
        [TestMethod]
        public void SayHelloTest()
        {
            var result = HelloWorld.SayHello();
            Assert.AreEqual("Hello Worlds!", result);
        }
    }
}
