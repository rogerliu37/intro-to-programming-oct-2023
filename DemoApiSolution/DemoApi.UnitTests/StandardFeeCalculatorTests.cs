
using DemoApi.Services;

namespace DemoApi.UnitTests;
public class StandardFeeCalculatorTests
{
	[Theory]
	[InlineData("10/28/2023")] // Saturday
	[InlineData("10/29/2023")] // Sunday

	public void NoFeesOnWeekends(string when)
	{
		// Given
		var clockIsNow = DateTime.SpecifyKind(DateTime.Parse(when), DateTimeKind.Local);
		var fakeSystemTime = Substitute.For<ISystemTime>();
		fakeSystemTime.GetCurrent().Returns(clockIsNow);
		var calculator = new StandardFeeCalculator(fakeSystemTime);

		// When
		var fee = calculator.GetCurrentFee();
		// Then
		Assert.Equal(0, fee);
	}

	[Theory]
	[InlineData("10/25/2023")] // Wednesday
	[InlineData("10/26/2023")] // Thursday
	public void FeesOnWeekdays(string when)
	{
		var clockIsNow = DateTime.SpecifyKind(DateTime.Parse(when), DateTimeKind.Local);
		var fakeSystemTime = Substitute.For<ISystemTime>();
		fakeSystemTime.GetCurrent().Returns(clockIsNow);
		var calculator = new StandardFeeCalculator(fakeSystemTime);

		var fee = calculator.GetCurrentFee();

		Assert.Equal(.03M, fee);
	}
}
