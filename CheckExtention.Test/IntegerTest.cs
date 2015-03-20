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
    public class IntegerTest
    {
         int intTestValue = 3;
         [TestMethod]
         public void TestZero()
         {
             Assert.AreEqual(false, intTestValue.Is().Zero());
         }

         [TestMethod]
         public void TestPositive()
         {
             Assert.AreEqual(true, intTestValue.Is().Positive());
         }

         [TestMethod]
         public void TestNegative()
         {
             Assert.AreEqual(false, intTestValue.Is().Negative());
         }

         [TestMethod]
         public void TestEqual1()
         {
             Assert.AreEqual(true, intTestValue.Is().Equal(intTestValue));
         }

         [TestMethod]
         public void TestEqual2()
         {
             Assert.AreEqual(false, intTestValue.Is().Equal(111));
         }

         [TestMethod]
         public void TestEven()
         {
             Assert.AreEqual(false, intTestValue.Is().Even());
         }

         [TestMethod]
         public void TestOdd()
         {
             Assert.AreEqual(true, intTestValue.Is().Odd());
         }

         [TestMethod]
         public void TestAbove()
         {
             Assert.AreEqual(false, intTestValue.Is().Above(4));
         }

         [TestMethod]
         public void TestUnder()
         {
             Assert.AreEqual(true, intTestValue.Is().Under(4));
         }

    }
}
