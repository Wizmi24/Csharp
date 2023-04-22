using PositiveCountNegativeSum;

var p1 = new ArrayMath();

var result = p1.CountPosSumNeg(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14, -15 });

Console.WriteLine($"Array count: {result[0]}, Array Sum: {result[1]}");