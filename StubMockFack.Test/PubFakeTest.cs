using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Moq;

namespace StubMockFack.Test
{
    [TestClass]
    public class PubFakeTest
    {
        [TestMethod]
        public void Test_Friday_Charge_Customer_Count()
        {
           
            //arrange
            Mock<ICheckInFee> stubCheckInFee = new Mock<ICheckInFee>();
            Mock<IDateTimeProvider> stubDateTime = new Mock<IDateTimeProvider>();
            PubFake target = new PubFake(stubCheckInFee.Object, stubDateTime.Object);

            
        //    stubCheckInFee.Setup(x => x.GetFee(It.IsAny<Customer>())).Returns(200);

            stubDateTime.Setup(t => t.Now).Returns(new DateTime(2016, 3, 4));

            var customers = new List<Customer>
            {
                new Customer{ IsFemale=true},
                new Customer{ IsFemale=false},
                new Customer{ IsFemale=false},
            };

            decimal expected = 2;

            //act
            var actual = target.CheckIn(customers);

            //assert
            Assert.AreEqual(expected, actual);
        }

    }
}
