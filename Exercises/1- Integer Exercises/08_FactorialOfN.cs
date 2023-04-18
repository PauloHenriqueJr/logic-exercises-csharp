namespace Exercises
{
    public class FactorialOfN
    {
        public static void Solution1()
        {
            Console.WriteLine("\nCálculo do fatorial de um número inteiro.\n");
            Console.Write("Digite um inteiro nao-negativo: ");

            int n = int.Parse(Console.ReadLine());
            int factorial = 1;

            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }

            Console.WriteLine($"\nO fatorial de {n} é {factorial}.\n");
        }
    }
}
