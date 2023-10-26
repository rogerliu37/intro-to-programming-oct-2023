namespace DemoApi.Services;

public class TemperatureConverterService
{
	private readonly ICalculateFees _feeCalculator;

	// depending on abstractions not concretions
	public TemperatureConverterService(ICalculateFees feeCalculator)
	{
		_feeCalculator = feeCalculator;
	}

	public ConversionWithFeeResponse ConvertFtoC(float temp)
	{
		// Write the code you wish you had.
		// I am saying WHAT I need, not WHO I need.
		decimal fee = _feeCalculator.GetCurrentFee();

		var convertedTemp = TemperatureConverter.ConvertFromF(temp);
		return new ConversionWithFeeResponse(temp, convertedTemp, fee);
	}

	public ConversionWithFeeResponse ConvertCtoF(float temp)
	{
		decimal fee = _feeCalculator.GetCurrentFee();

		var convertedTemp = TemperatureConverter.ConvertFromC(temp);
		return new ConversionWithFeeResponse(convertedTemp, temp, fee);
	}
}


public record ConversionWithFeeResponse(float F, float C, decimal Fee);