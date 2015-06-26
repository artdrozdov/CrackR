using System;
using System.Collections.Generic;
using CrackR.Design.CallCenter.Operators;

namespace CrackR.Design.CallCenter
{
    public class CallCenter : ICaller
    {
        protected Queue<IOperator> FreeOperators { get; set; }
        protected Queue<IOperator> WorkingOperators { get; set; }
        protected ICaller NextLevel { get; set; }
        public uint OperatorsCount { get; set; }

        public CallCenter(uint amount = 4)
        {
            FreeOperators = new Queue<IOperator>();
            OperatorsCount = amount;
            WorkingOperators = new Queue<IOperator>();
            HireOperators();
        }

        public CallCenter(ICaller nextLevel = null, uint amount = 4)
            : this(amount)
        {
            NextLevel = nextLevel;
        }

        protected virtual void HireOperators()
        {
            for (int i = 0; i < OperatorsCount; i++)
                FreeOperators.Enqueue(new CallCenterOperator());
        }

        public void DispatchCall()
        {
            if (FreeOperators.Count > 0)
            {
                var caller = FreeOperators.Dequeue();
                caller.HandleCall();
                WorkingOperators.Enqueue(caller);
            }
            else
            {
                if (NextLevel != null)
                {
                    NextLevel.DispatchCall();
                }
                else
                {
                    Console.WriteLine("Sorry, all operators are busy. Please, call again later!");
                }
            }
        }
    }
}
