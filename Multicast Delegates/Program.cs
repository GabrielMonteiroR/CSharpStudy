//São delegates que guardam referencia para mais de um metodo
//Mais utilizados em void

using MulticastDelegates.Entities;

namespace MulticastDelegates
{
    delegate void BinaryNumericOperation(double n1, double n2);
    class Program
    {
        static void Main(string[] args)
        {

            double a = 10F;
            double b = 12F;

            BinaryNumericOperation op = CalculationService.ShowSum;
            op += CalculationService.ShowMax;

            op.Invoke(a, b);

        }
    }
}





