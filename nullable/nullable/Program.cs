//Nullable<double> x = null;

double? x = null;
double? y = 10.0;

Console.WriteLine(x.GetValueOrDefault());
Console.WriteLine(y.GetValueOrDefault());

Console.WriteLine(x.HasValue);
Console.WriteLine(y.HasValue);

try
{
    Console.WriteLine(x.Value);
}
catch
{
    Console.WriteLine("X is null");
}

Console.WriteLine(y.Value);


//operador de coalescência nula

//  if x is null? then x = 5
double xyz = x ?? 5;