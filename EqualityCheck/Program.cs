using EqualityCheck;

var p1 = new CheckingEquality();

Console.WriteLine("Is it equal? " + p1.isEqual("a","b"));
Console.WriteLine("Is it equal? " + p1.isEqual("1", 1));
Console.WriteLine("Is it equal? " + p1.isEqual(1, true));
Console.WriteLine("Is it equal? " + p1.isEqual("a", 'a'));
Console.WriteLine("Is it equal? " + p1.isEqual("1", "1"));