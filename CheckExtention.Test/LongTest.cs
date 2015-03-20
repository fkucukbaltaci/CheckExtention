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
    public class LongTest
    {
         long lngTestValue = 3;
         [TestMethod]
         public void TestZero()
         {
             Assert.AreEqual(false, lngTestValue.Is().Zero());
         }

         [TestMethod]
         public void TestPositive()
         {
             Assert.AreEqual(true, lngTestValue.Is().Positive());
         }

         [TestMethod]
         public void TestNegative()
         {
             Assert.AreEqual(false, lngTestValue.Is().Negative());
         }

         [TestMethod]
         public void TestEqual1()
         {
             Assert.AreEqual(true, lngTestValue.Is().Equal(lngTestValue));
         }

         [TestMethod]
         public void TestEqual2()
         {
             Assert.AreEqual(false, lngTestValue.Is().Equal(111));
         }

         [TestMethod]
         public void TestEven()
         {
             Assert.AreEqual(false, lngTestValue.Is().Even());
         }

         [TestMethod]
         public void TestOdd()
         {
             Assert.AreEqual(true, lngTestValue.Is().Odd());
         }

         [TestMethod]
         public void TestAbove()
         {
             Assert.AreEqual(false, lngTestValue.Is().Above(4));
         }

         [TestMethod]
         public void TestUnder()
         {
             Assert.AreEqual(true, lngTestValue.Is().Under(4));
         }

    }
}
