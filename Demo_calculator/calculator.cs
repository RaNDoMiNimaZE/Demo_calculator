using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_calculator
{
    public static class calculator
    {
        
        public static int add(int a, int b)
        {
            return a + b;
        }
        public static int multiply(int a, int b)
        {
            return a * b;
        }
        public static int subtract(int a, int b)
        {
            return a + b;
        }
        public static int divide(int a, int b)
        {
            if (a == 0 || b == 0) return 0;
            else return a / b;
        }
    }
}
