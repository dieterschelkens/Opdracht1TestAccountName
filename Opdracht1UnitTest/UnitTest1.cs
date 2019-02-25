using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Opdracht1TestAccountName;

namespace Opdracht1UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPersonGet2Names()
        {
            Person person = new Person();
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

        }
    }
}
