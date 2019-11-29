﻿using System;
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
        /// <param name="variable1">1st value.</param>
        /// <param name="variable2">2nd value.</param>
        /// <returns>the addition value.</returns>
        //Any Update
        public virtual int Add(int variable1, int variable2)
        {
            return variable1+variable2;
        }
        public virtual int Sub(int variable1, int variable2)
        {
            return variable1 - variable2;
        }
        public virtual int Mul(int variable1, int variable2)
        {
            return variable1 * variable2;
        }
        public virtual int Div(int variable1, int variable2)
        {
            int res;
            if (variable2 != 0)
            {
                res = variable1 / variable2;
            }
                else
            {
                res = Int32.MinValue;
            }

            return res;
        }
    }
}
