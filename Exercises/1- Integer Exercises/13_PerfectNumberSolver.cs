namespace Exercises
{
    public class PerfectNumberSolver
    {
        public static void Solution1()
        {
            Console.WriteLine("Verificação de número perfeito.");

            Console.Write("Digite um número inteiro: ");
            int n = int.Parse(Console.ReadLine());
            
            int sum = 0;

            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                }
            }

            if (sum == n)
            {
                Console.WriteLine($"{n} é um número perfeito.");
            }
            else
            {
                Console.WriteLine($"{n} não é um número perfeito.");
            }
        }
    }
}
