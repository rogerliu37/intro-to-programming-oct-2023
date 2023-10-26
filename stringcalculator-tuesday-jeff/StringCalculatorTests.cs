
namespace StringCalculator;

public class StringCalculatorTests
{
	private readonly StringCalculator _calculator = new StringCalculator();
	[Fact]
	public void EmptyStringReturnsZero()
	{
		var result = _calculator.Add("");

		Assert.Equal(0, result);
	}
	[Theory]
	[InlineData("1", 1)]
	[InlineData("2", 2)]
	[InlineData("308", 308)]
	public void SingleDigit(string input, int expected)
	{
		var result = _calculator.Add(input);
		Assert.Equal(expected, result);
	}

	[Theory]
	[InlineData("1,2", 3)]
	[InlineData("2,2", 4)]
	[InlineData("10,2", 12)]
	[InlineData("108,10", 118)]
	public void TwoDigits(string input, int expected)
	{
		var result = _calculator.Add(input);
		Assert.Equal(expected, result);
	}

	[Theory]
	[InlineData("1,2,3,4,5,6,7,8,9", 45)]

	public void Arbitrary(string input, int expected)
	{
		var result = _calculator.Add(input);
		Assert.Equal(expected, result);
	}

	[Theory]
	[InlineData("1,2,3\n4,5,6,7\n8,9", 45)]

	public void NewLines(string input, int expected)
	{
		var result = _calculator.Add(input);
		Assert.Equal(expected, result);
	}

	[Fact]
	public void Overloaded()
	{
		var result = _calculator.Add("1,2", 100);

		Assert.Equal(103, result);
	}

	[Fact]
	public void SingleDigitOnly()
	{
		var result = _calculator.Add("108", true);

		Assert.Equal(9, result);
	}

}
