namespace Exercises
{
    // Program that reads a sequence of integers non-null and prints the square of each number read.
    public class SquaresOfSequence
    {
        public static void Solution1()
        {
            Console.WriteLine("\nCálculo dos quadrados de uma sequência de números.\n");
            Console.WriteLine("A sequência termina com um 0 (zero).\n");

            int num = 1;
            while (num != 0)
            {
                Console.Write("Digite um número: ");
                num = int.Parse(Console.ReadLine());

                int square = num * num;
                Console.WriteLine($"{num} ao quadrado é {square}\n");
            }
        }
    }
}
