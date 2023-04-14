namespace Exercises
{
    public class SumOfNNumbers
    {
        // Solução 1
        public static void Solution1()
        {
            /*
            Programa que lê um inteiro positivo n e imprime o valor da soma
            1 + 2 + 3 + ... + n.

            Exemplos de execução:

            >>> 
            Cálculo da soma dos n primeiros inteiros positivos
            Digite o valor de n: 3
            A soma dos 3 primeiros inteiros positivos é 6
            >>> 
            Calculo da soma dos n primeiros inteiros positivos
            Digite o valor de n: 10
            A soma dos 10 primeiros inteiros positivos é 55
            >>> 
            Calculo da soma dos n primeiros inteiros positivos
            Digite o valor de n: 0
            A soma dos 0 primeiros inteiros positivos é 0
            >>> 
            */

            Console.WriteLine("Calculo da soma dos n primeiros inteiros positivos - Solução 1");

            Console.WriteLine("Digite o valor de n:");

            // leia o valor de n
            int n = int.Parse(Console.ReadLine());

            // inicialize a soma
            int soma = 0;

            // calcule a soma
            int i = 1;
            while (i <= n)
            {
                soma = soma + i;
                i = i + 1;
            }

            // imprima a soma
            Console.WriteLine("\nA soma dos {0} primeiros inteiros positivos é {1}", n, soma);
        }

        // Solução 2
        public static void Solution2()
        {
            /*
            Programa que lê um inteiro positivo n e imprime o valor da soma
            1 + 2 + 3 + ... + n.

            Exemplos de execução:

            >>> 
            Cálculo da soma dos n primeiros inteiros positivos
            Digite o valor de n: 3
            A soma dos 3 primeiros inteiros positivos é 6
            >>> 
            Calculo da soma dos n primeiros inteiros positivos
            Digite o valor de n: 10
            A soma dos 10 primeiros inteiros positivos é 55
            >>> 
            Calculo da soma dos n primeiros inteiros positivos
            Digite o valor de n: 0
            A soma dos 0 primeiros inteiros positivos é 0
            >>> 
            */

            Console.WriteLine("Calculo da soma dos n primeiros inteiros positivos - Solução 2");

            // leia o valor de n
            int n = int.Parse(Console.ReadLine());

            // calcule a soma de uma PA de razão 1
            int soma = n * (n + 1) / 2;

            // imprima a soma
            Console.WriteLine("\nA soma dos {0} primeiros inteiros positivos é {1}", n, soma);
        }
    }
}
