using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;

namespace testproj
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(1, 1);
        }



        [TestMethod]
        public void LongRunningTest1()
        {
            Thread.Sleep(30000);
            Assert.AreEqual(1, 1);
        }


        [TestMethod]
        public void LongRunningTest2()
        {
            Thread.Sleep(30000);
            Assert.AreEqual(1, 1);
        }


    }
}
