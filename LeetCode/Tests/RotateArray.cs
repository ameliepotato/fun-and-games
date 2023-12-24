using LeetCode;

namespace Tests
{
    public class RotateArray
    {
        [Test] 
        public void Test1() {
            var input = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };
            int k = 3;
            var output = new List<int>() { 5, 6, 7, 1, 2, 3, 4 };

            LeetCode.Algorithms.RotateArray.Run(input, k);

            Assert.That(CommonTools.AreEqual(input.ToArray(), output.ToArray()));
        }

        [Test] 
        public void Test2() {
            var input = new List<int>() { -1, -100, 3, 99 };
            int k = 2;
            var output = new List<int>() { 3, 99, -1, -100 };

            LeetCode.Algorithms.RotateArray.Run(input, k);

            Assert.That(CommonTools.AreEqual(input.ToArray(), output.ToArray()));

        }

        [Test]
        public void Test3()
        {
            var input = new List<int>() { 1,2 };
            int k = 1;
            var output = new List<int>() { 2, 1 };

            LeetCode.Algorithms.RotateArray.Run(input, k);

            Assert.That(CommonTools.AreEqual(input.ToArray(), output.ToArray()));

        }

        [Test]
        public void Test4()
        {
            var input = new List<int>() { 1, 2 };
            int k = 3;
            var output = new List<int>() { 2, 1 };

            LeetCode.Algorithms.RotateArray.Run(input, k);

            Assert.That(CommonTools.AreEqual(input.ToArray(), output.ToArray()));

        }
    }
}
