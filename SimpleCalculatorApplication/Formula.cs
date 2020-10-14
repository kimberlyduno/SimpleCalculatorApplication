using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculatorApplication
{

    public delegate int GetAnswer(int x, int y);
    class Formula
    {

        public static int getSum(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int getSub(int num1, int num2)
        {
            return num1 - num2;
        }

        public static int getMul(int num1, int num2)
        {
            return num1 * num2;
        }

        public static int getDiv(int num1, int num2)
        {
            return num1 / num2;
        }
    }
}
