using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateCalculator
{
    public delegate int GetResult(int x, int y);

    class Solution
    {
        public static int getTotal1(int num1, int num2)
        {
            return num1 + num2;
        }
        public static int getTotal2(int num3, int num4)
        {
            return num3 - num4;
        }
        public static int getTotal3(int num5, int num6)
        {
            return num5 * num6;
        }
        public static int getTotal4(int num7, int num8)
        {
            return num7 / num8;
        }
    }
}
