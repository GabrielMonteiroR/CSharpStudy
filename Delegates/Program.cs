using System;
using Delegates.Entities;

double a = 10;
double b = 12;

double result = CalculationService.Square(a);
// Console.WriteLine(result);

//DELEGATE
//Neste caso esta limitando que somente operações com dois doubles podem utilizar o op
BinaryNumericOperation op = CalculationService.Sum;

double resultTwo = op(a,b);
System.Console.WriteLine(resultTwo);


