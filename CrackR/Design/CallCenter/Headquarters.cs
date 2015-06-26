using CrackR.Design.CallCenter.Operators;

namespace CrackR.Design.CallCenter
{
    public class Headquarters : CallCenter
    {
        public Headquarters(ICaller nextLevel = null, uint amount = 1) : base(nextLevel, amount) { }
        protected override void HireOperators()
        {
            for (int i = 0; i < OperatorsCount; i++)
                FreeOperators.Enqueue(new Boss());
        }
    }
}
