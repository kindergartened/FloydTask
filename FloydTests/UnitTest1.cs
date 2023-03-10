namespace FloydTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DeleteSpacesTest()
        {
            string expected = "asdasdasd asdasd asd asd";
            string actual = "          asdasdasd    asdasd asd asd    ";
            Assert.AreEqual(expected, DeleteSpaces(actual));
        }
        [TestMethod]
        public void IsSpacyStrTest() 
        {
            bool expected = true;
            bool actual = !IsSpacyStr("                ");
            Assert.AreEqual(expected, actual);

            expected = false;
            actual = !IsSpacyStr("  asdasd  asd ");
            Assert.AreEqual(expected, actual);
        }
    }
}