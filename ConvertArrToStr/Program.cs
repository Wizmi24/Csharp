using ConvertArrToStr;

var p1 = new Converter();

Console.WriteLine(string.Join(",", p1.ConvertIt(new object[] { 1, 2, "a", "b" })));
Console.WriteLine(string.Join(",", p1.ConvertIt(new object[] { "a", "b", 10, 115 })));
Console.WriteLine(string.Join(",", p1.ConvertIt(new object[] { })));
Console.WriteLine(string.Join(",", p1.ConvertIt(new object[] { -4, "k", 0 })));
Console.WriteLine(string.Join(",", p1.ConvertIt(new object[] { "Hell000!", 5 })));
