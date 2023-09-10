using _7._3Uzduotis_IF_UnitTetsing;

namespace Test7._3_IF
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestFinalDiscount()
        {

            float result = 10.97f;
            int discount = 25;
            float expected = 8.2275f;

            float actual = Program.ApplyDiscount(result, discount);
            Assert.AreEqual(expected, actual);
        }
    }
}