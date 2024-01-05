using System;

class Program
{
    static void Main()
    {
        FinanceOperations bankLoan = new Bank();
        FinanceOperations microFinanceLoan = new MicroFinance();
        double loanAmountBank = bankLoan.CalculateLoanPercent(12, 1000);
        double loanAmountMicroFinance = microFinanceLoan.CalculateLoanPercent(12, 1000);
    }
    public interface FinanceOperations
    {
        bool CheckUserHistory();
        double CalculateLoanPercent(int month, double amountPerMonth);
    }
    public class Bank : FinanceOperations
    {
        public bool CheckUserHistory()
        {
            Random random = new Random();
            return random.Next(2) == 0;
        }
        public double CalculateLoanPercent(int month, double amountPerMonth)
        {
            if (CheckUserHistory())
            {
                double maxAmount = amountPerMonth * month * 1.05; // 5% 
                Console.WriteLine($"Bank Loan approved. Total amount to be paid: {maxAmount:C}");
                return maxAmount;
            }
            else
            {
                Console.WriteLine("Bank Loan denied.");
                return 0;
            }
        }
    }
    public class MicroFinance : FinanceOperations
    {
        public bool CheckUserHistory()
        {
            return true;
        }

        public double CalculateLoanPercent(int month, double amountPerMonth)
        {
            double maxAmount = amountPerMonth * month * 1.1 + 4; // 10% + 4$
            Console.WriteLine($"MicroFinance Loan approved. Total amount to be paid: {maxAmount:C}");
            return maxAmount;
        }
    }
}
