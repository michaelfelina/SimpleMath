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
        public void TestAdd()
        {
            double result = simpleMath.Add(1,1);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void TestMultiply()
        {
            double result = simpleMath.Multiply(1, 1);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void TestSubtraction()
        {
            double result = simpleMath.Minus(1, 1);

            Assert.AreEqual(0, result);
        }
    }
}
