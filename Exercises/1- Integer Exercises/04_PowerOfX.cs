namespace Exercises
{
    // Program that reads an integer x and an integer n greater than or equal to zero and prints x raised to n.
    public class PowerOfX
    {
        public static void Solution1()
        {
            Console.Write("Digite a base (número inteiro): ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Digite o expoente (inteiro >= 0): ");
            int n = int.Parse(Console.ReadLine());

            int i = 0;

            int power_x = 1;

            while (i < n)
            {
                i = i + 1;
                power_x = power_x * x;
            }

            Console.WriteLine("O valor de {0} elevado a {1} é {2}", x, n, power_x);
        }

        // This program is wrong.
        public static void Solution2()
        {
            Console.WriteLine("Cálculo de potências\n");
            Console.Write("Digite a base (número inteiro): ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o expoente (inteiro >= 0): ");
            int n = Convert.ToInt32(Console.ReadLine());

            int i = 0;

            while (i < n)
            {
                i = i + 1;
                x = x * x; // ERROR: we need a variable for powers
            }

            Console.WriteLine("O valor de " + x + " elevado a " + n + " é " + x);

        }
    }
}
