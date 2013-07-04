using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CItest
{
    public enum Operations
    {
        Add = 0,
        Sub,
        Div,
        Mul
    }

    public class Calculator
    {
        public double Eval(double op1, double op2, Operations operation)
        {
            int decimals = 3;
            switch (operation)
            {
                case Operations.Add:
                    return Math.Round(op1 + op2, decimals);
                case Operations.Sub:
                    return Math.Round(op1 - op2, decimals);
                case Operations.Div:
                    return Math.Round(op1 / op2, decimals);
                case Operations.Mul:
                    return Math.Round(op1 * op1, decimals);
                default: throw new ArgumentOutOfRangeException("Неизвестная операция");
            }
        }
    }
}
