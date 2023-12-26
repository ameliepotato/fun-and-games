using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    public class RandomizedSet
    {
        [Test] 
        public void Test1()
        {
            LeetCode.Algorithms.RandomizedSet obj = new LeetCode.Algorithms.RandomizedSet();
            int val = 1;
            bool param_1 = obj.Insert(val);
            
            Assert.That(param_1);

            int param_3 = obj.GetRandom();

            Assert.That(param_3, Is.EqualTo(1));

            bool param_4 = obj.Insert(2);

            Assert.That(param_4);

            bool param_5 = obj.Insert(1);

            Assert.That(!param_5);


            bool param_2 = obj.Remove(1);

            Assert.That(param_2);

            bool param_6 = obj.Remove(1);

            Assert.That(!param_6);

        }
    }
}
