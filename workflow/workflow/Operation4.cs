using System;
using workflow.Contracts;

namespace workflow
{
    public class Operation4 : IStrategy
    {
        public string Name => "operation 4";

        // Operation 4: If the input number contains the digit 7 or
        // divides by 7 (with a remainder of zero) – throws an exception
        // and stop the workflow, otherwise Add 7 to the input number.
        public float DoOperation(float input)
        {
            if(input.ToString().Contains('7')||input%7==0)
            {
                throw new Exception("input number contains the digit 7 or divides by 7");
            }
            return input + 7;
        }
    }
}
