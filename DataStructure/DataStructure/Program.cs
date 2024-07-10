//Vetores simples

//using System.Globalization;

//int vectorSize = int.Parse(Console.ReadLine());

//double[] myVect = new double[vectorSize];

//for (int i = 0; i < vectorSize; i++)
//{
//    myVect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//}

//Ref & Out - Modificadores de parâmetros
//Ref altera o valor da variavel e não somente o valor do parametro.
//Out faz o mesmo porém não exige a variavel seja inicializada com um valor.
// static void AoQuadrado(ref int x)
//{
//    x *= 3;
//}

////BEFORE
//int a = 10;
//Console.WriteLine(a);

////THEN
//AoQuadrado(ref a);

////AFTER
//Console.WriteLine(a);

