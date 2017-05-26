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
        public void TrueForValidAddress()
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
        public void FalseForMissingAtSign()
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
        public void FalseForMissingNullOrMissingAdress()
        {
            //arrange part  
            var sut = new Validator();

            //act part
            var result = sut.ValidateEmailAdress(null);


            //assert part
            Assert.IsFalse(result);

        }
        [Test]
        public void FalseForMissingDotCom()
        {
            //arrange part  
            var sut = new Validator();

            //act part
            var result = sut.ValidateEmailAdress("Test.com");


            //assert part
            Assert.IsFalse(result);

        }
        [Test]
        public void FalseForBeingEmpty()
        {
            //arrange part  
            var sut = new Validator();

            //act part
            var result = sut.ValidateEmailAdress("");


            //assert part
            Assert.IsFalse(result);

        }
        [Test]
        public void FalseForContainingNumbers()
        {
            //arrange part  
            var sut = new Validator();

            //act part
            var result = sut.ValidateEmailAdress("Name2015@test.com");


            //assert part
            Assert.IsTrue(result);

        }
        [Test]
        public void FalseForMissingDotInDotCom()
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

