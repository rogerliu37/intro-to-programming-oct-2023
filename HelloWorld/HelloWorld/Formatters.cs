
// Services
public static class Formatters
{
    public static FormattedNameResult FormatName(string firstName, string lastName)
    {
        var fullName = $"{firstName} {lastName}";
        return new FormattedNameResult(fullName, fullName.Length);

    }
}


// "Value Types"
public record FormattedNameResult(string FullName, int Length);