using SortingASCaDESC;

var sort = new Sort();

var answear = sort.SortContacts(new string[] {
  "John Locke",
  "Thomas Aquinas",
  "David Hume",
  "Rene Descartes"
}, "ASC");
Console.WriteLine("Ascending");
foreach (var item in answear)
{
    Console.WriteLine(item);
}
Console.WriteLine();
answear = sort.SortContacts(new string[] {
  "Paul Erdos",
  "Leonhard Euler",
  "Carl Gauss"
}, "DESC");
Console.WriteLine("Descending");
foreach (var item in answear)
{
    Console.WriteLine(item);
}