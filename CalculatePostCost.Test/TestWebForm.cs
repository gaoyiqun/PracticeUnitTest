using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatePostCost.Test
{
    [TestClass]
    public class TestWebForm
    {
        [TestMethod]
        public void GetsCompanyNameTest_BlackCat()
        {
            BlackCat target = new BlackCat();
            string expected = "BlackCat";
            Assert.AreEqual(expected, target.GetsCompanyName());
        }

        [TestMethod]
        public void GetsFeeTest_BlackCat()
        {
            BlackCat target = new BlackCat();
            double expected = 0F;
            Assert.AreEqual(expected, target.GetsFee());
        }

        [TestMethod]
        public void CalculateTest_BlackCat()
        {
            BlackCat target = new BlackCat()
            {
                ShipProduct = new Product
                {
                    IsNeedCool = true,
                    Name = "test1",
                    Size = new getSize
                    {
                        Height = 10,
                        Length = 30,
                        Width = 20
                    },
                    Weight = 10

                }
            };

            target.Calculate();

            var expectedName = "BlackCat";
            var expectedFee = 200;

            var actualName = target.GetsCompanyName();
            var actualFee = target.GetsFee();

            Assert.AreEqual(expectedName, actualName);
            Assert.AreEqual(expectedFee, actualFee);
        }

        [TestMethod]
        public void GetsCompanyNameTest_Hsinchu()
        {
            Hsinchu target = new Hsinchu();
            string expected = "Hsinchu";
            Assert.AreEqual(expected, target.GetsCompanyName());
        }

        [TestMethod]
        public void GetsFeeTest_Hsinchu()
        {
            Hsinchu target = new Hsinchu();
            double expected = 0F;
            Assert.AreEqual(expected, target.GetsFee());
        }

        [TestMethod]
        public void CalculateTest_Hsinchu()
        {
            Hsinchu target = new Hsinchu()
            {
                ShipProduct = new Product
                {
                    IsNeedCool = true,
                    Name = "test1",
                    Size = new getSize
                    {
                        Height = 10,
                        Length = 30,
                        Width = 20
                    },
                    Weight = 10

                }
            };

            target.Calculate();

            var expectedName = "Hsinchu";
            var expectedFee = 254.16;

            var actualName = target.GetsCompanyName();
            var actualFee = target.GetsFee();

            Assert.AreEqual(expectedName, actualName);
            Assert.AreEqual(expectedFee, actualFee);
        }

        [TestMethod]
        public void GetsCompanyNameTest_PostOffice()
        {
            PostOffice target = new PostOffice();
            string expected = "PostOffice";
            Assert.AreEqual(expected, target.GetsCompanyName());
        }

        [TestMethod]
        public void GetsFeeTest_PostOffice()
        {
            PostOffice target = new PostOffice();
            double expected = 0F;
            Assert.AreEqual(expected, target.GetsFee());
        }

        [TestMethod]
        public void CalculateTest_PostOffice()
        {
            PostOffice target = new PostOffice()
            {
                ShipProduct = new Product
                {
                    IsNeedCool = true,
                    Name = "test1",
                    Size = new getSize
                    {
                        Height = 10,
                        Length = 30,
                        Width = 20
                    },
                    Weight = 10

                }
            };

            target.Calculate();

            var expectedName = "PostOffice";
            var expectedFee = 180;

            var actualName = target.GetsCompanyName();
            var actualFee = target.GetsFee();

            Assert.AreEqual(expectedName, actualName);
            Assert.AreEqual(expectedFee, actualFee);
        }

    }
}
