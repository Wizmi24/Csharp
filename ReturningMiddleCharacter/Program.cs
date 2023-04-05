using ReturningMiddleCharacter;

var p1 = new ReturnCharacter();

var ans = p1.MiddleChar("test");
Console.WriteLine(ans);

ans = p1.MiddleChar("testing");
Console.WriteLine(ans);

ans = p1.MiddleChar("middle");
Console.WriteLine(ans);

ans = p1.MiddleChar("A");
Console.WriteLine(ans);