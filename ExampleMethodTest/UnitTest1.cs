using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestExample_1;

namespace ExampleMethodTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            bool respMethod = Class1.Calcolo1();
            Assert.AreEqual(false, respMethod);
        }
    }
}
