using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console
{
   public class CalculatorEngine
    {
        //i'm abdell
        /// <summary>
        /// Function to Additin two value
        /// </summary>
        /// <param name="a">1st value.</param>
        /// <param name="b">2nd value.</param>
        /// <returns>the addition value.</returns>
        public int Add(int a, int b)
        {
            return a+b;
        }
        public int Sub(int a, int b)
        {
            return a-b;
        }
        public int Mul(int a, int b)
        {
            return a*b;
        }
        public int Div(int a, int b)
        {
            int res;
            if (b != 0)
            {
                res = a / b;
            }
                else
            {
                res = Int32.MinValue;
            }

            return res;
        }
    }
}
