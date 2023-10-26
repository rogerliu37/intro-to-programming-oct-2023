
namespace DemoApi.UnitTests;
public class ConvertingTemperatures
{
	[Theory]
	[InlineData(212, 100)]
	[InlineData(32, 0)]
	public void CanConvertFromFtoC(float temp, float expected)
	{

		float result = TemperatureConverter.ConvertFromF(temp);

		Assert.Equal(expected, result);
	}


	[Theory]
	[InlineData(100, 212)]
	[InlineData(0, 32)]
	public void CanConvertFromCtoF(float temp, float expected)
	{

		float result = TemperatureConverter.ConvertFromC(temp);

		Assert.Equal(expected, result);
	}
}
