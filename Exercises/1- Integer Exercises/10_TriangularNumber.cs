namespace Exercises
{
    public class TriangularNumber
    {
        public static void Solution1()
        {
            Console.WriteLine("Cálculo do número triangular de um número inteiro.");

            Console.Write("Digite um número inteiro não-negativo: ");
            int n = int.Parse(Console.ReadLine());

            int i = 0;

            while (i * (i + 1) * (i + 2) < n)
            {
                i++;
            }

            if (i * (i + 1) * (i + 2) == n)
            {
                Console.WriteLine($"{n} é um número triangular, pois é o produto de {i} x {i + 1} x {i + 2}.");
            }
            else
            {
                Console.WriteLine($"{n} não é um número triangular.");
            }
        }

    }
}
