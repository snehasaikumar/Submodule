using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Submodule
{
    public class Calculate
    {

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Multiply(int a, int b)
        {
            return a*b;
        }

        public double Divide(int e, int f)
        {
            return e%f;
        }

    }
}
