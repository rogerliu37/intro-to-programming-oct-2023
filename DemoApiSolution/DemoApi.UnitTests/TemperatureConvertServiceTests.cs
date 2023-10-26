


using DemoApi.Services;

namespace DemoApi.UnitTests;
public class TemperatureConvertServiceTests
{

	[Fact]
	public void UsesTheFeeCalculator()
	{
		// Given
		var fakeFeeCalculator = Substitute.For<ICalculateFees>();
		fakeFeeCalculator.GetCurrentFee().Returns(42.23M);
		var service = new TemperatureConverterService(fakeFeeCalculator);

		// When
		ConversionWithFeeResponse response = service.ConvertFtoC(100F);

		// Then
		Assert.Equal(42.23M, response.Fee);
	}


}


// Test Double.
public class StubbedFeeThing : ICalculateFees
{
	public decimal GetCurrentFee()
	{
		return 42.23M;
	}
}