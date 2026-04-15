static class SavingsAccount
{
    public static float InterestRate(decimal balance)
    {
        return balance switch
        {
            < 0 => 3.213f,
            >= 0 and < 1000 => 0.5f,
            >= 1000 and < 5000 => 1.621f,
            >= 5000 => 2.475f
        };
    }

    public static decimal Interest(decimal balance)
    {
        return balance/100 * (decimal)InterestRate(balance);
    }

    public static decimal AnnualBalanceUpdate(decimal balance)
    {
        return balance + Interest(balance);
    }

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        int years = 0;
        decimal increment = AnnualBalanceUpdate(balance)-balance;
        balance+=increment;
        while (balance < targetBalance)
        {
            years++;
            balance += increment;
        }
        return years;
    }
}
