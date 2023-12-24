
using LeetCode;

namespace Tests
{
    public class MajorityElement
    {
        [Test]
        public void Test1()
        {
            var input = new List<int>() { 3, 2, 3 };
            var expected = 3;
            var output = LeetCode.Algorithms.MajorityElement.Run(input);

            Assert.That(output, Is.EqualTo(expected));
        }

        [Test]
        public void Test2()
        {
            var input = new List<int>() { 2, 2, 1, 1, 1, 2, 2 };
            var expected = 2;
            var output = LeetCode.Algorithms.MajorityElement.Run(input);

            Assert.That(output, Is.EqualTo(expected));
        }
    }
}