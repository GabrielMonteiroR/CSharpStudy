int FirstNumber = int.Parse(Console.ReadLine());
int SecondNumber = int.Parse(Console.ReadLine());

try
{
    int result = FirstNumber / SecondNumber;
    Console.WriteLine(result);
}
catch(Exception ex)
{
    Console.WriteLine("ERRO: " + ex.Message);
}
finally
{
Console.WriteLine("EXECUTA INDEPEDENTE DE TER DADO CERTO OU NÃO");
}