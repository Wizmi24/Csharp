
using BigNumArray;

var p1 = new SearchForBiggestArrayNumber();
var answear = p1.FindLargest(new double[][] { new double[] { 4, 2, 7, 1 }, new double[] { 20, 70, 40, 90 }, new double[] { 1, 2, 0 } });
foreach (var item in answear)
{
    Console.WriteLine(item);
}