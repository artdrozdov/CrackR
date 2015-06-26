using System;

namespace CrackR.Design.CallCenter.Operators
{
    public class Boss : IOperator
    {
        public void HandleCall()
        {
            Console.WriteLine("WTF? Who R U, man?");
        }
    }
}
