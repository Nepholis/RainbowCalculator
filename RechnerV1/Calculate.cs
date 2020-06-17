using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace RechnerV1
{
    /// <summary>
    /// Can calculate 2 Numbers with each other to get a final Number, check diving >> b != 0 befor handing over1
    /// </summary>
    class Calculate
    {
        public decimal result = 0;
        public Calculate(decimal a, decimal b, string myOperator)
        {
            if (myOperator == "+") { this.result = decimal.Add(a,b); }
            else if (myOperator == "-") { this.result = decimal.Subtract(a,b); }
            else if (myOperator == "*") { this.result = decimal.Multiply(a,b) ; }
            else if (myOperator == "/") { this.result = decimal.Divide(a,b); }
            else { }
        }
        //public decimal Add(decimal a, decimal b)
        //{
        //    return a + b;
        //}
        //public decimal Sub(decimal a, decimal b)
        //{
        //    return a - b;
        //}
        //public decimal Mul(decimal a, decimal b)
        //{
        //    return a * b;
        //}
        //public decimal Div(decimal a, decimal b)
        //{
        //    return a / b;
        //}

        /// <summary>
        /// returns 
        /// </summary>
        public decimal getResult()
        {
            return result;
        }
    }
}
