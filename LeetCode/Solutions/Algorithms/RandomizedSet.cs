using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms
{
    public class RandomizedSet
    {
        private List<int> _values;
        public RandomizedSet()
        {
            _values = new List<int>();
        }

        public bool Insert(int val)
        {
            if (!_values.Contains(val))
            {
                _values.Add(val);
                return true;
            }
            return false;
        }

        public bool Remove(int val)
        {
            if (_values.Contains(val))
            {
                _values.Remove(val);
                return true;
            }
            return false;
        }

        public int GetRandom()
        {
            Random rnd = new Random();
            int i = rnd.Next(-1, _values.Count()-1)+1;
            return _values.ElementAt(i);
        }
    }
}
