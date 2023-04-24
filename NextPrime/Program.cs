using NextPrime;

var p1 = new Prime();

//Given an integer, create a function that returns the next prime. If the number is prime, return the number itself.

Console.WriteLine("Next prime is: " + p1.NextPrime(12));
Console.WriteLine("Next prime is: " + p1.NextPrime(24));
Console.WriteLine("Next prime is: " + p1.NextPrime(11));
Console.WriteLine("Next prime is: " + p1.NextPrime(13));