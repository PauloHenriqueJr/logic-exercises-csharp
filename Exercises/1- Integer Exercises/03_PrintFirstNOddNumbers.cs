namespace Exercises
{
    // Program that reads a positive integer does not print the first n positive integers.
    public class OddNumbers
    {
        public static void Solution1()
        {
            Console.WriteLine("\nGerador dos n primeiros números ímpares positivos\n");

            int n = int.Parse(Console.ReadLine());

            int i = 0;

            int odd = 1;

            while (i < n)
            {
                Console.WriteLine(odd);

                i = i + 1;

                odd = odd + 2;
            }
        }

        public static void Solution2()
        {
            Console.WriteLine("\nGerador dos n primeiros números ímpares positivos\n");

            int n = int.Parse(Console.ReadLine());

            int i = 0;

            while (i < n)
            {
                Console.WriteLine(2 * i + 1);

                i = i + 1;
            }
        }
    }
}
