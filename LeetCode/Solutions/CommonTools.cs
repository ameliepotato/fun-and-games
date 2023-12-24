using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class CommonTools
    {
        public static string PrintCollection<T>(List<T> enumerable)
        {
            string res = "\n[";
            int i = 0;
            foreach (var item in enumerable)
            {
                res += $" {item} ";
                i++;
            }
            res += "]";
            return res;
        }

        public static bool AreEqual(int[] a, int[] b)
        {
            bool ret = a.Length == b.Length;
            if (ret)
            {
                for (int i = 0; i < a.Length && ret; i++)
                {
                    ret &= a[i] == b[i];
                }
            }
            Console.WriteLine($"Arrays {(ret?"are":"aren't")} equal: {PrintCollection(a.ToList())} {PrintCollection(b.ToList())}");
            return ret;
        }
    }
}
