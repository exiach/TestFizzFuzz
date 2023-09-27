using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;


namespace TestTwistedFizzBuzz
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodRange()
        {
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            //act
            //TwistedFizzBuzz.

            //assert
            var output = stringWriter.ToString();
            Assert.AreEqual("Fizz", output);
        }
    }
}
