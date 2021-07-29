namespace BankingDomain
{
    public class StandardBonusCalculator : ICalculateBankAccountBonuses
    {
        decimal ICalculateBankAccountBonuses.GetDepositBonusFor(decimal balance, decimal amountToDeposit)
        {
            return (balance >= 10000) ? amountToDeposit * 0.10M : 0;
        }
    }
}