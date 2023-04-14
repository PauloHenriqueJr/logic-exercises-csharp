namespace Exercises
{
    public class OddNumbers
    {
        public static void Solution1()
        {
            Console.WriteLine("\nGerador dos n primeiros números ímpares positivos\n");

            // leia o valor de n
            int n = int.Parse(Console.ReadLine());

            // contador de ímpares impressos
            int i = 0;

            // primeiro número ímpar
            int impar = 1;

            // imprima os n primeiros impares, um por linha
            while (i < n)
            {
                // imprima o próximo número ímpar
                Console.WriteLine(impar);

                // incremente p contador
                i = i + 1;

                // determine o próximo ímpar
                impar = impar + 2;
            }
        }

        public static void Solution2()
        {
            Console.WriteLine("\nGerador dos n primeiros números ímpares positivos\n");

            // leia o valor de n
            int n = int.Parse(Console.ReadLine());

            // contador de ímpares impressos
            int i = 0;

            // imprima os n primeiros impares, um por linha
            while (i < n)
            {
                // imprima o próximo ímpar
                Console.WriteLine(2 * i + 1);

                i = i + 1;
            }
        }
    }
}
