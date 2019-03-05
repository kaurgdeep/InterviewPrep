using Microsoft.VisualStudio.TestTools.UnitTesting;
using MaxGap;

namespace MaxGapUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod_2ones()
        {
            Assert.AreEqual(Program.MaxGap(0b1001), 2); // 9
        }

        [TestMethod]
        public void TestMethod_3ones()
        {
            Assert.AreEqual(Program.MaxGap(529), 4);
        }

        [TestMethod]
        public void TestMethod_Allones()
        {
            Assert.AreEqual(Program.MaxGap(0xFFFF), 0);
        }

        [TestMethod]
        public void TestMethod_NoOnes()
        {
            Assert.AreEqual(Program.MaxGap(0), 0);
        }

        [TestMethod]
        public void TestMethod_Medium2()
        {
            Assert.AreEqual(3, Program.MaxGap(561892));
        }

        [TestMethod]
        public void TestMethod_large2()
        {
            Assert.AreEqual(Program.MaxGap(74901729), 4);
        }

        [TestMethod]
        public void TestMethod_large4()
        {
            Assert.AreEqual(Program.MaxGap(1376796946), 5);
        }
    }
}
