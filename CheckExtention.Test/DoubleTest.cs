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
    public class DoubleTest
    {
         double dobTestValue = 3.4544;
         [TestMethod]
         public void TestZero()
         {
             Assert.AreEqual(false, dobTestValue.Is().Zero());
         }

         [TestMethod]
         public void TestPositive()
         {
             Assert.AreEqual(true, dobTestValue.Is().Positive());
         }

         [TestMethod]
         public void TestNegative()
         {
             Assert.AreEqual(false, dobTestValue.Is().Negative());
         }

         [TestMethod]
         public void TestEqual1()
         {
             Assert.AreEqual(true, dobTestValue.Is().Equal(dobTestValue));
         }

         [TestMethod]
         public void TestEqual2()
         {
             Assert.AreEqual(false, dobTestValue.Is().Equal(111));
         }

         [TestMethod]
         public void TestEven()
         {
             Assert.AreEqual(false, dobTestValue.Is().Even());
         }

         [TestMethod]
         public void TestOdd()
         {
             Assert.AreEqual(true, dobTestValue.Is().Odd());
         }

         [TestMethod]
         public void TestAbove()
         {
             Assert.AreEqual(false, dobTestValue.Is().Above(4));
         }

         [TestMethod]
         public void TestUnder()
         {
             Assert.AreEqual(true, dobTestValue.Is().Under(4));
         }

    }
}
