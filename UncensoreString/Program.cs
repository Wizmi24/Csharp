
using UncensoreString;

var p1 = new Uncensoring();

Console.WriteLine(p1.Uncensore("Wh*r* d*d my v*w*ls g*?", "eeioeo"));
Console.WriteLine(p1.Uncensore2("*PP*RC*S*", "UEAE"));