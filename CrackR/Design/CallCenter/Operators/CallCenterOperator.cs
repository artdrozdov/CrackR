using System;

namespace CrackR.Design.CallCenter.Operators
{
    public class CallCenterOperator : IOperator
    {
        public void HandleCall()
        {
            Console.WriteLine("Hi! I'm a call center operator. What can I do for you?");
        }
    }
}
