using System;

namespace Aggregation
{
    class BaseDeposit : Deposit
    {
        public BaseDeposit(decimal depositAmount, int depositPeriod)
        : base(depositAmount, depositPeriod)
        {

        }
        override public decimal Income()
        {
            const int YearPercent = 60;
            // —ложные проценты x*(1+s/(12*100))^m x -начальна€ сумма, s-годова€ ставка в процентах, m - срок вклада в мес€ц€х
            if (Period == 0)
            {
                return 0;
            }
            return Math.Floor((Amount * (decimal)System.Math.Pow((1 + (double)YearPercent / 1200), Period) - Amount) * 100) / 100;
        }
    }
    //TODO: Define public class "BaseDeposit" that inherits from "Deposit". +

    //TODO: Define constructor that calls constructor of a base class. +

    //TODO: Override method "Income" of base class according to the task. +
}