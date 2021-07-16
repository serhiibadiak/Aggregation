namespace Aggregation
{
    class SpecialDeposit : Deposit
    {
        public SpecialDeposit(decimal depositAmount, int depositPeriod)
        : base(depositAmount, depositPeriod)
        {

        }
        override public decimal Income()
        {
            decimal sum = 0;
            decimal PreviosMonthSum = 0;
            for (int i = 1; i <= Period; i++)
            {
                if (i == 1)
                {
                    sum += Amount * i / 100;
                    PreviosMonthSum = sum;
                }
                else if (i > 1)
                {
                    sum += (PreviosMonthSum + Amount) * i / 100;
                    PreviosMonthSum = sum;
                }
            }
            return System.Math.Floor(sum * 100) / 100;
        }
    }
    //TODO: Define public class "SpecialDeposit" that inherits from "Deposit". +

    //TODO: Define constructor that calls constructor of a base class. +

    //TODO: Override method "Income" of base class according to the task. +
}