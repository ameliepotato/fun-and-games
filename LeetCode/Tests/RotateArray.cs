using LeetCode;

namespace Tests
{
    public class RotateArray
    {
        [Test]
        public void Test1() {
            var input = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            int k = 3;
            var output = new int[] { 5, 6, 7, 1, 2, 3, 4 };

            LeetCode.Algorithms.RotateArray.Run(input, k);

            Assert.That(CommonTools.AreEqual(input, output));
        }

        [Test] 
        public void Test2() {
            var input = new int[] { -1, -100, 3, 99 };
            int k = 2;
            var output = new int[] { 3, 99, -1, -100 };

            LeetCode.Algorithms.RotateArray.Run(input, k);

            Assert.That(CommonTools.AreEqual(input, output));

        }

        [Test]
        public void Test3()
        {
            var input = new int[] { 1,2 };
            int k = 1;
            var output = new int[] { 2, 1 };

            LeetCode.Algorithms.RotateArray.Run(input, k);

            Assert.That(CommonTools.AreEqual(input, output));

        }

        [Test]
        public void Test4()
        {
            var input = new int[] { 1, 2 };
            int k = 3;
            var output = new int[] { 2, 1 };

            LeetCode.Algorithms.RotateArray.Run(input, k);

            Assert.That(CommonTools.AreEqual(input, output));

        }

        [Test]
        public void Test5()
        {
            var input = CommonTools.LoadFromFile<int>("TestData\\RotateArray.txt");

            Assert.IsNotNull(input);

            int k = 54944;
            var expected = new int[] { };
            int expectedSeconds = 3;

            DateTime start = DateTime.Now;
            Console.WriteLine($"RotateArray Started at: {start}");

            Task t = Task.Run(() => {
                LeetCode.Algorithms.RotateArray.Run(input.ToArray(), k);
                DateTime end = DateTime.Now;
                Console.WriteLine($"RotateArray Ended at:   {end}");
                Assert.That((int)end.Subtract(start).TotalSeconds, Is.LessThan(expectedSeconds));
            });

            bool endedOnTime = t.Wait(expectedSeconds);

            Assert.That(endedOnTime, $"RotateArray should take less than {expectedSeconds} seconds");
            
        }
    }
}
