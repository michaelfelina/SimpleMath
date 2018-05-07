using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleMath;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Test
{
    [TestClass]
    public class Test
    {
        public Logic simpleMath;
        public Test()
        {
            simpleMath = new Logic();
        }

        [TestMethod]
        public void TestCase1()
        {
            double result = simpleMath.Add(1,1);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void TestCase2()
        {
            double result = simpleMath.Multiply(1, 1);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void TestCase3()
        {
            double result = simpleMath.Multiply(1, 1);
            Assert.AreEqual(1, result);
        }
    }
}
