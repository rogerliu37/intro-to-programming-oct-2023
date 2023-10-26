namespace DemoApi;

public class TemperatureConverter
{
	public static float ConvertFromC(float temp)
	{
		return (temp * 9) / 5 + 32;
	}

	public static float ConvertFromF(float temp)
	{
		return (temp - 32) * 5 / 9;
	}
}
