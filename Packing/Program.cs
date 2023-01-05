using Packing;

/*
You arrive at the supermarket checkout and you've only got a limited number of shopping bags with you.
Miser that you are, you hate buying extra bags when you've got dozens at home that you forgot to bring with you!!
Can you fit all your shopping into the bags you've got with you?

Each bag can carry a maximum of 10kg and each item you've purchased weighs between 1 and 10kg.

Create a function that takes two parameters, a list of the weights of each item and the number of bags you are carrying.
Return True if there are enough bags to contain all the items, otherwise False.
 */

var zad = new RandomGenerator();


string userInput;
bool check;
int bought, bags;

do{
    Console.WriteLine("How many things have you bought?");
    userInput=Console.ReadLine();
    check = Int32.TryParse(userInput, out bought);
} while (!check||bought<1) ;
var answear = zad.Generate(bought);
do
{
    Console.WriteLine("How many bags have you took?");
    userInput = Console.ReadLine();
    check = Int32.TryParse(userInput, out bags);
} while (!check||bought<1);
Console.WriteLine("yay");
new Pack();
Pack.CanFit(bags, answear);