using Microsoft.VisualStudio.TestTools.UnitTesting;
using COMP123Examples;
namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //given/arrange

            int number1 = 5;
            int number2 = 12;

            //when/act

            int sum = Program.AddNumbers(number1, number2);

            //then/assert

            Assert.AreEqual(17, sum);

        }
        [TestMethod]
        public void AddNumbersTest2()
        {
            //given/arrange

            int number1 = 50;
            int number2 = 14;

            //when/act

            int sum = Program.AddNumbers(number1, number2);

            //then/assert

            Assert.AreEqual(64, sum);

        }
    }
}
