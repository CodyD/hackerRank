using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace PlusMinus.Test
{
    [TestClass]
    public class ComputationTests
    {
        /// <summary>
        /// arr = [1,1,0,-1,-1]
        /// Results
        /// 0.400000
        /// 0.400000
        /// 0.200000
        /// </summary>
        [TestMethod]
        public void POSITIVE_NEGATIVE_ZERO_EXPECTS_ALL_DECIMALS()
        {
            List<int> arr = new List<int>() { 1, 1, 0, -1, -1 };
            var result = PlusMinus.Result.Compute(arr);
            var p = result.Format(result.Positive);
            Assert.AreEqual("0.400000", p);
            var n = result.Format(result.Negative);
            Assert.AreEqual("0.400000", n);
            var z = result.Format(result.Zero);
            Assert.AreEqual("0.200000", z);
        }

        /// <summary>
        /// arr = [1,1,0,-1,-1]
        /// Results
        /// 0.800000
        /// 0.000000
        /// 0.200000
        /// </summary>
        [TestMethod]
        public void POSITIVE_ZERO_EXPECTS_ALL_DECIMALS()
        {
            List<int> arr = new List<int>() { 1, 1, 0, 1, 1 };
            var result = PlusMinus.Result.Compute(arr);
            var p = result.Format(result.Positive);
            Assert.AreEqual("0.800000", p);
            var n = result.Format(result.Negative);
            Assert.AreEqual("0.000000", n);
            var z = result.Format(result.Zero);
            Assert.AreEqual("0.200000", z);
        }


        /// <summary>
        /// Passes in an empty array, expects 0.000000 for all results.
        /// </summary>
        [TestMethod]
        public void EMPTY_EXPECTS_ALL_DECIMALS()
        {
            List<int> arr = new List<int>();
            var result = PlusMinus.Result.Compute(arr);
            var p = result.Format(result.Positive);
            Assert.AreEqual("0.000000", p);
            var n = result.Format(result.Negative);
            Assert.AreEqual("0.000000", n);
            var z = result.Format(result.Zero);
            Assert.AreEqual("0.000000", z);
        }
    }
}