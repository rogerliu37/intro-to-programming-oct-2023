namespace DemoApi.Services;

public class StandardFeeCalculator : ICalculateFees
{
	private readonly ISystemTime _systemTime;

	public StandardFeeCalculator(ISystemTime systemTime)
	{
		_systemTime = systemTime;
	}

	public decimal GetCurrentFee()
	{
		var localNow = _systemTime.GetCurrent().ToLocalTime();
		var isWeekend = localNow.DayOfWeek == DayOfWeek.Sunday || localNow.DayOfWeek == DayOfWeek.Saturday;

		return isWeekend ? 0 : 0.03M;
	}
}
