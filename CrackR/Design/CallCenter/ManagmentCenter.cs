using CrackR.Design.CallCenter.Operators;

namespace CrackR.Design.CallCenter
{
    public class ManagmentCenter : CallCenter
    {
        public ManagmentCenter(ICaller nextLevel = null, uint amount = 2) : base(nextLevel, amount) { }
        protected override void HireOperators()
        {
            for (int i = 0; i < OperatorsCount; i++)
                FreeOperators.Enqueue(new Manager());
        }
    }
}
