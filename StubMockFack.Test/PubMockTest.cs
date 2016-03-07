using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Rhino.Mocks;

namespace StubMockFack.Test
{
    [TestClass]
    public class PubMockTest
    {
        [TestMethod]
        public void Test_CheckIn_Charge_Only_Male()
        {
            //arrange mock
            var customers = new List<Customer>();

            var customer1 = new Customer { IsFemale = true};
            var customer2 = new Customer { IsFemale = false };
            var customer3 = new Customer { IsFemale = false };

            customers.Add(customer1);
            customers.Add(customer2);
            customers.Add(customer3);

            MockRepository mock = new MockRepository();
            ICheckInFee stubCheckInFee = mock.StrictMock<ICheckInFee>();

            using (mock.Record())
            {
                //expected called times of ICheckInFee will be twice.
                stubCheckInFee.GetFee(customer1);

                LastCall.IgnoreArguments().Return((decimal)100).Repeat.Times(2);
            }

            using (mock.Playback())
            {
                var target = new Pub(stubCheckInFee);
                var count = target.CheckIn(customers);
            }
        }
    }
}
