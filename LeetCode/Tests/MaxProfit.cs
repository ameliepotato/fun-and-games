using LeetCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    public class MaxProfit
    {
        [Test]
        public void Test1()
        {
            var input = new int[] { 7, 1, 5, 3, 6, 4 };
            int expected = 5;
            int output = LeetCode.Algorithms.MaxProfit.Run(input);

            Assert.That(output, Is.EqualTo(expected));
        }

        [Test]
        public void Test2()
        {
            var input = new int[] { 7, 6, 4, 3, 1 };
            int expected = 0;
            int output = LeetCode.Algorithms.MaxProfit.Run(input);

            Assert.That(output, Is.EqualTo(expected));
        }

        [Test]
        public void Test3()
        {
            var input = CommonTools.LoadFromFile<int>("TestData\\MaxProfit.txt")?.ToArray();

            Assert.That(input, Is.Not.Null);

            int expected = 999;
            DateTime start = DateTime.Now;
            int expectedSeconds = 10;

            Console.WriteLine($"MaxProfit Started at: {start}");

            int output = LeetCode.Algorithms.MaxProfit.Run(input);

            DateTime end = DateTime.Now;

            Console.WriteLine($"MaxProfit Ended at:   {end}");

            Assert.That(output, Is.EqualTo(expected));

            Assert.That((int)end.Subtract(start).TotalSeconds, Is.LessThan(expectedSeconds));
        }

        [Test]
        public void Test4()
        {
            var input = CommonTools.LoadFromFile<int>("TestData\\MaxProfitALotOfZeros.txt")?.ToArray();

            Assert.That(input, Is.Not.Null);

            int expected = 0;
            DateTime start = DateTime.Now;
            int expectedSeconds = 10;

            Console.WriteLine($"MaxProfit Started at: {start}");

            int output = LeetCode.Algorithms.MaxProfit.Run(input);

            DateTime end = DateTime.Now;

            Console.WriteLine($"MaxProfit Ended at:   {end}");

            Assert.That(output, Is.EqualTo(expected));

            Assert.That((int)end.Subtract(start).TotalSeconds, Is.LessThan(expectedSeconds));
        }

        [Test]
        public void Test5()
        {
            int[] input = new int[] { 1, 2 };
            int expected = 1;
            int output = LeetCode.Algorithms.MaxProfit.Run(input);
            Assert.That(output, Is.EqualTo(expected));
        }

        [Test]
        public void Test6()
        {
            int[] input = new int[] { 3, 2, 6, 5, 0, 3 };
            int expected = 4;
            int output = LeetCode.Algorithms.MaxProfit.Run(input);
            Assert.That(output, Is.EqualTo(expected));
        }


        [Test]
        public void Test7()
        {
            int[] input = new int[] { 1 };
            int expected = 0;
            int output = LeetCode.Algorithms.MaxProfit.Run(input);
            Assert.That(output, Is.EqualTo(expected));
        }

        [Test]
        public void Test8()
        {
            int[] input = new int[] { 2, 1 };
            int expected = 0;
            int output = LeetCode.Algorithms.MaxProfit.Run(input);
            Assert.That(output, Is.EqualTo(expected));
        }

        [Test]
        public void Test9()
        {
            int[] input = new int[] { 3, 3, 5, 0, 0, 3, 1, 4 };
            int expected = 4;
            int output = LeetCode.Algorithms.MaxProfit.Run(input);
            Assert.That(output, Is.EqualTo(expected));
        }
    }
}
