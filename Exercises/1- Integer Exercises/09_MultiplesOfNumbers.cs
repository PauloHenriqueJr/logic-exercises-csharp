namespace Exercises
{
    public class MultiplesOfNumbers
    {
        public static void Solution1()
        {
            Console.WriteLine("\nCálculo dos múltiplos de um número.\n");

            Console.Write("Digite um número inteiro: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Digite um número inteiro: ");
            int i = int.Parse(Console.ReadLine());

            Console.Write("Digite um número inteiro: ");
            int j = int.Parse(Console.ReadLine());

            int multi = 0;

            for (int count = 1; multi <= n; count++)
            {
                if (count % i == 0 || count % j == 0)
                {
                    Console.WriteLine(count);
                    multi++;
                }
            }
        }
    }
}
