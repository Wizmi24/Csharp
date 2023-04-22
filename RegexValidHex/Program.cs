using RegexValidHex;

var p1 = new ValidHex();

Console.WriteLine("This is valid hex: " + p1.RegexMethod("#CD5C5C"));
Console.WriteLine("This is valid hex: " + p1.RegexMethod("#EAECEE"));
Console.WriteLine("This is valid hex: " + p1.RegexMethod("#eaecee"));
Console.WriteLine("This is valid hex: " + p1.RegexMethod("#CD5C58C"));
Console.WriteLine("This is valid hex: " + p1.RegexMethod("#CD5C5Z"));
Console.WriteLine("This is valid hex: " + p1.RegexMethod("#CD5C&C"));