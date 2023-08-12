using System;
using CalcJun.Interfaces;

namespace CalcJun.Classes
{
	public class OperationMinus : IOperation
	{
        public string Name { get; } = "-";

        public float Execute(float a, float b)
        {
            return a - b;
        }
    }
}

