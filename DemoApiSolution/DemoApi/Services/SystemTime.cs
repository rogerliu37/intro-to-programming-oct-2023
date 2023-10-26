namespace DemoApi.Services;

public class SystemTime : ISystemTime
{
	public DateTimeOffset GetCurrent()
	{
		return DateTimeOffset.UtcNow;
	}
}