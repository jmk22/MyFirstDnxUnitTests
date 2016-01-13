using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstDnxUnitTests.Models
{
    public class Methods
    {
        public static int Subtract(int x, int y)
        {
            return x-y;
        }
        public static bool IsEven(int value)
        {
            return value % 2 == 0;
        }
    }
}
