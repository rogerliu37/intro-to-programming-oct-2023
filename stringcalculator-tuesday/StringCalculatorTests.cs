
namespace StringCalculator;

public class StringCalculatorTests
{
	[Fact]
	public void EmptyStringReturnsZero()
	{
		var calculator = new StringCalculator();

		var result = calculator.Add("");

		Assert.Equal(0, result);
	}

	[Theory]
	[InlineData("1", 1)]
	[InlineData("2", 2)]
	[InlineData("118", 118)]
	public void SingleDigit(string input, int expected)
	{
		var calculator = new StringCalculator();
		var result = calculator.Add(input);
		Assert.Equal(expected, result);
	}

	[Theory]
	[InlineData("1,1", 2)]
	[InlineData("10,2", 12)]
	[InlineData("108,10", 118)]
	public void TwoDigits(string input, int expected)
	{
		var calculator = new StringCalculator();
		var result = calculator.Add(input);
		Assert.Equal(expected, result);
	}
	[Theory]
	[InlineData("1,1,1", 3)]
	[InlineData("1,2,3,4,5,6,7,8,9", 45)]

	public void Arbitrary(string input, int expected)
	{
		var calculator = new StringCalculator();
		var result = calculator.Add(input);
		Assert.Equal(expected, result);
	}

	[Theory]
	[InlineData("1,2\n3", 6)]
	[InlineData("1\n2", 3)]
	public void MixedDelimeters(string input, int expected)
	{
		var calculator = new StringCalculator();
		var result = calculator.Add(input);
		Assert.Equal(expected, result);
	}
	[Theory]
	[InlineData("//;\n1;2", 3)]
	[InlineData("//*\n1*3", 4)]
	[InlineData("//*\n1,3*2", 6)]

	public void CustomeDelimeter(string input, int expected)
	{

		var calculator = new StringCalculator();
		var result = calculator.Add(input);
		Assert.Equal(expected, result);
	}
}
