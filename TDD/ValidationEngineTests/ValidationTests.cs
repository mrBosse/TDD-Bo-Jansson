using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValidationEngine;

namespace ValidationEngineTests

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
        public void TrueForValidEmailAddress()
        {
            //arrange part  
            var sut = new Validator();

            //act part
            var result = sut.ValidateEmailAdress("mike@edmunt.com");
            //var result2 = sut.ValidateEmailAdress("joe@apple.com");

            //assert part
            Assert.IsTrue(result);
            //Assert.IsTrue(result2);a
        }
        [Test]
        public void FalseForEmailAddressMissingAtSign()
        {
            //arrange part  
            var sut = new Validator();

            //act part
            var result = sut.ValidateEmailAdress("mikeedmunt.com");
            //var result2 = sut.ValidateEmailAdress("joe@apple.com");

            //assert part
            Assert.IsFalse(result);
            //Assert.IsTrue(result2);
        }
        [Test]
        public void FalseForEmailAddressBeingNull()
        {
            //arrange part  
            var sut = new Validator();

            //act part
            var result = sut.ValidateEmailAdress(null);


            //assert part
            Assert.IsFalse(result);

        }
        [Test]
        public void FalseForEmailAddressMissingDotCom()
        {
            //arrange part  
            var sut = new Validator();

            //act part
            var result = sut.ValidateEmailAdress("Test.com");


            //assert part
            Assert.IsFalse(result);

        }
        [Test]
        public void FalseForEmailAddressMissingOrBeingEmpty()
        {
            //arrange part  
            var sut = new Validator();

            //act part
            var result = sut.ValidateEmailAdress("");


            //assert part
            Assert.IsFalse(result);

        }
        [Test]
        public void FalseForEmailAddressContainingNumbers()
        {
            //arrange part  
            var sut = new Validator();

            //act part
            var result = sut.ValidateEmailAdress("Name2015@test.com");


            //assert part
            Assert.IsTrue(result);

        }
        [Test]
        public void FalseForEmailAddressMissingDotInDotCom()
        {
            //arrange part  
            var sut = new Validator();

            //act part
            var result = sut.ValidateEmailAdress("name.text@com");


            //assert part
            Assert.IsFalse(result);
        }
    }
}

