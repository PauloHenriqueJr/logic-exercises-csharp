namespace Exercises
{
    // Program that reads a positive integer n and prints the sum value
    public class SumOfNNumbers
    {
        public static void Solution1()
        {
            Console.WriteLine("Calculo da soma dos n primeiros inteiros positivos - Solução 1");

            Console.WriteLine("Digite o valor de n:");

            int n = int.Parse(Console.ReadLine());

            int sum = 0;

            int i = 1;
            while (i <= n)
            {
                sum = sum + i;
                i = i + 1;
            }

            Console.WriteLine("\nA soma dos {0} primeiros inteiros positivos é {1}", n, sum);
        }

        public static void Solution2()
        {

            Console.WriteLine("Calculo da soma dos n primeiros inteiros positivos - Solução 2");

            int n = int.Parse(Console.ReadLine());

            int sum = n * (n + 1) / 2;

            Console.WriteLine("\nA soma dos {0} primeiros inteiros positivos é {1}", n, sum);
        }
    }
}
