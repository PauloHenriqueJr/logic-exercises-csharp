namespace Exercises
{
    public class SumNumbersPairs
    {
        public static void Solution1()
        {
            Console.WriteLine("\nSoma de números pares.\n");

            Console.Write("Digite a quantidade de números: ");
            int n = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                Console.Write("Digite o número " + (i + 1) + ": ");
                int num = int.Parse(Console.ReadLine());

                if (num % 2 == 0)
                {
                    sum += num;
                }
            }

            Console.WriteLine($"\nA soma dos números pares é {sum}.\n");
        }
    }
}
