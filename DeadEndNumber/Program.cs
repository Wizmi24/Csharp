/*
 This number sequence can start with any positive integer n.
 s is the sum of the individual digits in n.
 If s divides into n evenly then the next term of the series is n//s.
 Otherwise the next term is n*s. Eventually the series will reach a dead end with two numbers alternating: 58, 754, 12064, 928, 17632, 928, 17632.
 This series has a length of 5 with 17632 as the last term.

Compose a function that takes a positive integer and returns its series length and its last term.
 */

using DeadEndNumber;

string userInput;
bool flag;
int number;

Console.WriteLine("Enter positive integer");
do
{
    userInput = Console.ReadLine();
    flag = Int32.TryParse(userInput, out number);
} while (!flag||number<1);

var seq = new Sequence();
seq.SequenceLenght(number);