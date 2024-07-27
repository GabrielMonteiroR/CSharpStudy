using System;

List<int> ints = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

int sumOne = 0;

foreach (int number in ints)
{
    sumOne += number;
}

Console.WriteLine("That's 'SumOne': ");
Console.WriteLine(sumOne);

//Lambda Expression

int sumTwo = ints.Aggregate(0, (numberOne, numberTwo) => numberOne + numberTwo);

Console.WriteLine("That's 'SumTwo': ");
Console.WriteLine(sumTwo);
