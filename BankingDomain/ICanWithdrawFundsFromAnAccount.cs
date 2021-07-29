namespace BankingDomain
{
    public interface ICanWithdrawFundsFromAnAccount
    {
        void Withdraw(decimal amountToWithdraw);
    }
}