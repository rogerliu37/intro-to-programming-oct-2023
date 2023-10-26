

var firstName = "George";
var lastName = "Washington";




var fullName = Formatters.FormatName(firstName, lastName);


Console.WriteLine(fullName.FullName);
Console.WriteLine(new String('*', fullName.Length));

//fullName.FullName = "Bob Smith";


Console.WriteLine(fullName.FullName);
Console.WriteLine(new String('*', fullName.Length));