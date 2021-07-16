namespace Aggregation
{
    abstract class Deposit
    {
        public decimal Amount { get; }
        public int Period { get; }
        public Deposit(decimal depositAmount, int depositPeriod)
        {
            this.Amount = depositAmount;
            this.Period = depositPeriod;
        }
        abstract public decimal Income();
    }
    //TODO: Define public abstract class "Deposit"

    //TODO: Define public readonly property "Amount" with decimal type.

    //TODO: Define public readonly property "Period" with int type.

    //TODO: Define constructor that gets "Amount" and "Period" and assigns them to its properties.

    //TODO: Define public abstract method "Income" that returns deposit profit depending on "Amount" and "Period".
}