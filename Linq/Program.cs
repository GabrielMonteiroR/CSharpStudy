//Specify the data source

int[] numbers = new int[] { 2, 3, 4, 5 };

//Define the query expression

IEnumerable<int> result = numbers.Where(number => number % 2 == 0).Select(num => num * 10);

// Execute the query

foreach (int number in result)
{
    System.Console.WriteLine(number);
}