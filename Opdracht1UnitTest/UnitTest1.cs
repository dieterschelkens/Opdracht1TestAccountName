using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Opdracht1TestAccountName;

namespace Opdracht1UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        Person person = new Person();

        [TestMethod]
        public void TestPersonGet2Names()
        {
            string input = "Wim Beck";
            string[] names = input.Split(' ');
            person.firstName = names[0];
            person.lastName = names[1];
            Assert.AreEqual("Wim", person.firstName);
            Assert.AreEqual("Beck", person.lastName);
        }

        [TestMethod]
        public void TestPersonGenerateAccountIs6CharsLong()
        {
            string actualOutput = person.generateAccount();
            Assert.Equals(actualOutput.Length, 6);
        }

        [TestMethod]
        public void TestPersonGenerateAccountIsCorrectOutput()
        {
            string actualOutput = person.generateAccount();
            string expectedOutput = "beckwb";
            Assert.Equals(expectedOutput, actualOutput);
        }
    }
}
