
namespace StringCalculator;

public class StringCalculator
{


	public int Add(string numbers)
	{
		var delimeters = new List<char> { ',', '\n' };
		if (numbers == "")
		{
			return 0;
		}
		if (numbers.StartsWith("//"))
		{
			// //*\n1*2
			delimeters.Add(numbers[2]);
			return parseNumbers(numbers[4..], delimeters);
		}
		return parseNumbers(numbers, delimeters);
	}

	private int parseNumbers(string numbers, List<char> delimeters)
	{
		return numbers
					.Split(delimeters.ToArray())
					.Select(int.Parse)
					.Sum();
	}


}
