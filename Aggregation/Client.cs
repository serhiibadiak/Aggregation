namespace Aggregation
{
    class Client
    {
        private Deposit[] deposits;
        public Client()
        {
            deposits = new Deposit[10];
        }
        public bool AddDeposit(Deposit depositToAdd)
        {
            for (int i = 0; i < deposits.Length; i++)
            {
                if(deposits[i] == null)
                {
                    deposits[i] = depositToAdd;
                    return true;
                }
            }
            return false;
        }
        public decimal TotalIncome()
        {
            decimal sum = 0;
            for (int i = 0; i < deposits.Length; i++)
            {
                if (deposits[i] != null)
                {
                    sum += deposits[i].Income();
                }
            }
            return sum;
        }
        public decimal MaxIncome()
        {
            decimal max = 0;
            for (int i = 0; i < deposits.Length; i++)
            {
                if (deposits[i] != null && deposits[i].Income() > max)
                {
                    max = deposits[i].Income();
                }
            }
            return max;
        }
        public decimal GetIncomeByNumber(int number)
        {
            if (deposits[number] != null)
            {
                return deposits[number -1].Income();
            }
            else return 0;
        }

    }
    //TODO: Define public class "Client". +
    
    //TODO: Define private field "deposits" with type of array of "Deposit". +
    
    //TODO: Define parameterless constructor that creates empty array of deposits with size of 10. +
    
    //TODO: Define public method "AddDeposit" that takes deposit and adds it to "deposits". If the array of deposits has empty place, returns true, else returns false. +
    
    //TODO: Define public method "TotalIncome" that returns total income of all deposits upon their expiration. +
    
    //TODO: Define public method "MaxIncome" that returns max value of income of all deposits of client.
    
    //TODO: Define public method "GetIncomeByNumber" that takes number of deposit (index of deposit in array plus 1) that returns income of this deposit.
}