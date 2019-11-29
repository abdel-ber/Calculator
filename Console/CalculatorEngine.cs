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
        /// <param name="Variable1">1st value.</param>
        /// <param name="Variable2">2nd value.</param>
        /// <returns>the addition value.</returns>
        //Any Update
        public virtual int Add(int Variable1, int Variable2)
        {
            return Variable1+Variable2;
        }
        public int Sub(int Variable1, int Variable2)
        {
            return Variable1 - Variable2;
        }
        public virtual int Mul(int Variable1, int Variable2)
        {
            return Variable1 * Variable2;
        }
        public virtual int Div(int Variable1, int Variable2)
        {
            int res;
            if (Variable2 != 0)
            {
                res = Variable1 / Variable2;
            }
                else
            {
                res = Int32.MinValue;
            }

            return res;
        }
    }
}
