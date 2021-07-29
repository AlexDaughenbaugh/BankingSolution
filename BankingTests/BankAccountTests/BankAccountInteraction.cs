using BankingDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BankingTests.BankAccountTests
{
    public class BankAccountInteraction
    {
        [Fact]
        public void TheBonusCalculatorIsUsedProperly()
        {
            var account = new BankAccount(new BonusCalculatorStubDummy());
            var openingBalance = account.GetBalance();
            var amountToDeposit = 100;

            account.Deposit(amountToDeposit);

            Assert.Equal(openingBalance + amountToDeposit + 42, account.GetBalance());
        }
    }
}
