
using Banking.Domain;

namespace Banking.Tests;
public class MakingDeposits
{

    [Fact]
    public void MakingADepositIncreasesBalance()
    {
        // Given
        var account = new Account();
        var openingBalance = account.GetBalance();
        var amountToDeposit = 100M;

        // when
        account.Deposit(amountToDeposit);


        // Then
        Assert.Equal(openingBalance + amountToDeposit, account.GetBalance());
    }
}
