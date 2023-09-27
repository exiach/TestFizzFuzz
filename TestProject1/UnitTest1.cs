using TwistedFizzBuzz;

namespace TestTwistedFizzBuzz
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMultipleThree()
        {
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            //act
            TwistedFizzBuzz.TwistedFizzBuzz.PrintFizzBuzz(3);

            //assert
            var output = stringWriter.ToString().Trim();
            Assert.AreEqual("Fizz", output);
        }

        [TestMethod]
        public void TestMultipleFive()
        {
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            //act
            TwistedFizzBuzz.TwistedFizzBuzz.PrintFizzBuzz(5);

            //assert
            var output = stringWriter.ToString().Trim();
            Assert.AreEqual("Buzz", output);
        }

        [TestMethod]
        public void TestMultipleThreeFive()
        {
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            //act
            TwistedFizzBuzz.TwistedFizzBuzz.PrintFizzBuzz(30);

            //assert
            var output = stringWriter.ToString().Trim();
            Assert.AreEqual("FizzBuzz", output);
        }

        [TestMethod]
        public void TestNoMultipleThreeFive()
        {
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            //act
            TwistedFizzBuzz.TwistedFizzBuzz.PrintFizzBuzz(11);

            //assert
            var output = stringWriter.ToString().Trim();
            Assert.AreEqual("11", output);
        }
    }
}