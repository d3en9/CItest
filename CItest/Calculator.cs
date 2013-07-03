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
            switch (operation)
            {
                case Operations.Add:
                    return op1 + op2;
                case Operations.Sub:
                    return op1 - op2;
                case Operations.Div:
                    return op1 / op2;
                case Operations.Mul:
                    return op1 * op1;
                default: throw new ArgumentOutOfRangeException("Неизвестная операция");
            }
        }
    }
}
