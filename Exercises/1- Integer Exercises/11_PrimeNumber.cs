namespace Exercises
{
    public class PrimeNumber
    {
        public static void Solution1()
        {
            Console.WriteLine("Cálculo de números primos.");
            Console.Write("Digite um número inteiro não-negativo: ");

            int n = int.Parse(Console.ReadLine());

            bool isPrime = true;

            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            string message = isPrime ? $"{n} é um número primo." : $"{n} não é um número primo.";
            Console.WriteLine(message);

        }
    }
}
