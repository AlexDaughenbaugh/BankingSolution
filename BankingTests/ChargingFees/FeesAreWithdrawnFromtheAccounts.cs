using BankingDomain;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BankingTests.ChargingFees
{
    public class FeesAreWithdrawnFromtheAccounts
    {
        [Fact]
        public void CanAssessFeesOnGroupsOfAccounts()
        {
            var feeProcessor = new FeeProcessor();
            var mockedWithdrawThing = new Mock<ICanWithdrawFundsFromAnAccount>();

            feeProcessor.ChargeFee(mockedWithdrawThing.Object, 1.55M);

            mockedWithdrawThing.Verify(m => m.Withdraw(1.55M));
            
        }
    }
}
