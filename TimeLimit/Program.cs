using TimeLimit;

var p1 = new Test();

Console.WriteLine("Candidate is " + p1.Limit(new int[] { 5, 5, 10, 10, 15, 15, 20, 20 }, 120));
Console.WriteLine();
Console.WriteLine("Candidate is " + p1.Limit(new int[] { 2, 3, 8, 6, 5, 12, 10, 18 }, 64));
Console.WriteLine();
Console.WriteLine("Candidate is " + p1.Limit(new int[] { 5, 5, 10, 10, 25, 15, 20, 20 }, 120));
Console.WriteLine();
Console.WriteLine("Candidate is " + p1.Limit(new int[] { 5, 5, 10, 10, 15, 15, 20 }, 120));
Console.WriteLine();
Console.WriteLine("Candidate is " + p1.Limit(new int[] { 5, 5, 10, 10, 15, 15, 20, 20 }, 130));