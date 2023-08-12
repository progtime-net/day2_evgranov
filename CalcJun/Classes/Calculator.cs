using System;
using CalcJun.Interfaces;

namespace CalcJun.Classes
{
	public class Calculator : ICalculator
	{
        public float ExecuteOperation(string operation, float a, float b)
        {
            IOperation oper = null;

            if (operation == "+")
            {
                oper = new OperationPlus();
            }
            else if (operation == "-")
            {
                oper = new OperationMinus();
            }

            return oper.Execute(a, b);
        }

        public void InputAndCalculate()
        {
            string line = Console.ReadLine();    // 2 + 2

            float a = float.Parse(line.Split()[0]);
            string operation = line.Split()[1];
            float b = float.Parse(line.Split()[2]);

            float res = ExecuteOperation(operation, a, b);

            Console.WriteLine(res);
        }
    }
}

