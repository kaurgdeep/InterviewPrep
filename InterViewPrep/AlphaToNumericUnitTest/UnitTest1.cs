using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlphaToNumericUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(Program.MaxGap(0b1001), 2); // 9
        }
    
    }
}
