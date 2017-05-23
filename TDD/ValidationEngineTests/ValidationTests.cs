using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationEngine
{
    [TestFixture]
    public class ValidationTests
    {
        private static string[] errorEmails()
        {
            return new string[] {
            "",
            "Test.com",
            "name@test",
            "name.text@com",
            "Name2015@test.com",
            "name@test2015.com"

            };
        }

        [Test]
        public void TrueForValidAddress()
        {
            //arrange part  
            var sut = new Validator();

            //act part
            var result = sut.ValidateEmailAdress("mike@edmunt.com");
            var result2 = sut.ValidateEmailAdress("joe@apple.com");

            //assert part
            Assert.IsTrue(result);
            Assert.IsTrue(result2);
        }
    }
}

