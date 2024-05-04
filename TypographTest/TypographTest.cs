using Microsoft.VisualStudio.TestTools.UnitTesting;
using TypographApp;

namespace TypographTest
{
    [TestClass]
    public class TypographTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var typograph = new Typograph();
            var input = "This   is   a   test.";
            var expected = "This is a test.";
            Assert.AreEqual(expected, typograph.Rule_ReplaceSpaces(input));
        }
        [TestMethod]
        public void TestMethod2() 
        {
            var typograph = new Typograph();
            var input = "7+−12";
            var expected = "7±12";
            Assert.AreEqual(expected, typograph.Rule_MinusPlus(input));
        }
        [TestMethod]
        public void TestMethod3() 
        { 
            var typograph = new Typograph();
            var input = "9-1=8";
            var expected = "9 − 1 = 8";
            Assert.AreEqual(expected, typograph.Rule_OperationSigns(input));
        }
        [TestMethod]
        public void TestMethod4()
        {
            var typograph = new Typograph();
            var input = "12+1=13";
            var expected = "12 + 1 = 13";
            Assert.AreEqual(expected, typograph.Rule_OperationSigns(input));
        }
        [TestMethod]
        public void TestMethod5()
        {
            var typograph = new Typograph();
            var input = "2*3=6";
            var expected = "2 * 3 = 6";
            Assert.AreEqual(expected, typograph.Rule_OperationSigns(input));
        }
        [TestMethod]
        public void TestMethod6()
        {
            var typograph = new Typograph();
            var input = "10/2=5";
            var expected = "10 / 2 = 5";
            Assert.AreEqual(expected, typograph.Rule_OperationSigns(input));
        }
        [TestMethod]
        public void TestMethod7()
        {
            var typograph = new Typograph();
            var input = "a...";
            var expected = "a…";
            Assert.AreEqual(expected, typograph.Rule_ReplaceEllipsis(input));
        }
        [TestMethod]
        public void TestMethod8()
        {
            var typograph = new Typograph();
            var input = "a-b";
            var expected = "a—b";
            Assert.AreEqual(expected, typograph.Rule_Tyre(input));
        }
        [TestMethod]
        public void TestMethod9()
        {
            var typograph = new Typograph();
            var input = "I love 52";
            var expected = "I love Да здравствует Санкт-Петербург, и это город наш!!!";
            Assert.AreEqual(expected, typograph.Rule_FiftyTwo(input));
        }
        [TestMethod]
        public void TestMethod10()
        {
            var typograph = new Typograph();
            var input = "This is a test.";
            var expected = "This is a test(точка)";
            Assert.AreEqual(expected, typograph.Rule_Point(input));
        }
    }
}
