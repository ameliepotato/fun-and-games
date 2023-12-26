
using LeetCode;

namespace Tests
{
    public class JumpGame
    {
        [Test]
        public void Test1()
        {
            var input = new int[] { 2, 3, 1, 1, 4 };
            var expected = true;
            var output = LeetCode.Algorithms.JumpGame.Run(input);

            Assert.That(output, Is.EqualTo(expected));
        }

        [Test]
        public void Test2()
        {
            var input = new int[] { 3, 2, 1, 0, 4 };
            var expected = false;
            var output = LeetCode.Algorithms.JumpGame.Run(input);

            Assert.That(output, Is.EqualTo(expected));
        }

        [Test]
        public void Test3()
        {
            var input = new int[] { 2, 0 };
            var expected = true;
            var output = LeetCode.Algorithms.JumpGame.Run(input);

            Assert.That(output, Is.EqualTo(expected));
        }

        [Test]
        public void Test4()
        {
            var input = new int[] { 2, 0, 0 };
            var expected = true;
            var output = LeetCode.Algorithms.JumpGame.Run(input);

            Assert.That(output, Is.EqualTo(expected));
        }

        [Test]
        public void Test5()
        {
            var input = new int[] { 1, 1, 1, 0 };
            var expected = true;
            var output = LeetCode.Algorithms.JumpGame.Run(input);

            Assert.That(output, Is.EqualTo(expected));
        }


        [Test]
        public void Test6()
        {
            var input = new int[] { 0 };
            var expected = true;
            var output = LeetCode.Algorithms.JumpGame.Run(input);

            Assert.That(output, Is.EqualTo(expected));
        }



        [Test]
        public void Test7()
        {
            var input = new int[] { 2, 0, 2 };
            var expected = true;
            var output = LeetCode.Algorithms.JumpGame.Run(input);

            Assert.That(output, Is.EqualTo(expected));
        }


        [Test]
        public void Test8()
        {
            var input = new int[] {
                8, 2, 4, 4, 4, 9, 5, 2, 5, 8, 8, 0, 8, 6, 9, 1, 1, 6, 3, 5, 1, 2, 
                6, 6, 0, 4, 8, 6, 0, 3, 2, 8, 7, 6, 5, 1, 7, 0, 3, 4, 8, 3, 5, 9, 
                0, 4, 0, 1, 0, 5, 9, 2, 0, 7, 0, 2, 1, 0, 8, 2, 5, 1, 2, 3, 9, 7, 
                4, 7, 0, 0, 1, 8, 5, 6, 7, 5, 1, 9, 9, 3, 5, 0, 7, 5 };

            var expected = true;
            int expectedSeconds = 10;
            DateTime start = DateTime.Now;
            Console.WriteLine($"JumpGame Started at: {start}");

            var output = LeetCode.Algorithms.JumpGame.Run(input);

            DateTime end = DateTime.Now;

            Console.WriteLine($"JumpGame Ended at:   {end}");

            Assert.That(output, Is.EqualTo(expected));

            Assert.That((int)end.Subtract(start).TotalSeconds, Is.LessThan(expectedSeconds));
        }


        [Test]
        public void Test9()
        {
            var input = CommonTools.LoadFromFile<int>("TestData\\JumpGameLots.txt");

            Assert.IsNotNull(input);

            var expected = false;
            int expectedSeconds = 10;
            DateTime start = DateTime.Now;
            Console.WriteLine($"JumpGame Started at: {start}");

            var output = LeetCode.Algorithms.JumpGame.Run(input.ToArray());

            DateTime end = DateTime.Now;

            Console.WriteLine($"JumpGame Ended at:   {end}");

            Assert.That(output, Is.EqualTo(expected));

            Assert.That((int)end.Subtract(start).TotalSeconds, Is.LessThan(expectedSeconds));
        }
    }
}