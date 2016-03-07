using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Practices.Unity;
using Moq;

namespace PracticeUnitTest.Test
{
    [TestClass]
    public class ValidationConstructorTest
    {
        [TestMethod]
        public void CheckAuthenticationTest()
        {

            string id = "01";
            string password = "zaq1234";

            //Create and mock of interface

            Mock<IAccountDoc> doc = new Mock<IAccountDoc>();
            doc.Setup(r => r.GetPassword(id)).Returns("Irene");

            Mock<IHash> hash = new Mock<IHash>();
            hash.Setup(r => r.GetHashResult(password)).Returns("Irene");

            ValidationConstructor target = new ValidationConstructor(doc.Object, hash.Object);

            bool real = target.CheckAuthentication(id,password);

            bool expected = true;

            Assert.AreEqual(expected, real);
           
        }
    }
}
