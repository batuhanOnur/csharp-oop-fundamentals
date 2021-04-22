using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            //--Arrange
            Customer customer = new Customer
            {
                FirstName = "Batuhan",
                LastName = "Onur"
            };
            string expected = "Onur, Batuhan";

            //--Act
            string actual = customer.FullName;

            //--Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FullNameFirstEmpty()
        {
            //--Arrange
            Customer customer = new Customer
            {
                LastName = "Onur"
            };
            string expected = "Onur";

            //--Act
            string actual = customer.FullName;

            //--Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            //--Arrange
            Customer customer = new Customer
            {
                FirstName = "Batuhan"
            };
            string expected = "Batuhan";

            //--Act
            string actual = customer.FullName;

            //--Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void StaticTest()
        {
            //--Arrange
            var c1 = new Customer();
            c1.FirstName = "Bilbo";  // c1 InstanceCount'a ulaşamaz. çünkü static.
            Customer.InstanceCount += 1;  // static'e ulaşmak için direk object çağırılır.

            var c2 = new Customer();
            c2.FirstName = "Frodo";
            Customer.InstanceCount += 1;

            var c3 = new Customer();
            c3.FirstName = "Rosie";
            Customer.InstanceCount += 1;

            //--Act

            //--Assert
            Assert.AreEqual(3, Customer.InstanceCount);
        }
    }
}
