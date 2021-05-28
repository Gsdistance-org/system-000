using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace system_000.dll.library.calc
{
    public static class calc
    {
        public static double add(double num1, double num2)
        {
            return num1 + num2;
        }

        public static double subtract(double num1, double num2)
        {
            return num1 - num2;
        }

        public static double divide(double num1, double num2)
        {
            return num1 / num2;
        }

        public static double multiply(double num1, double num2)
        {
            return num1 * num2;
        }
    }
}
