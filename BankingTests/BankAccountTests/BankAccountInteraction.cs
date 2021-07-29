using BankingDomain;
using Moq;
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
            //Given
            var stubbedBonusCalculator = new Mock<ICalculateBankAccountBonuses>();
            var account = new BankAccount(stubbedBonusCalculator.Object);
            var openingBalance = account.GetBalance();
            var amountToDeposit = 100;
            stubbedBonusCalculator
                .Setup(calc => calc.GetDepositBonusFor(openingBalance, amountToDeposit))
                .Returns(42);

            account.Deposit(amountToDeposit);

            Assert.Equal(openingBalance + amountToDeposit + 42, account.GetBalance());
        }
    }
}
