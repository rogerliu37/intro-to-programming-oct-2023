namespace DemoApi.Services;

public interface ISystemTime
{
	DateTimeOffset GetCurrent();
}
