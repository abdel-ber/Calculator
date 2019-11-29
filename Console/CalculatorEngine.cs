using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console
{
    //Berkal Abdelghani 
    //modif Mickael
   public class CalculatorEngine
    {
        //i'm abdell
        /// <summary>
        /// Function to Additin two value
        /// </summary>
        /// <param name="a">1st value.</param>
        /// <param name="b">2nd value.</param>
        /// <returns>the addition value.</returns>
        //Any Update
        public virtual int Add(int Val1, int Val2)
        {
            return Val1+Val2;
        }
        public int Sub(int Val1, int Val2)
        {
            return Val1 - Val2;
        }
        public virtual int Mul(int Val1, int Val2)
        {
            return Val1 * Val2;
        }
        public virtual int Div(int Val1, int Val2)
        {
            int res;
            if (Val2 != 0)
            {
                res = Val1 / Val2;
            }
                else
            {
                res = Int32.MinValue;
            }

            return res;
        }
    }
}
