namespace Exercises
{
    public class DailySalesMarch
    {
        // Program that reads the sales amount with random values in each day of the month of March and prints the total amount sold in the month.
        public static void Solution1()
        {
            Console.WriteLine("Análise de vendas em Março");
            Console.WriteLine();

            const int daysInMarch = 31;
            int maxSales = 0;
            int maxDay = 0;

            Random random = new Random();

            for (int day = 1; day <= daysInMarch; day++)
            {
                int sales = random.Next(1, 101);
                Console.WriteLine("Vendas do dia " + day + ": " + sales);

                if (sales > maxSales)
                {
                    maxSales = sales;
                    maxDay = day;
                }
            }

            Console.WriteLine();
            Console.WriteLine("O dia de maior venda em Março foi o dia " + maxDay + ".");
            Console.WriteLine("Foram vendidos " + maxSales + " discos nesse dia.");
        }

        // Program that reads the sales amount of manual form in each day of the month of March and prints the total amount sold in the month.
        public static void Solution2()
        {
            Console.WriteLine("Análise de vendas em Março");
            Console.WriteLine();

            const int daysInMarch = 31;
            int maxSales = 0;
            int maxDay = 0;

            for (int day = 1; day <= daysInMarch; day++)
            {
                Console.Write("Digite a quantidade de discos vendidos no dia " + day + ": ");
                int sales = int.Parse(Console.ReadLine());

                if (sales > maxSales)
                {
                    maxSales = sales;
                    maxDay = day;
                }
            }

            Console.WriteLine();
            Console.WriteLine("O dia de maior venda em Março foi o dia " + maxDay + ".");
            Console.WriteLine("Foram vendidos " + maxSales + " discos nesse dia.");
        }
    }
}
