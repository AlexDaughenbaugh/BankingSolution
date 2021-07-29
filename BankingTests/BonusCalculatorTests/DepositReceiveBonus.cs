using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using BankingDomain;

namespace BankingTests.BonusCalculatorTests
{
    public class DepositReceiveBonus
    {
        [Fact]
        public void GoldAccountsRecieveABonus()
        {
            ICalculateBankAccountBonuses calculator = new StandardBonusCalculator();

            var bonus = calculator.GetDepositBonusFor(10000, 100);

            Assert.Equal(10, bonus);
        }

        [Fact]
        public void NonGoldAccountsGetNoBonus()
        {
            ICalculateBankAccountBonuses calculator = new StandardBonusCalculator();

            var bonus = calculator.GetDepositBonusFor(9999.9M, 100);

            Assert.Equal(0, bonus);

        }
    }
}
