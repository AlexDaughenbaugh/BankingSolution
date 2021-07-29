namespace BankingDomain
{
    public class FeeProcessor
    {
        public void ChargeFee(ICanWithdrawFundsFromAnAccount account, decimal amount)
        {
            account.Withdraw(amount);
        }
    }
}