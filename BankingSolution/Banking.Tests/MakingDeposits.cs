
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

	[Fact]
	public void MultipleAccounts()
	{
		var bobsAccount = new Account();
		var suesAccount = new Account();

		suesAccount.Deposit(1000);


		Assert.Equal(5000, bobsAccount.GetBalance());

		Assert.Equal(6000, suesAccount.GetBalance());

		//Assert.Equal(6000M, suesAccount._balance);

		//suesAccount._balance -= 1000000;
	}
}
