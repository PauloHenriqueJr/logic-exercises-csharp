namespace Exercises
{
    public class EuclideanAlgorithm
    {
        public static void Solution1()
        {
            Console.WriteLine("Cálculo do MDC de dois números inteiros.");

            Console.Write("Digite um número inteiro: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Digite um número inteiro: ");
            int b = int.Parse(Console.ReadLine());

            int mdc = 0;

            for (int i = 1; i <= a && i <= b; i++)
            {
                if (a % i == 0 && b % i == 0)
                {
                    mdc = i;
                }
            }

            Console.WriteLine($"O MDC de {a} e {b} é {mdc}.");
        }
    }
}
