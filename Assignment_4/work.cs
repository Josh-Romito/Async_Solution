using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Assignment_4
{
    public class work
    {
        private static int idx = 0;
        public static int Index
        {
            get { return idx++; }
        }
        public static long Fib_B(int n)
        {
            
            //0,1,1,2,3,5,8,13,21,34,55,…
            if (n == 0 || n == 1)//satisfaction condition
                return n;
            return Fib_B(n - 2) + Fib_B(n - 1);
        }
        public static void WorkIt(int ValueToWorkWith, int[] intArray, int indexToWriteAt)
        {
            intArray[indexToWriteAt] = (int)Fib_B(ValueToWorkWith);
        }

    }
}
