using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CheckExtention;

namespace CheckExtention.Test
{
    [TestClass]
    public class StringTest
    {
        [TestMethod]
        public void TestEmail1()
        {
            Assert.AreEqual(true, "something@example.com".Is().Email(),"TestMail 1");
        }

        [TestMethod]
        public void TestEmail2()
        {
            Assert.AreEqual(false, "something@example.com".Is().Not().Email(), "TestMail 2");
        }

        [TestMethod]
        public void TestEmail3()
        {
            Assert.AreEqual(true, "something@example.com ".Is().Not().Email(), "TestMail 3");
        }

        [TestMethod]
        public void TestEmail4()
        {
            Assert.AreEqual(true, "somethdsfsdf.com".Is().Not().Email(), "TestMail 4");
        }

        [TestMethod]
        public void TestEmail5()
        {
            Assert.AreEqual(true, "".Is().Not().Email(), "TestMail 5");
        }

        [TestMethod]
        public void TestAssigned1()
        {
            Assert.AreEqual(false, "".Is().Assigned());
        }

        [TestMethod]
        public void TestAssigned2()
        {
            Assert.AreEqual(true, "assigned".Is().Assigned());
        }

        [TestMethod]
        public void TestAssigned3()
        {
            string strValue = null;
            Assert.AreEqual(false, strValue.Is().Assigned());
        }

        [TestMethod]
        public void TestUrl1()
        {
            string strValue = "";
            Assert.AreEqual(false, strValue.Is().Url());
        }

        [TestMethod]
        public void TestUrl2()
        {
            string strValue = "http://";
            Assert.AreEqual(false, strValue.Is().Url());
        }

        [TestMethod]
        public void TestUrl3()
        {
            string strValue = "http://www.example.com/";
            Assert.AreEqual(true, strValue.Is().Url());
        }

        [TestMethod]
        public void TestUrl4()
        {
            string strValue = "https://www.example.com/some/url/";
            Assert.AreEqual(true, strValue.Is().Url());
        }

        [TestMethod]
        public void TestUrl5()
        {
            string strValue = "http://subdomain.example.com/some/url/";
            Assert.AreEqual(true, strValue.Is().Url());
        }

        [TestMethod]
        public void TestUrl6()
        {
            string strValue = "http://subdomain.example.com/some/url/script.js";
            Assert.AreEqual(true, strValue.Is().Url());
        }

        [TestMethod]
        public void TestUrl7()
        {
            string strValue = "www.example.com";
            Assert.AreEqual(true, strValue.Is().Url());
        }

        [TestMethod]
        public void TestUrl8()
        {
            string strValue = "example.com";
            Assert.AreEqual(true, strValue.Is().Url());
        }

        [TestMethod]
        public void TestUrl9()
        {
            string strValue = "example";
            Assert.AreEqual(false, strValue.Is().Url());
        }

        [TestMethod]
        public void TestCreditCard1()
        {
            string strValue = "";
            Assert.AreEqual(false, strValue.Is().CreditCard());
        }

        [TestMethod]
        public void TestCreditCard2()
        {
            string strValue = "test";
            Assert.AreEqual(false, strValue.Is().CreditCard());
        }

        [TestMethod]
        public void TestCreditCard3()
        {
            string strValue = " ";
            Assert.AreEqual(false, strValue.Is().CreditCard());
        }

        [TestMethod]
        public void TestCreditCard4()
        {
            string strValue = " ";
            Assert.AreEqual(false, strValue.Is().CreditCard());
        }

        [TestMethod]
        public void TestCreditCard5()
        {
            string strValue = "5409034677631330";
            Assert.AreEqual(true, strValue.Is().CreditCard());
        }

        [TestMethod]
        public void TestCreditCard6()
        {
            string strValue = "5205375787878618";
            Assert.AreEqual(true, strValue.Is().CreditCard());
        }

        [TestMethod]
        public void TestCreditCard7()
        {
            string strValue = "4556889785416005";
            Assert.AreEqual(true, strValue.Is().CreditCard());
        }

        [TestMethod]
        public void TestCreditCard8()
        {
            string strValue = "4539847557611809";
            Assert.AreEqual(true, strValue.Is().CreditCard());
        }

        [TestMethod]
        public void TestCreditCard9()
        {
            string strValue = "372991231893256";
            Assert.AreEqual(true, strValue.Is().CreditCard());
        }

        [TestMethod]
        public void TestCreditCard10()
        {
            string strValue = "377652311486917";
            Assert.AreEqual(true, strValue.Is().CreditCard());
        }

        [TestMethod]
        public void TestCreditCard11()
        {
            string strValue = "3776523114 86917";
            Assert.AreEqual(false, strValue.Is().CreditCard());
        }

        [TestMethod]
        public void TestCreditCard12()
        {
            string strValue = "37765231148691";
            Assert.AreEqual(false, strValue.Is().CreditCard());
        }

    }
}
