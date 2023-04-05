using MultiplesArray;

var p1 = new ReturningArray();

var ans = p1.ArrayOfMultiples(7,5);
Console.WriteLine(string.Join(",", ans));

ans = p1.ArrayOfMultiples(12, 10);
Console.WriteLine(string.Join(",", ans));

ans = p1.ArrayOfMultiples(17, 7);
Console.WriteLine(string.Join(",", ans));

ans = p1.ArrayOfMultiples(630, 14);
Console.WriteLine(string.Join(",", ans));

ans = p1.ArrayOfMultiples(140, 3);
Console.WriteLine(string.Join(",", ans));