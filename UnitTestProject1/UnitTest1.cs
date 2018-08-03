using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloJenkins;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("Hello World", Program.creatMessage());
        }
    }
}
