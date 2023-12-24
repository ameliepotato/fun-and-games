using LeetCode;
using LeetCode.Algorithms;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    public class RemoveDuplicates
    {
        [Test]
        public void Test1()
        {
            bool ret = true;

            List<int> testData = new List<int>() { 1, 1, 1, 2, 2, 3 };
            List<int> expectedData = new List<int>() { 1, 1, 2, 2, 3 };

            int k = RemoveDuplicatesFromSortedArrays.Run(ref testData);

            Assert.That(k, Is.EqualTo(expectedData.Count));

            Assert.That(CommonTools.AreEqual(expectedData.ToArray(), testData.Take(k).ToArray()));
        }

        [Test] 
        public void Test2()
        {
            var testData = new List<int>() { 0, 0, 1, 1, 1, 1, 2, 3, 3 };

            var expectedData = new List<int>() { 0, 0, 1, 1, 2, 3, 3 };
           
            int k = RemoveDuplicatesFromSortedArrays.Run(ref testData);
            Assert.That(k, Is.EqualTo(expectedData.Count));

            Assert.That(CommonTools.AreEqual(expectedData.ToArray(), testData.Take(k).ToArray()));
        }
    }
}
