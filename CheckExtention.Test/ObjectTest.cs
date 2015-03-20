using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CheckExtention;

namespace CheckExtention.Test
{
     [TestClass]
    public class ObjectTest
    {

         [TestMethod]
         public void TestNull1()
         {
             object objObject = null;
             Assert.AreEqual(true, objObject.Is().Null());
         }

         [TestMethod]
         public void TestNull2()
         {
             object objObject = DBNull.Value;
             Assert.AreEqual(true, objObject.Is().Null());
         }

         [TestMethod]
         public void TestNull3()
         {
             object objObject = "not null";
             Assert.AreEqual(false, objObject.Is().Null());
         }

         [TestMethod]
         public void TestNull4()
         {
             object objObject = new object();
             Assert.AreEqual(false, objObject.Is().Null());
         }

         [TestMethod]
         public void TestNumeric()
         {
             object objObject = 1111;
             Assert.AreEqual(true, objObject.Is().Numeric());
         }

         [TestMethod]
         public void TestNumeric1()
         {
             object objObject = "1111";
             Assert.AreEqual(true, objObject.Is().Numeric());
         }

         [TestMethod]
         public void TestNumeric2()
         {
             object objObject = "11a11";
             Assert.AreEqual(false, objObject.Is().Numeric());
         }

         [TestMethod]
         public void TestNumeric3()
         {
             object objObject = "11.1";
             Assert.AreEqual(true, objObject.Is().Numeric());
         }

         [TestMethod]
         public void TestNumeric4()
         {
             object objObject = "11,1,1";
             Assert.AreEqual(false, objObject.Is().Numeric());
         }

         [TestMethod]
         public void TestNumeric5()
         {
             object objObject = "";
             Assert.AreEqual(false, objObject.Is().Numeric());
         }

         [TestMethod]
         public void TestNumeric6()
         {
             object objObject = "100.000.000";
             Assert.AreEqual(true, objObject.Is().Numeric());
         }

         [TestMethod]
         public void TestNumeric7()
         {
             object objObject = "";
             Assert.AreEqual(false, objObject.Is().Numeric());
         }

         [TestMethod]
         public void TestNumeric8()
         {
             object objObject = "test";
             Assert.AreEqual(false, objObject.Is().Numeric());
         }

         [TestMethod]
         public void TestNumber1()
         {
             object objObject = "";
             Assert.AreEqual(false, objObject.Is().Number());
         }

         [TestMethod]
         public void TestNumber2()
         {
             object objObject = "aaa";
             Assert.AreEqual(false, objObject.Is().Number());
         }

         [TestMethod]
         public void TestNumber3()
         {
             object objObject = "34334234234234242342342324";
             Assert.AreEqual(true, objObject.Is().Number());
         }

         [TestMethod]
         public void TestNumber4()
         {
             object objObject = "33.5";
             Assert.AreEqual(false, objObject.Is().Number());
         }

         [TestMethod]
         public void TestNumber5()
         {
             object objObject = "100.0000.000";
             Assert.AreEqual(false, objObject.Is().Number());
         }

         [TestMethod]
         public void TestNumber6()
         {
             object objObject = "33,5";
             Assert.AreEqual(false, objObject.Is().Number());
         }

    }
}
