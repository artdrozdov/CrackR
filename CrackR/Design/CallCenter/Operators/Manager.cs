using System;

namespace CrackR.Design.CallCenter.Operators
{
    public class Manager : IOperator
    {
        public void HandleCall()
        {
            Console.WriteLine("I'm a manager. What's happened?");
        }
    }
}
